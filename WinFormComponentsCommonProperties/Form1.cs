using System;
using System.Drawing;
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

        private void visibleButton_Click(object sender, EventArgs e)
        {
            if (targetButton.Visible)
            {
                targetButton.Visible = false;
                visibleButton.Text = "Visible = False";
            } else
            {
                targetButton.Visible = true;
                visibleButton.Text = "Visible = True";
            }
        }

        private void enabledButton_Click(object sender, EventArgs e)
        {
            if (targetButton.Enabled)
            {
                targetButton.Enabled = false;
                enabledButton.Text = "Enabled = False";
            } else
            {
                targetButton.Enabled = true;
                enabledButton.Text = "Enabled = True";
            }
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            int x = (this.Width / 2) - 50;
            int y = (this.Height / 2) - 50;
            targetButton.Location = new Point(x, y);
            targetButton.Text = "Target\nX = " + x + "\nY = " + y;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            targetButton.Top -= 5;
            targetButton.Text = "Target\nX = " + targetButton.Location.X + "\nY = " + targetButton.Location.Y;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            targetButton.Top += 5;
            targetButton.Text = "Target\nX = " + targetButton.Location.X + "\nY = " + targetButton.Location.Y;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            targetButton.Left -= 5;
            targetButton.Text = "Target\nX = " + targetButton.Location.X + "\nY = " + targetButton.Location.Y;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            targetButton.Left += 5;
            targetButton.Text = "Target\nX = " + targetButton.Location.X + "\nY = " + targetButton.Location.Y;
        }
    }
}
