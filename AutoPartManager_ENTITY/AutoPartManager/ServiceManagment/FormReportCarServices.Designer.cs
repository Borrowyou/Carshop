namespace ServiceManagment
{
    partial class FormReportCarServices
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
            this.pnl = new DevExpress.XtraEditors.PanelControl();
            this.gridCarRepairs = new DevExpress.XtraGrid.GridControl();
            this.gridViewCarRepairs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ServiceWorksBindingSrc = new System.Windows.Forms.BindingSource();
            this.colSERVICE_WORK_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIME_START = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIME_FINISH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOOKUP_ITEMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPLOYEES_SERVICE_WORKS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_WORK_PARTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClientsBindSrc = new System.Windows.Forms.BindingSource();
            this.lblCarSrch = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnFindClCar = new DevExpress.XtraEditors.SimpleButton();
            this.ClCarBindSrc = new System.Windows.Forms.BindingSource();
            this.CarSrchBindingSrc = new System.Windows.Forms.BindingSource();
            this.colCAR_REG_NUMB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAR_YEAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOOKUP_ITEMS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModels = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarRepairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarRepairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceWorksBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClCarBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSrchBindingSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnFindClCar);
            this.pnl.Controls.Add(this.searchLookUpEdit2);
            this.pnl.Controls.Add(this.lblCarSrch);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(690, 57);
            this.pnl.TabIndex = 0;
            // 
            // gridCarRepairs
            // 
            this.gridCarRepairs.DataSource = this.ServiceWorksBindingSrc;
            this.gridCarRepairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCarRepairs.Location = new System.Drawing.Point(0, 57);
            this.gridCarRepairs.MainView = this.gridViewCarRepairs;
            this.gridCarRepairs.Name = "gridCarRepairs";
            this.gridCarRepairs.Size = new System.Drawing.Size(690, 309);
            this.gridCarRepairs.TabIndex = 1;
            this.gridCarRepairs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCarRepairs});
            // 
            // gridViewCarRepairs
            // 
            this.gridViewCarRepairs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colSERVICE_WORK_PARTS});
            this.gridViewCarRepairs.GridControl = this.gridCarRepairs;
            this.gridViewCarRepairs.Name = "gridViewCarRepairs";
            this.gridViewCarRepairs.OptionsBehavior.Editable = false;
            this.gridViewCarRepairs.OptionsView.ShowGroupPanel = false;
            this.gridViewCarRepairs.DoubleClick += new System.EventHandler(this.gridViewCarRepairs_DoubleClick);
            // 
            // ServiceWorksBindingSrc
            // 
            this.ServiceWorksBindingSrc.DataSource = typeof(AutoPartDataModels.SERVICE_WORKS);
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
            this.colWORK_STATUS.FieldName = "WORK_STATUS";
            this.colWORK_STATUS.Name = "colWORK_STATUS";
            // 
            // colTIME_START
            // 
            this.colTIME_START.Caption = "Започване";
            this.colTIME_START.FieldName = "TIME_START";
            this.colTIME_START.Name = "colTIME_START";
            this.colTIME_START.Visible = true;
            this.colTIME_START.VisibleIndex = 1;
            // 
            // colTIME_FINISH
            // 
            this.colTIME_FINISH.Caption = "Приключен";
            this.colTIME_FINISH.FieldName = "TIME_FINISH";
            this.colTIME_FINISH.Name = "colTIME_FINISH";
            this.colTIME_FINISH.Visible = true;
            this.colTIME_FINISH.VisibleIndex = 2;
            // 
            // colWORK_PRICE
            // 
            this.colWORK_PRICE.Caption = "Цена";
            this.colWORK_PRICE.FieldName = "WORK_PRICE";
            this.colWORK_PRICE.Name = "colWORK_PRICE";
            this.colWORK_PRICE.Visible = true;
            this.colWORK_PRICE.VisibleIndex = 3;
            // 
            // colSERVICE_ID
            // 
            this.colSERVICE_ID.FieldName = "SERVICE_ID";
            this.colSERVICE_ID.Name = "colSERVICE_ID";
            // 
            // colAPPOITMENTS
            // 
            this.colAPPOITMENTS.FieldName = "APPOITMENTS";
            this.colAPPOITMENTS.Name = "colAPPOITMENTS";
            // 
            // colLOOKUP_ITEMS
            // 
            this.colLOOKUP_ITEMS.FieldName = "LOOKUP_ITEMS";
            this.colLOOKUP_ITEMS.Name = "colLOOKUP_ITEMS";
            // 
            // colEMPLOYEES_SERVICE_WORKS
            // 
            this.colEMPLOYEES_SERVICE_WORKS.FieldName = "EMPLOYEES_SERVICE_WORKS";
            this.colEMPLOYEES_SERVICE_WORKS.Name = "colEMPLOYEES_SERVICE_WORKS";
            // 
            // colSERVICES
            // 
            this.colSERVICES.Caption = "Услуга";
            this.colSERVICES.FieldName = "SERVICES.SERVICE_NAME";
            this.colSERVICES.Name = "colSERVICES";
            this.colSERVICES.Visible = true;
            this.colSERVICES.VisibleIndex = 0;
            // 
            // colSERVICE_WORK_PARTS
            // 
            this.colSERVICE_WORK_PARTS.FieldName = "SERVICE_WORK_PARTS";
            this.colSERVICE_WORK_PARTS.Name = "colSERVICE_WORK_PARTS";
            // 
            // ClientsBindSrc
            // 
            this.ClientsBindSrc.DataSource = typeof(AutoPartDataModels.Clients);
            // 
            // lblCarSrch
            // 
            this.lblCarSrch.Location = new System.Drawing.Point(10, 20);
            this.lblCarSrch.Name = "lblCarSrch";
            this.lblCarSrch.Size = new System.Drawing.Size(29, 13);
            this.lblCarSrch.TabIndex = 0;
            this.lblCarSrch.Text = "Кола:";
            // 
            // searchLookUpEdit2
            // 
            this.searchLookUpEdit2.Location = new System.Drawing.Point(45, 17);
            this.searchLookUpEdit2.Name = "searchLookUpEdit2";
            this.searchLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit2.Properties.DataSource = this.CarSrchBindingSrc;
            this.searchLookUpEdit2.Properties.DisplayMember = "Models.MODEL_NAME";
            this.searchLookUpEdit2.Properties.ValueMember = "CLIENT_CAR_ID";
            this.searchLookUpEdit2.Properties.View = this.searchLookUpEdit2View;
            this.searchLookUpEdit2.Size = new System.Drawing.Size(313, 20);
            this.searchLookUpEdit2.TabIndex = 1;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAR_REG_NUMB,
            this.colModels,
            this.colCAR_YEAR,
            this.colLOOKUP_ITEMS1});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // btnFindClCar
            // 
            this.btnFindClCar.Location = new System.Drawing.Point(379, 15);
            this.btnFindClCar.Name = "btnFindClCar";
            this.btnFindClCar.Size = new System.Drawing.Size(75, 23);
            this.btnFindClCar.TabIndex = 2;
            this.btnFindClCar.Text = "Намери";
            this.btnFindClCar.Click += new System.EventHandler(this.btnFindClCar_Click);
            // 
            // ClCarBindSrc
            // 
            this.ClCarBindSrc.DataSource = typeof(AutoPartDataModels.CLIENT_CARS);
            // 
            // CarSrchBindingSrc
            // 
            this.CarSrchBindingSrc.DataSource = typeof(AutoPartDataModels.CLIENT_CARS);
            // 
            // colCAR_REG_NUMB
            // 
            this.colCAR_REG_NUMB.Caption = "Рег. номер";
            this.colCAR_REG_NUMB.FieldName = "CAR_REG_NUMB";
            this.colCAR_REG_NUMB.Name = "colCAR_REG_NUMB";
            this.colCAR_REG_NUMB.Visible = true;
            this.colCAR_REG_NUMB.VisibleIndex = 0;
            // 
            // colCAR_YEAR
            // 
            this.colCAR_YEAR.Caption = "Година";
            this.colCAR_YEAR.FieldName = "CAR_YEAR";
            this.colCAR_YEAR.Name = "colCAR_YEAR";
            this.colCAR_YEAR.Visible = true;
            this.colCAR_YEAR.VisibleIndex = 1;
            // 
            // colLOOKUP_ITEMS1
            // 
            this.colLOOKUP_ITEMS1.Caption = "Двигател";
            this.colLOOKUP_ITEMS1.FieldName = "LOOKUP_ITEMS.ITEM_NAME";
            this.colLOOKUP_ITEMS1.Name = "colLOOKUP_ITEMS1";
            this.colLOOKUP_ITEMS1.Visible = true;
            this.colLOOKUP_ITEMS1.VisibleIndex = 2;
            // 
            // colModels
            // 
            this.colModels.Caption = "Модел";
            this.colModels.FieldName = "Models.MODEL_NAME";
            this.colModels.Name = "colModels";
            this.colModels.Visible = true;
            this.colModels.VisibleIndex = 3;
            // 
            // FormReportCarServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.gridCarRepairs);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportCarServices";
            this.Text = "Спарвки за ремотни на коли";
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarRepairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarRepairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceWorksBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClCarBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSrchBindingSrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnl;
        private DevExpress.XtraGrid.GridControl gridCarRepairs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCarRepairs;
        private System.Windows.Forms.BindingSource ServiceWorksBindingSrc;
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
        private DevExpress.XtraEditors.SimpleButton btnFindClCar;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.LabelControl lblCarSrch;
        private System.Windows.Forms.BindingSource ClientsBindSrc;
        private System.Windows.Forms.BindingSource ClCarBindSrc;
        private System.Windows.Forms.BindingSource CarSrchBindingSrc;
        private DevExpress.XtraGrid.Columns.GridColumn colCAR_REG_NUMB;
        private DevExpress.XtraGrid.Columns.GridColumn colModels;
        private DevExpress.XtraGrid.Columns.GridColumn colCAR_YEAR;
        private DevExpress.XtraGrid.Columns.GridColumn colLOOKUP_ITEMS1;
    }
}