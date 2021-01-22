using System;
using System.Windows.Forms;

namespace Zinexium
{
    public partial class ScriptHubs : Form
    {
        public ScriptHubs()
        {
            var domain = AppDomain.CurrentDomain;

            InitializeComponent();

        }

        private void ScriptHubs_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
