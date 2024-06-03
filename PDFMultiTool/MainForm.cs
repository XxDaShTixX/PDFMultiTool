using PDFMultiTool.Utility;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PDFMultiTool
{
    public partial class MainForm : Form
    {
        // Color Palette: https://colorhunt.co/palette/22283131363f76abaeeeeeee

        // Current user control
        private UserControl _currentControl;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Standard UserControl location and size
        private Size userControlSize = new Size(682, 402);
        private Point userControlLocation = new Point(106, 36);

        // Standard font
        private Font standardFont = new Font("Candara", 12);

        public MainForm()
        {
            InitializeComponent();

            // Disable the maximize box
            this.MaximizeBox = false;

            // Set event handler for when window is being resized
            this.Resize += new EventHandler(FormResizingEventHandler);

            // Initialize everything that needs to be initialized
            Initialize();
        }

        private void Initialize()
        {
            // MUST INITIALIZE FIRST
            // Reference logger output window in Logger singleton class
            Logger.Instance.SetLogRichTextBox(output_MainForm_RichTextbox);

            // Initialize configuration file
            Configuration.Instance.InitializeConfig(
                output_MainForm_RichTextbox,
                ghostScriptFile_MainForm_OpenFileDialog
            );
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormResizingEventHandler(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Convert_MainForm_Button_Click(object sender, EventArgs e)
        {
            // Create a new instance of your UserControl
            var myUserControl = new ConvertUserControl();

            // Remove the old user control
            if (_currentControl != null)
            {
                this.Controls.Remove(_currentControl);
            }


            // Add it to the form (or another control)
            this.Controls.Add(myUserControl);

            // Set the location and size as needed
            myUserControl.Location = userControlLocation;
            myUserControl.Size = userControlSize;

            // Update the current control
            _currentControl = myUserControl;
        }

        private void combine_MainForm_Button_Click(object sender, EventArgs e)
        {
            // Create a new instance of your new control
            var myUserControl = new CombineUserControl();

            // Remove the old user control
            if (_currentControl != null)
            {
                this.Controls.Remove(_currentControl);
            }

            // Add it to the form (or another control)
            this.Controls.Add(myUserControl);

            // Set the location and size as needed
            myUserControl.Location = userControlLocation;
            myUserControl.Size = userControlSize;

            // Update the current control
            _currentControl = myUserControl;
        }

        private void split_MainForm_Button_Click(object sender, EventArgs e)
        {
            // Create a new instance of your new control
            var myUserControl = new SplitUserControl();

            // Remove the old user control
            if (_currentControl != null)
            {
                this.Controls.Remove(_currentControl);
            }

            // Add it to the form (or another control)
            this.Controls.Add(myUserControl);

            // Set the location and size as needed
            myUserControl.Location = userControlLocation;
            myUserControl.Size = userControlSize;

            // Update the current control
            _currentControl = myUserControl;
        }

        private void GitHub_MainForm_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            GitHub_MainForm_LinkLabel.LinkVisited = false;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://github.com/XxDaShTixX/PDFMultiTool/");
        }
    }
}
