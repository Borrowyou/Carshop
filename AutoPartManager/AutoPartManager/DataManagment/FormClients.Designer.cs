﻿namespace DataManagment
{
    partial class FormClients
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
            this.pnlFrameClients = new System.Windows.Forms.Panel();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.gridClients = new DevExpress.XtraGrid.GridControl();
            this.AllClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDataSet = new DataManagment.ClientsDataSet();
            this.gridViewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDETAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFrameClients
            // 
            this.pnlFrameClients.AutoScroll = true;
            this.pnlFrameClients.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFrameClients.Location = new System.Drawing.Point(446, 0);
            this.pnlFrameClients.MinimumSize = new System.Drawing.Size(330, 340);
            this.pnlFrameClients.Name = "pnlFrameClients";
            this.pnlFrameClients.Size = new System.Drawing.Size(330, 340);
            this.pnlFrameClients.TabIndex = 0;
            // 
            // pnlClients
            // 
            this.pnlClients.Controls.Add(this.gridClients);
            this.pnlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClients.Location = new System.Drawing.Point(0, 0);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(446, 294);
            this.pnlClients.TabIndex = 1;
            // 
            // gridClients
            // 
            this.gridClients.DataSource = this.AllClientsBindingSource;
            this.gridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClients.Location = new System.Drawing.Point(0, 0);
            this.gridClients.MainView = this.gridViewClients;
            this.gridClients.Name = "gridClients";
            this.gridClients.Size = new System.Drawing.Size(446, 294);
            this.gridClients.TabIndex = 0;
            this.gridClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClients});
            // 
            // AllClientsBindingSource
            // 
            this.AllClientsBindingSource.DataMember = "Clients";
            this.AllClientsBindingSource.DataSource = this.clientsDataSet;
            this.AllClientsBindingSource.PositionChanged += new System.EventHandler(this.AllClientsBindingSource_PositionChanged);
            // 
            // clientsDataSet
            // 
            this.clientsDataSet.DataSetName = "ClientsDataSet";
            this.clientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewClients
            // 
            this.gridViewClients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCLIENT_ID,
            this.colCLIENT_NAME,
            this.colCLIENT_FORM,
            this.colCOMPANY,
            this.colTELEPHONE,
            this.colEMAIL,
            this.colDETAILS});
            this.gridViewClients.GridControl = this.gridClients;
            this.gridViewClients.Name = "gridViewClients";
            this.gridViewClients.OptionsBehavior.Editable = false;
            this.gridViewClients.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridViewClients.OptionsView.ShowGroupPanel = false;
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
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(443, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 294);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 294);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlClients);
            this.Controls.Add(this.pnlFrameClients);
            this.Name = "FormClients";
            this.Text = "FormManageClients";
            this.Load += new System.EventHandler(this.FormManageClients_Load);
            this.pnlClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrameClients;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.Splitter splitter1;
        private ClientsDataSet clientsDataSet;
        private DevExpress.XtraGrid.GridControl gridClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClients;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_FORM;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDETAILS;
        private System.Windows.Forms.BindingSource AllClientsBindingSource;


    }
}