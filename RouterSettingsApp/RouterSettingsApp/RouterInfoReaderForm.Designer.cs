namespace RouterSettingsApp
{
    partial class RouterInfoReaderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblRouterName;
        private System.Windows.Forms.Label lblRouterIP;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.TextBox txtRouterName;
        private System.Windows.Forms.TextBox txtRouterIP;
        private System.Windows.Forms.TextBox txtMacAddress;
        private System.Windows.Forms.TextBox txtManufacturer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouterInfoReaderForm));
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtRouterName = new System.Windows.Forms.TextBox();
            this.txtRouterIP = new System.Windows.Forms.TextBox();
            this.txtMacAddress = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblRouterName = new System.Windows.Forms.Label();
            this.lblRouterIP = new System.Windows.Forms.Label();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.btnDetect = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.txtRouterName);
            this.groupBoxInfo.Controls.Add(this.txtRouterIP);
            this.groupBoxInfo.Controls.Add(this.txtMacAddress);
            this.groupBoxInfo.Controls.Add(this.txtManufacturer);
            this.groupBoxInfo.Controls.Add(this.lblRouterName);
            this.groupBoxInfo.Controls.Add(this.lblRouterIP);
            this.groupBoxInfo.Controls.Add(this.lblMacAddress);
            this.groupBoxInfo.Controls.Add(this.lblManufacturer);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 99);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(360, 190);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Router Information";
            // 
            // txtRouterName
            // 
            this.txtRouterName.Location = new System.Drawing.Point(130, 27);
            this.txtRouterName.Name = "txtRouterName";
            this.txtRouterName.ReadOnly = true;
            this.txtRouterName.Size = new System.Drawing.Size(200, 23);
            this.txtRouterName.TabIndex = 0;
            // 
            // txtRouterIP
            // 
            this.txtRouterIP.Location = new System.Drawing.Point(130, 62);
            this.txtRouterIP.Name = "txtRouterIP";
            this.txtRouterIP.ReadOnly = true;
            this.txtRouterIP.Size = new System.Drawing.Size(200, 23);
            this.txtRouterIP.TabIndex = 1;
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.Location = new System.Drawing.Point(130, 97);
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.ReadOnly = true;
            this.txtMacAddress.Size = new System.Drawing.Size(200, 23);
            this.txtMacAddress.TabIndex = 2;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(130, 132);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(200, 23);
            this.txtManufacturer.TabIndex = 3;
            // 
            // lblRouterName
            // 
            this.lblRouterName.AutoSize = true;
            this.lblRouterName.Location = new System.Drawing.Point(15, 30);
            this.lblRouterName.Name = "lblRouterName";
            this.lblRouterName.Size = new System.Drawing.Size(85, 15);
            this.lblRouterName.TabIndex = 4;
            this.lblRouterName.Text = "Router Name:";
            // 
            // lblRouterIP
            // 
            this.lblRouterIP.AutoSize = true;
            this.lblRouterIP.Location = new System.Drawing.Point(15, 65);
            this.lblRouterIP.Name = "lblRouterIP";
            this.lblRouterIP.Size = new System.Drawing.Size(63, 15);
            this.lblRouterIP.TabIndex = 5;
            this.lblRouterIP.Text = "Router IP:";
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Location = new System.Drawing.Point(15, 100);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(83, 15);
            this.lblMacAddress.TabIndex = 6;
            this.lblMacAddress.Text = "MAC Address:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(15, 135);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(87, 15);
            this.lblManufacturer.TabIndex = 7;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // btnDetect
            // 
            this.btnDetect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDetect.Location = new System.Drawing.Point(385, 227);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(120, 30);
            this.btnDetect.TabIndex = 2;
            this.btnDetect.Text = "Detect Router Info";
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Location = new System.Drawing.Point(385, 107);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(120, 100);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "View some information about your router";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Router Info";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(385, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Click here to view information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Company/Brand Logo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RouterInfoReaderForm
            // 
            this.ClientSize = new System.Drawing.Size(520, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.btnDetect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouterInfoReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Router Info";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
