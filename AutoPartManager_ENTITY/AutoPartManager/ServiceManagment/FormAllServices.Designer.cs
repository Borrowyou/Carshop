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
            this.components = new System.ComponentModel.Container();
            this.sERVICE_WORKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICE_WORKSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colAPPOITMENTS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.WorkStatusBindingSrc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkStatusBindingSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // sERVICE_WORKSBindingSource
            // 
            this.sERVICE_WORKSBindingSource.DataSource = typeof(AutoPartDataModels.SERVICE_WORKS);
            // 
            // sERVICE_WORKSGridControl
            // 
            this.sERVICE_WORKSGridControl.DataSource = this.sERVICE_WORKSBindingSource;
            this.sERVICE_WORKSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sERVICE_WORKSGridControl.Location = new System.Drawing.Point(0, 0);
            this.sERVICE_WORKSGridControl.MainView = this.gridView1;
            this.sERVICE_WORKSGridControl.Name = "sERVICE_WORKSGridControl";
            this.sERVICE_WORKSGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.sERVICE_WORKSGridControl.Size = new System.Drawing.Size(735, 393);
            this.sERVICE_WORKSGridControl.TabIndex = 1;
            this.sERVICE_WORKSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colWORK_STATUS.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colWORK_STATUS.FieldName = "WORK_STATUS";
            this.colWORK_STATUS.Name = "colWORK_STATUS";
            this.colWORK_STATUS.Visible = true;
            this.colWORK_STATUS.VisibleIndex = 3;
            // 
            // colTIME_START
            // 
            this.colTIME_START.FieldName = "TIME_START";
            this.colTIME_START.Name = "colTIME_START";
            this.colTIME_START.Visible = true;
            this.colTIME_START.VisibleIndex = 4;
            // 
            // colTIME_FINISH
            // 
            this.colTIME_FINISH.FieldName = "TIME_FINISH";
            this.colTIME_FINISH.Name = "colTIME_FINISH";
            this.colTIME_FINISH.Visible = true;
            this.colTIME_FINISH.VisibleIndex = 5;
            // 
            // colWORK_PRICE
            // 
            this.colWORK_PRICE.FieldName = "WORK_PRICE";
            this.colWORK_PRICE.Name = "colWORK_PRICE";
            this.colWORK_PRICE.Visible = true;
            this.colWORK_PRICE.VisibleIndex = 6;
            // 
            // colSERVICE_ID
            // 
            this.colSERVICE_ID.FieldName = "SERVICE_ID";
            this.colSERVICE_ID.Name = "colSERVICE_ID";
            // 
            // colAPPOITMENTS
            // 
            this.colAPPOITMENTS.FieldName = "APPOITMENTS.Clients.CLIENT_NAME";
            this.colAPPOITMENTS.Name = "colAPPOITMENTS";
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
            this.colEMPLOYEES_SERVICE_WORKS.FieldName = "EMPLOYEES_SERVICE_WORKS";
            this.colEMPLOYEES_SERVICE_WORKS.Name = "colEMPLOYEES_SERVICE_WORKS";
            // 
            // colSERVICES
            // 
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
            // colAPPOITMENTS1
            // 
            this.colAPPOITMENTS1.FieldName = "APPOITMENTS.CLIENT_CARS.Models.MODEL_NAME";
            this.colAPPOITMENTS1.Name = "colAPPOITMENTS1";
            this.colAPPOITMENTS1.Visible = true;
            this.colAPPOITMENTS1.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.WorkStatusBindingSrc;
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEM_NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEM_CODE";
            // 
            // WorkStatusBindingSrc
            // 
            this.WorkStatusBindingSrc.DataSource = typeof(AutoPartDataModels.LOOKUP_ITEMS);
            // 
            // FormAllServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 393);
            this.Controls.Add(this.sERVICE_WORKSGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllServices";
            this.Text = "FormAllServices";
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkStatusBindingSrc)).EndInit();
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
    }
}