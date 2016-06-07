namespace ServiceManagment
{
    partial class FormAppoitmentInvoice
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
            this.lblInvoiceDate = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lblNumber = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.PaymWayBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.lblCreator = new DevExpress.XtraEditors.LabelControl();
            this.lblSum = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtEditCreator = new DevExpress.XtraEditors.TextEdit();
            this.EmplBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditReciever = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymWayBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditReciever.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Location = new System.Drawing.Point(12, 12);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(104, 13);
            this.lblInvoiceDate.TabIndex = 0;
            this.lblInvoiceDate.Text = "Дата на фактурата:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(122, 9);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(97, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(246, 12);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Номер:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(287, 9);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(157, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Начин на плащане:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(122, 42);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_NAME", "Вид", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.PaymWayBindSrc;
            this.lookUpEdit1.Properties.DisplayMember = "ITEM_NAME";
            this.lookUpEdit1.Properties.ValueMember = "ITEM_NAME";
            this.lookUpEdit1.Size = new System.Drawing.Size(97, 20);
            this.lookUpEdit1.TabIndex = 5;
            // 
            // PaymWayBindSrc
            // 
            this.PaymWayBindSrc.DataSource = typeof(AutoPartDataModels.LOOKUP_ITEMS);
            // 
            // lblCreator
            // 
            this.lblCreator.Location = new System.Drawing.Point(228, 45);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(53, 13);
            this.lblCreator.TabIndex = 6;
            this.lblCreator.Text = "Съставил:";
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(12, 96);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(91, 13);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "Сума за плащане:";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Location = new System.Drawing.Point(119, 96);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(35, 13);
            this.lblTotalSum.TabIndex = 9;
            this.lblTotalSum.Text = "label1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Сума словом:";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(85, 117);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(359, 20);
            this.textEdit2.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(369, 90);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Генерирай";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtEditCreator
            // 
            this.txtEditCreator.Location = new System.Drawing.Point(287, 42);
            this.txtEditCreator.Name = "txtEditCreator";
            this.txtEditCreator.Size = new System.Drawing.Size(157, 20);
            this.txtEditCreator.TabIndex = 13;
            // 
            // EmplBindSrc
            // 
            this.EmplBindSrc.DataSource = typeof(AutoPartDataModels.EMPLOYEES);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Получател:";
            // 
            // txtEditReciever
            // 
            this.txtEditReciever.Location = new System.Drawing.Point(122, 68);
            this.txtEditReciever.Name = "txtEditReciever";
            this.txtEditReciever.Size = new System.Drawing.Size(159, 20);
            this.txtEditReciever.TabIndex = 15;
            // 
            // FormAppoitmentInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 175);
            this.Controls.Add(this.txtEditReciever);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtEditCreator);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblTotalSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.lblInvoiceDate);
            this.Name = "FormAppoitmentInvoice";
            this.Text = "Фактура";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAppoitmentInvoice_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymWayBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditReciever.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblInvoiceDate;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl lblNumber;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl lblCreator;
        private DevExpress.XtraEditors.LabelControl lblSum;
        private System.Windows.Forms.Label lblTotalSum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource PaymWayBindSrc;
        private System.Windows.Forms.BindingSource EmplBindSrc;
        private DevExpress.XtraEditors.TextEdit txtEditCreator;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEditReciever;
    }
}