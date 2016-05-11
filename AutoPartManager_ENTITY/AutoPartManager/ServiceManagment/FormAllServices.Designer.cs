namespace ServiceManagment
{
    partial class FormAllServices
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
            this.sERVICE_WORKSBindingSource = new System.Windows.Forms.BindingSource();
            this.sERVICE_WORKSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSERVICE_WORK_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.WorkStatusBindingSrc = new System.Windows.Forms.BindingSource();
            this.colTIME_START = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colTIME_FINISH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOOKUP_ITEMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPLOYEES_SERVICE_WORKS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MechanicsBindSrc = new System.Windows.Forms.BindingSource();
            this.colSERVICES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_WORK_PARTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENTS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.pnlSearchMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.LookUpStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkStatusBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchMenu)).BeginInit();
            this.pnlSearchMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sERVICE_WORKSBindingSource
            // 
            this.sERVICE_WORKSBindingSource.DataSource = typeof(AutoPartDataModels.SERVICE_WORKS);
            this.sERVICE_WORKSBindingSource.PositionChanged += new System.EventHandler(this.sERVICE_WORKSBindingSource_PositionChanged);
            // 
            // sERVICE_WORKSGridControl
            // 
            this.sERVICE_WORKSGridControl.DataSource = this.sERVICE_WORKSBindingSource;
            this.sERVICE_WORKSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sERVICE_WORKSGridControl.Location = new System.Drawing.Point(0, 37);
            this.sERVICE_WORKSGridControl.MainView = this.gridView1;
            this.sERVICE_WORKSGridControl.Name = "sERVICE_WORKSGridControl";
            this.sERVICE_WORKSGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemDateEdit1});
            this.sERVICE_WORKSGridControl.Size = new System.Drawing.Size(735, 356);
            this.sERVICE_WORKSGridControl.TabIndex = 1;
            this.sERVICE_WORKSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sERVICE_WORKSGridControl.DoubleClick += new System.EventHandler(this.sERVICE_WORKSGridControl_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSERVICE_WORK_ID,
            this.colAPPOITMENT_ID,
            this.colWORK_STATUS,
            this.colTIME_START,
            this.colTIME_FINISH,
            this.colWORK_PRICE,
            this.colSERVICE_ID,
            this.colAPPOITMENTS,
            this.colLOOKUP_ITEMS,
            this.colEMPLOYEES_SERVICE_WORKS,
            this.colSERVICES,
            this.colSERVICE_WORK_PARTS,
            this.colAPPOITMENTS1});
            this.gridView1.GridControl = this.sERVICE_WORKSGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colSERVICE_WORK_ID
            // 
            this.colSERVICE_WORK_ID.FieldName = "SERVICE_WORK_ID";
            this.colSERVICE_WORK_ID.Name = "colSERVICE_WORK_ID";
            // 
            // colAPPOITMENT_ID
            // 
            this.colAPPOITMENT_ID.FieldName = "APPOITMENT_ID";
            this.colAPPOITMENT_ID.Name = "colAPPOITMENT_ID";
            // 
            // colWORK_STATUS
            // 
            this.colWORK_STATUS.Caption = "Статус";
            this.colWORK_STATUS.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colWORK_STATUS.FieldName = "WORK_STATUS";
            this.colWORK_STATUS.Name = "colWORK_STATUS";
            this.colWORK_STATUS.Visible = true;
            this.colWORK_STATUS.VisibleIndex = 3;
            this.colWORK_STATUS.Width = 102;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_NAME", "Статус", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.WorkStatusBindingSrc;
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEM_NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEM_CODE";
            // 
            // WorkStatusBindingSrc
            // 
            this.WorkStatusBindingSrc.DataSource = typeof(AutoPartDataModels.LOOKUP_ITEMS);
            // 
            // colTIME_START
            // 
            this.colTIME_START.Caption = "Време започване";
            this.colTIME_START.ColumnEdit = this.repositoryItemDateEdit1;
            this.colTIME_START.DisplayFormat.FormatString = "MM/dd/yyyy hh:mm";
            this.colTIME_START.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTIME_START.FieldName = "TIME_START";
            this.colTIME_START.Name = "colTIME_START";
            this.colTIME_START.Visible = true;
            this.colTIME_START.VisibleIndex = 4;
            this.colTIME_START.Width = 119;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colTIME_FINISH
            // 
            this.colTIME_FINISH.Caption = "Време приключване";
            this.colTIME_FINISH.ColumnEdit = this.repositoryItemDateEdit1;
            this.colTIME_FINISH.DisplayFormat.FormatString = "MM/dd/yyyy hh:mm";
            this.colTIME_FINISH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTIME_FINISH.FieldName = "TIME_FINISH";
            this.colTIME_FINISH.Name = "colTIME_FINISH";
            this.colTIME_FINISH.Visible = true;
            this.colTIME_FINISH.VisibleIndex = 5;
            this.colTIME_FINISH.Width = 93;
            // 
            // colWORK_PRICE
            // 
            this.colWORK_PRICE.FieldName = "WORK_PRICE";
            this.colWORK_PRICE.Name = "colWORK_PRICE";
            // 
            // colSERVICE_ID
            // 
            this.colSERVICE_ID.FieldName = "SERVICE_ID";
            this.colSERVICE_ID.Name = "colSERVICE_ID";
            // 
            // colAPPOITMENTS
            // 
            this.colAPPOITMENTS.Caption = "Клиент";
            this.colAPPOITMENTS.FieldName = "APPOITMENTS.Clients.CLIENT_NAME";
            this.colAPPOITMENTS.Name = "colAPPOITMENTS";
            this.colAPPOITMENTS.OptionsColumn.AllowEdit = false;
            this.colAPPOITMENTS.Visible = true;
            this.colAPPOITMENTS.VisibleIndex = 1;
            // 
            // colLOOKUP_ITEMS
            // 
            this.colLOOKUP_ITEMS.FieldName = "LOOKUP_ITEMS";
            this.colLOOKUP_ITEMS.Name = "colLOOKUP_ITEMS";
            // 
            // colEMPLOYEES_SERVICE_WORKS
            // 
            this.colEMPLOYEES_SERVICE_WORKS.Caption = "Монтьори";
            this.colEMPLOYEES_SERVICE_WORKS.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colEMPLOYEES_SERVICE_WORKS.FieldName = "EMPLOYEES_SERVICE_WORKS";
            this.colEMPLOYEES_SERVICE_WORKS.Name = "colEMPLOYEES_SERVICE_WORKS";
            this.colEMPLOYEES_SERVICE_WORKS.Visible = true;
            this.colEMPLOYEES_SERVICE_WORKS.VisibleIndex = 6;
            this.colEMPLOYEES_SERVICE_WORKS.Width = 97;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPLOYEES.NAME", "NAME", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit3.DataSource = this.MechanicsBindSrc;
            this.repositoryItemLookUpEdit3.DisplayMember = "EMPLOYEES.NAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "NAME";
            // 
            // MechanicsBindSrc
            // 
            this.MechanicsBindSrc.DataSource = typeof(AutoPartDataModels.EMPLOYEES_SERVICE_WORKS);
            // 
            // colSERVICES
            // 
            this.colSERVICES.Caption = "Услуга";
            this.colSERVICES.FieldName = "SERVICES.SERVICE_NAME";
            this.colSERVICES.Name = "colSERVICES";
            this.colSERVICES.OptionsColumn.AllowEdit = false;
            this.colSERVICES.Visible = true;
            this.colSERVICES.VisibleIndex = 0;
            // 
            // colSERVICE_WORK_PARTS
            // 
            this.colSERVICE_WORK_PARTS.FieldName = "SERVICE_WORK_PARTS";
            this.colSERVICE_WORK_PARTS.Name = "colSERVICE_WORK_PARTS";
            // 
            // colAPPOITMENTS1
            // 
            this.colAPPOITMENTS1.Caption = "Модел";
            this.colAPPOITMENTS1.FieldName = "APPOITMENTS.CLIENT_CARS.Models.MODEL_NAME";
            this.colAPPOITMENTS1.Name = "colAPPOITMENTS1";
            this.colAPPOITMENTS1.OptionsColumn.AllowEdit = false;
            this.colAPPOITMENTS1.Visible = true;
            this.colAPPOITMENTS1.VisibleIndex = 2;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.MechanicsBindSrc;
            this.repositoryItemLookUpEdit2.DisplayMember = "NAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "NAME";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.DataSource = this.MechanicsBindSrc;
            this.repositoryItemCheckedComboBoxEdit1.DisplayMember = "NAME";
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            this.repositoryItemCheckedComboBoxEdit1.ValueMember = "EMPLOYEE_ID";
            // 
            // pnlSearchMenu
            // 
            this.pnlSearchMenu.Controls.Add(this.btnSave);
            this.pnlSearchMenu.Controls.Add(this.btnRefresh);
            this.pnlSearchMenu.Controls.Add(this.LookUpStatus);
            this.pnlSearchMenu.Controls.Add(this.lblStatus);
            this.pnlSearchMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchMenu.Name = "pnlSearchMenu";
            this.pnlSearchMenu.Size = new System.Drawing.Size(735, 37);
            this.pnlSearchMenu.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(648, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Запази";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(164, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Зареди";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LookUpStatus
            // 
            this.LookUpStatus.Location = new System.Drawing.Point(58, 9);
            this.LookUpStatus.Name = "LookUpStatus";
            this.LookUpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_NAME", "Статус", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookUpStatus.Properties.DataSource = this.WorkStatusBindingSrc;
            this.LookUpStatus.Properties.DisplayMember = "ITEM_NAME";
            this.LookUpStatus.Properties.ValueMember = "ITEM_CODE";
            this.LookUpStatus.Size = new System.Drawing.Size(100, 20);
            this.LookUpStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Статус:";
            // 
            // FormAllServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 393);
            this.Controls.Add(this.sERVICE_WORKSGridControl);
            this.Controls.Add(this.pnlSearchMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllServices";
            this.Text = "FormAllServices";
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkStatusBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchMenu)).EndInit();
            this.pnlSearchMenu.ResumeLayout(false);
            this.pnlSearchMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sERVICE_WORKSBindingSource;
        private DevExpress.XtraGrid.GridControl sERVICE_WORKSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_WORK_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPOITMENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colTIME_START;
        private DevExpress.XtraGrid.Columns.GridColumn colTIME_FINISH;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPOITMENTS;
        private DevExpress.XtraGrid.Columns.GridColumn colLOOKUP_ITEMS;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEES_SERVICE_WORKS;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICES;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_WORK_PARTS;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPOITMENTS1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource WorkStatusBindingSrc;
        private DevExpress.XtraEditors.PanelControl pnlSearchMenu;
        private DevExpress.XtraEditors.LookUpEdit LookUpStatus;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private System.Windows.Forms.BindingSource MechanicsBindSrc;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}