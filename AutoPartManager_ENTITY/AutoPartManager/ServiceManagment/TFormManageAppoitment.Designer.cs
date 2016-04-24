namespace ServiceManagment
{
    partial class TFormManageAppoitment
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
            this.lblClient = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.aPPOITMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDETAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPOITMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_CARS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFindClient = new DevExpress.XtraEditors.SimpleButton();
            this.SrchClientCar = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cLIENT_CARSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCLIENT_CAR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODEL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAR_YEAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENGINE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENGINE_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClients = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.AppTime = new DevExpress.XtraEditors.TimeEdit();
            this.AppntDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlApptment = new DevExpress.XtraEditors.PanelControl();
            this.btnAddServiceWork = new DevExpress.XtraEditors.SimpleButton();
            this.sERVICE_WORKSGridControl = new DevExpress.XtraGrid.GridControl();
            this.sERVICE_WORKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOITMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchClientCar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_CARSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlApptment)).BeginInit();
            this.pnlApptment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(25, 22);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(37, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Клиент";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aPPOITMENTBindingSource, "CLIENT_ID", true));
            this.gridLookUpEdit1.Location = new System.Drawing.Point(100, 19);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.clientBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "CLIENT_NAME";
            this.gridLookUpEdit1.Properties.ValueMember = "CLIENT_ID";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(238, 20);
            this.gridLookUpEdit1.TabIndex = 1;
            // 
            // aPPOITMENTBindingSource
            // 
            this.aPPOITMENTBindingSource.DataSource = typeof(ServiceManagment.APPOITMENTS);
            this.aPPOITMENTBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.aPPOITMENTBindingSource_AddingNew);
            this.aPPOITMENTBindingSource.CurrentItemChanged += new System.EventHandler(this.aPPOITMENTBindingSource_CurrentItemChanged);
            this.aPPOITMENTBindingSource.PositionChanged += new System.EventHandler(this.aPPOITMENTBindingSource_PositionChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ServiceManagment.Clients);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCLIENT_ID,
            this.colCLIENT_NAME,
            this.colCLIENT_FORM,
            this.colCOMPANY,
            this.colTELEPHONE,
            this.colEMAIL,
            this.colDETAILS,
            this.colAPPOITMENTS,
            this.colCLIENT_CARS});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            // colAPPOITMENTS
            // 
            this.colAPPOITMENTS.FieldName = "APPOITMENTS";
            this.colAPPOITMENTS.Name = "colAPPOITMENTS";
            this.colAPPOITMENTS.Visible = true;
            this.colAPPOITMENTS.VisibleIndex = 7;
            // 
            // colCLIENT_CARS
            // 
            this.colCLIENT_CARS.FieldName = "CLIENT_CARS";
            this.colCLIENT_CARS.Name = "colCLIENT_CARS";
            this.colCLIENT_CARS.Visible = true;
            this.colCLIENT_CARS.VisibleIndex = 8;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(353, 17);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(75, 23);
            this.btnFindClient.TabIndex = 17;
            this.btnFindClient.Text = "Нов Клиент";
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // SrchClientCar
            // 
            this.SrchClientCar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aPPOITMENTBindingSource, "CLIENT_CAR_ID", true));
            this.SrchClientCar.Location = new System.Drawing.Point(100, 123);
            this.SrchClientCar.Name = "SrchClientCar";
            this.SrchClientCar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SrchClientCar.Properties.DataSource = this.cLIENT_CARSBindingSource;
            this.SrchClientCar.Properties.DisplayMember = "Models.MODEL_NAME";
            this.SrchClientCar.Properties.ValueMember = "CLIENT_CAR_ID";
            this.SrchClientCar.Properties.View = this.gridView1;
            this.SrchClientCar.Size = new System.Drawing.Size(238, 20);
            this.SrchClientCar.TabIndex = 16;
            // 
            // cLIENT_CARSBindingSource
            // 
            this.cLIENT_CARSBindingSource.DataSource = typeof(ServiceManagment.CLIENT_CARS);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCLIENT_CAR_ID,
            this.colCLIENT_ID1,
            this.colCAR_ID,
            this.colMODEL_ID,
            this.colCAR_YEAR,
            this.colENGINE_TYPE,
            this.colENGINE_SIZE,
            this.colClients,
            this.colModels});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCLIENT_CAR_ID
            // 
            this.colCLIENT_CAR_ID.FieldName = "CLIENT_CAR_ID";
            this.colCLIENT_CAR_ID.Name = "colCLIENT_CAR_ID";
            this.colCLIENT_CAR_ID.Visible = true;
            this.colCLIENT_CAR_ID.VisibleIndex = 0;
            // 
            // colCLIENT_ID1
            // 
            this.colCLIENT_ID1.FieldName = "CLIENT_ID";
            this.colCLIENT_ID1.Name = "colCLIENT_ID1";
            this.colCLIENT_ID1.Visible = true;
            this.colCLIENT_ID1.VisibleIndex = 1;
            // 
            // colCAR_ID
            // 
            this.colCAR_ID.FieldName = "CAR_ID";
            this.colCAR_ID.Name = "colCAR_ID";
            this.colCAR_ID.Visible = true;
            this.colCAR_ID.VisibleIndex = 2;
            // 
            // colMODEL_ID
            // 
            this.colMODEL_ID.FieldName = "MODEL_ID";
            this.colMODEL_ID.Name = "colMODEL_ID";
            this.colMODEL_ID.Visible = true;
            this.colMODEL_ID.VisibleIndex = 3;
            // 
            // colCAR_YEAR
            // 
            this.colCAR_YEAR.FieldName = "CAR_YEAR";
            this.colCAR_YEAR.Name = "colCAR_YEAR";
            this.colCAR_YEAR.Visible = true;
            this.colCAR_YEAR.VisibleIndex = 4;
            // 
            // colENGINE_TYPE
            // 
            this.colENGINE_TYPE.FieldName = "ENGINE_TYPE";
            this.colENGINE_TYPE.Name = "colENGINE_TYPE";
            this.colENGINE_TYPE.Visible = true;
            this.colENGINE_TYPE.VisibleIndex = 5;
            // 
            // colENGINE_SIZE
            // 
            this.colENGINE_SIZE.FieldName = "ENGINE_SIZE";
            this.colENGINE_SIZE.Name = "colENGINE_SIZE";
            this.colENGINE_SIZE.Visible = true;
            this.colENGINE_SIZE.VisibleIndex = 6;
            // 
            // colClients
            // 
            this.colClients.FieldName = "Clients";
            this.colClients.Name = "colClients";
            this.colClients.Visible = true;
            this.colClients.VisibleIndex = 7;
            // 
            // colModels
            // 
            this.colModels.FieldName = "Models.MODEL_NAME";
            this.colModels.Name = "colModels";
            this.colModels.Visible = true;
            this.colModels.VisibleIndex = 8;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(19, 126);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(36, 13);
            this.lblCar.TabIndex = 15;
            this.lblCar.Text = "Кола:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 94);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Дата и час";
            // 
            // AppTime
            // 
            this.AppTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aPPOITMENTBindingSource, "APPOITMENT_DATE", true));
            this.AppTime.EditValue = new System.DateTime(2016, 3, 13, 0, 0, 0, 0);
            this.AppTime.Location = new System.Drawing.Point(100, 91);
            this.AppTime.Name = "AppTime";
            this.AppTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AppTime.Size = new System.Drawing.Size(238, 20);
            this.AppTime.TabIndex = 13;
            // 
            // AppntDate
            // 
            this.AppntDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aPPOITMENTBindingSource, "APPOITMENT_DATE", true));
            this.AppntDate.Location = new System.Drawing.Point(100, 56);
            this.AppntDate.Name = "AppntDate";
            this.AppntDate.Size = new System.Drawing.Size(238, 21);
            this.AppntDate.TabIndex = 12;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(19, 56);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(62, 13);
            this.lblDateTime.TabIndex = 11;
            this.lblDateTime.Text = "Дата и час";
            // 
            // pnlApptment
            // 
            this.pnlApptment.Controls.Add(this.btnSave);
            this.pnlApptment.Controls.Add(this.btnAddServiceWork);
            this.pnlApptment.Controls.Add(this.sERVICE_WORKSGridControl);
            this.pnlApptment.Controls.Add(this.lblClient);
            this.pnlApptment.Controls.Add(this.gridLookUpEdit1);
            this.pnlApptment.Controls.Add(this.lblDateTime);
            this.pnlApptment.Controls.Add(this.AppntDate);
            this.pnlApptment.Controls.Add(this.AppTime);
            this.pnlApptment.Controls.Add(this.lblTime);
            this.pnlApptment.Controls.Add(this.lblCar);
            this.pnlApptment.Controls.Add(this.SrchClientCar);
            this.pnlApptment.Controls.Add(this.btnFindClient);
            this.pnlApptment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApptment.Location = new System.Drawing.Point(0, 0);
            this.pnlApptment.Name = "pnlApptment";
            this.pnlApptment.Size = new System.Drawing.Size(1162, 462);
            this.pnlApptment.TabIndex = 19;
            // 
            // btnAddServiceWork
            // 
            this.btnAddServiceWork.Location = new System.Drawing.Point(22, 148);
            this.btnAddServiceWork.Name = "btnAddServiceWork";
            this.btnAddServiceWork.Size = new System.Drawing.Size(75, 23);
            this.btnAddServiceWork.TabIndex = 19;
            this.btnAddServiceWork.Text = "Добави";
            this.btnAddServiceWork.Click += new System.EventHandler(this.btnAddServiceWork_Click);
            // 
            // sERVICE_WORKSGridControl
            // 
            this.sERVICE_WORKSGridControl.DataSource = this.sERVICE_WORKSBindingSource;
            this.sERVICE_WORKSGridControl.Location = new System.Drawing.Point(22, 177);
            this.sERVICE_WORKSGridControl.MainView = this.gridView2;
            this.sERVICE_WORKSGridControl.Name = "sERVICE_WORKSGridControl";
            this.sERVICE_WORKSGridControl.Size = new System.Drawing.Size(406, 220);
            this.sERVICE_WORKSGridControl.TabIndex = 18;
            this.sERVICE_WORKSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sERVICE_WORKSBindingSource
            // 
            this.sERVICE_WORKSBindingSource.DataMember = "SERVICE_WORKS";
            this.sERVICE_WORKSBindingSource.DataSource = this.aPPOITMENTBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.sERVICE_WORKSGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 24);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Запази";
            this.btnSave.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TFormManageAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 462);
            this.Controls.Add(this.pnlApptment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TFormManageAppoitment";
            this.Text = "TFormManageAppoitment";
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOITMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchClientCar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_CARSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlApptment)).EndInit();
            this.pnlApptment.ResumeLayout(false);
            this.pnlApptment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_WORKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource aPPOITMENTBindingSource;
        private DevExpress.XtraEditors.LabelControl lblClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_FORM;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDETAILS;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPOITMENTS;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_CARS;
        private DevExpress.XtraEditors.SimpleButton btnFindClient;
        private DevExpress.XtraEditors.SearchLookUpEdit SrchClientCar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.TimeEdit AppTime;
        private System.Windows.Forms.DateTimePicker AppntDate;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.BindingSource cLIENT_CARSBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_CAR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODEL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCAR_YEAR;
        private DevExpress.XtraGrid.Columns.GridColumn colENGINE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colENGINE_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colClients;
        private DevExpress.XtraGrid.Columns.GridColumn colModels;
        private DevExpress.XtraEditors.PanelControl pnlApptment;
        private DevExpress.XtraEditors.SimpleButton btnAddServiceWork;
        private DevExpress.XtraGrid.GridControl sERVICE_WORKSGridControl;
        private System.Windows.Forms.BindingSource sERVICE_WORKSBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}