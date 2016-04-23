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
            this.txtEditClientName = new DevExpress.XtraEditors.TextEdit();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsDset = new DataManagment.ClientsDataSet();
            this.dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtEditCientTelephone = new DevExpress.XtraEditors.TextEdit();
            this.txtEditClientEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblDateADd = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTelephone = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.RichtxtDetails = new System.Windows.Forms.RichTextBox();
            this.txtEditDetails = new DevExpress.XtraEditors.TextEdit();
            this.chkIsFIrm = new DevExpress.XtraEditors.CheckEdit();
            this.ClientCarsBindingSrc = new System.Windows.Forms.BindingSource(this.components);
            this.AllCarsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.ModelsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.YearsList = new System.Windows.Forms.BindingSource(this.components);
            this.EngTypeBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddCar = new System.Windows.Forms.Button();
            this.carsTableAdapter = new DataManagment.ClientsDataSetTableAdapters.CarsTableAdapter();
            this.ModelYearsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsFIrm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCarsBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngTypeBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditClientName
            // 
            this.txtEditClientName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClientBindingSource, "CLIENT_NAME", true));
            this.txtEditClientName.EditValue = "";
            this.txtEditClientName.Location = new System.Drawing.Point(81, 66);
            this.txtEditClientName.Name = "txtEditClientName";
            this.txtEditClientName.Size = new System.Drawing.Size(245, 20);
            this.txtEditClientName.TabIndex = 1;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataMember = "ClientByID";
            this.ClientBindingSource.DataSource = this.ClientsDset;
            // 
            // ClientsDset
            // 
            this.ClientsDset.DataSetName = "ClientsDset";
            this.ClientsDset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateEditFrom
            // 
            this.dateEditFrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClientBindingSource, "CLIENT_FORM", true));
            this.dateEditFrom.EditValue = null;
            this.dateEditFrom.Location = new System.Drawing.Point(131, 21);
            this.dateEditFrom.Name = "dateEditFrom";
            this.dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Size = new System.Drawing.Size(195, 20);
            this.dateEditFrom.TabIndex = 0;
            // 
            // txtEditCientTelephone
            // 
            this.txtEditCientTelephone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClientBindingSource, "TELEPHONE", true));
            this.txtEditCientTelephone.Location = new System.Drawing.Point(81, 120);
            this.txtEditCientTelephone.Name = "txtEditCientTelephone";
            this.txtEditCientTelephone.Size = new System.Drawing.Size(245, 20);
            this.txtEditCientTelephone.TabIndex = 3;
            // 
            // txtEditClientEmail
            // 
            this.txtEditClientEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClientBindingSource, "EMAIL", true));
            this.txtEditClientEmail.Location = new System.Drawing.Point(81, 151);
            this.txtEditClientEmail.Name = "txtEditClientEmail";
            this.txtEditClientEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEditClientEmail.TabIndex = 4;
            // 
            // lblDateADd
            // 
            this.lblDateADd.Location = new System.Drawing.Point(27, 24);
            this.lblDateADd.Name = "lblDateADd";
            this.lblDateADd.Size = new System.Drawing.Size(97, 13);
            this.lblDateADd.TabIndex = 6;
            this.lblDateADd.Text = "Дата на добавяне:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(27, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(19, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Име";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Email:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(27, 123);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(48, 13);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "Телефон:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(15, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // RichtxtDetails
            // 
            this.RichtxtDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClientBindingSource, "DETAILS", true));
            this.RichtxtDetails.Location = new System.Drawing.Point(27, 187);
            this.RichtxtDetails.Name = "RichtxtDetails";
            this.RichtxtDetails.Size = new System.Drawing.Size(299, 80);
            this.RichtxtDetails.TabIndex = 5;
            this.RichtxtDetails.Text = "";
            // 
            // txtEditDetails
            // 
            this.txtEditDetails.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClientBindingSource, "DETAILS", true));
            this.txtEditDetails.Location = new System.Drawing.Point(42, 207);
            this.txtEditDetails.Name = "txtEditDetails";
            this.txtEditDetails.Size = new System.Drawing.Size(100, 20);
            this.txtEditDetails.TabIndex = 14;
            this.txtEditDetails.Visible = false;
            // 
            // chkIsFIrm
            // 
            this.chkIsFIrm.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClientBindingSource, "COMPANY", true));
            this.chkIsFIrm.Location = new System.Drawing.Point(251, 92);
            this.chkIsFIrm.Name = "chkIsFIrm";
            this.chkIsFIrm.Properties.Caption = "Фирма";
            this.chkIsFIrm.Size = new System.Drawing.Size(75, 19);
            this.chkIsFIrm.TabIndex = 2;
            this.chkIsFIrm.CheckedChanged += new System.EventHandler(this.chkIsFIrm_CheckedChanged);
            // 
            // ClientCarsBindingSrc
            // 
            this.ClientCarsBindingSrc.DataMember = "CLIENT_CARS";
            this.ClientCarsBindingSrc.DataSource = this.ClientsDset;
            this.ClientCarsBindingSrc.Sort = "";
            // 
            // AllCarsBindSrc
            // 
            this.AllCarsBindSrc.DataMember = "Cars";
            this.AllCarsBindSrc.DataSource = this.ClientsDset;
            // 
            // ModelsBindSrc
            // 
            this.ModelsBindSrc.DataMember = "Models";
            this.ModelsBindSrc.DataSource = this.ClientsDset;
            // 
            // YearsList
            // 
            this.YearsList.DataMember = "FUN_YEARS_BETWEEN_LIST";
            this.YearsList.DataSource = this.ClientsDset;
            // 
            // EngTypeBindSrc
            // 
            this.EngTypeBindSrc.DataMember = "LOOKUP_ITEMS";
            this.EngTypeBindSrc.DataSource = this.ClientsDset;
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
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // ModelYearsBindSrc
            // 
            this.ModelYearsBindSrc.DataMember = "ModelYears";
            this.ModelYearsBindSrc.DataSource = this.ClientsDset;
            // 
            // FormManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 474);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.chkIsFIrm);
            this.Controls.Add(this.txtEditDetails);
            this.Controls.Add(this.RichtxtDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDateADd);
            this.Controls.Add(this.txtEditClientEmail);
            this.Controls.Add(this.txtEditCientTelephone);
            this.Controls.Add(this.dateEditFrom);
            this.Controls.Add(this.txtEditClientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageClients";
            this.Text = "FormManageClients";
            this.Load += new System.EventHandler(this.FormManageClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsFIrm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCarsBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngTypeBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEditClientName;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.TextEdit txtEditCientTelephone;
        private DevExpress.XtraEditors.TextEdit txtEditClientEmail;
        private DevExpress.XtraEditors.LabelControl lblDateADd;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTelephone;
        private ClientsDataSet ClientsDset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.RichTextBox RichtxtDetails;
        private DevExpress.XtraEditors.TextEdit txtEditDetails;
        private DevExpress.XtraEditors.CheckEdit chkIsFIrm;
        private System.Windows.Forms.BindingSource ClientCarsBindingSrc;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.BindingSource AllCarsBindSrc;
        private ClientsDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource ModelsBindSrc;
        private System.Windows.Forms.BindingSource ModelYearsBindSrc;
        private System.Windows.Forms.BindingSource YearsList;
        private System.Windows.Forms.BindingSource EngTypeBindSrc;
    }
}