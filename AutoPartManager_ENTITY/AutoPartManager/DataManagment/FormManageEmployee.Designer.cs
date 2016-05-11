namespace DataManagment
{
    partial class FormManageEmployee
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
            System.Windows.Forms.Label dATE_EMPLOYEELabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label qUIT_DATELabel;
            System.Windows.Forms.Label tELEPHONELabel;
            System.Windows.Forms.Label eMPL_TYPELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label dETAILSLabel;
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATE_EMPLOYEEDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.nAMETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.qUIT_DATEDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tELEPHONETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.eMPL_TYPELookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.EmplTypeBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.eMAILTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dETAILSTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            dATE_EMPLOYEELabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            qUIT_DATELabel = new System.Windows.Forms.Label();
            tELEPHONELabel = new System.Windows.Forms.Label();
            eMPL_TYPELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            dETAILSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATE_EMPLOYEEDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATE_EMPLOYEEDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIT_DATEDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIT_DATEDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEPHONETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPL_TYPELookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplTypeBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMAILTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILSTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dATE_EMPLOYEELabel
            // 
            dATE_EMPLOYEELabel.AutoSize = true;
            dATE_EMPLOYEELabel.Location = new System.Drawing.Point(14, 14);
            dATE_EMPLOYEELabel.Name = "dATE_EMPLOYEELabel";
            dATE_EMPLOYEELabel.Size = new System.Drawing.Size(104, 13);
            dATE_EMPLOYEELabel.TabIndex = 1;
            dATE_EMPLOYEELabel.Text = "Дата назначаване:";
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(14, 47);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(32, 13);
            nAMELabel.TabIndex = 2;
            nAMELabel.Text = "Име:";
            nAMELabel.Click += new System.EventHandler(this.nAMELabel_Click);
            // 
            // qUIT_DATELabel
            // 
            qUIT_DATELabel.AutoSize = true;
            qUIT_DATELabel.Location = new System.Drawing.Point(14, 167);
            qUIT_DATELabel.Name = "qUIT_DATELabel";
            qUIT_DATELabel.Size = new System.Drawing.Size(92, 13);
            qUIT_DATELabel.TabIndex = 4;
            qUIT_DATELabel.Text = "Дата напускане:";
            // 
            // tELEPHONELabel
            // 
            tELEPHONELabel.AutoSize = true;
            tELEPHONELabel.Location = new System.Drawing.Point(14, 77);
            tELEPHONELabel.Name = "tELEPHONELabel";
            tELEPHONELabel.Size = new System.Drawing.Size(55, 13);
            tELEPHONELabel.TabIndex = 6;
            tELEPHONELabel.Text = "Телефон:";
            // 
            // eMPL_TYPELabel
            // 
            eMPL_TYPELabel.AutoSize = true;
            eMPL_TYPELabel.Location = new System.Drawing.Point(14, 136);
            eMPL_TYPELabel.Name = "eMPL_TYPELabel";
            eMPL_TYPELabel.Size = new System.Drawing.Size(60, 13);
            eMPL_TYPELabel.TabIndex = 8;
            eMPL_TYPELabel.Text = "Длъжност";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(14, 106);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(35, 13);
            eMAILLabel.TabIndex = 10;
            eMAILLabel.Text = "Email:";
            // 
            // dETAILSLabel
            // 
            dETAILSLabel.AutoSize = true;
            dETAILSLabel.Location = new System.Drawing.Point(14, 198);
            dETAILSLabel.Name = "dETAILSLabel";
            dETAILSLabel.Size = new System.Drawing.Size(74, 13);
            dETAILSLabel.TabIndex = 12;
            dETAILSLabel.Text = "Подробности";
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataSource = typeof(AutoPartDataModels.EMPLOYEES);
            // 
            // dATE_EMPLOYEEDateEdit
            // 
            this.dATE_EMPLOYEEDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eMPLOYEESBindingSource, "DATE_EMPLOYEE", true));
            this.dATE_EMPLOYEEDateEdit.EditValue = null;
            this.dATE_EMPLOYEEDateEdit.Location = new System.Drawing.Point(123, 11);
            this.dATE_EMPLOYEEDateEdit.Name = "dATE_EMPLOYEEDateEdit";
            this.dATE_EMPLOYEEDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dATE_EMPLOYEEDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dATE_EMPLOYEEDateEdit.Size = new System.Drawing.Size(231, 20);
            this.dATE_EMPLOYEEDateEdit.TabIndex = 0;
            // 
            // nAMETextEdit
            // 
            this.nAMETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eMPLOYEESBindingSource, "NAME", true));
            this.nAMETextEdit.Location = new System.Drawing.Point(123, 41);
            this.nAMETextEdit.Name = "nAMETextEdit";
            this.nAMETextEdit.Size = new System.Drawing.Size(231, 20);
            this.nAMETextEdit.TabIndex = 1;
            // 
            // qUIT_DATEDateEdit
            // 
            this.qUIT_DATEDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eMPLOYEESBindingSource, "QUIT_DATE", true));
            this.qUIT_DATEDateEdit.EditValue = null;
            this.qUIT_DATEDateEdit.Location = new System.Drawing.Point(123, 163);
            this.qUIT_DATEDateEdit.Name = "qUIT_DATEDateEdit";
            this.qUIT_DATEDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.qUIT_DATEDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.qUIT_DATEDateEdit.Size = new System.Drawing.Size(231, 20);
            this.qUIT_DATEDateEdit.TabIndex = 5;
            // 
            // tELEPHONETextEdit
            // 
            this.tELEPHONETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eMPLOYEESBindingSource, "TELEPHONE", true));
            this.tELEPHONETextEdit.Location = new System.Drawing.Point(123, 74);
            this.tELEPHONETextEdit.Name = "tELEPHONETextEdit";
            this.tELEPHONETextEdit.Size = new System.Drawing.Size(231, 20);
            this.tELEPHONETextEdit.TabIndex = 2;
            // 
            // eMPL_TYPELookUpEdit
            // 
            this.eMPL_TYPELookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eMPLOYEESBindingSource, "EMPL_TYPE", true));
            this.eMPL_TYPELookUpEdit.Location = new System.Drawing.Point(123, 129);
            this.eMPL_TYPELookUpEdit.Name = "eMPL_TYPELookUpEdit";
            this.eMPL_TYPELookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.eMPL_TYPELookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_NAME", "Длъжност", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.eMPL_TYPELookUpEdit.Properties.DataSource = this.EmplTypeBindSrc;
            this.eMPL_TYPELookUpEdit.Properties.DisplayMember = "ITEM_NAME";
            this.eMPL_TYPELookUpEdit.Properties.ValueMember = "ITEM_CODE";
            this.eMPL_TYPELookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.eMPL_TYPELookUpEdit.TabIndex = 4;
            // 
            // EmplTypeBindSrc
            // 
            this.EmplTypeBindSrc.DataSource = typeof(AutoPartDataModels.LOOKUP_ITEMS);
            // 
            // eMAILTextEdit
            // 
            this.eMAILTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eMPLOYEESBindingSource, "EMAIL", true));
            this.eMAILTextEdit.Location = new System.Drawing.Point(123, 103);
            this.eMAILTextEdit.Name = "eMAILTextEdit";
            this.eMAILTextEdit.Size = new System.Drawing.Size(231, 20);
            this.eMAILTextEdit.TabIndex = 3;
            // 
            // dETAILSTextEdit
            // 
            this.dETAILSTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eMPLOYEESBindingSource, "DETAILS", true));
            this.dETAILSTextEdit.Location = new System.Drawing.Point(123, 193);
            this.dETAILSTextEdit.Name = "dETAILSTextEdit";
            this.dETAILSTextEdit.Size = new System.Drawing.Size(231, 20);
            this.dETAILSTextEdit.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 22);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 341);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(dETAILSLabel);
            this.Controls.Add(this.dETAILSTextEdit);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextEdit);
            this.Controls.Add(eMPL_TYPELabel);
            this.Controls.Add(this.eMPL_TYPELookUpEdit);
            this.Controls.Add(tELEPHONELabel);
            this.Controls.Add(this.tELEPHONETextEdit);
            this.Controls.Add(qUIT_DATELabel);
            this.Controls.Add(this.qUIT_DATEDateEdit);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextEdit);
            this.Controls.Add(dATE_EMPLOYEELabel);
            this.Controls.Add(this.dATE_EMPLOYEEDateEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageEmployee";
            this.Text = "Служител";
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATE_EMPLOYEEDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATE_EMPLOYEEDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIT_DATEDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIT_DATEDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEPHONETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPL_TYPELookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplTypeBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMAILTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILSTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private DevExpress.XtraEditors.DateEdit dATE_EMPLOYEEDateEdit;
        private DevExpress.XtraEditors.TextEdit nAMETextEdit;
        private DevExpress.XtraEditors.DateEdit qUIT_DATEDateEdit;
        private DevExpress.XtraEditors.TextEdit tELEPHONETextEdit;
        private DevExpress.XtraEditors.LookUpEdit eMPL_TYPELookUpEdit;
        private DevExpress.XtraEditors.TextEdit eMAILTextEdit;
        private DevExpress.XtraEditors.TextEdit dETAILSTextEdit;
        private System.Windows.Forms.BindingSource EmplTypeBindSrc;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}