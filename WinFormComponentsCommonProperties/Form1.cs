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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case 1:
                    FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case 2:
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case 3:
                    FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case 4:
                    FormBorderStyle = FormBorderStyle.None;
                    break;
                case 5:
                    FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case 6:
                    FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
                default:
                    break;
            }
        }
    }
}
