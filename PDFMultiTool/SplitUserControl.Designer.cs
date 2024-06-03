namespace PDFMultiTool
{
    partial class SplitUserControl
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
            this.BrowseFile_Button = new System.Windows.Forms.Button();
            this.browseOutput_Button = new System.Windows.Forms.Button();
            this.browseOutput_Textbox = new System.Windows.Forms.TextBox();
            this.SelectFiles_Label = new System.Windows.Forms.Label();
            this.browseOutput_CombineUserControl_Label = new System.Windows.Forms.Label();
            this.browseFiles_ConvertUserControl_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseFolder_ConvertUserControl_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OutputFileName_Label = new System.Windows.Forms.Label();
            this.OutputFileName_TextBox = new System.Windows.Forms.TextBox();
            this.OutputFileExtension_Label = new System.Windows.Forms.Label();
            this.split_Button = new System.Windows.Forms.Button();
            this.browseFile_Textbox = new System.Windows.Forms.TextBox();
            this.FromPage_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileToPage_TextBox = new System.Windows.Forms.TextBox();
            this.fileFromPage_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.browseOutput_Button.Location = new System.Drawing.Point(207, 189);
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
            this.browseOutput_Textbox.Location = new System.Drawing.Point(7, 225);
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
            this.browseOutput_CombineUserControl_Label.Location = new System.Drawing.Point(3, 195);
            this.browseOutput_CombineUserControl_Label.Name = "browseOutput_CombineUserControl_Label";
            this.browseOutput_CombineUserControl_Label.Size = new System.Drawing.Size(181, 19);
            this.browseOutput_CombineUserControl_Label.TabIndex = 11;
            this.browseOutput_CombineUserControl_Label.Text = "2. Select Output Location";
            // 
            // browseFolder_ConvertUserControl_FolderBrowserDialog
            // 
            this.browseFolder_ConvertUserControl_FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // OutputFileName_Label
            // 
            this.OutputFileName_Label.AutoSize = true;
            this.OutputFileName_Label.BackColor = System.Drawing.Color.Transparent;
            this.OutputFileName_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFileName_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OutputFileName_Label.Location = new System.Drawing.Point(4, 310);
            this.OutputFileName_Label.Name = "OutputFileName_Label";
            this.OutputFileName_Label.Size = new System.Drawing.Size(144, 19);
            this.OutputFileName_Label.TabIndex = 21;
            this.OutputFileName_Label.Text = "3. Output File Name";
            // 
            // OutputFileName_TextBox
            // 
            this.OutputFileName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OutputFileName_TextBox.Location = new System.Drawing.Point(154, 307);
            this.OutputFileName_TextBox.Name = "OutputFileName_TextBox";
            this.OutputFileName_TextBox.Size = new System.Drawing.Size(111, 27);
            this.OutputFileName_TextBox.TabIndex = 20;
            this.OutputFileName_TextBox.Text = "Output";
            // 
            // OutputFileExtension_Label
            // 
            this.OutputFileExtension_Label.AutoSize = true;
            this.OutputFileExtension_Label.BackColor = System.Drawing.Color.Transparent;
            this.OutputFileExtension_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFileExtension_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OutputFileExtension_Label.Location = new System.Drawing.Point(271, 310);
            this.OutputFileExtension_Label.Name = "OutputFileExtension_Label";
            this.OutputFileExtension_Label.Size = new System.Drawing.Size(37, 19);
            this.OutputFileExtension_Label.TabIndex = 27;
            this.OutputFileExtension_Label.Text = ".pdf";
            // 
            // split_Button
            // 
            this.split_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.split_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.split_Button.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.split_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.split_Button.Location = new System.Drawing.Point(579, 349);
            this.split_Button.Name = "split_Button";
            this.split_Button.Size = new System.Drawing.Size(100, 50);
            this.split_Button.TabIndex = 4;
            this.split_Button.Text = "Split";
            this.split_Button.UseVisualStyleBackColor = true;
            this.split_Button.Click += new System.EventHandler(this.split_Button_Click);
            // 
            // browseFile_Textbox
            // 
            this.browseFile_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.browseFile_Textbox.Location = new System.Drawing.Point(7, 45);
            this.browseFile_Textbox.Name = "browseFile_Textbox";
            this.browseFile_Textbox.ReadOnly = true;
            this.browseFile_Textbox.Size = new System.Drawing.Size(300, 27);
            this.browseFile_Textbox.TabIndex = 28;
            // 
            // FromPage_Label
            // 
            this.FromPage_Label.AutoSize = true;
            this.FromPage_Label.BackColor = System.Drawing.Color.Transparent;
            this.FromPage_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromPage_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.FromPage_Label.Location = new System.Drawing.Point(3, 81);
            this.FromPage_Label.Name = "FromPage_Label";
            this.FromPage_Label.Size = new System.Drawing.Size(107, 19);
            this.FromPage_Label.TabIndex = 29;
            this.FromPage_Label.Text = "1.1. From Page:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "1.2. To Page:";
            // 
            // fileToPage_TextBox
            // 
            this.fileToPage_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fileToPage_TextBox.Location = new System.Drawing.Point(116, 111);
            this.fileToPage_TextBox.Name = "fileToPage_TextBox";
            this.fileToPage_TextBox.Size = new System.Drawing.Size(68, 27);
            this.fileToPage_TextBox.TabIndex = 33;
            this.fileToPage_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileToPage_TextBox_KeyPress);
            // 
            // fileFromPage_TextBox
            // 
            this.fileFromPage_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fileFromPage_TextBox.Location = new System.Drawing.Point(116, 78);
            this.fileFromPage_TextBox.Name = "fileFromPage_TextBox";
            this.fileFromPage_TextBox.Size = new System.Drawing.Size(68, 27);
            this.fileFromPage_TextBox.TabIndex = 34;
            this.fileFromPage_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileFromPage_TextBox_KeyPress);
            // 
            // SplitUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.fileFromPage_TextBox);
            this.Controls.Add(this.fileToPage_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FromPage_Label);
            this.Controls.Add(this.browseFile_Textbox);
            this.Controls.Add(this.OutputFileExtension_Label);
            this.Controls.Add(this.OutputFileName_Label);
            this.Controls.Add(this.OutputFileName_TextBox);
            this.Controls.Add(this.browseOutput_CombineUserControl_Label);
            this.Controls.Add(this.SelectFiles_Label);
            this.Controls.Add(this.browseOutput_Textbox);
            this.Controls.Add(this.browseOutput_Button);
            this.Controls.Add(this.BrowseFile_Button);
            this.Controls.Add(this.split_Button);
            this.Font = new System.Drawing.Font("Candara", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SplitUserControl";
            this.Size = new System.Drawing.Size(682, 402);
            this.Load += new System.EventHandler(this.CombineUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BrowseFile_Button;
        private System.Windows.Forms.Button browseOutput_Button;
        private System.Windows.Forms.TextBox browseOutput_Textbox;
        private System.Windows.Forms.Label SelectFiles_Label;
        private System.Windows.Forms.Label browseOutput_CombineUserControl_Label;
        private System.Windows.Forms.OpenFileDialog browseFiles_ConvertUserControl_OpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog browseFolder_ConvertUserControl_FolderBrowserDialog;
        private System.Windows.Forms.Label OutputFileName_Label;
        private System.Windows.Forms.TextBox OutputFileName_TextBox;
        private System.Windows.Forms.Label OutputFileExtension_Label;
        private System.Windows.Forms.Button split_Button;
        private System.Windows.Forms.TextBox browseFile_Textbox;
        private System.Windows.Forms.Label FromPage_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileToPage_TextBox;
        private System.Windows.Forms.TextBox fileFromPage_TextBox;
    }
}
