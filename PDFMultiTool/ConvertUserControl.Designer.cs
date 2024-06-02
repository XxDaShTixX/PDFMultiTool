namespace PDFMultiTool
{
    partial class ConvertUserControl
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
            this.convert_Button = new System.Windows.Forms.Button();
            this.BrowseFile_Button = new System.Windows.Forms.Button();
            this.browseOutput_Button = new System.Windows.Forms.Button();
            this.browseOutput_Textbox = new System.Windows.Forms.TextBox();
            this.SelectFiles_Label = new System.Windows.Forms.Label();
            this.browseOutput_Label = new System.Windows.Forms.Label();
            this.convertExtension_Label = new System.Windows.Forms.Label();
            this.fromExtension_ComboBox = new System.Windows.Forms.ComboBox();
            this.fromExtension_Label = new System.Windows.Forms.Label();
            this.toExtension_Label = new System.Windows.Forms.Label();
            this.toExtension_ComboBox = new System.Windows.Forms.ComboBox();
            this.browseFiles_ConvertUserControl_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectFiles_ListBox = new System.Windows.Forms.ListBox();
            this.browseFolder_ConvertUserControl_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Resolution_Label = new System.Windows.Forms.Label();
            this.Resolution_TextBox = new System.Windows.Forms.TextBox();
            this.SeparateOutputFiles_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // convert_Button
            // 
            this.convert_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.convert_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert_Button.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.convert_Button.Location = new System.Drawing.Point(579, 349);
            this.convert_Button.Name = "convert_Button";
            this.convert_Button.Size = new System.Drawing.Size(100, 50);
            this.convert_Button.TabIndex = 4;
            this.convert_Button.Text = "Convert";
            this.convert_Button.UseVisualStyleBackColor = true;
            this.convert_Button.Click += new System.EventHandler(this.convert_Button_Click);
            // 
            // BrowseFile_Button
            // 
            this.BrowseFile_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.BrowseFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseFile_Button.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFile_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.BrowseFile_Button.Location = new System.Drawing.Point(207, 128);
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
            this.browseOutput_Button.Location = new System.Drawing.Point(207, 300);
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
            this.browseOutput_Textbox.Location = new System.Drawing.Point(7, 336);
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
            this.SelectFiles_Label.Location = new System.Drawing.Point(3, 134);
            this.SelectFiles_Label.Name = "SelectFiles_Label";
            this.SelectFiles_Label.Size = new System.Drawing.Size(111, 19);
            this.SelectFiles_Label.TabIndex = 10;
            this.SelectFiles_Label.Text = "2. Select File(s)";
            // 
            // browseOutput_Label
            // 
            this.browseOutput_Label.AutoSize = true;
            this.browseOutput_Label.BackColor = System.Drawing.Color.Transparent;
            this.browseOutput_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseOutput_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.browseOutput_Label.Location = new System.Drawing.Point(3, 306);
            this.browseOutput_Label.Name = "browseOutput_Label";
            this.browseOutput_Label.Size = new System.Drawing.Size(181, 19);
            this.browseOutput_Label.TabIndex = 11;
            this.browseOutput_Label.Text = "3. Select Output Location";
            // 
            // convertExtension_Label
            // 
            this.convertExtension_Label.AutoSize = true;
            this.convertExtension_Label.BackColor = System.Drawing.Color.Transparent;
            this.convertExtension_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertExtension_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.convertExtension_Label.Location = new System.Drawing.Point(3, 0);
            this.convertExtension_Label.Name = "convertExtension_Label";
            this.convertExtension_Label.Size = new System.Drawing.Size(147, 19);
            this.convertExtension_Label.TabIndex = 13;
            this.convertExtension_Label.Text = "1. Convert Extension";
            // 
            // fromExtension_ComboBox
            // 
            this.fromExtension_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fromExtension_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromExtension_ComboBox.FormattingEnabled = true;
            this.fromExtension_ComboBox.Location = new System.Drawing.Point(57, 30);
            this.fromExtension_ComboBox.Name = "fromExtension_ComboBox";
            this.fromExtension_ComboBox.Size = new System.Drawing.Size(250, 27);
            this.fromExtension_ComboBox.Sorted = true;
            this.fromExtension_ComboBox.TabIndex = 14;
            this.fromExtension_ComboBox.SelectedIndexChanged += new System.EventHandler(this.fromExtension_ComboBox_SelectedIndexChanged);
            // 
            // fromExtension_Label
            // 
            this.fromExtension_Label.AutoSize = true;
            this.fromExtension_Label.BackColor = System.Drawing.Color.Transparent;
            this.fromExtension_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fromExtension_Label.Location = new System.Drawing.Point(3, 33);
            this.fromExtension_Label.Name = "fromExtension_Label";
            this.fromExtension_Label.Size = new System.Drawing.Size(45, 19);
            this.fromExtension_Label.TabIndex = 15;
            this.fromExtension_Label.Text = "From";
            // 
            // toExtension_Label
            // 
            this.toExtension_Label.AutoSize = true;
            this.toExtension_Label.BackColor = System.Drawing.Color.Transparent;
            this.toExtension_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.toExtension_Label.Location = new System.Drawing.Point(3, 66);
            this.toExtension_Label.Name = "toExtension_Label";
            this.toExtension_Label.Size = new System.Drawing.Size(25, 19);
            this.toExtension_Label.TabIndex = 17;
            this.toExtension_Label.Text = "To";
            // 
            // toExtension_ComboBox
            // 
            this.toExtension_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.toExtension_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toExtension_ComboBox.FormattingEnabled = true;
            this.toExtension_ComboBox.Location = new System.Drawing.Point(57, 63);
            this.toExtension_ComboBox.Name = "toExtension_ComboBox";
            this.toExtension_ComboBox.Size = new System.Drawing.Size(250, 27);
            this.toExtension_ComboBox.Sorted = true;
            this.toExtension_ComboBox.TabIndex = 16;
            this.toExtension_ComboBox.SelectedIndexChanged += new System.EventHandler(this.toExtension_ComboBox_SelectedIndexChanged);
            // 
            // SelectFiles_ListBox
            // 
            this.SelectFiles_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SelectFiles_ListBox.FormattingEnabled = true;
            this.SelectFiles_ListBox.HorizontalScrollbar = true;
            this.SelectFiles_ListBox.ItemHeight = 19;
            this.SelectFiles_ListBox.Location = new System.Drawing.Point(7, 164);
            this.SelectFiles_ListBox.Name = "SelectFiles_ListBox";
            this.SelectFiles_ListBox.Size = new System.Drawing.Size(300, 99);
            this.SelectFiles_ListBox.TabIndex = 18;
            // 
            // browseFolder_ConvertUserControl_FolderBrowserDialog
            // 
            this.browseFolder_ConvertUserControl_FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // Resolution_Label
            // 
            this.Resolution_Label.AutoSize = true;
            this.Resolution_Label.BackColor = System.Drawing.Color.Transparent;
            this.Resolution_Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolution_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Resolution_Label.Location = new System.Drawing.Point(375, 6);
            this.Resolution_Label.Name = "Resolution_Label";
            this.Resolution_Label.Size = new System.Drawing.Size(100, 19);
            this.Resolution_Label.TabIndex = 21;
            this.Resolution_Label.Text = "4. Resolution";
            // 
            // Resolution_TextBox
            // 
            this.Resolution_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Resolution_TextBox.Location = new System.Drawing.Point(579, 3);
            this.Resolution_TextBox.Name = "Resolution_TextBox";
            this.Resolution_TextBox.Size = new System.Drawing.Size(100, 27);
            this.Resolution_TextBox.TabIndex = 20;
            this.Resolution_TextBox.Text = "300";
            this.Resolution_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Resolution_TextBox_KeyPress);
            // 
            // SeparateOutputFiles_CheckBox
            // 
            this.SeparateOutputFiles_CheckBox.AutoSize = true;
            this.SeparateOutputFiles_CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SeparateOutputFiles_CheckBox.Location = new System.Drawing.Point(379, 133);
            this.SeparateOutputFiles_CheckBox.Name = "SeparateOutputFiles_CheckBox";
            this.SeparateOutputFiles_CheckBox.Size = new System.Drawing.Size(285, 23);
            this.SeparateOutputFiles_CheckBox.TabIndex = 24;
            this.SeparateOutputFiles_CheckBox.Text = "5. Separate Output Files for Each Page";
            this.SeparateOutputFiles_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ConvertUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.SeparateOutputFiles_CheckBox);
            this.Controls.Add(this.Resolution_Label);
            this.Controls.Add(this.Resolution_TextBox);
            this.Controls.Add(this.SelectFiles_ListBox);
            this.Controls.Add(this.toExtension_Label);
            this.Controls.Add(this.toExtension_ComboBox);
            this.Controls.Add(this.fromExtension_Label);
            this.Controls.Add(this.fromExtension_ComboBox);
            this.Controls.Add(this.convertExtension_Label);
            this.Controls.Add(this.browseOutput_Label);
            this.Controls.Add(this.SelectFiles_Label);
            this.Controls.Add(this.browseOutput_Textbox);
            this.Controls.Add(this.browseOutput_Button);
            this.Controls.Add(this.BrowseFile_Button);
            this.Controls.Add(this.convert_Button);
            this.Font = new System.Drawing.Font("Candara", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConvertUserControl";
            this.Size = new System.Drawing.Size(682, 402);
            this.Load += new System.EventHandler(this.ConvertUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button convert_Button;
        private System.Windows.Forms.Button BrowseFile_Button;
        private System.Windows.Forms.Button browseOutput_Button;
        private System.Windows.Forms.TextBox browseOutput_Textbox;
        private System.Windows.Forms.Label SelectFiles_Label;
        private System.Windows.Forms.Label browseOutput_Label;
        private System.Windows.Forms.Label convertExtension_Label;
        private System.Windows.Forms.ComboBox fromExtension_ComboBox;
        private System.Windows.Forms.Label fromExtension_Label;
        private System.Windows.Forms.Label toExtension_Label;
        private System.Windows.Forms.ComboBox toExtension_ComboBox;
        private System.Windows.Forms.OpenFileDialog browseFiles_ConvertUserControl_OpenFileDialog;
        private System.Windows.Forms.ListBox SelectFiles_ListBox;
        private System.Windows.Forms.FolderBrowserDialog browseFolder_ConvertUserControl_FolderBrowserDialog;
        private System.Windows.Forms.Label Resolution_Label;
        private System.Windows.Forms.TextBox Resolution_TextBox;
        private System.Windows.Forms.CheckBox SeparateOutputFiles_CheckBox;
    }
}
