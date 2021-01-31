using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zinexium
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            MessageBox.Show("Created & developed by: morganinnit#5555 \nCo-Developed by: ThonkPT#3766 \nIcons from: https://icons8.com", "Credits <3", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            scintilla1.ClearAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream

        private void scintilla1_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> Stashed changes
    }
}
