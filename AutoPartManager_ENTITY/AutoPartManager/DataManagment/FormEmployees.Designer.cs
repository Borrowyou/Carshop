namespace DataManagment
{
    partial class FormEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployees));
            this.pnlFrameClients = new System.Windows.Forms.Panel();
            this.pnlFormClient = new System.Windows.Forms.Panel();
            this.PnlBtns = new System.Windows.Forms.Panel();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.gridEmployyes = new DevExpress.XtraGrid.GridControl();
            this.EmployeesBindingSrc = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEMPLOYEE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPL_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDETAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_EMPLOYEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUIT_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOOKUP_ITEMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlFrameClients.SuspendLayout();
            this.PnlBtns.SuspendLayout();
            this.pnlClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFrameClients
            // 
            this.pnlFrameClients.AutoScroll = true;
            this.pnlFrameClients.Controls.Add(this.pnlFormClient);
            this.pnlFrameClients.Controls.Add(this.PnlBtns);
            this.pnlFrameClients.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFrameClients.Location = new System.Drawing.Point(446, 0);
            this.pnlFrameClients.MinimumSize = new System.Drawing.Size(330, 340);
            this.pnlFrameClients.Name = "pnlFrameClients";
            this.pnlFrameClients.Size = new System.Drawing.Size(330, 340);
            this.pnlFrameClients.TabIndex = 0;
            // 
            // pnlFormClient
            // 
            this.pnlFormClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormClient.Location = new System.Drawing.Point(0, 33);
            this.pnlFormClient.Name = "pnlFormClient";
            this.pnlFormClient.Size = new System.Drawing.Size(330, 307);
            this.pnlFormClient.TabIndex = 1;
            // 
            // PnlBtns
            // 
            this.PnlBtns.Controls.Add(this.btnNew);
            this.PnlBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtns.Location = new System.Drawing.Point(0, 0);
            this.PnlBtns.Name = "PnlBtns";
            this.PnlBtns.Size = new System.Drawing.Size(330, 33);
            this.PnlBtns.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 27);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Нов клиент";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlClients
            // 
            this.pnlClients.Controls.Add(this.gridEmployyes);
            this.pnlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClients.Location = new System.Drawing.Point(0, 0);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(446, 294);
            this.pnlClients.TabIndex = 1;
            // 
            // gridEmployyes
            // 
            this.gridEmployyes.DataSource = this.EmployeesBindingSrc;
            this.gridEmployyes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployyes.Location = new System.Drawing.Point(0, 0);
            this.gridEmployyes.MainView = this.gridViewEmployees;
            this.gridEmployyes.Name = "gridEmployyes";
            this.gridEmployyes.Size = new System.Drawing.Size(446, 294);
            this.gridEmployyes.TabIndex = 0;
            this.gridEmployyes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployees});
            // 
            // EmployeesBindingSrc
            // 
            this.EmployeesBindingSrc.DataSource = typeof(AutoPartDataModels.EMPLOYEES);
            this.EmployeesBindingSrc.PositionChanged += new System.EventHandler(this.clientsBindingSource_PositionChanged);
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEMPLOYEE_ID,
            this.colNAME,
            this.colEMPL_TYPE,
            this.colTELEPHONE,
            this.colEMAIL,
            this.colDETAILS,
            this.colDATE_EMPLOYEE,
            this.colQUIT_DATE,
            this.colLOOKUP_ITEMS});
            this.gridViewEmployees.GridControl = this.gridEmployyes;
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.OptionsBehavior.Editable = false;
            this.gridViewEmployees.OptionsFind.AlwaysVisible = true;
            this.gridViewEmployees.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridViewEmployees.OptionsView.ShowGroupPanel = false;
            // 
            // colEMPLOYEE_ID
            // 
            this.colEMPLOYEE_ID.FieldName = "EMPLOYEE_ID";
            this.colEMPLOYEE_ID.Name = "colEMPLOYEE_ID";
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Име";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            // 
            // colEMPL_TYPE
            // 
            this.colEMPL_TYPE.FieldName = "EMPL_TYPE";
            this.colEMPL_TYPE.Name = "colEMPL_TYPE";
            // 
            // colTELEPHONE
            // 
            this.colTELEPHONE.Caption = "Телефон";
            this.colTELEPHONE.FieldName = "TELEPHONE";
            this.colTELEPHONE.Name = "colTELEPHONE";
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "Email";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 1;
            // 
            // colDETAILS
            // 
            this.colDETAILS.Caption = "Подробности";
            this.colDETAILS.FieldName = "DETAILS";
            this.colDETAILS.Name = "colDETAILS";
            this.colDETAILS.Visible = true;
            this.colDETAILS.VisibleIndex = 2;
            // 
            // colDATE_EMPLOYEE
            // 
            this.colDATE_EMPLOYEE.Caption = "Дата назначаване";
            this.colDATE_EMPLOYEE.FieldName = "DATE_EMPLOYEE";
            this.colDATE_EMPLOYEE.Name = "colDATE_EMPLOYEE";
            this.colDATE_EMPLOYEE.Visible = true;
            this.colDATE_EMPLOYEE.VisibleIndex = 3;
            // 
            // colQUIT_DATE
            // 
            this.colQUIT_DATE.Caption = "Дата напускане";
            this.colQUIT_DATE.FieldName = "QUIT_DATE";
            this.colQUIT_DATE.Name = "colQUIT_DATE";
            this.colQUIT_DATE.Visible = true;
            this.colQUIT_DATE.VisibleIndex = 4;
            // 
            // colLOOKUP_ITEMS
            // 
            this.colLOOKUP_ITEMS.Caption = "Длъжност";
            this.colLOOKUP_ITEMS.FieldName = "LOOKUP_ITEMS.ITEM_NAME";
            this.colLOOKUP_ITEMS.Name = "colLOOKUP_ITEMS";
            this.colLOOKUP_ITEMS.Visible = true;
            this.colLOOKUP_ITEMS.VisibleIndex = 5;
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
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 294);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlClients);
            this.Controls.Add(this.pnlFrameClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmployees";
            this.Text = "Служители";
            this.Load += new System.EventHandler(this.FormManageClients_Load);
            this.pnlFrameClients.ResumeLayout(false);
            this.PnlBtns.ResumeLayout(false);
            this.pnlClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrameClients;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraGrid.GridControl gridEmployyes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployees;
        private System.Windows.Forms.Panel PnlBtns;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.Panel pnlFormClient;
        private System.Windows.Forms.BindingSource EmployeesBindingSrc;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPL_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDETAILS;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_EMPLOYEE;
        private DevExpress.XtraGrid.Columns.GridColumn colQUIT_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colLOOKUP_ITEMS;


    }
}