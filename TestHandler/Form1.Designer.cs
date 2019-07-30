namespace TestHandler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtfResults = new System.Windows.Forms.RichTextBox();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtfXML = new System.Windows.Forms.RichTextBox();
            this.chkXML = new System.Windows.Forms.CheckBox();
            this.cmdXML = new System.Windows.Forms.Button();
            this.txtArchiveResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdArchive = new System.Windows.Forms.Button();
            this.txtArchiveFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdFindConfigValue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnvironmentFolder = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtXMLKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXMLValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(975, 555);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(8, 35);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(442, 22);
            this.txtPath.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(11, 40);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(307, 22);
            this.txtResult.TabIndex = 5;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(478, 36);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(92, 22);
            this.txtExtension.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Extension";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(339, 40);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 8;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtExtension);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 82);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.cmdSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for First File ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtfResults);
            this.groupBox2.Controls.Add(this.chkSubFolders);
            this.groupBox2.Controls.Add(this.cmdGo);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 239);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find all Files in Folder ";
            // 
            // rtfResults
            // 
            this.rtfResults.Location = new System.Drawing.Point(11, 64);
            this.rtfResults.Name = "rtfResults";
            this.rtfResults.ReadOnly = true;
            this.rtfResults.Size = new System.Drawing.Size(540, 157);
            this.rtfResults.TabIndex = 11;
            this.rtfResults.Text = "";
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Location = new System.Drawing.Point(310, 21);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(155, 21);
            this.chkSubFolders.TabIndex = 9;
            this.chkSubFolders.Text = "Include Sub Folders";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(473, 21);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 23);
            this.cmdGo.TabIndex = 8;
            this.cmdGo.Text = "Search";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtfXML);
            this.groupBox3.Controls.Add(this.chkXML);
            this.groupBox3.Controls.Add(this.cmdXML);
            this.groupBox3.Location = new System.Drawing.Point(614, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 344);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "get as XML ";
            // 
            // rtfXML
            // 
            this.rtfXML.Location = new System.Drawing.Point(22, 53);
            this.rtfXML.Name = "rtfXML";
            this.rtfXML.ReadOnly = true;
            this.rtfXML.Size = new System.Drawing.Size(414, 277);
            this.rtfXML.TabIndex = 10;
            this.rtfXML.Text = "";
            // 
            // chkXML
            // 
            this.chkXML.AutoSize = true;
            this.chkXML.Location = new System.Drawing.Point(167, 24);
            this.chkXML.Name = "chkXML";
            this.chkXML.Size = new System.Drawing.Size(155, 21);
            this.chkXML.TabIndex = 9;
            this.chkXML.Text = "Include Sub Folders";
            this.chkXML.UseVisualStyleBackColor = true;
            // 
            // cmdXML
            // 
            this.cmdXML.Location = new System.Drawing.Point(361, 22);
            this.cmdXML.Name = "cmdXML";
            this.cmdXML.Size = new System.Drawing.Size(75, 23);
            this.cmdXML.TabIndex = 8;
            this.cmdXML.Text = "Search";
            this.cmdXML.UseVisualStyleBackColor = true;
            this.cmdXML.Click += new System.EventHandler(this.cmdXML_Click);
            // 
            // txtArchiveResult
            // 
            this.txtArchiveResult.Enabled = false;
            this.txtArchiveResult.Location = new System.Drawing.Point(209, 48);
            this.txtArchiveResult.Name = "txtArchiveResult";
            this.txtArchiveResult.ReadOnly = true;
            this.txtArchiveResult.Size = new System.Drawing.Size(161, 22);
            this.txtArchiveResult.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result";
            // 
            // cmdArchive
            // 
            this.cmdArchive.Location = new System.Drawing.Point(295, 91);
            this.cmdArchive.Name = "cmdArchive";
            this.cmdArchive.Size = new System.Drawing.Size(75, 23);
            this.cmdArchive.TabIndex = 3;
            this.cmdArchive.Text = "Archive";
            this.cmdArchive.UseVisualStyleBackColor = true;
            this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
            // 
            // txtArchiveFile
            // 
            this.txtArchiveFile.Location = new System.Drawing.Point(22, 48);
            this.txtArchiveFile.Name = "txtArchiveFile";
            this.txtArchiveFile.Size = new System.Drawing.Size(167, 22);
            this.txtArchiveFile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtArchiveResult);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmdArchive);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtArchiveFile);
            this.groupBox4.Location = new System.Drawing.Point(614, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 126);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Archive File ";
            // 
            // cmdFindConfigValue
            // 
            this.cmdFindConfigValue.Location = new System.Drawing.Point(414, 109);
            this.cmdFindConfigValue.Name = "cmdFindConfigValue";
            this.cmdFindConfigValue.Size = new System.Drawing.Size(75, 23);
            this.cmdFindConfigValue.TabIndex = 14;
            this.cmdFindConfigValue.Text = "Search";
            this.cmdFindConfigValue.UseVisualStyleBackColor = true;
            this.cmdFindConfigValue.Click += new System.EventHandler(this.cmdEnvironmentFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Environment Folder";
            // 
            // txtEnvironmentFolder
            // 
            this.txtEnvironmentFolder.Location = new System.Drawing.Point(6, 50);
            this.txtEnvironmentFolder.Name = "txtEnvironmentFolder";
            this.txtEnvironmentFolder.Size = new System.Drawing.Size(483, 22);
            this.txtEnvironmentFolder.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtXMLValue);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtXMLKey);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cmdFindConfigValue);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtEnvironmentFolder);
            this.groupBox5.Location = new System.Drawing.Point(12, 445);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(584, 170);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parse Config File ";
            // 
            // txtXMLKey
            // 
            this.txtXMLKey.Location = new System.Drawing.Point(45, 111);
            this.txtXMLKey.Name = "txtXMLKey";
            this.txtXMLKey.Size = new System.Drawing.Size(92, 22);
            this.txtXMLKey.TabIndex = 18;
            this.txtXMLKey.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Key";
            // 
            // txtXMLValue
            // 
            this.txtXMLValue.Location = new System.Drawing.Point(177, 110);
            this.txtXMLValue.Name = "txtXMLValue";
            this.txtXMLValue.ReadOnly = true;
            this.txtXMLValue.Size = new System.Drawing.Size(218, 22);
            this.txtXMLValue.TabIndex = 20;
            this.txtXMLValue.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1096, 635);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Testing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtfXML;
        private System.Windows.Forms.CheckBox chkXML;
        private System.Windows.Forms.Button cmdXML;
        private System.Windows.Forms.TextBox txtArchiveResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdArchive;
        private System.Windows.Forms.TextBox txtArchiveFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtfResults;
        private System.Windows.Forms.Button cmdFindConfigValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnvironmentFolder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtXMLValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXMLKey;
        private System.Windows.Forms.Label label6;
    }
}

