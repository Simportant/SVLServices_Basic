using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;


namespace SVLServices.Concrete
{
    class FileLister
    {

        string _FileDefinition;
        string _StartPath;
        bool _DoSubFolders;

        public FileLister(string def, string startpath, bool DoSubFolders)
        {
            Stack<string> stack = new Stack<string>();
            CurrentFiles = new BindingList<FileDetail>();

            def = def.Replace(".", "");

            _FileDefinition = string.Format("*.{0}", def);

            _StartPath = startpath;
            _DoSubFolders = DoSubFolders;
            stack.Push(_StartPath);
            GetFiles(stack);

        }
        
        public int count { get { return CurrentFiles.Count; } }
        public BindingList<FileDetail> CurrentFiles { get; }

        private void GetFiles(Stack<string> stack)
        {
            // Recursivly Get files that meet the criteria.
            string path;

            while (stack.Count > 0)
            {
                path = stack.Pop();

                // Don't really want to do this folder - it's full of c&*p......
                if (!path.StartsWith("C:\\Temp", StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        // Only do sub folders if necessary.
                        if (_DoSubFolders)
                        {
                            String[] subDirectories;
                            subDirectories = System.IO.Directory.GetDirectories(path);
                            foreach (string p in subDirectories) { stack.Push(p); }
                        }
                        String[] subFiles;
                        subFiles = System.IO.Directory.GetFiles(path, _FileDefinition);

                        // Grab file Details
                        foreach (string f in subFiles)
                        {
                            FileInfo oFileInfo = new FileInfo(f);

                            CurrentFiles.Add(new FileDetail(oFileInfo.Name,
                                                        oFileInfo.CreationTime,
                                                        oFileInfo.LastAccessTime,
                                                        path,
                                                        oFileInfo.Length));
                        }
                    }
                    catch (System.UnauthorizedAccessException) { CurrentFiles.Add(new FileDetail("No Access", path, 0)); }
                    catch (Exception) { CurrentFiles.Add(new FileDetail("EXCEPTION ", path, 0)); }

                }

                // Recurse for all folders left on the Stack.
                GetFiles(stack);

            }
        }

    }

    class FileDetail
    {
        long _Bytes;

        public FileDetail(string file, string path, long bytes)
        {
            FilePath = path;
            FileUser = string.Empty;
            FileName = file;
            FileCreationDate = DateTime.Now;
            FileAccessDate = DateTime.Now;
            _Bytes = bytes;
        }
        public FileDetail(string file, DateTime created, DateTime accessed, string path, long bytes)
        {
            FilePath = path;
            FileUser = string.Empty;
            FileName = file;
            FileCreationDate = created;
            FileAccessDate = accessed;
            _Bytes = bytes;
        }
        public FileDetail(string path, string user, string file, DateTime created, DateTime accessed, long bytes)
        {
            FilePath = path;
            FileUser = user;
            FileName = file;
            FileCreationDate = created;
            FileAccessDate = accessed;
            _Bytes = bytes;

        }

        public string FileName { get; }
        public DateTime FileCreationDate { get; }
        public DateTime FileAccessDate { get; }
        public string FileUser { get; }
        public string FilePath { get; }
        public string FileSize
        {
            get
            {
                if (_Bytes < 1025)
                    return _Bytes.ToString() + " bytes";
                else
                    return (_Bytes / 1024).ToString() + " KB";
            }
        }
    }


}
