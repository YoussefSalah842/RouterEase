using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouterSettingsApp
{
    public partial class MainForm : Form
    {
        private string currentRouterIp = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DetectAndLoadRouter();
        }

        private void DetectAndLoadRouter()
        {
            string ip = GetDefaultGateway();
            if (string.IsNullOrEmpty(ip))
            {
                string[] common = { "192.168.1.1", "192.168.0.1", "192.168.1.254" };
                foreach (var c in common)
                {
                    if (PingHost(c)) { ip = c; break; }
                }
            }

            if (!string.IsNullOrEmpty(ip))
            {
                currentRouterIp = ip;
                try { webBrowser1.Url = new Uri("http://" + ip); }
                catch { }
                toolStripStatusLabel1.Text = "Router IP: " + ip;
                manualIpTextBox.Text = ip;
            }
            else
            {
                toolStripStatusLabel1.Text = "Router IP: Not found";
            }
        }

        private string GetDefaultGateway()
        {
            var gateways = NetworkInterface.GetAllNetworkInterfaces()
                .SelectMany(nic => nic.GetIPProperties().GatewayAddresses)
                .Select(g => g.Address.ToString())
                .Where(s => !string.IsNullOrEmpty(s) && s != "0.0.0.0")
                .ToList();
            return gateways.FirstOrDefault();
        }

        private bool PingHost(string ip)
        {
            try
            {
                using (var p = new Ping())
                {
                    var reply = p.Send(ip, 1000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch { return false; }
        }

        private void openExternalButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentRouterIp))
                Process.Start("http://" + currentRouterIp);
        }

        private void copyIpButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentRouterIp))
                Clipboard.SetText(currentRouterIp);
        }

        private void setIpButton_Click(object sender, EventArgs e)
        {
            var ip = manualIpTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(ip))
            {
                currentRouterIp = ip;
                try
                {
                    webBrowser1.Url = new Uri("http://" + ip);
                    toolStripStatusLabel1.Text = "Router IP: " + ip;
                }
                catch
                {
                    MessageBox.Show("Invalid IP or cannot load page.");
                }
            }
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            string ip = string.IsNullOrEmpty(currentRouterIp) ? manualIpTextBox.Text.Trim() : currentRouterIp;
            if (string.IsNullOrEmpty(ip))
            {
                MessageBox.Show("No IP to ping");
                return;
            }

            bool ok = PingHost(ip);
            MessageBox.Show(ok ? "Ping successful" : "Ping failed");
        }

        private void autoRefreshCheckbox_Click(object sender, EventArgs e)
        {
            if (refreshTimer.Enabled)
            {
                refreshTimer.Stop();
                autoRefreshCheckbox.Text = "AutoRefresh Off";
            }
            else
            {
                refreshTimer.Start();
                autoRefreshCheckbox.Text = "AutoRefresh On";
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentRouterIp))
                webBrowser1.Refresh();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            NetworkSettingsForm NetworkSettings = new NetworkSettingsForm();
            NetworkSettings.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            NetworkInfoForm NetworkInfo = new NetworkInfoForm();
            NetworkInfo.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            IPconfig_settings IPconfig = new IPconfig_settings();
            IPconfig.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            RouterInfoReaderForm RouterInfo = new RouterInfoReaderForm();
            RouterInfo.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Help HelpDialog = new Help();
            HelpDialog.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            About AboutDialog = new About();
            AboutDialog.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            DiagnoseForm DiagnoseDialog = new DiagnoseForm();
            DiagnoseDialog.Show();
        }
    }
}