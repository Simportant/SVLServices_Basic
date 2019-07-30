using System;
using System.Windows.Forms;



namespace TestHandler
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.txtPath.Text = @"C:\test";
            this.txtExtension.Text = "xml";
            this.txtArchiveResult.Text = string.Empty;
            this.txtArchiveFile.Text = "output.txt";
            this.txtEnvironmentFolder.Text = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"\Nice_Systems\Real-Time");
            this.txtXMLKey.Text = "SMG_Test";
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (this.txtExtension.Text.Length == 3)
            {
                SVLServices.Concrete.FileIOService look = new SVLServices.Concrete.FileIOService();
                this.txtResult.Text = look.FindFirstFile(this.txtPath.Text, this.txtExtension.Text);
            }
            else
                this.txtResult.Text = "ERROR - bad Extension";            
        }

      
        private void cmdGo_Click(object sender, EventArgs e)
        {
            if (this.txtExtension.Text.Length == 3)
            {
                SVLServices.Concrete.FileIOService look = new SVLServices.Concrete.FileIOService();
                this.rtfResults.Text = look.ListFiles(this.txtPath.Text, this.txtExtension.Text, this.chkSubFolders.Checked);
            }
            else
                this.rtfResults.Text = "ERROR - bad Extension";
        }

        private void cmdXML_Click(object sender, EventArgs e)
        {
            if (this.txtExtension.Text.Length == 3)
            {
                SVLServices.Concrete.FileIOService look = new SVLServices.Concrete.FileIOService();
                this.rtfXML.Text = look.ListFilesXML(this.txtPath.Text, this.txtExtension.Text, this.chkXML.Checked);
            }
            else
                this.rtfXML.Text = "ERROR - bad Extension";
        }

        private void cmdArchive_Click(object sender, EventArgs e)
        {
            SVLServices.Concrete.FileIOService look = new SVLServices.Concrete.FileIOService();
            this.txtArchiveResult.Text = look.ArchiveFile(this.txtArchiveFile.Text, this.txtPath.Text);
        }

        private void cmdEnvironmentFolder_Click(object sender, EventArgs e)
        {
            if (this.txtXMLKey.Text.Length > 1)
            {
                SVLServices.Concrete.FileIOService look = new SVLServices.Concrete.FileIOService();
                this.txtXMLValue.Text = look.GetConfigValue(this.txtXMLKey.Text);
            }
            else
                this.txtEnvironmentFolder.Text = "ERROR - bad Key";
        }
    }
}

