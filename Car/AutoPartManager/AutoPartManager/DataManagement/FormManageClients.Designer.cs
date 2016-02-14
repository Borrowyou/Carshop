namespace DataManagement
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
            this.pnlClientsGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCtrlClients = new DevExpress.XtraGrid.GridControl();
            this.ClientsDSet = new DataManagement.ClientsDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDETAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.pnlClientsFrame = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlClientsGrid)).BeginInit();
            this.pnlClientsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlClientsFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientsGrid
            // 
            this.pnlClientsGrid.Controls.Add(this.gridCtrlClients);
            this.pnlClientsGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlClientsGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlClientsGrid.Name = "pnlClientsGrid";
            this.pnlClientsGrid.Size = new System.Drawing.Size(296, 262);
            this.pnlClientsGrid.TabIndex = 0;
            // 
            // gridCtrlClients
            // 
            this.gridCtrlClients.DataMember = "Clients";
            this.gridCtrlClients.DataSource = this.ClientsDSet;
            this.gridCtrlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlClients.Location = new System.Drawing.Point(2, 2);
            this.gridCtrlClients.MainView = this.gridView1;
            this.gridCtrlClients.Name = "gridCtrlClients";
            this.gridCtrlClients.Size = new System.Drawing.Size(292, 258);
            this.gridCtrlClients.TabIndex = 0;
            this.gridCtrlClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ClientsDSet
            // 
            this.ClientsDSet.ClientTbAdapter = null;
            this.ClientsDSet.DataSetName = "ClientsDataSet";
            this.ClientsDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCLIENT_ID,
            this.colCLIENT_NAME,
            this.colCLIENT_FORM,
            this.colCOMPANY,
            this.colTELEPHONE,
            this.colEMAIL,
            this.colDETAILS});
            this.gridView1.GridControl = this.gridCtrlClients;
            this.gridView1.Name = "gridView1";
            // 
            // colCLIENT_ID
            // 
            this.colCLIENT_ID.FieldName = "CLIENT_ID";
            this.colCLIENT_ID.Name = "colCLIENT_ID";
            this.colCLIENT_ID.Visible = true;
            this.colCLIENT_ID.VisibleIndex = 0;
            // 
            // colCLIENT_NAME
            // 
            this.colCLIENT_NAME.FieldName = "CLIENT_NAME";
            this.colCLIENT_NAME.Name = "colCLIENT_NAME";
            this.colCLIENT_NAME.Visible = true;
            this.colCLIENT_NAME.VisibleIndex = 1;
            // 
            // colCLIENT_FORM
            // 
            this.colCLIENT_FORM.FieldName = "CLIENT_FORM";
            this.colCLIENT_FORM.Name = "colCLIENT_FORM";
            this.colCLIENT_FORM.Visible = true;
            this.colCLIENT_FORM.VisibleIndex = 2;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.Visible = true;
            this.colCOMPANY.VisibleIndex = 3;
            // 
            // colTELEPHONE
            // 
            this.colTELEPHONE.FieldName = "TELEPHONE";
            this.colTELEPHONE.Name = "colTELEPHONE";
            this.colTELEPHONE.Visible = true;
            this.colTELEPHONE.VisibleIndex = 4;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 5;
            // 
            // colDETAILS
            // 
            this.colDETAILS.FieldName = "DETAILS";
            this.colDETAILS.Name = "colDETAILS";
            this.colDETAILS.Visible = true;
            this.colDETAILS.VisibleIndex = 6;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(296, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 262);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(301, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(197, 32);
            this.pnlButtons.TabIndex = 2;
            // 
            // pnlClientsFrame
            // 
            this.pnlClientsFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientsFrame.Location = new System.Drawing.Point(301, 32);
            this.pnlClientsFrame.Name = "pnlClientsFrame";
            this.pnlClientsFrame.Size = new System.Drawing.Size(197, 230);
            this.pnlClientsFrame.TabIndex = 3;
            // 
            // FormManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 262);
            this.Controls.Add(this.pnlClientsFrame);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.pnlClientsGrid);
            this.Name = "FormManageClients";
            this.Text = "FormManageClients";
            ((System.ComponentModel.ISupportInitialize)(this.pnlClientsGrid)).EndInit();
            this.pnlClientsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlClientsFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlClientsGrid;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl pnlButtons;
        private DevExpress.XtraEditors.PanelControl pnlClientsFrame;
        private DevExpress.XtraGrid.GridControl gridCtrlClients;
        private ClientsDataSet ClientsDSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_FORM;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDETAILS;
    }
}