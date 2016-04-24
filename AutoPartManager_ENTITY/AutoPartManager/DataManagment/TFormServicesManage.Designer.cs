namespace DataManagment
{
    partial class TFormServicesManage
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
            this.sERVICEBindingSource = new System.Windows.Forms.BindingSource();
            this.sERVICEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSERVICE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRICE_PER_HOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PnlMenuBtns = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewService = new DevExpress.XtraEditors.SimpleButton();
            this.pnlGridHolder = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMenuBtns)).BeginInit();
            this.PnlMenuBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridHolder)).BeginInit();
            this.pnlGridHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // sERVICEGridControl
            // 
            this.sERVICEGridControl.DataSource = this.sERVICEBindingSource;
            this.sERVICEGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sERVICEGridControl.Location = new System.Drawing.Point(2, 2);
            this.sERVICEGridControl.MainView = this.gridViewServices;
            this.sERVICEGridControl.Name = "sERVICEGridControl";
            this.sERVICEGridControl.Size = new System.Drawing.Size(647, 334);
            this.sERVICEGridControl.TabIndex = 0;
            this.sERVICEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServices});
            // 
            // gridViewServices
            // 
            this.gridViewServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSERVICE_ID,
            this.colSERVICE_NAME,
            this.colPRICE_PER_HOUR,
            this.colDESCRIPTION});
            this.gridViewServices.GridControl = this.sERVICEGridControl;
            this.gridViewServices.Name = "gridViewServices";
            this.gridViewServices.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewServices.OptionsCustomization.AllowRowSizing = true;
            this.gridViewServices.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewServices.OptionsView.ShowGroupPanel = false;
            // 
            // colSERVICE_ID
            // 
            this.colSERVICE_ID.FieldName = "SERVICE_ID";
            this.colSERVICE_ID.Name = "colSERVICE_ID";
            // 
            // colSERVICE_NAME
            // 
            this.colSERVICE_NAME.Caption = "Услуга";
            this.colSERVICE_NAME.FieldName = "SERVICE_NAME";
            this.colSERVICE_NAME.Name = "colSERVICE_NAME";
            this.colSERVICE_NAME.Visible = true;
            this.colSERVICE_NAME.VisibleIndex = 0;
            // 
            // colPRICE_PER_HOUR
            // 
            this.colPRICE_PER_HOUR.Caption = "Ориентировъчна цена";
            this.colPRICE_PER_HOUR.FieldName = "PRICE_PER_HOUR";
            this.colPRICE_PER_HOUR.Name = "colPRICE_PER_HOUR";
            this.colPRICE_PER_HOUR.Visible = true;
            this.colPRICE_PER_HOUR.VisibleIndex = 1;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "Описание";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 2;
            // 
            // PnlMenuBtns
            // 
            this.PnlMenuBtns.Controls.Add(this.btnClose);
            this.PnlMenuBtns.Controls.Add(this.btnCancel);
            this.PnlMenuBtns.Controls.Add(this.btnSave);
            this.PnlMenuBtns.Controls.Add(this.btnNewService);
            this.PnlMenuBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuBtns.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuBtns.Name = "PnlMenuBtns";
            this.PnlMenuBtns.Size = new System.Drawing.Size(88, 338);
            this.PnlMenuBtns.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Запази";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewService
            // 
            this.btnNewService.Location = new System.Drawing.Point(5, 12);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(77, 23);
            this.btnNewService.TabIndex = 1;
            this.btnNewService.Text = "Нов Запис";
            this.btnNewService.Click += new System.EventHandler(this.btnNewService_Click);
            // 
            // pnlGridHolder
            // 
            this.pnlGridHolder.Controls.Add(this.sERVICEGridControl);
            this.pnlGridHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridHolder.Location = new System.Drawing.Point(88, 0);
            this.pnlGridHolder.Name = "pnlGridHolder";
            this.pnlGridHolder.Size = new System.Drawing.Size(651, 338);
            this.pnlGridHolder.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(5, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(5, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Затвори";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TFormServicesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 338);
            this.Controls.Add(this.pnlGridHolder);
            this.Controls.Add(this.PnlMenuBtns);
            this.Name = "TFormServicesManage";
            this.Text = "TFormServicesManage";
            this.Load += new System.EventHandler(this.TFormServicesManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMenuBtns)).EndInit();
            this.PnlMenuBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridHolder)).EndInit();
            this.pnlGridHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sERVICEBindingSource;
        private DevExpress.XtraGrid.GridControl sERVICEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewServices;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPRICE_PER_HOUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraEditors.PanelControl PnlMenuBtns;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNewService;
        private DevExpress.XtraEditors.PanelControl pnlGridHolder;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}