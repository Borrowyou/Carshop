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
            this.aPPOITMENTSBindingSource = new System.Windows.Forms.BindingSource();
            this.GridCtrlAppoitments = new DevExpress.XtraGrid.GridControl();
            this.gridViewAppoitments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAPPOITMENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENT_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_CAR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClients = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_WORKS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOITMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCtrlAppoitments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppoitments)).BeginInit();
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
            this.colSERVICE_WORKS});
            this.gridViewAppoitments.GridControl = this.GridCtrlAppoitments;
            this.gridViewAppoitments.Name = "gridViewAppoitments";
            // 
            // colAPPOITMENT_ID
            // 
            this.colAPPOITMENT_ID.FieldName = "APPOITMENT_ID";
            this.colAPPOITMENT_ID.Name = "colAPPOITMENT_ID";
            this.colAPPOITMENT_ID.Visible = true;
            this.colAPPOITMENT_ID.VisibleIndex = 0;
            // 
            // colAPPOITMENT_DATE
            // 
            this.colAPPOITMENT_DATE.FieldName = "APPOITMENT_DATE";
            this.colAPPOITMENT_DATE.Name = "colAPPOITMENT_DATE";
            this.colAPPOITMENT_DATE.Visible = true;
            this.colAPPOITMENT_DATE.VisibleIndex = 1;
            // 
            // colCLIENT_ID
            // 
            this.colCLIENT_ID.FieldName = "CLIENT_ID";
            this.colCLIENT_ID.Name = "colCLIENT_ID";
            this.colCLIENT_ID.Visible = true;
            this.colCLIENT_ID.VisibleIndex = 2;
            // 
            // colCLIENT_CAR_ID
            // 
            this.colCLIENT_CAR_ID.FieldName = "CLIENT_CAR_ID";
            this.colCLIENT_CAR_ID.Name = "colCLIENT_CAR_ID";
            this.colCLIENT_CAR_ID.Visible = true;
            this.colCLIENT_CAR_ID.VisibleIndex = 3;
            // 
            // colClients
            // 
            this.colClients.FieldName = "Clients";
            this.colClients.Name = "colClients";
            this.colClients.Visible = true;
            this.colClients.VisibleIndex = 4;
            // 
            // colSERVICE_WORKS
            // 
            this.colSERVICE_WORKS.FieldName = "SERVICE_WORKS";
            this.colSERVICE_WORKS.Name = "colSERVICE_WORKS";
            this.colSERVICE_WORKS.Visible = true;
            this.colSERVICE_WORKS.VisibleIndex = 5;
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
    }
}