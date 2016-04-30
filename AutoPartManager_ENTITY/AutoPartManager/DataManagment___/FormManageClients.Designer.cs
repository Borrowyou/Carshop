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
            System.Windows.Forms.Label cLIENT_TYPELabel;
            this.txtEditClientName = new DevExpress.XtraEditors.TextEdit();
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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.cLIENT_TYPELookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientCarsBindingSrc = new System.Windows.Forms.BindingSource(this.components);
            this.AllCarsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.ModelsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.YearsList = new System.Windows.Forms.BindingSource(this.components);
            this.EngTypeBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.ModelYearsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.lOOKUP_ITEMS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            cLIENT_TYPELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_TYPELookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.ClientCarsBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngTypeBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOOKUP_ITEMS1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cLIENT_TYPELabel
            // 
            cLIENT_TYPELabel.AutoSize = true;
            cLIENT_TYPELabel.Location = new System.Drawing.Point(28, 95);
            cLIENT_TYPELabel.Name = "cLIENT_TYPELabel";
            cLIENT_TYPELabel.Size = new System.Drawing.Size(79, 13);
            cLIENT_TYPELabel.TabIndex = 16;
            cLIENT_TYPELabel.Text = "CLIENT TYPE:";
            cLIENT_TYPELabel.Click += new System.EventHandler(this.cLIENT_TYPELabel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(27, 463);
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
            // cLIENT_TYPELookUpEdit
            // 
            this.cLIENT_TYPELookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClientBindingSource, "CLIENT_TYPE", true));
            this.cLIENT_TYPELookUpEdit.Location = new System.Drawing.Point(113, 92);
            this.cLIENT_TYPELookUpEdit.Name = "cLIENT_TYPELookUpEdit";
            this.cLIENT_TYPELookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cLIENT_TYPELookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.cLIENT_TYPELookUpEdit.TabIndex = 17;
            this.cLIENT_TYPELookUpEdit.EditValueChanged += new System.EventHandler(this.cLIENT_TYPELookUpEdit_EditValueChanged);
            // 
    
            // 
            // FormManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 498);
            this.Controls.Add(cLIENT_TYPELabel);
            this.Controls.Add(this.cLIENT_TYPELookUpEdit);
            this.Controls.Add(this.btnAddCar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCientTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditClientEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_TYPELookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCarsBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngTypeBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOOKUP_ITEMS1BindingSource)).EndInit();
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
       // private ClientsDataSet ClientsDset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.RichTextBox RichtxtDetails;
        private DevExpress.XtraEditors.TextEdit txtEditDetails;
        private System.Windows.Forms.BindingSource ClientCarsBindingSrc;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.BindingSource AllCarsBindSrc;
        private System.Windows.Forms.BindingSource ModelsBindSrc;
        private System.Windows.Forms.BindingSource ModelYearsBindSrc;
        private System.Windows.Forms.BindingSource YearsList;
        private System.Windows.Forms.BindingSource EngTypeBindSrc;
        private DevExpress.XtraEditors.LookUpEdit cLIENT_TYPELookUpEdit;
        private System.Windows.Forms.BindingSource lOOKUP_ITEMS1BindingSource;
    }
}