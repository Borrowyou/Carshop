namespace ServiceManagment
{
    partial class FormReports
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
            this.pnlFormHolder = new System.Windows.Forms.Panel();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnCarServicesReport = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormHolder
            // 
            this.pnlFormHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormHolder.Location = new System.Drawing.Point(68, 0);
            this.pnlFormHolder.Name = "pnlFormHolder";
            this.pnlFormHolder.Size = new System.Drawing.Size(682, 415);
            this.pnlFormHolder.TabIndex = 3;
            // 
            // pnlBtns
            // 
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtns.Controls.Add(this.btnCarServicesReport);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBtns.Location = new System.Drawing.Point(0, 0);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(68, 415);
            this.pnlBtns.TabIndex = 2;
            // 
            // btnCarServicesReport
            // 
            this.btnCarServicesReport.Appearance.Options.UseTextOptions = true;
            this.btnCarServicesReport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCarServicesReport.Location = new System.Drawing.Point(3, 12);
            this.btnCarServicesReport.Name = "btnCarServicesReport";
            this.btnCarServicesReport.Size = new System.Drawing.Size(58, 43);
            this.btnCarServicesReport.TabIndex = 0;
            this.btnCarServicesReport.Text = "Ремонти на коли";
            this.btnCarServicesReport.Click += new System.EventHandler(this.btnCarServicesReport_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 415);
            this.Controls.Add(this.pnlFormHolder);
            this.Controls.Add(this.pnlBtns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReports";
            this.Text = "FormReports";
            this.pnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormHolder;
        private System.Windows.Forms.Panel pnlBtns;
        private DevExpress.XtraEditors.SimpleButton btnCarServicesReport;
    }
}