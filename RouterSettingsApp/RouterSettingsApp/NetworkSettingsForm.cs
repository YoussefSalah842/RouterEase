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
    public partial class NetworkSettingsForm : Form
    {
        public NetworkSettingsForm()
        {
            InitializeComponent();
            btnApply.Click += btnApply_Click;
        }

        private void NetworkSettingsForm_Load(object sender, EventArgs e)
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .ToList();
            foreach (var nic in nics)
                interfacesComboBox.Items.Add(nic.Name);

            if (interfacesComboBox.Items.Count > 0)
            {
                interfacesComboBox.SelectedIndex = 0;
                LoadInterfaceData();
            }
        }

        private void interfacesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInterfaceData();
        }

        private void LoadInterfaceData()
        {
            string ifaceName = interfacesComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(ifaceName)) return;

            var nic = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(n => n.Name == ifaceName);

            if (nic == null) return;

            var props = nic.GetIPProperties();

            // IPv4
            var ipv4Addr = props.UnicastAddresses
                .FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            if (ipv4Addr != null)
            {
                textIPv4.Text = ipv4Addr.Address.ToString();
                textSubnet.Text = ipv4Addr.IPv4Mask.ToString();
            }
            else
            {
                textIPv4.Text = "";
                textSubnet.Text = "";
            }

            // Gateway
            var gw = props.GatewayAddresses.FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            textGateway.Text = gw != null ? gw.Address.ToString() : "";

            // IPv6
            var ipv6Addr = props.UnicastAddresses
                .FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6);
            textIPv6.Text = ipv6Addr != null ? ipv6Addr.Address.ToString() : "";

            // DNS
            var dns = props.DnsAddresses;
            if (dns.Count > 0)
                textDNS.Text = string.Join(",", dns.Select(d => d.ToString()));
            else
                textDNS.Text = "";

            // DHCP
            checkDHCP.Checked = nic.GetIPProperties().GetIPv4Properties().IsDhcpEnabled;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string iface = interfacesComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(iface))
            {
                MessageBox.Show("Please select a network interface.");
                return;
            }

            try
            {
                if (checkDHCP.Checked)
                {
                    ExecuteNetsh($"interface ip set address name=\"{iface}\" dhcp");
                    ExecuteNetsh($"interface ip set dns name=\"{iface}\" dhcp");
                }
                else
                {
                    string ipv4 = textIPv4.Text.Trim();
                    string subnet = textSubnet.Text.Trim();
                    string gateway = textGateway.Text.Trim();
                    if (!string.IsNullOrEmpty(ipv4) && !string.IsNullOrEmpty(subnet))
                        ExecuteNetsh($"interface ip set address name=\"{iface}\" static {ipv4} {subnet} {gateway}");

                    string ipv6 = textIPv6.Text.Trim();
                    if (!string.IsNullOrEmpty(ipv6))
                        ExecuteNetsh($"interface ipv6 set address name=\"{iface}\" {ipv6}");

                    string dns = textDNS.Text.Trim();
                    if (!string.IsNullOrEmpty(dns))
                    {
                        var dnsServers = dns.Split(',').Select(d => d.Trim()).ToArray();
                        ExecuteNetsh($"interface ip set dns name=\"{iface}\" static {dnsServers[0]} primary");
                        for (int i = 1; i < dnsServers.Length; i++)
                            ExecuteNetsh($"interface ip add dns name=\"{iface}\" addr={dnsServers[i]} index={i + 1}");
                    }
                }

                MessageBox.Show("Settings applied successfully!");
                LoadInterfaceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying settings: " + ex.Message);
            }
        }

        private void ExecuteNetsh(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", command)
            {
                Verb = "runas",
                CreateNoWindow = true,
                UseShellExecute = true
            };
            Process.Start(psi).WaitForExit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}