using Direct.Shared;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace SVLServices.Concrete
{
    // Throw Exceptions because the RT Designer can catch them.
    //
    //  Add ref to Client & Designer configs in <appSettings>...</appSettings>: 
    //      <add key = "SVLServices.dll" value="predefinedAssembly" />
    //
    //

    [DirectDom(Category = "SVLServices", DisplayName = "FileHelper", Hidden = false)]
    public class FileIOService : DirectComponentBase
    {
        public FileIOService(IProject rtDesignerProject) : base(rtDesignerProject) { }

        public FileIOService() : base() { }


        [MethodDescription("Get the first file (alphabetically) in a directory matching an extension, if it exists."), DirectDom("FindFirstFile"), DirectDomMethod("FindFirstFile {Directory} {Extension}")]
        public string FindFirstFile(string dir, string ext)
        {
            try
            {
                if (!Directory.Exists(dir))
                    return "Directory doesn't exist!";

                string[] matchingFiles = Directory.GetFiles(dir, string.Format("*.{0}", ext));

                if (matchingFiles.Count() == 0)
                    return "No matching files";
                else
                    return Path.GetFileName(matchingFiles.First());

            }
            catch (System.Exception) { throw; }

        }

        [MethodDescription("Return a list of files {path|file,path|file etc...} in a directory matching an extension."), DirectDom("ListFiles"), DirectDomMethod("ListFiles {Directory} {Extension} {SubFolders}")]
        public string ListFiles(string dir, string ext, bool doSubFolders = false)
        {
            string result = string.Empty;
            FileLister _files;

            try
            {
                if (System.IO.Directory.Exists(dir))
                {
                    if (ext.Length < 3)
                        result = "Invalid extension (3 characters are required)";
                    else
                    {
                        _files = new FileLister(ext, dir, doSubFolders);
                        
                        if (_files.count < 1)
                            result = "No Files Found";
                        else
                        {
                            StringBuilder str = new StringBuilder();

                            foreach (FileDetail x in _files.CurrentFiles)
                            {
                                str.Append(x.FilePath).Append("|").Append(x.FileName).Append(",");
                            }

                            char[] charsToTrim = { ',', '|', ' ', '.' };
                            result = str.ToString().TrimEnd(charsToTrim);

                        }

                        _files = null;
                    }
                }
                else
                    result = "Directory does not exist";
            }
            catch (System.Exception) { throw; }

            return result;

        }

        [MethodDescription("Return all files as XML found in a directory matching an extension."), DirectDom("ListFilesXML"), DirectDomMethod("ListFilesXML {Directory} {Extension} {SubFolders}")]
        public string ListFilesXML(string dir, string ext, bool doSubFolders = false)
        {
            string result = string.Empty;
            FileLister _files;

            try
            {
                if (System.IO.Directory.Exists(dir))
                {
                    if (ext.Length < 3)
                        result = "Invalid extension (3 characters are required)";
                    else
                    {
                        _files = new FileLister(ext, dir, doSubFolders);

                        if (_files.count < 1)
                            result = "No Files Found";
                        else
                        {
                            using (var sw = new StringWriter())
                            {
                                using (var xw = XmlWriter.Create(sw))
                                {
                                    xw.WriteStartDocument();
                                    xw.WriteStartElement("files");

                                    foreach (FileDetail x in _files.CurrentFiles)
                                    {
                                        xw.WriteStartElement("file");
                                        xw.WriteElementString("name", x.FileName);
                                        xw.WriteElementString("path", x.FilePath);
                                        xw.WriteEndElement();                                        
                                    }

                                    xw.WriteEndElement();
                                    xw.WriteEndDocument();                                
                                }

                                return sw.ToString();
                            }
                        }

                        _files = null;
                    }
                }
                else
                    result = "Directory does not exist";
            }
            catch (System.Exception) { throw; }

            return result;

        }


        [MethodDescription("Get the newest file (Modified Date) in a directory matching an extension, if it exists."), DirectDom("NewestFile"), DirectDomMethod("NewestFile {Directory} {Extension}")]
        public string NewestFile(string dir, string ext)
        {
           
            try
            { 
                if (System.IO.Directory.Exists(dir))
                {
                    if (ext.Length < 3)
                        return "Invalid extension (3 characters are required)";
                    else
                    {
                        FileLister _files;
                        _files = new FileLister(ext, dir, false);

                        if (_files.count < 1)
                            return "No Files Found";
                        else
                            return _files.CurrentFiles.OrderByDescending(x => x.FileCreationDate).First().FileName;

                    }
                }
                else
                    return "Directory does not exist";
            }
            catch (System.Exception) { throw; }

        }

        [MethodDescription("Get the oldest file (Modified Date) in a directory matching an extension, if it exists."), DirectDom("OldestFile"), DirectDomMethod("OldestFile {Directory} {Extension}")]
        public string OldestFile(string dir, string ext)
        {

            try
            {
                if (System.IO.Directory.Exists(dir))
                {
                    if (ext.Length < 3)
                        return "Invalid extension (3 characters are required)";
                    else
                    {
                        FileLister _files;
                        _files = new FileLister(ext, dir, false);

                        if (_files.count < 1)
                            return "No Files Found";
                        else
                            return _files.CurrentFiles.OrderByDescending(x => x.FileCreationDate).Last().FileName;

                    }
                }
                else
                    return "Directory does not exist";
            }
            catch (System.Exception) { throw; }

        }

        [MethodDescription("Archive a file."), DirectDom("ArchiveFile"), DirectDomMethod("ArchiveFile {FileName} {Path}")]
        public string ArchiveFile(string file, string dir)
        {
            try
            {
                string ArchiveFolder = string.Empty;
                string ArchiveFile = string.Empty;

                // Ensure path is valid.
                if (!dir.EndsWith(@"\"))
                    dir = dir + @"\";

                if (!Directory.Exists(dir))
                    return "Directory doesn't exist!";

                if (!File.Exists(dir + file))
                    return "File doesn't exist!";

                ArchiveFolder = string.Concat(dir,  @"Archive\");

                // Create Archive folder if it does not exist.
                if (!Directory.Exists(ArchiveFolder))
                    Directory.CreateDirectory(ArchiveFolder);

                ArchiveFile = string.Concat(
                         Path.GetFileNameWithoutExtension(file),
                         System.DateTime.Now.ToString("yyyyMMddHHmmss"),
                         Path.GetExtension(file)
                         );

                File.Move(string.Concat(dir, file), 
                          string.Concat(ArchiveFolder, ArchiveFile)                        
                          );
                
                return "Complete";

            }
            catch (System.Exception) { throw; }

        }

        [MethodDescription("Return a Value from a Key in RTClient appSettings."), DirectDom("GetConfigValue"), DirectDomMethod("GetConfigValue {Key}")]
        public string GetConfigValue(string Key)
        {
            //  Read Value from Client config for Key in <appSettings>...</appSettings>: 
            //  For example... <add key = "IdentifyKey" value="ReturnValue" />

            string result = "Not Found";
            string FileName = @"RTClient.exe.config";
            string FilePath;

            try
            {
                // Get path to config file in users app data folder.
                FilePath = string.Concat(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), @"\Nice_Systems\Real-Time");
                
                if (!Directory.Exists(FilePath)) { return "AppData folder not found"; }

                if (!File.Exists(string.Concat(FilePath, @"\", FileName))) { return "Config file not found"; }
                
                // Get the required key from it.
                XmlDocument doc = new XmlDocument();
                doc.Load(string.Concat(FilePath, @"\", FileName));
                
                XmlNodeList appsettings = doc.SelectNodes(@"configuration/appSettings");
                
                foreach (XmlNode locationNode in appsettings)
                {
                    foreach (XmlNode elementLoc in locationNode.ChildNodes)
                    {
                        if (elementLoc.Attributes["key"].Value == Key)
                            return elementLoc.Attributes["value"].Value;
                    }
                }

                return result;
            }
            catch (System.Exception) { throw; }
        }
        

        }
    }

	
    