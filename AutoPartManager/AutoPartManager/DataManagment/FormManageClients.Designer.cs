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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RichtxtDetails = new System.Windows.Forms.RichTextBox();
            this.txtEditDetails = new DevExpress.XtraEditors.TextEdit();
            this.chkIsFIrm = new DevExpress.XtraEditors.CheckEdit();
            this.clientByIDTableAdapter = new DataManagment.ClientsDataSetTableAdapters.ClientByIDTableAdapter();
            this.btnAddCar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsFIrm.Properties)).BeginInit();
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
            this.ClientBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.ClientBindingSource_AddingNew);
            this.ClientBindingSource.PositionChanged += new System.EventHandler(this.ClientBindingSource_PositionChanged);
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
            this.btnSave.Location = new System.Drawing.Point(15, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(119, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(222, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // clientByIDTableAdapter
            // 
            this.clientByIDTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(27, 273);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(19, 19);
            this.btnAddCar.TabIndex = 15;
            this.btnAddCar.Text = "+";
            this.btnAddCar.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 438);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.chkIsFIrm);
            this.Controls.Add(this.txtEditDetails);
            this.Controls.Add(this.RichtxtDetails);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private ClientsDataSetTableAdapters.ClientByIDTableAdapter clientByIDTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox RichtxtDetails;
        private DevExpress.XtraEditors.TextEdit txtEditDetails;
        private DevExpress.XtraEditors.CheckEdit chkIsFIrm;
        private DevExpress.XtraEditors.SimpleButton btnAddCar;
    }
}