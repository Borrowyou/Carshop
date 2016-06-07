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
            this.btnFindClCar = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.CarSrchBindingSrc = new System.Windows.Forms.BindingSource();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAR_REG_NUMB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAR_YEAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOOKUP_ITEMS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCarSrch = new DevExpress.XtraEditors.LabelControl();
            this.ServiceWorksBindingSrc = new System.Windows.Forms.BindingSource();
            this.ClientsBindSrc = new System.Windows.Forms.BindingSource();
            this.ClCarBindSrc = new System.Windows.Forms.BindingSource();
            this.gridViewCarRepairs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAPPOITMENT_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAR_MILEAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClients = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPLAINS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCarRepairs = new DevExpress.XtraGrid.GridControl();
            this.colRAMPH_NUMB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENGINE_NUMB = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSrchBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceWorksBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClCarBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarRepairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarRepairs)).BeginInit();
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
            // btnFindClCar
            // 
            this.btnFindClCar.Location = new System.Drawing.Point(379, 15);
            this.btnFindClCar.Name = "btnFindClCar";
            this.btnFindClCar.Size = new System.Drawing.Size(75, 23);
            this.btnFindClCar.TabIndex = 2;
            this.btnFindClCar.Text = "Намери";
            this.btnFindClCar.Click += new System.EventHandler(this.btnFindClCar_Click);
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
            this.searchLookUpEdit2.EditValueChanged += new System.EventHandler(this.searchLookUpEdit2_EditValueChanged);
            // 
            // CarSrchBindingSrc
            // 
            this.CarSrchBindingSrc.DataSource = typeof(AutoPartDataModels.CLIENT_CARS);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAR_REG_NUMB,
            this.colModels,
            this.colCAR_YEAR,
            this.colLOOKUP_ITEMS1,
            this.colRAMPH_NUMB,
            this.colENGINE_NUMB});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colCAR_REG_NUMB
            // 
            this.colCAR_REG_NUMB.Caption = "Рег. номер";
            this.colCAR_REG_NUMB.FieldName = "CAR_REG_NUMB";
            this.colCAR_REG_NUMB.Name = "colCAR_REG_NUMB";
            this.colCAR_REG_NUMB.Visible = true;
            this.colCAR_REG_NUMB.VisibleIndex = 0;
            // 
            // colModels
            // 
            this.colModels.Caption = "Модел";
            this.colModels.FieldName = "Models.MODEL_NAME";
            this.colModels.Name = "colModels";
            this.colModels.Visible = true;
            this.colModels.VisibleIndex = 3;
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
            // lblCarSrch
            // 
            this.lblCarSrch.Location = new System.Drawing.Point(10, 20);
            this.lblCarSrch.Name = "lblCarSrch";
            this.lblCarSrch.Size = new System.Drawing.Size(29, 13);
            this.lblCarSrch.TabIndex = 0;
            this.lblCarSrch.Text = "Кола:";
            // 
            // ServiceWorksBindingSrc
            // 
            this.ServiceWorksBindingSrc.DataSource = typeof(AutoPartDataModels.APPOITMENTS);
            // 
            // ClientsBindSrc
            // 
            this.ClientsBindSrc.DataSource = typeof(AutoPartDataModels.Clients);
            // 
            // ClCarBindSrc
            // 
            this.ClCarBindSrc.DataSource = typeof(AutoPartDataModels.CLIENT_CARS);
            // 
            // gridViewCarRepairs
            // 
            this.gridViewCarRepairs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAPPOITMENT_DATE,
            this.colCAR_MILEAGE,
            this.colClients,
            this.colCOMPLAINS});
            this.gridViewCarRepairs.GridControl = this.gridCarRepairs;
            this.gridViewCarRepairs.Name = "gridViewCarRepairs";
            this.gridViewCarRepairs.OptionsBehavior.Editable = false;
            this.gridViewCarRepairs.OptionsView.ShowGroupPanel = false;
            this.gridViewCarRepairs.DoubleClick += new System.EventHandler(this.gridViewCarRepairs_DoubleClick);
            // 
            // colAPPOITMENT_DATE
            // 
            this.colAPPOITMENT_DATE.Caption = "Дата";
            this.colAPPOITMENT_DATE.FieldName = "APPOITMENT_DATE";
            this.colAPPOITMENT_DATE.Name = "colAPPOITMENT_DATE";
            this.colAPPOITMENT_DATE.Visible = true;
            this.colAPPOITMENT_DATE.VisibleIndex = 0;
            this.colAPPOITMENT_DATE.Width = 76;
            // 
            // colCAR_MILEAGE
            // 
            this.colCAR_MILEAGE.Caption = "Километраж";
            this.colCAR_MILEAGE.FieldName = "CAR_MILEAGE";
            this.colCAR_MILEAGE.Name = "colCAR_MILEAGE";
            this.colCAR_MILEAGE.Visible = true;
            this.colCAR_MILEAGE.VisibleIndex = 1;
            this.colCAR_MILEAGE.Width = 71;
            // 
            // colClients
            // 
            this.colClients.Caption = "Клиент";
            this.colClients.FieldName = "Clients.CLIENT_NAME";
            this.colClients.Name = "colClients";
            this.colClients.Visible = true;
            this.colClients.VisibleIndex = 2;
            this.colClients.Width = 124;
            // 
            // colCOMPLAINS
            // 
            this.colCOMPLAINS.Caption = "Оплакване";
            this.colCOMPLAINS.FieldName = "COMPLAINS";
            this.colCOMPLAINS.Name = "colCOMPLAINS";
            this.colCOMPLAINS.Visible = true;
            this.colCOMPLAINS.VisibleIndex = 3;
            this.colCOMPLAINS.Width = 401;
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
            // colRAMPH_NUMB
            // 
            this.colRAMPH_NUMB.Caption = "Ном. Рама";
            this.colRAMPH_NUMB.FieldName = "RAMPH_NUMB";
            this.colRAMPH_NUMB.Name = "colRAMPH_NUMB";
            this.colRAMPH_NUMB.Visible = true;
            this.colRAMPH_NUMB.VisibleIndex = 4;
            // 
            // colENGINE_NUMB
            // 
            this.colENGINE_NUMB.Caption = "Ном. Двиг.";
            this.colENGINE_NUMB.FieldName = "ENGINE_NUMB";
            this.colENGINE_NUMB.Name = "colENGINE_NUMB";
            this.colENGINE_NUMB.Visible = true;
            this.colENGINE_NUMB.VisibleIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarSrchBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceWorksBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClCarBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarRepairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarRepairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnl;
        private System.Windows.Forms.BindingSource ServiceWorksBindingSrc;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCarRepairs;
        private DevExpress.XtraGrid.GridControl gridCarRepairs;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPOITMENT_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCAR_MILEAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colClients;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPLAINS;
        private DevExpress.XtraGrid.Columns.GridColumn colRAMPH_NUMB;
        private DevExpress.XtraGrid.Columns.GridColumn colENGINE_NUMB;
    }
}