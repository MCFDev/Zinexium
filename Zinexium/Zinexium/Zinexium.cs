using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Media;
using System.Windows.Forms;

namespace Zinexium
{
    public partial class Zinexium : Form
    {

        Point lastPoint;
        public Zinexium()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created & developed by: morgan#1092 \nCo-Developed by: ThonkPT#3766 \nIcons from: https://icons8.com \nInspiration for the Script Hub from: https://github.com/PareX2019/JSON-Scripthub", "Credits <3", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            scintilla1.ClearAll();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

            WebClient wc = new WebClient();
            var link = wc.DownloadString("https://pastebin.com/raw/j91p7SQE");
            Process.Start(link);

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            ScriptHubs Sc = new ScriptHubs();
            Sc.Show();
        }
    }
}
