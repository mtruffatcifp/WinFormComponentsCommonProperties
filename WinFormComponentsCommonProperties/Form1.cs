using System;
using System.Windows.Forms;

namespace WinFormComponentsCommonProperties
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            formSizeLabel.Text = $"Form Size: {this.Width}, {this.Height}";
            this.Text = $"({this.DesktopLocation.X.ToString()}, {this.DesktopLocation.Y.ToString()}) Winforms Components - Common Controls";
        }
        private void mainForm_Move(object sender, EventArgs e)
        {
            this.Text = $"({this.DesktopLocation.X.ToString()}, {this.DesktopLocation.Y.ToString()}) Winforms Components - Common Controls";
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            formSizeLabel.Text = $"Form Size: {this.Width}, {this.Height}";
        }
    }
}
