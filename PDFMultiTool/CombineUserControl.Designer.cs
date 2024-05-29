namespace PDFMultiTool
{
    partial class CombineUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combine_Button = new System.Windows.Forms.Button();
            this.BrowseFile_Button = new System.Windows.Forms.Button();
            this.browseOutput_Button = new System.Windows.Forms.Button();
            this.browseOutput_Textbox = new System.Windows.Forms.TextBox();
            this.SelectFiles_Label = new System.Windows.Forms.Label();
            this.browseOutput_CombineUserControl_Label = new System.Windows.Forms.Label();
            this.browseFiles_ConvertUserControl_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectFiles_ListBox = new System.Windows.Forms.ListBox();
            this.browseFolder_ConvertUserControl_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progress_UserControl_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.OutputFileName_CombineUserControl_Label = new System.Windows.Forms.Label();
            this.OutputFileName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Resolution_TextBox = new System.Windows.Forms.TextBox();
            this.OutputFileExtension_CombineUserControl_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combine_Button
            // 
            this.combine_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.combine_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combine_Button.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combine_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.combine_Button.Location = new System.Drawing.Point(579, 336);
            this.combine_Button.Name = "combine_Button";
            this.combine_Button.Size = new System.Drawing.Size(100, 50);
            this.combine_Button.TabIndex = 4;
            this.combine_Button.Text = "Combine";
            this.combine_Button.UseVisualStyleBackColor = true;
            this.combine_Button.Click += new System.EventHandler(this.combine_Button_Click);
            // 
            // BrowseFile_Button
            // 
            this.BrowseFile_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.BrowseFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseFile_Button.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFile_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.BrowseFile_Button.Location = new System.Drawing.Point(207, 9);
            this.BrowseFile_Button.Name = "BrowseFile_Button";
            this.BrowseFile_Button.Size = new System.Drawing.Size(100, 30);
            this.BrowseFile_Button.TabIndex = 5;
            this.BrowseFile_Button.Text = "Browse";
            this.BrowseFile_Button.UseVisualStyleBackColor = true;
            this.BrowseFile_Button.Click += new System.EventHandler(this.BrowseFile_Button_Click);
            // 
            // browseOutput_Button
            // 
            this.browseOutput_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.browseOutput_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseOutput_Button.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseOutput_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.browseOutput_Button.Location = new System.Drawing.Point(207, 167);
            this.browseOutput_Button.Name = "browseOutput_Button";
            this.browseOutput_Button.Size = new System.Drawing.Size(100, 30);
            this.browseOutput_Button.TabIndex = 6;
            this.browseOutput_Button.Text = "Browse";
            this.browseOutput_Button.UseVisualStyleBackColor = true;
            this.browseOutput_Button.Click += new System.EventHandler(this.browseOutput_Button_Click);
            // 
            // browseOutput_Textbox
            // 
            this.browseOutput_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.browseOutput_Textbox.Location = new System.Drawing.Point(7, 203);
            this.browseOutput_Textbox.Name = "browseOutput_Textbox";
            this.browseOutput_Textbox.ReadOnly = true;
            this.browseOutput_Textbox.Size = new System.Drawing.Size(300, 27);
            this.browseOutput_Textbox.TabIndex = 9;
            // 
            // SelectFiles_Label
            // 
            this.SelectFiles_Label.AutoSize = true;
            this.SelectFiles_Label.BackColor = System.Drawing.Color.Transparent;
            this.SelectFiles_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFiles_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SelectFiles_Label.Location = new System.Drawing.Point(3, 15);
            this.SelectFiles_Label.Name = "SelectFiles_Label";
            this.SelectFiles_Label.Size = new System.Drawing.Size(108, 19);
            this.SelectFiles_Label.TabIndex = 10;
            this.SelectFiles_Label.Text = "1. Select File(s)";
            // 
            // browseOutput_CombineUserControl_Label
            // 
            this.browseOutput_CombineUserControl_Label.AutoSize = true;
            this.browseOutput_CombineUserControl_Label.BackColor = System.Drawing.Color.Transparent;
            this.browseOutput_CombineUserControl_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseOutput_CombineUserControl_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.browseOutput_CombineUserControl_Label.Location = new System.Drawing.Point(3, 173);
            this.browseOutput_CombineUserControl_Label.Name = "browseOutput_CombineUserControl_Label";
            this.browseOutput_CombineUserControl_Label.Size = new System.Drawing.Size(181, 19);
            this.browseOutput_CombineUserControl_Label.TabIndex = 11;
            this.browseOutput_CombineUserControl_Label.Text = "2. Select Output Location";
            // 
            // SelectFiles_ListBox
            // 
            this.SelectFiles_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SelectFiles_ListBox.FormattingEnabled = true;
            this.SelectFiles_ListBox.HorizontalScrollbar = true;
            this.SelectFiles_ListBox.ItemHeight = 19;
            this.SelectFiles_ListBox.Location = new System.Drawing.Point(7, 45);
            this.SelectFiles_ListBox.Name = "SelectFiles_ListBox";
            this.SelectFiles_ListBox.Size = new System.Drawing.Size(300, 99);
            this.SelectFiles_ListBox.TabIndex = 18;
            // 
            // browseFolder_ConvertUserControl_FolderBrowserDialog
            // 
            this.browseFolder_ConvertUserControl_FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // progress_UserControl_ProgressBar
            // 
            this.progress_UserControl_ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.progress_UserControl_ProgressBar.Location = new System.Drawing.Point(0, 392);
            this.progress_UserControl_ProgressBar.Name = "progress_UserControl_ProgressBar";
            this.progress_UserControl_ProgressBar.Size = new System.Drawing.Size(679, 10);
            this.progress_UserControl_ProgressBar.TabIndex = 19;
            // 
            // OutputFileName_CombineUserControl_Label
            // 
            this.OutputFileName_CombineUserControl_Label.AutoSize = true;
            this.OutputFileName_CombineUserControl_Label.BackColor = System.Drawing.Color.Transparent;
            this.OutputFileName_CombineUserControl_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFileName_CombineUserControl_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OutputFileName_CombineUserControl_Label.Location = new System.Drawing.Point(3, 263);
            this.OutputFileName_CombineUserControl_Label.Name = "OutputFileName_CombineUserControl_Label";
            this.OutputFileName_CombineUserControl_Label.Size = new System.Drawing.Size(144, 19);
            this.OutputFileName_CombineUserControl_Label.TabIndex = 21;
            this.OutputFileName_CombineUserControl_Label.Text = "3. Output File Name";
            // 
            // OutputFileName_TextBox
            // 
            this.OutputFileName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OutputFileName_TextBox.Location = new System.Drawing.Point(153, 260);
            this.OutputFileName_TextBox.Name = "OutputFileName_TextBox";
            this.OutputFileName_TextBox.Size = new System.Drawing.Size(111, 27);
            this.OutputFileName_TextBox.TabIndex = 20;
            this.OutputFileName_TextBox.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(3, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "4. [Optional] Resolution";
            // 
            // Resolution_TextBox
            // 
            this.Resolution_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Resolution_TextBox.Location = new System.Drawing.Point(207, 326);
            this.Resolution_TextBox.Name = "Resolution_TextBox";
            this.Resolution_TextBox.Size = new System.Drawing.Size(100, 27);
            this.Resolution_TextBox.TabIndex = 25;
            this.Resolution_TextBox.Text = "300";
            this.Resolution_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Resolution_TextBox_KeyPress);
            // 
            // OutputFileExtension_CombineUserControl_Label
            // 
            this.OutputFileExtension_CombineUserControl_Label.AutoSize = true;
            this.OutputFileExtension_CombineUserControl_Label.BackColor = System.Drawing.Color.Transparent;
            this.OutputFileExtension_CombineUserControl_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFileExtension_CombineUserControl_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OutputFileExtension_CombineUserControl_Label.Location = new System.Drawing.Point(270, 263);
            this.OutputFileExtension_CombineUserControl_Label.Name = "OutputFileExtension_CombineUserControl_Label";
            this.OutputFileExtension_CombineUserControl_Label.Size = new System.Drawing.Size(37, 19);
            this.OutputFileExtension_CombineUserControl_Label.TabIndex = 27;
            this.OutputFileExtension_CombineUserControl_Label.Text = ".pdf";
            // 
            // CombineUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.OutputFileExtension_CombineUserControl_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resolution_TextBox);
            this.Controls.Add(this.OutputFileName_CombineUserControl_Label);
            this.Controls.Add(this.OutputFileName_TextBox);
            this.Controls.Add(this.progress_UserControl_ProgressBar);
            this.Controls.Add(this.SelectFiles_ListBox);
            this.Controls.Add(this.browseOutput_CombineUserControl_Label);
            this.Controls.Add(this.SelectFiles_Label);
            this.Controls.Add(this.browseOutput_Textbox);
            this.Controls.Add(this.browseOutput_Button);
            this.Controls.Add(this.BrowseFile_Button);
            this.Controls.Add(this.combine_Button);
            this.Font = new System.Drawing.Font("Candara", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CombineUserControl";
            this.Size = new System.Drawing.Size(682, 402);
            this.Load += new System.EventHandler(this.CombineUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button combine_Button;
        private System.Windows.Forms.Button BrowseFile_Button;
        private System.Windows.Forms.Button browseOutput_Button;
        private System.Windows.Forms.TextBox browseOutput_Textbox;
        private System.Windows.Forms.Label SelectFiles_Label;
        private System.Windows.Forms.Label browseOutput_CombineUserControl_Label;
        private System.Windows.Forms.OpenFileDialog browseFiles_ConvertUserControl_OpenFileDialog;
        private System.Windows.Forms.ListBox SelectFiles_ListBox;
        private System.Windows.Forms.FolderBrowserDialog browseFolder_ConvertUserControl_FolderBrowserDialog;
        private System.Windows.Forms.ProgressBar progress_UserControl_ProgressBar;
        private System.Windows.Forms.Label OutputFileName_CombineUserControl_Label;
        private System.Windows.Forms.TextBox OutputFileName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Resolution_TextBox;
        private System.Windows.Forms.Label OutputFileExtension_CombineUserControl_Label;
    }
}
