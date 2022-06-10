using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C shutdown -s -f -t 1";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C shutdown -l";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C shutdown -r -f -t 1";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
