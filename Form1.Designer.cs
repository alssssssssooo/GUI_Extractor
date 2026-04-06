namespace ExtractorGui;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Button btnDownload;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnBrowseInput;
    private System.Windows.Forms.Button btnBrowseOutput;
    private System.Windows.Forms.Label lblInput;
    private System.Windows.Forms.Label lblOutput;
    private System.Windows.Forms.TextBox tbInputPath;
    private System.Windows.Forms.TextBox tbOutputPath;
    private System.Windows.Forms.CheckBox cbAll;
    private System.Windows.Forms.CheckBox cbDeep;
    private System.Windows.Forms.CheckBox cbSeparate;
    private System.Windows.Forms.CheckBox cbSkipExisting;
    private System.Windows.Forms.CheckBox cbQuiet;
    private System.Windows.Forms.ComboBox cbLanguage;
    private System.Windows.Forms.Label lblLanguage;
    private System.Windows.Forms.GroupBox grpOptions;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.Label lblLog;
    private System.Windows.Forms.Label lblStatus;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        btnDownload = new System.Windows.Forms.Button();
        btnRun = new System.Windows.Forms.Button();
        btnHelp = new System.Windows.Forms.Button();
        btnBrowseInput = new System.Windows.Forms.Button();
        btnBrowseOutput = new System.Windows.Forms.Button();
        lblInput = new System.Windows.Forms.Label();
        lblOutput = new System.Windows.Forms.Label();
        tbInputPath = new System.Windows.Forms.TextBox();
        tbOutputPath = new System.Windows.Forms.TextBox();
        cbAll = new System.Windows.Forms.CheckBox();
        cbDeep = new System.Windows.Forms.CheckBox();
        cbSeparate = new System.Windows.Forms.CheckBox();
        cbSkipExisting = new System.Windows.Forms.CheckBox();
        cbQuiet = new System.Windows.Forms.CheckBox();
        cbLanguage = new System.Windows.Forms.ComboBox();
        lblLanguage = new System.Windows.Forms.Label();
        grpOptions = new System.Windows.Forms.GroupBox();
        tbLog = new System.Windows.Forms.TextBox();
        lblLog = new System.Windows.Forms.Label();
        lblStatus = new System.Windows.Forms.Label();
        SuspendLayout();
        
        // btnDownload
        btnDownload.Location = new System.Drawing.Point(22, 16);
        btnDownload.Name = "btnDownload";
        btnDownload.Size = new System.Drawing.Size(150, 32);
        btnDownload.TabIndex = 0;
        btnDownload.Text = "Download";
        btnDownload.UseVisualStyleBackColor = true;
        btnDownload.Click += btnDownload_Click;
        
        // btnRun
        btnRun.Location = new System.Drawing.Point(22, 192);
        btnRun.Name = "btnRun";
        btnRun.Size = new System.Drawing.Size(150, 32);
        btnRun.TabIndex = 9;
        btnRun.Text = "Run";
        btnRun.UseVisualStyleBackColor = true;
        btnRun.Click += btnRun_Click;
        
        // btnHelp
        btnHelp.Location = new System.Drawing.Point(182, 16);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new System.Drawing.Size(150, 32);
        btnHelp.TabIndex = 1;
        btnHelp.Text = "Help";
        btnHelp.UseVisualStyleBackColor = true;
        btnHelp.Click += btnHelp_Click;
        
        // btnBrowseInput
        btnBrowseInput.Location = new System.Drawing.Point(726, 70);
        btnBrowseInput.Name = "btnBrowseInput";
        btnBrowseInput.Size = new System.Drawing.Size(60, 27);
        btnBrowseInput.TabIndex = 2;
        btnBrowseInput.Text = "...";
        btnBrowseInput.UseVisualStyleBackColor = true;
        btnBrowseInput.Click += btnBrowseInput_Click;
        
        // btnBrowseOutput
        btnBrowseOutput.Location = new System.Drawing.Point(726, 116);
        btnBrowseOutput.Name = "btnBrowseOutput";
        btnBrowseOutput.Size = new System.Drawing.Size(60, 27);
        btnBrowseOutput.TabIndex = 4;
        btnBrowseOutput.Text = "...";
        btnBrowseOutput.UseVisualStyleBackColor = true;
        btnBrowseOutput.Click += btnBrowseOutput_Click;
        
        // lblInput
        lblInput.AutoSize = true;
        lblInput.Location = new System.Drawing.Point(22, 75);
        lblInput.Name = "lblInput";
        lblInput.Size = new System.Drawing.Size(111, 15);
        lblInput.TabIndex = 5;
        lblInput.Text = "Input file / folder:";
        
        // lblOutput
        lblOutput.AutoSize = true;
        lblOutput.Location = new System.Drawing.Point(22, 121);
        lblOutput.Name = "lblOutput";
        lblOutput.Size = new System.Drawing.Size(84, 15);
        lblOutput.TabIndex = 6;
        lblOutput.Text = "Output folder:";
        
        // tbInputPath
        tbInputPath.Location = new System.Drawing.Point(145, 72);
        tbInputPath.Name = "tbInputPath";
        tbInputPath.Size = new System.Drawing.Size(575, 23);
        tbInputPath.TabIndex = 1;
        
        // tbOutputPath
        tbOutputPath.Location = new System.Drawing.Point(145, 116);
        tbOutputPath.Name = "tbOutputPath";
        tbOutputPath.Size = new System.Drawing.Size(575, 23);
        tbOutputPath.TabIndex = 3;
        
        // cbAll
        cbAll.AutoSize = true;
        cbAll.Location = new System.Drawing.Point(18, 26);
        cbAll.Name = "cbAll";
        cbAll.Size = new System.Drawing.Size(198, 19);
        cbAll.TabIndex = 5;
        cbAll.Text = "--all (extract all .scs in folder)";
        cbAll.UseVisualStyleBackColor = true;
        
        // cbDeep
        cbDeep.AutoSize = true;
        cbDeep.Location = new System.Drawing.Point(18, 52);
        cbDeep.Name = "cbDeep";
        cbDeep.Size = new System.Drawing.Size(152, 19);
        cbDeep.TabIndex = 6;
        cbDeep.Text = "--deep (HashFS deep scan)";
        cbDeep.UseVisualStyleBackColor = true;
        
        // cbSeparate
        cbSeparate.AutoSize = true;
        cbSeparate.Location = new System.Drawing.Point(18, 78);
        cbSeparate.Name = "cbSeparate";
        cbSeparate.Size = new System.Drawing.Size(160, 19);
        cbSeparate.TabIndex = 7;
        cbSeparate.Text = "--separate (separate output)";
        cbSeparate.UseVisualStyleBackColor = true;
        
        // cbSkipExisting
        cbSkipExisting.AutoSize = true;
        cbSkipExisting.Location = new System.Drawing.Point(18, 104);
        cbSkipExisting.Name = "cbSkipExisting";
        cbSkipExisting.Size = new System.Drawing.Size(212, 19);
        cbSkipExisting.TabIndex = 8;
        cbSkipExisting.Text = "--skip-existing (do not overwrite)";
        cbSkipExisting.UseVisualStyleBackColor = true;
        
        // cbQuiet
        cbQuiet.AutoSize = true;
        cbQuiet.Location = new System.Drawing.Point(18, 129);
        cbQuiet.Name = "cbQuiet";
        cbQuiet.Size = new System.Drawing.Size(180, 19);
        cbQuiet.TabIndex = 12;
        cbQuiet.Text = "-q (do not wait for keypress)";
        cbQuiet.UseVisualStyleBackColor = true;
        cbQuiet.Checked = true;
        
        // cbLanguage
        cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cbLanguage.FormattingEnabled = true;
        cbLanguage.Location = new System.Drawing.Point(592, 21);
        cbLanguage.Name = "cbLanguage";
        cbLanguage.Size = new System.Drawing.Size(194, 23);
        cbLanguage.TabIndex = 10;
        cbLanguage.SelectedIndexChanged += cbLanguage_SelectedIndexChanged;
        
        // lblLanguage
        lblLanguage.AutoSize = true;
        lblLanguage.Location = new System.Drawing.Point(524, 25);
        lblLanguage.Name = "lblLanguage";
        lblLanguage.Size = new System.Drawing.Size(58, 15);
        lblLanguage.TabIndex = 11;
        lblLanguage.Text = "Language";
        
        // grpOptions
        grpOptions.Controls.Add(cbAll);
        grpOptions.Controls.Add(cbDeep);
        grpOptions.Controls.Add(cbSeparate);
        grpOptions.Controls.Add(cbSkipExisting);
        grpOptions.Controls.Add(cbQuiet);
        grpOptions.Location = new System.Drawing.Point(22, 245);
        grpOptions.Name = "grpOptions";
        grpOptions.Size = new System.Drawing.Size(764, 170);
        grpOptions.TabIndex = 12;
        grpOptions.TabStop = false;
        grpOptions.Text = "Extraction Options";
        
        // tbLog
        tbLog.Location = new System.Drawing.Point(22, 418);
        tbLog.Multiline = true;
        tbLog.Name = "tbLog";
        tbLog.ReadOnly = true;
        tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tbLog.Size = new System.Drawing.Size(764, 170);
        tbLog.TabIndex = 13;
        
        // lblLog
        lblLog.AutoSize = true;
        lblLog.Location = new System.Drawing.Point(22, 400);
        lblLog.Name = "lblLog";
        lblLog.Size = new System.Drawing.Size(69, 15);
        lblLog.TabIndex = 14;
        lblLog.Text = "Log output";
        
        // lblStatus
        lblStatus.AutoSize = true;
        lblStatus.Location = new System.Drawing.Point(22, 375);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(96, 15);
        lblStatus.TabIndex = 15;
        lblStatus.Text = "Status message";
        
        // Form1
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(808, 606);
        Controls.Add(lblStatus);
        Controls.Add(lblLog);
        Controls.Add(tbLog);
        Controls.Add(grpOptions);
        Controls.Add(lblLanguage);
        Controls.Add(cbLanguage);
        Controls.Add(btnHelp);
        Controls.Add(btnRun);
        Controls.Add(tbOutputPath);
        Controls.Add(tbInputPath);
        Controls.Add(lblOutput);
        Controls.Add(lblInput);
        Controls.Add(btnBrowseOutput);
        Controls.Add(btnBrowseInput);
        Controls.Add(btnDownload);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Extractor GUI";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
