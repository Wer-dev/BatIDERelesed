namespace BatIDE
{
    partial class BatEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatEditor));
            this.CodeTXT = new FastColoredTextBoxNS.FastColoredTextBox();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.ListProject = new System.Windows.Forms.ListBox();
            this.NameProject = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundEditorCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сommentingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseEditor = new System.Windows.Forms.Label();
            this.HideEditor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findToGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTXT)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeTXT
            // 
            this.CodeTXT.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.autocompleteMenu1.SetAutocompleteMenu(this.CodeTXT, this.autocompleteMenu1);
            this.CodeTXT.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.CodeTXT.AutoScrollMinSize = new System.Drawing.Size(305, 28);
            this.CodeTXT.BackBrush = null;
            this.CodeTXT.BackColor = System.Drawing.Color.Black;
            this.CodeTXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CodeTXT.CharHeight = 28;
            this.CodeTXT.CharWidth = 14;
            this.CodeTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeTXT.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CodeTXT.Font = new System.Drawing.Font("Source Code Pro", 13.8F);
            this.CodeTXT.ForeColor = System.Drawing.SystemColors.Menu;
            this.CodeTXT.IndentBackColor = System.Drawing.Color.Black;
            this.CodeTXT.IsReplaceMode = false;
            this.CodeTXT.LineNumberColor = System.Drawing.Color.SpringGreen;
            this.CodeTXT.Location = new System.Drawing.Point(0, 63);
            this.CodeTXT.Margin = new System.Windows.Forms.Padding(6);
            this.CodeTXT.Name = "CodeTXT";
            this.CodeTXT.Paddings = new System.Windows.Forms.Padding(0);
            this.CodeTXT.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CodeTXT.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("CodeTXT.ServiceColors")));
            this.CodeTXT.ServiceLinesColor = System.Drawing.Color.Gray;
            this.CodeTXT.Size = new System.Drawing.Size(858, 468);
            this.CodeTXT.TabIndex = 0;
            this.CodeTXT.Text = "fastColoredTextBox1";
            this.CodeTXT.Zoom = 100;
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "@echo off",
        "echo text",
        "echo.",
        "set variable=value",
        "setlocal",
        "endlocal",
        "if condition command",
        "if exist file command",
        "if not condition command",
        "if not exist file command",
        "goto label",
        "goto :eof",
        "call :label",
        "shift",
        "for %%variable in (set) do command [command-parameters]",
        "for /f \"options\" %%variable in (file-set) do command [command-parameters]",
        "for /l %%variable in (start,step,end) do command [command-parameters]",
        "for /d %%variable in (set) do command [command-parameters]",
        "for /r [[drive:]path] %%variable in (set) do command [command-parameters]",
        "for /f \"tokens=* delims= \" %%variable in (file-set) do command [command-parameter" +
            "s]",
        "set /p variable=[promptString]",
        "choice /c choices /n /m promptString",
        "pause",
        "copy source destination [/y]",
        "move source destination [/y]",
        "rename old new",
        "del file",
        "rmdir directory",
        "mkdir directory",
        "attrib [±R] [±A] [±S] [±H] [drive:][path][filename] [/s] [/d]",
        "cls",
        "title text",
        "start \"title\" [/d path] [options] \"command\" [parameters]",
        "call :label",
        "echo !variable!",
        "set \"variable=value\"",
        "for %%A in (\"%variable%\") do command [command-parameters]",
        "for /f \"usebackq tokens=* delims=\" %%A in (\"file\") do command [command-parameters" +
            "]",
        "setlocal enabledelayedexpansion",
        "endlocal & set variable=value",
        "if errorlevel number command",
        "if defined variable command",
        "choice /t timeout /d choice /n /m promptString",
        "xcopy source destination /s /i /y",
        "xcopy source destination /s /i /d",
        "xcopy source destination /s /i /d /y",
        "md directory",
        "rd directory",
        "attrib -R -A -S -H [drive:][path][filename] [/s] [/d]",
        "goto :label",
        "shift /n",
        "set /a variable=expression",
        "for %%variable in (\"string\") do command [command-parameters]",
        "for /f %%variable in (\'command\') do command [command-parameters]",
        "for %%variable in (set) do ( command [command-parameters] )",
        "for /f \"tokens=*\" %%variable in (\'command\') do ( command [command-parameters] )",
        "set /p \"variable=promptText\"",
        "if exist \"filename\" ( command [command-parameters] ) else ( command [command-para" +
            "meters] )",
        "start \"\" \"command\"",
        "timeout /t seconds /nobreak",
        "choice /c choices /n /t timeout /d default /m promptString",
        "if not defined variable command",
        "setlocal disabledelayedexpansion",
        "popd",
        "pushd",
        "assoc",
        "ftype",
        "choice /c choices /n /t timeout /d default /m promptString",
        "xcopy source destination /s /i",
        "xcopy source destination /s /i /y",
        "robocopy source destination [file(s)] [options]",
        "erase file",
        "rename",
        "pause",
        "break",
        "rem",
        "for /f \"delims=\" %%variable in (\"string\") do command [command-parameters]",
        "for /f \"tokens=* delims=\" %%variable in (\'command\') do command [command-parameter" +
            "s]",
        "for /l %%variable in (start,step,end) do ( command [command-parameters] )",
        "for /d %%variable in (\"directory\") do ( command [command-parameters] )",
        "set /a \"variable+=value\"",
        "set /a \"variable-=value\"",
        "choice /c choices /n /t timeout /m promptString",
        "takeown",
        "icacls",
        "schtasks",
        "bcdedit",
        "sc",
        "powercfg",
        "reg",
        "wevtutil",
        "wmic",
        "driverquery"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            this.autocompleteMenu1.ToolTipDuration = 100;
            // 
            // ListProject
            // 
            this.ListProject.BackColor = System.Drawing.SystemColors.InfoText;
            this.ListProject.Font = new System.Drawing.Font("Source Code Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListProject.ForeColor = System.Drawing.SystemColors.Menu;
            this.ListProject.FormattingEnabled = true;
            this.ListProject.ItemHeight = 29;
            this.ListProject.Location = new System.Drawing.Point(867, 63);
            this.ListProject.Name = "ListProject";
            this.ListProject.Size = new System.Drawing.Size(251, 468);
            this.ListProject.TabIndex = 1;
            this.ListProject.SelectedIndexChanged += new System.EventHandler(this.ListProject_SelectedIndexChanged);
            // 
            // NameProject
            // 
            this.NameProject.AutoSize = true;
            this.NameProject.Location = new System.Drawing.Point(-6, 9);
            this.NameProject.Name = "NameProject";
            this.NameProject.Size = new System.Drawing.Size(117, 36);
            this.NameProject.TabIndex = 2;
            this.NameProject.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.testToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.documentalToolStripMenuItem,
            this.findToolStripMenuItem,
            this.сommentingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 533);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.testToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem.Image")));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripMenuItem.Image")));
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundEditorCodeToolStripMenuItem});
            this.settingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // backgroundEditorCodeToolStripMenuItem
            // 
            this.backgroundEditorCodeToolStripMenuItem.Name = "backgroundEditorCodeToolStripMenuItem";
            this.backgroundEditorCodeToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.backgroundEditorCodeToolStripMenuItem.Text = "Background Editor Code";
            this.backgroundEditorCodeToolStripMenuItem.Click += new System.EventHandler(this.backgroundEditorCodeToolStripMenuItem_Click);
            // 
            // documentalToolStripMenuItem
            // 
            this.documentalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.documentalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("documentalToolStripMenuItem.Image")));
            this.documentalToolStripMenuItem.Name = "documentalToolStripMenuItem";
            this.documentalToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.documentalToolStripMenuItem.Text = "Documentation";
            this.documentalToolStripMenuItem.Click += new System.EventHandler(this.documentalToolStripMenuItem_Click);
            // 
            // сommentingToolStripMenuItem
            // 
            this.сommentingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.сommentingToolStripMenuItem.Name = "сommentingToolStripMenuItem";
            this.сommentingToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.сommentingToolStripMenuItem.Text = "Сommenting";
            this.сommentingToolStripMenuItem.Click += new System.EventHandler(this.сommentingToolStripMenuItem_Click);
            // 
            // CloseEditor
            // 
            this.CloseEditor.AutoSize = true;
            this.CloseEditor.Location = new System.Drawing.Point(1074, 9);
            this.CloseEditor.Name = "CloseEditor";
            this.CloseEditor.Size = new System.Drawing.Size(32, 36);
            this.CloseEditor.TabIndex = 4;
            this.CloseEditor.Text = "X";
            this.CloseEditor.Click += new System.EventHandler(this.CloseEditor_Click);
            this.CloseEditor.MouseEnter += new System.EventHandler(this.CloseEditor_MouseEnter);
            this.CloseEditor.MouseLeave += new System.EventHandler(this.CloseEditor_MouseLeave);
            // 
            // HideEditor
            // 
            this.HideEditor.AutoSize = true;
            this.HideEditor.Location = new System.Drawing.Point(1036, 9);
            this.HideEditor.Name = "HideEditor";
            this.HideEditor.Size = new System.Drawing.Size(32, 36);
            this.HideEditor.TabIndex = 5;
            this.HideEditor.Text = "-";
            this.HideEditor.Click += new System.EventHandler(this.HideEditor_Click);
            this.HideEditor.MouseEnter += new System.EventHandler(this.HideEditor_MouseEnter);
            this.HideEditor.MouseLeave += new System.EventHandler(this.HideEditor_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(966, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 34);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(917, 12);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(43, 34);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem1,
            this.findToGOToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem});
            this.findToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findAndReplaceToolStripMenuItem.Text = "Replace";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem1
            // 
            this.findToolStripMenuItem1.Name = "findToolStripMenuItem1";
            this.findToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem1.Text = "Find";
            this.findToolStripMenuItem1.Click += new System.EventHandler(this.findToolStripMenuItem1_Click);
            // 
            // findToGOToolStripMenuItem
            // 
            this.findToGOToolStripMenuItem.Name = "findToGOToolStripMenuItem";
            this.findToGOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToGOToolStripMenuItem.Text = "Find the term";
            this.findToGOToolStripMenuItem.Click += new System.EventHandler(this.findToGOToolStripMenuItem_Click);
            // 
            // BatEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1118, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HideEditor);
            this.Controls.Add(this.CloseEditor);
            this.Controls.Add(this.NameProject);
            this.Controls.Add(this.ListProject);
            this.Controls.Add(this.CodeTXT);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Source Code Pro", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BatEditor";
            this.Text = "BatEditor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BatEditor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BatEditor_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BatEditor_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CodeTXT)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox CodeTXT;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.ListBox ListProject;
        private System.Windows.Forms.Label NameProject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label CloseEditor;
        private System.Windows.Forms.Label HideEditor;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundEditorCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сommentingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
    }
}