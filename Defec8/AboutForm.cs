using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Defec8
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"https:\\vk.com\id222419967");
        }
    }
}
