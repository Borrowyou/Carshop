﻿namespace AutoPartManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.частиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlBtms = new System.Windows.Forms.Panel();
            this.btnAppoitments = new DevExpress.XtraEditors.SimpleButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.PnlBtms.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.частиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
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
            // PnlBtms
            // 
            this.PnlBtms.Controls.Add(this.btnAppoitments);
            this.PnlBtms.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtms.Location = new System.Drawing.Point(0, 24);
            this.PnlBtms.Name = "PnlBtms";
            this.PnlBtms.Size = new System.Drawing.Size(386, 44);
            this.PnlBtms.TabIndex = 2;
            // 
            // btnAppoitments
            // 
            this.btnAppoitments.Location = new System.Drawing.Point(12, 3);
            this.btnAppoitments.Name = "btnAppoitments";
            this.btnAppoitments.Size = new System.Drawing.Size(82, 38);
            this.btnAppoitments.TabIndex = 3;
            this.btnAppoitments.Text = "simpleButton1";
            this.btnAppoitments.Click += new System.EventHandler(this.btnAppoitments_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 68);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(386, 194);
            this.pnlForm.TabIndex = 3;
            // 
            // FormAutoPartManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.PnlBtms);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAutoPartManager";
            this.Text = "Form1";
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


    }
}
