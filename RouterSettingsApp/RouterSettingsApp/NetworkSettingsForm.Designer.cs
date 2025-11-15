namespace RouterSettingsApp
{
    partial class NetworkSettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkSettingsForm));
            this.interfacesComboBox = new System.Windows.Forms.ComboBox();
            this.labelInterface = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabIPv4 = new System.Windows.Forms.TabPage();
            this.labelIPv4 = new System.Windows.Forms.Label();
            this.textIPv4 = new System.Windows.Forms.TextBox();
            this.labelSubnet = new System.Windows.Forms.Label();
            this.textSubnet = new System.Windows.Forms.TextBox();
            this.labelGateway = new System.Windows.Forms.Label();
            this.textGateway = new System.Windows.Forms.TextBox();
            this.checkDHCP = new System.Windows.Forms.CheckBox();
            this.tabIPv6 = new System.Windows.Forms.TabPage();
            this.labelIPv6 = new System.Windows.Forms.Label();
            this.textIPv6 = new System.Windows.Forms.TextBox();
            this.tabDNS = new System.Windows.Forms.TabPage();
            this.labelDNS = new System.Windows.Forms.Label();
            this.textDNS = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabIPv4.SuspendLayout();
            this.tabIPv6.SuspendLayout();
            this.tabDNS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // interfacesComboBox
            // 
            this.interfacesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interfacesComboBox.Location = new System.Drawing.Point(122, 104);
            this.interfacesComboBox.Name = "interfacesComboBox";
            this.interfacesComboBox.Size = new System.Drawing.Size(250, 21);
            this.interfacesComboBox.TabIndex = 1;
            this.interfacesComboBox.SelectedIndexChanged += new System.EventHandler(this.interfacesComboBox_SelectedIndexChanged);
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Location = new System.Drawing.Point(12, 107);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(85, 13);
            this.labelInterface.TabIndex = 0;
            this.labelInterface.Text = "Select Interface:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabIPv4);
            this.tabControl.Controls.Add(this.tabIPv6);
            this.tabControl.Controls.Add(this.tabDNS);
            this.tabControl.Location = new System.Drawing.Point(15, 131);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(464, 231);
            this.tabControl.TabIndex = 2;
            // 
            // tabIPv4
            // 
            this.tabIPv4.Controls.Add(this.labelIPv4);
            this.tabIPv4.Controls.Add(this.textIPv4);
            this.tabIPv4.Controls.Add(this.labelSubnet);
            this.tabIPv4.Controls.Add(this.textSubnet);
            this.tabIPv4.Controls.Add(this.labelGateway);
            this.tabIPv4.Controls.Add(this.textGateway);
            this.tabIPv4.Controls.Add(this.checkDHCP);
            this.tabIPv4.Location = new System.Drawing.Point(4, 22);
            this.tabIPv4.Name = "tabIPv4";
            this.tabIPv4.Size = new System.Drawing.Size(456, 205);
            this.tabIPv4.TabIndex = 0;
            this.tabIPv4.Text = "IPv4 Settings";
            // 
            // labelIPv4
            // 
            this.labelIPv4.Location = new System.Drawing.Point(10, 20);
            this.labelIPv4.Name = "labelIPv4";
            this.labelIPv4.Size = new System.Drawing.Size(100, 23);
            this.labelIPv4.TabIndex = 0;
            this.labelIPv4.Text = "IPv4 Address:";
            // 
            // textIPv4
            // 
            this.textIPv4.Location = new System.Drawing.Point(120, 17);
            this.textIPv4.Name = "textIPv4";
            this.textIPv4.Size = new System.Drawing.Size(200, 20);
            this.textIPv4.TabIndex = 1;
            // 
            // labelSubnet
            // 
            this.labelSubnet.Location = new System.Drawing.Point(10, 50);
            this.labelSubnet.Name = "labelSubnet";
            this.labelSubnet.Size = new System.Drawing.Size(100, 23);
            this.labelSubnet.TabIndex = 2;
            this.labelSubnet.Text = "Subnet Mask:";
            // 
            // textSubnet
            // 
            this.textSubnet.Location = new System.Drawing.Point(120, 47);
            this.textSubnet.Name = "textSubnet";
            this.textSubnet.Size = new System.Drawing.Size(200, 20);
            this.textSubnet.TabIndex = 3;
            // 
            // labelGateway
            // 
            this.labelGateway.Location = new System.Drawing.Point(10, 80);
            this.labelGateway.Name = "labelGateway";
            this.labelGateway.Size = new System.Drawing.Size(100, 23);
            this.labelGateway.TabIndex = 4;
            this.labelGateway.Text = "Default Gateway:";
            // 
            // textGateway
            // 
            this.textGateway.Location = new System.Drawing.Point(120, 77);
            this.textGateway.Name = "textGateway";
            this.textGateway.Size = new System.Drawing.Size(200, 20);
            this.textGateway.TabIndex = 5;
            // 
            // checkDHCP
            // 
            this.checkDHCP.AutoSize = true;
            this.checkDHCP.Location = new System.Drawing.Point(10, 110);
            this.checkDHCP.Name = "checkDHCP";
            this.checkDHCP.Size = new System.Drawing.Size(92, 17);
            this.checkDHCP.TabIndex = 6;
            this.checkDHCP.Text = "Enable DHCP";
            // 
            // tabIPv6
            // 
            this.tabIPv6.Controls.Add(this.labelIPv6);
            this.tabIPv6.Controls.Add(this.textIPv6);
            this.tabIPv6.Location = new System.Drawing.Point(4, 22);
            this.tabIPv6.Name = "tabIPv6";
            this.tabIPv6.Size = new System.Drawing.Size(456, 205);
            this.tabIPv6.TabIndex = 1;
            this.tabIPv6.Text = "IPv6 Settings";
            // 
            // labelIPv6
            // 
            this.labelIPv6.Location = new System.Drawing.Point(10, 20);
            this.labelIPv6.Name = "labelIPv6";
            this.labelIPv6.Size = new System.Drawing.Size(100, 23);
            this.labelIPv6.TabIndex = 0;
            this.labelIPv6.Text = "IPv6 Address:";
            // 
            // textIPv6
            // 
            this.textIPv6.Location = new System.Drawing.Point(120, 17);
            this.textIPv6.Name = "textIPv6";
            this.textIPv6.Size = new System.Drawing.Size(200, 20);
            this.textIPv6.TabIndex = 1;
            // 
            // tabDNS
            // 
            this.tabDNS.Controls.Add(this.labelDNS);
            this.tabDNS.Controls.Add(this.textDNS);
            this.tabDNS.Location = new System.Drawing.Point(4, 22);
            this.tabDNS.Name = "tabDNS";
            this.tabDNS.Size = new System.Drawing.Size(456, 205);
            this.tabDNS.TabIndex = 2;
            this.tabDNS.Text = "DNS Settings";
            // 
            // labelDNS
            // 
            this.labelDNS.Location = new System.Drawing.Point(10, 20);
            this.labelDNS.Name = "labelDNS";
            this.labelDNS.Size = new System.Drawing.Size(100, 23);
            this.labelDNS.TabIndex = 0;
            this.labelDNS.Text = "DNS Servers (comma-separated):";
            // 
            // textDNS
            // 
            this.textDNS.Location = new System.Drawing.Point(10, 45);
            this.textDNS.Name = "textDNS";
            this.textDNS.Size = new System.Drawing.Size(200, 20);
            this.textDNS.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(375, 367);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 33);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply Settings";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 88);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Network Settings ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modifying or updating network data and IP addresses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NetworkSettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(491, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelInterface);
            this.Controls.Add(this.interfacesComboBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NetworkSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Settings - Advanced";
            this.Load += new System.EventHandler(this.NetworkSettingsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabIPv4.ResumeLayout(false);
            this.tabIPv4.PerformLayout();
            this.tabIPv6.ResumeLayout(false);
            this.tabIPv6.PerformLayout();
            this.tabDNS.ResumeLayout(false);
            this.tabDNS.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox interfacesComboBox;
        private System.Windows.Forms.Label labelInterface;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabIPv4;
        private System.Windows.Forms.TabPage tabIPv6;
        private System.Windows.Forms.TabPage tabDNS;
        private System.Windows.Forms.TextBox textIPv4;
        private System.Windows.Forms.TextBox textSubnet;
        private System.Windows.Forms.TextBox textGateway;
        private System.Windows.Forms.CheckBox checkDHCP;
        private System.Windows.Forms.Label labelIPv4;
        private System.Windows.Forms.Label labelSubnet;
        private System.Windows.Forms.Label labelGateway;
        private System.Windows.Forms.TextBox textIPv6;
        private System.Windows.Forms.Label labelIPv6;
        private System.Windows.Forms.TextBox textDNS;
        private System.Windows.Forms.Label labelDNS;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
