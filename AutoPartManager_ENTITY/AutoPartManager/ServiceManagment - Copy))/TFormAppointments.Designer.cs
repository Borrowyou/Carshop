﻿namespace ServiceManagment
{
    partial class TFormAppointments
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
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnNewAppointment = new DevExpress.XtraEditors.SimpleButton();
            this.pnlFormHolder = new System.Windows.Forms.Panel();
            this.pnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtns
            // 
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtns.Controls.Add(this.btnNewAppointment);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBtns.Location = new System.Drawing.Point(0, 0);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(68, 339);
            this.pnlBtns.TabIndex = 0;
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(3, 12);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(58, 43);
            this.btnNewAppointment.TabIndex = 0;
            this.btnNewAppointment.Text = "Нов запис";
            // 
            // pnlFormHolder
            // 
            this.pnlFormHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormHolder.Location = new System.Drawing.Point(68, 0);
            this.pnlFormHolder.Name = "pnlFormHolder";
            this.pnlFormHolder.Size = new System.Drawing.Size(554, 339);
            this.pnlFormHolder.TabIndex = 1;
            // 
            // TFormAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 339);
            this.Controls.Add(this.pnlFormHolder);
            this.Controls.Add(this.pnlBtns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TFormAppointments";
            this.Text = "TFormAppointments";
            this.pnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBtns;
        private DevExpress.XtraEditors.SimpleButton btnNewAppointment;
        private System.Windows.Forms.Panel pnlFormHolder;
    }
}