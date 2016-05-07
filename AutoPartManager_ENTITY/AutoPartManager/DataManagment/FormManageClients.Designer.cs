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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageClients));
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOOKUP_ITEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOOKUP_ITEMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CLIENT_TYPE", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(81, 92);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_NAME", "Вид", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.lOOKUP_ITEMSBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "ITEM_NAME";
            this.lookUpEdit1.Properties.ValueMember = "ITEM_CODE";
            this.lookUpEdit1.Size = new System.Drawing.Size(110, 20);
            this.lookUpEdit1.TabIndex = 3;
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
            this.lblClType.Location = new System.Drawing.Point(27, 95);
            this.lblClType.Name = "lblClType";
            this.lblClType.Size = new System.Drawing.Size(23, 13);
            this.lblClType.TabIndex = 17;
            this.lblClType.Text = "Вид:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(27, 273);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(19, 23);
            this.btnAddCar.TabIndex = 16;
            this.btnAddCar.Text = "+";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click_1);
            // 
            // txtEditDetails
            // 
            this.txtEditDetails.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "DETAILS", true));
            this.txtEditDetails.Location = new System.Drawing.Point(42, 207);
            this.txtEditDetails.Name = "txtEditDetails";
            this.txtEditDetails.Size = new System.Drawing.Size(100, 20);
            this.txtEditDetails.TabIndex = 14;
            this.txtEditDetails.Visible = false;
            // 
            // RichtxtDetails
            // 
            this.RichtxtDetails.Location = new System.Drawing.Point(27, 187);
            this.RichtxtDetails.Name = "RichtxtDetails";
            this.RichtxtDetails.Size = new System.Drawing.Size(299, 80);
            this.RichtxtDetails.TabIndex = 6;
            this.RichtxtDetails.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(251, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(27, 123);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(48, 13);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "Телефон:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(27, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(19, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Име";
            // 
            // lblDateADd
            // 
            this.lblDateADd.Location = new System.Drawing.Point(27, 24);
            this.lblDateADd.Name = "lblDateADd";
            this.lblDateADd.Size = new System.Drawing.Size(97, 13);
            this.lblDateADd.TabIndex = 6;
            this.lblDateADd.Text = "Дата на добавяне:";
            // 
            // txtEditClientEmail
            // 
            this.txtEditClientEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "EMAIL", true));
            this.txtEditClientEmail.Location = new System.Drawing.Point(81, 151);
            this.txtEditClientEmail.Name = "txtEditClientEmail";
            this.txtEditClientEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEditClientEmail.TabIndex = 5;
            // 
            // txtEditCientTelephone
            // 
            this.txtEditCientTelephone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "TELEPHONE", true));
            this.txtEditCientTelephone.Location = new System.Drawing.Point(81, 120);
            this.txtEditCientTelephone.Name = "txtEditCientTelephone";
            this.txtEditCientTelephone.Size = new System.Drawing.Size(245, 20);
            this.txtEditCientTelephone.TabIndex = 4;
            // 
            // dateEditFrom
            // 
            this.dateEditFrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CLIENT_FORM", true));
            this.dateEditFrom.EditValue = null;
            this.dateEditFrom.Location = new System.Drawing.Point(131, 21);
            this.dateEditFrom.Name = "dateEditFrom";
            this.dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Size = new System.Drawing.Size(195, 20);
            this.dateEditFrom.TabIndex = 1;
            // 
            // txtEditClientName
            // 
            this.txtEditClientName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CLIENT_NAME", true));
            this.txtEditClientName.EditValue = "";
            this.txtEditClientName.Location = new System.Drawing.Point(81, 66);
            this.txtEditClientName.Name = "txtEditClientName";
            this.txtEditClientName.Size = new System.Drawing.Size(245, 20);
            this.txtEditClientName.TabIndex = 2;
            // 
            // FormManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(345, 561);
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
    }
}