using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouterSettingsApp
{
    public partial class IPconfig_settings : Form
    {
        public IPconfig_settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string command = "ipconfig";


            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string command = "ipconfig /all";


            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string command = "ipconfig /release";


            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string command = "ipconfig /renew";


            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}