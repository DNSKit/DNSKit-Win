namespace DNSKit_Controller
{
    partial class DNSKit_Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNSKit_Controller));
            this.mainName = new System.Windows.Forms.Label();
            this.dnsList = new System.Windows.Forms.Label();
            this.selectDNS = new System.Windows.Forms.ComboBox();
            this.useSelected = new System.Windows.Forms.Button();
            this.disableBtn = new System.Windows.Forms.Button();
            this.randBtn = new System.Windows.Forms.Button();
            this.logoBg = new System.Windows.Forms.PictureBox();
            this.DNSKit = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoBg)).BeginInit();
            this.SuspendLayout();
            // 
            // mainName
            // 
            this.mainName.AutoSize = true;
            this.mainName.BackColor = System.Drawing.SystemColors.Control;
            this.mainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainName.Location = new System.Drawing.Point(5, 3);
            this.mainName.Name = "mainName";
            this.mainName.Size = new System.Drawing.Size(144, 31);
            this.mainName.TabIndex = 2;
            this.mainName.Text = "mainName";
            // 
            // dnsList
            // 
            this.dnsList.AutoSize = true;
            this.dnsList.Location = new System.Drawing.Point(8, 34);
            this.dnsList.Name = "dnsList";
            this.dnsList.Size = new System.Drawing.Size(40, 13);
            this.dnsList.TabIndex = 4;
            this.dnsList.Text = "dnsList";
            // 
            // selectDNS
            // 
            this.selectDNS.FormattingEnabled = true;
            this.selectDNS.Location = new System.Drawing.Point(213, 202);
            this.selectDNS.Name = "selectDNS";
            this.selectDNS.Size = new System.Drawing.Size(150, 21);
            this.selectDNS.TabIndex = 6;
            // 
            // useSelected
            // 
            this.useSelected.Location = new System.Drawing.Point(288, 229);
            this.useSelected.Name = "useSelected";
            this.useSelected.Size = new System.Drawing.Size(75, 23);
            this.useSelected.TabIndex = 7;
            this.useSelected.Text = "Use DNS";
            this.useSelected.UseVisualStyleBackColor = true;
            this.useSelected.Click += new System.EventHandler(this.useSelected_Click);
            // 
            // disableBtn
            // 
            this.disableBtn.Location = new System.Drawing.Point(93, 229);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(75, 23);
            this.disableBtn.TabIndex = 8;
            this.disableBtn.Text = "Disable";
            this.disableBtn.UseVisualStyleBackColor = true;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // randBtn
            // 
            this.randBtn.Location = new System.Drawing.Point(12, 229);
            this.randBtn.Name = "randBtn";
            this.randBtn.Size = new System.Drawing.Size(75, 23);
            this.randBtn.TabIndex = 9;
            this.randBtn.Text = "Random";
            this.randBtn.UseVisualStyleBackColor = true;
            this.randBtn.Click += new System.EventHandler(this.randBtn_Click);
            // 
            // logoBg
            // 
            this.logoBg.Image = ((System.Drawing.Image)(resources.GetObject("logoBg.Image")));
            this.logoBg.Location = new System.Drawing.Point(26, 86);
            this.logoBg.Name = "logoBg";
            this.logoBg.Size = new System.Drawing.Size(315, 71);
            this.logoBg.TabIndex = 10;
            this.logoBg.TabStop = false;
            // 
            // DNSKit
            // 
            this.DNSKit.Icon = ((System.Drawing.Icon)(resources.GetObject("DNSKit.Icon")));
            this.DNSKit.Text = "DNSKit";
            this.DNSKit.Visible = true;
            this.DNSKit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DNSKit_MouseDoubleClick);
            // 
            // DNSKit_Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 255);
            this.Controls.Add(this.logoBg);
            this.Controls.Add(this.randBtn);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.useSelected);
            this.Controls.Add(this.selectDNS);
            this.Controls.Add(this.dnsList);
            this.Controls.Add(this.mainName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(391, 293);
            this.MinimumSize = new System.Drawing.Size(391, 293);
            this.Name = "DNSKit_Controller";
            this.Text = "DNSKit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DNSKit_Controller_FormClosing);
            this.Load += new System.EventHandler(this.DNSKit_Controller_Load);
            this.Resize += new System.EventHandler(this.DNSKit_Controller_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.logoBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainName;
        private System.Windows.Forms.Label dnsList;
        private System.Windows.Forms.ComboBox selectDNS;
        private System.Windows.Forms.Button useSelected;
        private System.Windows.Forms.Button disableBtn;
        private System.Windows.Forms.Button randBtn;
        private System.Windows.Forms.PictureBox logoBg;
        private System.Windows.Forms.NotifyIcon DNSKit;
    }
}

