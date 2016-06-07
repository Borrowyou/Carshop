namespace DataManagment
{
    partial class FormManageClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageClients));
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource();
            this.lOOKUP_ITEMSBindingSource = new System.Windows.Forms.BindingSource();
            this.lblClType = new DevExpress.XtraEditors.LabelControl();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.txtEditDetails = new DevExpress.XtraEditors.TextEdit();
            this.RichtxtDetails = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTelephone = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblDateADd = new DevExpress.XtraEditors.LabelControl();
            this.txtEditClientEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtEditCientTelephone = new DevExpress.XtraEditors.TextEdit();
            this.dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtEditClientName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEIK = new System.Windows.Forms.Label();
            this.txtEIK = new DevExpress.XtraEditors.TextEdit();
            this.txtMon = new DevExpress.XtraEditors.TextEdit();
            this.lblMon = new DevExpress.XtraEditors.LabelControl();
            this.lblAdress = new DevExpress.XtraEditors.LabelControl();
            this.txtAdress = new DevExpress.XtraEditors.TextEdit();
            this.lblTown = new DevExpress.XtraEditors.LabelControl();
            this.txtEditTown = new DevExpress.XtraEditors.TextEdit();
            this.lblIBan = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lblBank = new DevExpress.XtraEditors.LabelControl();
            this.txtEditBank = new DevExpress.XtraEditors.TextEdit();
            this.lblBic = new DevExpress.XtraEditors.LabelControl();
            this.txtEditBIC = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOOKUP_ITEMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEIK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditBIC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CLIENT_TYPE", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(68, 81);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_NAME", "Вид", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.lOOKUP_ITEMSBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "ITEM_NAME";
            this.lookUpEdit1.Properties.NullText = "Избери вид";
            this.lookUpEdit1.Properties.ValueMember = "ITEM_CODE";
            this.lookUpEdit1.Size = new System.Drawing.Size(83, 20);
            this.lookUpEdit1.TabIndex = 3;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(AutoPartDataModels.Clients);
            // 
            // lOOKUP_ITEMSBindingSource
            // 
            this.lOOKUP_ITEMSBindingSource.DataSource = typeof(AutoPartDataModels.LOOKUP_ITEMS);
            // 
            // lblClType
            // 
            this.lblClType.Location = new System.Drawing.Point(14, 88);
            this.lblClType.Name = "lblClType";
            this.lblClType.Size = new System.Drawing.Size(23, 13);
            this.lblClType.TabIndex = 17;
            this.lblClType.Text = "Вид:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(27, 292);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(97, 23);
            this.btnAddCar.TabIndex = 13;
            this.btnAddCar.Text = "Добави кола";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click_1);
            // 
            // txtEditDetails
            // 
            this.txtEditDetails.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "DETAILS", true));
            this.txtEditDetails.Location = new System.Drawing.Point(28, 254);
            this.txtEditDetails.Name = "txtEditDetails";
            this.txtEditDetails.Size = new System.Drawing.Size(100, 20);
            this.txtEditDetails.TabIndex = 14;
            this.txtEditDetails.Visible = false;
            // 
            // RichtxtDetails
            // 
            this.RichtxtDetails.Location = new System.Drawing.Point(27, 247);
            this.RichtxtDetails.Name = "RichtxtDetails";
            this.RichtxtDetails.Size = new System.Drawing.Size(299, 27);
            this.RichtxtDetails.TabIndex = 12;
            this.RichtxtDetails.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(14, 36);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(48, 13);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "Телефон:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(14, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Име(Фирма):";
            // 
            // lblDateADd
            // 
            this.lblDateADd.Location = new System.Drawing.Point(10, -3);
            this.lblDateADd.Name = "lblDateADd";
            this.lblDateADd.Size = new System.Drawing.Size(97, 13);
            this.lblDateADd.TabIndex = 6;
            this.lblDateADd.Text = "Дата на добавяне:";
            this.lblDateADd.Visible = false;
            // 
            // txtEditClientEmail
            // 
            this.txtEditClientEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "EMAIL", true));
            this.txtEditClientEmail.Location = new System.Drawing.Point(68, 55);
            this.txtEditClientEmail.Name = "txtEditClientEmail";
            this.txtEditClientEmail.Size = new System.Drawing.Size(258, 20);
            this.txtEditClientEmail.TabIndex = 2;
            // 
            // txtEditCientTelephone
            // 
            this.txtEditCientTelephone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "TELEPHONE", true));
            this.txtEditCientTelephone.Location = new System.Drawing.Point(68, 29);
            this.txtEditCientTelephone.Name = "txtEditCientTelephone";
            this.txtEditCientTelephone.Size = new System.Drawing.Size(258, 20);
            this.txtEditCientTelephone.TabIndex = 1;
            // 
            // dateEditFrom
            // 
            this.dateEditFrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CLIENT_FORM", true));
            this.dateEditFrom.EditValue = null;
            this.dateEditFrom.Location = new System.Drawing.Point(114, -6);
            this.dateEditFrom.Name = "dateEditFrom";
            this.dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Size = new System.Drawing.Size(195, 20);
            this.dateEditFrom.TabIndex = 0;
            this.dateEditFrom.Visible = false;
            // 
            // txtEditClientName
            // 
            this.txtEditClientName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CLIENT_NAME", true));
            this.txtEditClientName.EditValue = "";
            this.txtEditClientName.Location = new System.Drawing.Point(81, 3);
            this.txtEditClientName.Name = "txtEditClientName";
            this.txtEditClientName.Size = new System.Drawing.Size(245, 20);
            this.txtEditClientName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Допълнително подробности за клиента:";
            // 
            // lblEIK
            // 
            this.lblEIK.AutoSize = true;
            this.lblEIK.Location = new System.Drawing.Point(157, 85);
            this.lblEIK.Name = "lblEIK";
            this.lblEIK.Size = new System.Drawing.Size(32, 13);
            this.lblEIK.TabIndex = 19;
            this.lblEIK.Text = "ЕИК:";
            // 
            // txtEIK
            // 
            this.txtEIK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "EIK", true));
            this.txtEIK.Location = new System.Drawing.Point(185, 81);
            this.txtEIK.Name = "txtEIK";
            this.txtEIK.Size = new System.Drawing.Size(141, 20);
            this.txtEIK.TabIndex = 4;
            // 
            // txtMon
            // 
            this.txtMon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "MON", true));
            this.txtMon.Location = new System.Drawing.Point(68, 107);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(121, 20);
            this.txtMon.TabIndex = 5;
            // 
            // lblMon
            // 
            this.lblMon.Location = new System.Drawing.Point(14, 110);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(27, 13);
            this.lblMon.TabIndex = 22;
            this.lblMon.Text = "МОЛ:";
            // 
            // lblAdress
            // 
            this.lblAdress.Location = new System.Drawing.Point(14, 136);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(35, 13);
            this.lblAdress.TabIndex = 24;
            this.lblAdress.Text = "Адрес:";
            // 
            // txtAdress
            // 
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "ADDRESS", true));
            this.txtAdress.Location = new System.Drawing.Point(68, 133);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(258, 20);
            this.txtAdress.TabIndex = 7;
            // 
            // lblTown
            // 
            this.lblTown.Location = new System.Drawing.Point(193, 110);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(29, 13);
            this.lblTown.TabIndex = 25;
            this.lblTown.Text = "Град:";
            // 
            // txtEditTown
            // 
            this.txtEditTown.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "TOWN", true));
            this.txtEditTown.Location = new System.Drawing.Point(228, 107);
            this.txtEditTown.Name = "txtEditTown";
            this.txtEditTown.Size = new System.Drawing.Size(98, 20);
            this.txtEditTown.TabIndex = 6;
            // 
            // lblIBan
            // 
            this.lblIBan.AutoSize = true;
            this.lblIBan.Location = new System.Drawing.Point(12, 162);
            this.lblIBan.Name = "lblIBan";
            this.lblIBan.Size = new System.Drawing.Size(35, 13);
            this.lblIBan.TabIndex = 27;
            this.lblIBan.Text = "IBAN:";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "IBAN", true));
            this.textEdit2.Location = new System.Drawing.Point(68, 159);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(258, 20);
            this.textEdit2.TabIndex = 8;
            // 
            // lblBank
            // 
            this.lblBank.Location = new System.Drawing.Point(15, 185);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(34, 13);
            this.lblBank.TabIndex = 29;
            this.lblBank.Text = "Банка:";
            // 
            // txtEditBank
            // 
            this.txtEditBank.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "BANK", true));
            this.txtEditBank.Location = new System.Drawing.Point(68, 182);
            this.txtEditBank.Name = "txtEditBank";
            this.txtEditBank.Size = new System.Drawing.Size(121, 20);
            this.txtEditBank.TabIndex = 9;
            // 
            // lblBic
            // 
            this.lblBic.Location = new System.Drawing.Point(195, 188);
            this.lblBic.Name = "lblBic";
            this.lblBic.Size = new System.Drawing.Size(21, 13);
            this.lblBic.TabIndex = 31;
            this.lblBic.Text = "BIC:";
            // 
            // txtEditBIC
            // 
            this.txtEditBIC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "BIC", true));
            this.txtEditBIC.Location = new System.Drawing.Point(219, 185);
            this.txtEditBIC.Name = "txtEditBIC";
            this.txtEditBIC.Size = new System.Drawing.Size(107, 20);
            this.txtEditBIC.TabIndex = 10;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "ZDDSNUMB", true));
            this.textEdit1.Location = new System.Drawing.Point(68, 208);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(148, 20);
            this.textEdit1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "ЗДДС№";
            // 
            // FormManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(345, 561);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditBIC);
            this.Controls.Add(this.lblBic);
            this.Controls.Add(this.txtEditBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.lblIBan);
            this.Controls.Add(this.txtEditTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.txtEIK);
            this.Controls.Add(this.lblEIK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.RichtxtDetails);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.lblClType);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.txtEditDetails);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEditClientName);
            this.Controls.Add(this.txtEditCientTelephone);
            this.Controls.Add(this.dateEditFrom);
            this.Controls.Add(this.txtEditClientEmail);
            this.Controls.Add(this.lblDateADd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageClients";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.FormManageClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOOKUP_ITEMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEIK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditBIC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource lOOKUP_ITEMSBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl lblClType;
        private System.Windows.Forms.Button btnAddCar;
        private DevExpress.XtraEditors.TextEdit txtEditDetails;
        private System.Windows.Forms.RichTextBox RichtxtDetails;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.LabelControl lblTelephone;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblDateADd;
        private DevExpress.XtraEditors.TextEdit txtEditClientEmail;
        private DevExpress.XtraEditors.TextEdit txtEditCientTelephone;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.TextEdit txtEditClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEIK;
        private DevExpress.XtraEditors.TextEdit txtEIK;
        private DevExpress.XtraEditors.TextEdit txtMon;
        private DevExpress.XtraEditors.LabelControl lblMon;
        private DevExpress.XtraEditors.LabelControl lblAdress;
        private DevExpress.XtraEditors.TextEdit txtAdress;
        private DevExpress.XtraEditors.LabelControl lblTown;
        private DevExpress.XtraEditors.TextEdit txtEditTown;
        private System.Windows.Forms.Label lblIBan;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl lblBank;
        private DevExpress.XtraEditors.TextEdit txtEditBank;
        private DevExpress.XtraEditors.LabelControl lblBic;
        private DevExpress.XtraEditors.TextEdit txtEditBIC;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
    }
}