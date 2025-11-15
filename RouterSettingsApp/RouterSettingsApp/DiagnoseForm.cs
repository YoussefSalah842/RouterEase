using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouterSettingsApp
{
    public partial class DiagnoseForm : Form
    {
        public DiagnoseForm()
        {
            InitializeComponent();
            btnRun.Click += BtnRun_Click;
        }

        private void DiagnoseForm_Load(object sender, EventArgs e)
        {
            lstResults.Items.Add("Ready to diagnose network...");
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            lstResults.Items.Add("Checking Gateway...");
            var gw = GetDefaultGateway();
            lstResults.Items.Add("Gateway: " + (gw ?? "Not found"));

            lstResults.Items.Add("Pinging Google...");
            bool pingGoogle = PingHost("8.8.8.8");
            lstResults.Items.Add("Ping 8.8.8.8: " + (pingGoogle ? "Success" : "Failed"));

            lstResults.Items.Add("Checking DNS...");
            bool dnsPing = PingHost("1.1.1.1");
            lstResults.Items.Add("Ping DNS 1.1.1.1: " + (dnsPing ? "Success" : "Failed"));

            lstResults.Items.Add("Checking Internet...");
            bool netPing = PingHost("google.com");
            lstResults.Items.Add("Internet: " + (netPing ? "Available" : "Not reachable"));
        }

        private string GetDefaultGateway()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (var gw in ni.GetIPProperties().GatewayAddresses)
                    {
                        if (gw.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            return gw.Address.ToString();
                    }
                }
            }
            return null;
        }

        private bool PingHost(string host)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(host, 2000);
                return reply.Status == IPStatus.Success;
            }
            catch { return false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPconfig_settings IPconfig = new IPconfig_settings();
            IPconfig.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}