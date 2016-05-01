namespace ServiceManagment
{
    partial class FormAllAppoitments
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
            this.aPPOITMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridCtrlAppoitments = new DevExpress.XtraGrid.GridControl();
            this.gridViewAppoitments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAPPOITMENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENT_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_CAR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClients = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_WORKS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_CARS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOITMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCtrlAppoitments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppoitments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // aPPOITMENTSBindingSource
            // 
            this.aPPOITMENTSBindingSource.DataSource = typeof(AutoPartDataModels.APPOITMENTS);
            // 
            // GridCtrlAppoitments
            // 
            this.GridCtrlAppoitments.DataSource = this.aPPOITMENTSBindingSource;
            this.GridCtrlAppoitments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCtrlAppoitments.Location = new System.Drawing.Point(0, 0);
            this.GridCtrlAppoitments.MainView = this.gridViewAppoitments;
            this.GridCtrlAppoitments.Name = "GridCtrlAppoitments";
            this.GridCtrlAppoitments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1});
            this.GridCtrlAppoitments.Size = new System.Drawing.Size(744, 336);
            this.GridCtrlAppoitments.TabIndex = 1;
            this.GridCtrlAppoitments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAppoitments});
            // 
            // gridViewAppoitments
            // 
            this.gridViewAppoitments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAPPOITMENT_ID,
            this.colAPPOITMENT_DATE,
            this.colCLIENT_ID,
            this.colCLIENT_CAR_ID,
            this.colClients,
            this.colSERVICE_WORKS,
            this.colCLIENT_CARS});
            this.gridViewAppoitments.GridControl = this.GridCtrlAppoitments;
            this.gridViewAppoitments.Name = "gridViewAppoitments";
            this.gridViewAppoitments.DoubleClick += new System.EventHandler(this.gridViewAppoitments_DoubleClick);
            // 
            // colAPPOITMENT_ID
            // 
            this.colAPPOITMENT_ID.FieldName = "APPOITMENT_ID";
            this.colAPPOITMENT_ID.Name = "colAPPOITMENT_ID";
            // 
            // colAPPOITMENT_DATE
            // 
            this.colAPPOITMENT_DATE.DisplayFormat.FormatString = "dd";
            this.colAPPOITMENT_DATE.FieldName = "APPOITMENT_DATE";
            this.colAPPOITMENT_DATE.Name = "colAPPOITMENT_DATE";
            this.colAPPOITMENT_DATE.Visible = true;
            this.colAPPOITMENT_DATE.VisibleIndex = 0;
            // 
            // colCLIENT_ID
            // 
            this.colCLIENT_ID.FieldName = "CLIENT_ID";
            this.colCLIENT_ID.Name = "colCLIENT_ID";
            // 
            // colCLIENT_CAR_ID
            // 
            this.colCLIENT_CAR_ID.FieldName = "CLIENT_CAR_ID";
            this.colCLIENT_CAR_ID.Name = "colCLIENT_CAR_ID";
            // 
            // colClients
            // 
            this.colClients.FieldName = "Clients.CLIENT_NAME";
            this.colClients.Name = "colClients";
            this.colClients.Visible = true;
            this.colClients.VisibleIndex = 1;
            // 
            // colSERVICE_WORKS
            // 
            this.colSERVICE_WORKS.FieldName = "SERVICE_WORKS";
            this.colSERVICE_WORKS.Name = "colSERVICE_WORKS";
            // 
            // colCLIENT_CARS
            // 
            this.colCLIENT_CARS.FieldName = "CLIENT_CARS.Models.MODEL_NAME";
            this.colCLIENT_CARS.Name = "colCLIENT_CARS";
            this.colCLIENT_CARS.Visible = true;
            this.colCLIENT_CARS.VisibleIndex = 3;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FormAllAppoitments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 336);
            this.Controls.Add(this.GridCtrlAppoitments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllAppoitments";
            this.Text = "FormAllAppoitments";
            this.Load += new System.EventHandler(this.FormAllAppoitments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aPPOITMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCtrlAppoitments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppoitments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource aPPOITMENTSBindingSource;
        private DevExpress.XtraGrid.GridControl GridCtrlAppoitments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAppoitments;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPOITMENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPOITMENT_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_CAR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colClients;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_WORKS;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_CARS;
    }
}