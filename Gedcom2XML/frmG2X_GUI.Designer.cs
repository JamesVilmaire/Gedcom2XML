namespace Gedcom2XML
{
    partial class frmG2X_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmG2X_GUI));
            this.openFileGedcom = new System.Windows.Forms.OpenFileDialog();
            this.tbSelectGedcom = new System.Windows.Forms.TextBox();
            this.tbSelectXML = new System.Windows.Forms.TextBox();
            this.btnSelectGedcomFile = new System.Windows.Forms.Button();
            this.btnSelectXMLfile = new System.Windows.Forms.Button();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParseIt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileGedcom
            // 
            this.openFileGedcom.FileName = "gedcom";
            // 
            // tbSelectGedcom
            // 
            this.tbSelectGedcom.Location = new System.Drawing.Point(12, 25);
            this.tbSelectGedcom.Name = "tbSelectGedcom";
            this.tbSelectGedcom.Size = new System.Drawing.Size(236, 20);
            this.tbSelectGedcom.TabIndex = 0;
            // 
            // tbSelectXML
            // 
            this.tbSelectXML.Location = new System.Drawing.Point(12, 77);
            this.tbSelectXML.Name = "tbSelectXML";
            this.tbSelectXML.Size = new System.Drawing.Size(236, 20);
            this.tbSelectXML.TabIndex = 1;
            this.tbSelectXML.Text = "DefaultOutput.xml";
            this.tbSelectXML.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSelectGedcomFile
            // 
            this.btnSelectGedcomFile.Location = new System.Drawing.Point(254, 23);
            this.btnSelectGedcomFile.Name = "btnSelectGedcomFile";
            this.btnSelectGedcomFile.Size = new System.Drawing.Size(26, 23);
            this.btnSelectGedcomFile.TabIndex = 2;
            this.btnSelectGedcomFile.Text = "...";
            this.btnSelectGedcomFile.UseVisualStyleBackColor = true;
            this.btnSelectGedcomFile.Click += new System.EventHandler(this.btnSelectGedcomFile_Click);
            // 
            // btnSelectXMLfile
            // 
            this.btnSelectXMLfile.Location = new System.Drawing.Point(254, 74);
            this.btnSelectXMLfile.Name = "btnSelectXMLfile";
            this.btnSelectXMLfile.Size = new System.Drawing.Size(26, 23);
            this.btnSelectXMLfile.TabIndex = 3;
            this.btnSelectXMLfile.Text = "...";
            this.btnSelectXMLfile.UseVisualStyleBackColor = true;
            this.btnSelectXMLfile.Click += new System.EventHandler(this.btnSelectXMLfile_Click);
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(12, 9);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(106, 13);
            this.lblInputFile.TabIndex = 4;
            this.lblInputFile.Text = "Input File (GEDCOM)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output File (XML)";
            // 
            // btnParseIt
            // 
            this.btnParseIt.Location = new System.Drawing.Point(224, 238);
            this.btnParseIt.Name = "btnParseIt";
            this.btnParseIt.Size = new System.Drawing.Size(56, 23);
            this.btnParseIt.TabIndex = 7;
            this.btnParseIt.Text = "Parse It!";
            this.btnParseIt.UseVisualStyleBackColor = true;
            this.btnParseIt.Click += new System.EventHandler(this.btnParseIt_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(162, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(100, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.AcceptsReturn = true;
            this.tbStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbStatus.Location = new System.Drawing.Point(12, 110);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStatus.Size = new System.Drawing.Size(268, 116);
            this.tbStatus.TabIndex = 10;
            this.tbStatus.TabStop = false;
            this.tbStatus.Text = "Welcome to Gedcom 2 XML! ";
            this.tbStatus.WordWrap = false;
            // 
            // frmG2X_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnParseIt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInputFile);
            this.Controls.Add(this.btnSelectXMLfile);
            this.Controls.Add(this.btnSelectGedcomFile);
            this.Controls.Add(this.tbSelectXML);
            this.Controls.Add(this.tbSelectGedcom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmG2X_GUI";
            this.Text = "GEDCOM 2 XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileGedcom;
        private System.Windows.Forms.TextBox tbSelectGedcom;
        private System.Windows.Forms.TextBox tbSelectXML;
        private System.Windows.Forms.Button btnSelectGedcomFile;
        private System.Windows.Forms.Button btnSelectXMLfile;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParseIt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbStatus;
    }
}

