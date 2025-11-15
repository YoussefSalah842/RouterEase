using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace RouterSettingsApp
{
    public partial class RouterInfoReaderForm : Form
    {
        public RouterInfoReaderForm()
        {
            InitializeComponent();
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            try
            {
                var gateways = NetworkInterface.GetAllNetworkInterfaces()
                    .SelectMany(i => i.GetIPProperties()?.GatewayAddresses)
                    .Where(g => g?.Address != null && !g.Address.Equals(IPAddress.None))
                    .ToList();

                if (gateways.Count == 0)
                {
                    MessageBox.Show("No active router found.");
                    return;
                }

                string routerIP = gateways.First().Address.ToString();
                txtRouterIP.Text = routerIP;

                var network = NetworkInterface.GetAllNetworkInterfaces()
                    .FirstOrDefault(i => i.OperationalStatus == OperationalStatus.Up);

                if (network != null)
                {
                    txtMacAddress.Text = BitConverter.ToString(network.GetPhysicalAddress().GetAddressBytes());
                    string name = network.Name;
                    txtRouterName.Text = name;
                    string manufacturer = DetectManufacturerFromMac(txtMacAddress.Text);
                    txtManufacturer.Text = manufacturer;
                    SetRouterLogo(manufacturer);
                }
                else
                {
                    MessageBox.Show("No active network interface found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while detecting router info:\n" + ex.Message);
            }
        }

        private string DetectManufacturerFromMac(string mac)
        {
            mac = mac.Replace(":", "").Replace("-", "").ToUpper();
            if (mac.StartsWith("F8B4")) return "TP-Link";
            if (mac.StartsWith("00E0FC") || mac.StartsWith("A0C5")) return "ZTE";
            if (mac.StartsWith("C83A35") || mac.StartsWith("70F9")) return "Huawei";
            if (mac.StartsWith("0024D2") || mac.StartsWith("E0CB4E")) return "D-Link";
            return "Unknown";
        }

        private void SetRouterLogo(string manufacturer)
        {
            switch (manufacturer)
            {
                case "ZTE":
                    pictureLogo.Image = Properties.Resources.zte;
                    break;
                case "TP-Link":
                    pictureLogo.Image = Properties.Resources.tplink;
                    break;
                case "Huawei":
                    pictureLogo.Image = Properties.Resources.huawei;
                    break;
                case "D-Link":
                    pictureLogo.Image = Properties.Resources.dlink;
                    break;
                default:
                    pictureLogo.Image = Properties.Resources.default_router;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}