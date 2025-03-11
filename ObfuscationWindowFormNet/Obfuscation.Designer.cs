namespace ObfuscationWindowFormNet
{
    partial class Obfuscation
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
            NameProject = new Label();
            lbSetting = new Label();
            chkControlFlow = new CheckBox();
            chkEncryptConstants = new CheckBox();
            chkInvalidMetadata = new CheckBox();
            chkInvalidOpcode = new CheckBox();
            chkRenameSymbols = new CheckBox();
            chkReferenceProxy = new CheckBox();
            chkEncryptResources = new CheckBox();
            chkEncryptStrings = new CheckBox();
            chkWatermark = new CheckBox();
            lbOutput = new Label();
            label4 = new Label();
            txtFileNameOutput = new TextBox();
            label5 = new Label();
            txtNameAttribus = new TextBox();
            lbMaxNumberAttribus = new Label();
            txtFileExe = new TextBox();
            btnSelectFile = new Button();
            Play = new Button();
            txtFolder = new TextBox();
            btnSelectFolder = new Button();
            chkAntiDebug = new CheckBox();
            chkAntiTamper = new CheckBox();
            rtbLogs = new RichTextBox();
            SuspendLayout();
            // 
            // NameProject
            // 
            NameProject.AutoSize = true;
            NameProject.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameProject.Location = new Point(23, 19);
            NameProject.Name = "NameProject";
            NameProject.Size = new Size(126, 26);
            NameProject.TabIndex = 0;
            NameProject.Text = "Obfuscation";
            // 
            // lbSetting
            // 
            lbSetting.AutoSize = true;
            lbSetting.Font = new Font("Times New Roman", 10.2F);
            lbSetting.Location = new Point(23, 60);
            lbSetting.Name = "lbSetting";
            lbSetting.Size = new Size(57, 19);
            lbSetting.TabIndex = 1;
            lbSetting.Text = "Setting";
            // 
            // chkControlFlow
            // 
            chkControlFlow.AutoSize = true;
            chkControlFlow.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkControlFlow.Location = new Point(23, 152);
            chkControlFlow.Name = "chkControlFlow";
            chkControlFlow.RightToLeft = RightToLeft.No;
            chkControlFlow.Size = new Size(125, 24);
            chkControlFlow.TabIndex = 4;
            chkControlFlow.Text = "Control Flow";
            chkControlFlow.UseVisualStyleBackColor = true;
            chkControlFlow.CheckedChanged += chkControlFlow_CheckedChanged;
            // 
            // chkEncryptConstants
            // 
            chkEncryptConstants.AutoSize = true;
            chkEncryptConstants.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkEncryptConstants.Location = new Point(23, 182);
            chkEncryptConstants.Name = "chkEncryptConstants";
            chkEncryptConstants.RightToLeft = RightToLeft.No;
            chkEncryptConstants.Size = new Size(188, 24);
            chkEncryptConstants.TabIndex = 5;
            chkEncryptConstants.Text = "Constants Protection";
            chkEncryptConstants.UseVisualStyleBackColor = true;
            chkEncryptConstants.CheckedChanged += chkEncryptConstants_CheckedChanged;
            // 
            // chkInvalidMetadata
            // 
            chkInvalidMetadata.AutoSize = true;
            chkInvalidMetadata.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkInvalidMetadata.Location = new Point(23, 212);
            chkInvalidMetadata.Name = "chkInvalidMetadata";
            chkInvalidMetadata.RightToLeft = RightToLeft.No;
            chkInvalidMetadata.Size = new Size(152, 24);
            chkInvalidMetadata.TabIndex = 6;
            chkInvalidMetadata.Text = "Invalid Metadata";
            chkInvalidMetadata.UseVisualStyleBackColor = true;
            chkInvalidMetadata.CheckedChanged += chkInvalidMetadata_CheckedChanged;
            // 
            // chkInvalidOpcode
            // 
            chkInvalidOpcode.AutoSize = true;
            chkInvalidOpcode.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkInvalidOpcode.Location = new Point(23, 242);
            chkInvalidOpcode.Name = "chkInvalidOpcode";
            chkInvalidOpcode.RightToLeft = RightToLeft.No;
            chkInvalidOpcode.Size = new Size(141, 24);
            chkInvalidOpcode.TabIndex = 7;
            chkInvalidOpcode.Text = "Invalid Opcode";
            chkInvalidOpcode.UseVisualStyleBackColor = true;
            chkInvalidOpcode.CheckedChanged += chkInvalidOpcode_CheckedChanged;
            // 
            // chkRenameSymbols
            // 
            chkRenameSymbols.AutoSize = true;
            chkRenameSymbols.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkRenameSymbols.Location = new Point(23, 272);
            chkRenameSymbols.Name = "chkRenameSymbols";
            chkRenameSymbols.RightToLeft = RightToLeft.No;
            chkRenameSymbols.Size = new Size(170, 24);
            chkRenameSymbols.TabIndex = 8;
            chkRenameSymbols.Text = "Name Obfuscation";
            chkRenameSymbols.UseVisualStyleBackColor = true;
            chkRenameSymbols.CheckedChanged += chkRenameSymbols_CheckedChanged;
            // 
            // chkReferenceProxy
            // 
            chkReferenceProxy.AutoSize = true;
            chkReferenceProxy.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkReferenceProxy.Location = new Point(23, 302);
            chkReferenceProxy.Name = "chkReferenceProxy";
            chkReferenceProxy.RightToLeft = RightToLeft.No;
            chkReferenceProxy.Size = new Size(155, 24);
            chkReferenceProxy.TabIndex = 9;
            chkReferenceProxy.Text = "Reference Proxy";
            chkReferenceProxy.UseVisualStyleBackColor = true;
            chkReferenceProxy.CheckedChanged += chkReferenceProxy_CheckedChanged;
            // 
            // chkEncryptResources
            // 
            chkEncryptResources.AutoSize = true;
            chkEncryptResources.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkEncryptResources.Location = new Point(23, 332);
            chkEncryptResources.Name = "chkEncryptResources";
            chkEncryptResources.RightToLeft = RightToLeft.No;
            chkEncryptResources.Size = new Size(196, 24);
            chkEncryptResources.TabIndex = 10;
            chkEncryptResources.Text = "Resources Encryption";
            chkEncryptResources.UseVisualStyleBackColor = true;
            chkEncryptResources.CheckedChanged += chkEncryptResources_CheckedChanged;
            // 
            // chkEncryptStrings
            // 
            chkEncryptStrings.AutoSize = true;
            chkEncryptStrings.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkEncryptStrings.Location = new Point(23, 362);
            chkEncryptStrings.Name = "chkEncryptStrings";
            chkEncryptStrings.RightToLeft = RightToLeft.No;
            chkEncryptStrings.Size = new Size(159, 24);
            chkEncryptStrings.TabIndex = 11;
            chkEncryptStrings.Text = "String Encryption";
            chkEncryptStrings.UseVisualStyleBackColor = true;
            chkEncryptStrings.CheckedChanged += chkEncryptStrings_CheckedChanged;
            // 
            // chkWatermark
            // 
            chkWatermark.AutoSize = true;
            chkWatermark.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkWatermark.Location = new Point(23, 392);
            chkWatermark.Name = "chkWatermark";
            chkWatermark.RightToLeft = RightToLeft.No;
            chkWatermark.Size = new Size(113, 24);
            chkWatermark.TabIndex = 12;
            chkWatermark.Text = "Watermark";
            chkWatermark.UseVisualStyleBackColor = true;
            chkWatermark.CheckedChanged += chkWatermark_CheckedChanged;
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Font = new Font("Times New Roman", 10.2F);
            lbOutput.Location = new Point(235, 169);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(55, 19);
            lbOutput.TabIndex = 13;
            lbOutput.Text = "Output";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.Location = new Point(285, 92);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 14;
            label4.Text = "File name";
            // 
            // txtFileNameOutput
            // 
            txtFileNameOutput.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileNameOutput.Location = new Point(367, 90);
            txtFileNameOutput.Name = "txtFileNameOutput";
            txtFileNameOutput.RightToLeft = RightToLeft.No;
            txtFileNameOutput.Size = new Size(224, 25);
            txtFileNameOutput.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F);
            label5.Location = new Point(285, 122);
            label5.Name = "label5";
            label5.Size = new Size(138, 19);
            label5.TabIndex = 16;
            label5.Text = "Number of attribus";
            // 
            // txtNameAttribus
            // 
            txtNameAttribus.Font = new Font("Times New Roman", 7.8F);
            txtNameAttribus.Location = new Point(429, 119);
            txtNameAttribus.Name = "txtNameAttribus";
            txtNameAttribus.RightToLeft = RightToLeft.No;
            txtNameAttribus.Size = new Size(76, 22);
            txtNameAttribus.TabIndex = 17;
            txtNameAttribus.TextAlign = HorizontalAlignment.Center;
            // 
            // lbMaxNumberAttribus
            // 
            lbMaxNumberAttribus.AutoSize = true;
            lbMaxNumberAttribus.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMaxNumberAttribus.Location = new Point(522, 126);
            lbMaxNumberAttribus.Name = "lbMaxNumberAttribus";
            lbMaxNumberAttribus.Size = new Size(45, 15);
            lbMaxNumberAttribus.TabIndex = 18;
            lbMaxNumberAttribus.Text = "Max 20";
            // 
            // txtFileExe
            // 
            txtFileExe.Font = new Font("Times New Roman", 9F);
            txtFileExe.Location = new Point(175, 17);
            txtFileExe.Name = "txtFileExe";
            txtFileExe.RightToLeft = RightToLeft.No;
            txtFileExe.Size = new Size(467, 25);
            txtFileExe.TabIndex = 19;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Font = new Font("Times New Roman", 10.2F);
            btnSelectFile.Location = new Point(648, 16);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.RightToLeft = RightToLeft.Yes;
            btnSelectFile.Size = new Size(107, 29);
            btnSelectFile.TabIndex = 20;
            btnSelectFile.Text = "Select file";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // Play
            // 
            Play.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Play.Location = new Point(761, 12);
            Play.Name = "Play";
            Play.RightToLeft = RightToLeft.Yes;
            Play.Size = new Size(102, 37);
            Play.TabIndex = 21;
            Play.Text = "Protect";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // txtFolder
            // 
            txtFolder.Font = new Font("Times New Roman", 9F);
            txtFolder.Location = new Point(175, 57);
            txtFolder.Name = "txtFolder";
            txtFolder.RightToLeft = RightToLeft.No;
            txtFolder.Size = new Size(467, 25);
            txtFolder.TabIndex = 22;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Times New Roman", 10.2F);
            btnSelectFolder.Location = new Point(648, 55);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.RightToLeft = RightToLeft.No;
            btnSelectFolder.Size = new Size(215, 29);
            btnSelectFolder.TabIndex = 23;
            btnSelectFolder.Text = "Select folder depend";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // chkAntiDebug
            // 
            chkAntiDebug.AutoSize = true;
            chkAntiDebug.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkAntiDebug.Location = new Point(23, 90);
            chkAntiDebug.Name = "chkAntiDebug";
            chkAntiDebug.RightToLeft = RightToLeft.No;
            chkAntiDebug.Size = new Size(115, 24);
            chkAntiDebug.TabIndex = 24;
            chkAntiDebug.Text = "Anti-Debug";
            chkAntiDebug.UseVisualStyleBackColor = true;
            chkAntiDebug.CheckedChanged += chkAntiDebug_CheckedChanged;
            // 
            // chkAntiTamper
            // 
            chkAntiTamper.AutoSize = true;
            chkAntiTamper.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkAntiTamper.Location = new Point(23, 122);
            chkAntiTamper.Name = "chkAntiTamper";
            chkAntiTamper.RightToLeft = RightToLeft.No;
            chkAntiTamper.Size = new Size(123, 24);
            chkAntiTamper.TabIndex = 25;
            chkAntiTamper.Text = "Anti-Tamper";
            chkAntiTamper.UseVisualStyleBackColor = true;
            chkAntiTamper.CheckedChanged += chkAntiTamper_CheckedChanged;
            // 
            // rtbLogs
            // 
            rtbLogs.Location = new Point(235, 191);
            rtbLogs.Name = "rtbLogs";
            rtbLogs.Size = new Size(628, 247);
            rtbLogs.TabIndex = 26;
            rtbLogs.Text = "";
            // 
            // Obfuscation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(rtbLogs);
            Controls.Add(chkAntiTamper);
            Controls.Add(chkAntiDebug);
            Controls.Add(btnSelectFolder);
            Controls.Add(txtFolder);
            Controls.Add(Play);
            Controls.Add(btnSelectFile);
            Controls.Add(txtFileExe);
            Controls.Add(lbMaxNumberAttribus);
            Controls.Add(txtNameAttribus);
            Controls.Add(label5);
            Controls.Add(txtFileNameOutput);
            Controls.Add(label4);
            Controls.Add(lbOutput);
            Controls.Add(chkWatermark);
            Controls.Add(chkEncryptStrings);
            Controls.Add(chkEncryptResources);
            Controls.Add(chkReferenceProxy);
            Controls.Add(chkRenameSymbols);
            Controls.Add(chkInvalidOpcode);
            Controls.Add(chkInvalidMetadata);
            Controls.Add(chkEncryptConstants);
            Controls.Add(chkControlFlow);
            Controls.Add(lbSetting);
            Controls.Add(NameProject);
            Name = "Obfuscation";
            Text = "Obfuscation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameProject;
        private Label lbSetting;
        private CheckBox chkControlFlow;
        private CheckBox chkEncryptConstants;
        private CheckBox chkInvalidMetadata;
        private CheckBox chkInvalidOpcode;
        private CheckBox chkRenameSymbols;
        private CheckBox chkReferenceProxy;
        private CheckBox chkEncryptResources;
        private CheckBox chkEncryptStrings;
        private CheckBox chkWatermark;
        private Label lbOutput;
        private Label label4;
        private TextBox txtFileNameOutput;
        private Label label5;
        private TextBox txtNameAttribus;
        private Label lbMaxNumberAttribus;
        private TextBox txtFileExe;
        private Button btnSelectFile;
        private Button Play;
        private TextBox txtFolder;
        private Button btnSelectFolder;
        private CheckBox chkAntiDebug;
        private CheckBox chkAntiTamper;
        private RichTextBox rtbLogs;
    }
}