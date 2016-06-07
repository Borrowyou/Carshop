namespace AutoPartManager
{
    partial class FormAutoPartManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutoPartManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.частиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.служителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlBtms = new System.Windows.Forms.Panel();
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.btnAppoitments = new DevExpress.XtraEditors.SimpleButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.маркиИМоделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.PnlBtms.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.частиToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.служителиToolStripMenuItem,
            this.маркиИМоделиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.clientsToolStripMenuItem.Text = "Клиенти";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // частиToolStripMenuItem
            // 
            this.частиToolStripMenuItem.Name = "частиToolStripMenuItem";
            this.частиToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.частиToolStripMenuItem.Text = "Части";
            this.частиToolStripMenuItem.Click += new System.EventHandler(this.частиToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // служителиToolStripMenuItem
            // 
            this.служителиToolStripMenuItem.Name = "служителиToolStripMenuItem";
            this.служителиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.служителиToolStripMenuItem.Text = "Служители";
            this.служителиToolStripMenuItem.Click += new System.EventHandler(this.служителиToolStripMenuItem_Click);
            // 
            // PnlBtms
            // 
            this.PnlBtms.Controls.Add(this.btnReports);
            this.PnlBtms.Controls.Add(this.btnAppoitments);
            this.PnlBtms.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtms.Location = new System.Drawing.Point(0, 24);
            this.PnlBtms.Name = "PnlBtms";
            this.PnlBtms.Size = new System.Drawing.Size(445, 44);
            this.PnlBtms.TabIndex = 2;
            // 
            // btnReports
            // 
            this.btnReports.Appearance.Options.UseTextOptions = true;
            this.btnReports.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnReports.Location = new System.Drawing.Point(83, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(65, 38);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Справки";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAppoitments
            // 
            this.btnAppoitments.Appearance.Options.UseTextOptions = true;
            this.btnAppoitments.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnAppoitments.Location = new System.Drawing.Point(12, 3);
            this.btnAppoitments.Name = "btnAppoitments";
            this.btnAppoitments.Size = new System.Drawing.Size(65, 41);
            this.btnAppoitments.TabIndex = 3;
            this.btnAppoitments.Text = "Часове и ремонти";
            this.btnAppoitments.Click += new System.EventHandler(this.btnAppoitments_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 68);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(445, 194);
            this.pnlForm.TabIndex = 3;
            // 
            // маркиИМоделиToolStripMenuItem
            // 
            this.маркиИМоделиToolStripMenuItem.Name = "маркиИМоделиToolStripMenuItem";
            this.маркиИМоделиToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.маркиИМоделиToolStripMenuItem.Text = "Марки и модели";
            this.маркиИМоделиToolStripMenuItem.Click += new System.EventHandler(this.маркиИМоделиToolStripMenuItem_Click);
            // 
            // FormAutoPartManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.PnlBtms);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAutoPartManager";
            this.Text = "Авто трейдър";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAutoPartManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlBtms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem частиToolStripMenuItem;
        private System.Windows.Forms.Panel PnlBtms;
        private DevExpress.XtraEditors.SimpleButton btnAppoitments;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem служителиToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnReports;
        private System.Windows.Forms.ToolStripMenuItem маркиИМоделиToolStripMenuItem;


    }
}

