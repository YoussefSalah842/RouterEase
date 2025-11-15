using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouterSettingsApp
{
    public partial class NetworkInfoForm : Form
    {
        public NetworkInfoForm()
        {
            InitializeComponent();
        }

        private void NetworkInfoForm_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Name", "Interface Name");
                dataGridView1.Columns.Add("Description", "Description");
                dataGridView1.Columns.Add("IPv4", "IPv4 Address");
                dataGridView1.Columns.Add("IPv6", "IPv6 Address");
                dataGridView1.Columns.Add("Gateway", "Gateway");
                dataGridView1.Columns.Add("DNS", "DNS Servers");
            }

            LoadNetworkInfo();
            refreshTimer.Start();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            LoadNetworkInfo();
        }

        private void LoadNetworkInfo()
        {
            dataGridView1.Rows.Clear();
            var nics = NetworkInterface.GetAllNetworkInterfaces()
                        .Where(n => n.OperationalStatus == OperationalStatus.Up)
                        .ToList();

            foreach (var nic in nics)
            {
                var props = nic.GetIPProperties();
                string ipv4 = props.UnicastAddresses
                            .Where(u => u.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            .Select(u => u.Address.ToString())
                            .FirstOrDefault() ?? "-";
                string ipv6 = props.UnicastAddresses
                            .Where(u => u.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                            .Select(u => u.Address.ToString())
                            .FirstOrDefault() ?? "-";
                string gateway = props.GatewayAddresses.FirstOrDefault()?.Address.ToString() ?? "-";
                string dns = string.Join(", ", props.DnsAddresses.Select(d => d.ToString()));
                dataGridView1.Rows.Add(nic.Name, nic.Description, ipv4, ipv6, gateway, dns);
            }
        }
    }
}