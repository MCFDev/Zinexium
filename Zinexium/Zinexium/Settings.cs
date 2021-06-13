using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zinexium
{
    public partial class Settings : Form
    {
        Point lastPoint;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {   //Setting the colors and settings from settings
            this.BackColor = Properties.Settings.Default.ui_color;
            this.checkBox2.Checked = Properties.Settings.Default.AutoAttach;
            this.TextColorIndicator.BackColor = Properties.Settings.Default.TextBoxColor;
            this.UIcolorIndicator.BackColor = Properties.Settings.Default.ui_color;
        }

        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            
            if (Program.ColorsChanged == true)
            {
                MessageBox.Show("It Seems you changed the colors so for them to take effect you have to restart Zinexium", "Settings changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoAttach = checkBox2.Checked;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();

            Properties.Settings.Default.ui_color = colorDialog1.Color;

            this.UIcolorIndicator.BackColor = colorDialog1.Color;
            Program.ColorsChanged = true;
            Properties.Settings.Default.Save();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            Properties.Settings.Default.TextBoxColor = colorDialog1.Color;

            this.TextColorIndicator.BackColor = colorDialog1.Color;
            Program.ColorsChanged = true;

            Properties.Settings.Default.Save();
        }

        private void TextColorIndicator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
