namespace DataManagment
{
    partial class TFormSearchParts
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
            this.pnlGridParts = new System.Windows.Forms.Panel();
            this.pnlGridPrts = new System.Windows.Forms.Panel();
            this.GridParts = new DevExpress.XtraGrid.GridControl();
            this.AllPartsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.PartsDataSet = new DataManagment.TPartsDataSet();
            this.gridViewParts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCar_Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart_details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart_Manuf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSrchCtrls = new System.Windows.Forms.Panel();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.SrchFilterBndSrc = new System.Windows.Forms.BindingSource(this.components);
            this.CarsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFormPart = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ModelsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.partsSrchFilterTableAdapter = new DataManagment.TPartsDataSetTableAdapters.PartsSrchFilterTableAdapter();
            this.pnlGridParts.SuspendLayout();
            this.pnlGridPrts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParts)).BeginInit();
            this.pnlSrchCtrls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchFilterBndSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGridParts
            // 
            this.pnlGridParts.Controls.Add(this.pnlGridPrts);
            this.pnlGridParts.Controls.Add(this.pnlSrchCtrls);
            this.pnlGridParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridParts.Location = new System.Drawing.Point(0, 0);
            this.pnlGridParts.Name = "pnlGridParts";
            this.pnlGridParts.Size = new System.Drawing.Size(586, 301);
            this.pnlGridParts.TabIndex = 0;
            // 
            // pnlGridPrts
            // 
            this.pnlGridPrts.Controls.Add(this.GridParts);
            this.pnlGridPrts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridPrts.Location = new System.Drawing.Point(0, 35);
            this.pnlGridPrts.Name = "pnlGridPrts";
            this.pnlGridPrts.Size = new System.Drawing.Size(586, 266);
            this.pnlGridPrts.TabIndex = 4;
            // 
            // GridParts
            // 
            this.GridParts.DataSource = this.AllPartsBindSrc;
            this.GridParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridParts.Location = new System.Drawing.Point(0, 0);
            this.GridParts.MainView = this.gridViewParts;
            this.GridParts.Name = "GridParts";
            this.GridParts.Size = new System.Drawing.Size(586, 266);
            this.GridParts.TabIndex = 2;
            this.GridParts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParts});
            // 
            // AllPartsBindSrc
            // 
            this.AllPartsBindSrc.DataMember = "ModelParts";
            this.AllPartsBindSrc.DataSource = this.PartsDataSet;
            this.AllPartsBindSrc.PositionChanged += new System.EventHandler(this.AllPartsBindSrc_PositionChanged);
            // 
            // PartsDataSet
            // 
            this.PartsDataSet.DataSetName = "TPartsDataSet";
            this.PartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewParts
            // 
            this.gridViewParts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCar_Model,
            this.colModel_Name,
            this.colPart_ID,
            this.colPart_Name,
            this.colPart_price,
            this.colPart_details,
            this.colPart_Manuf,
            this.colCar_ID,
            this.colModel_ID});
            this.gridViewParts.GridControl = this.GridParts;
            this.gridViewParts.Name = "gridViewParts";
            this.gridViewParts.OptionsBehavior.Editable = false;
            this.gridViewParts.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridViewParts.OptionsView.ShowGroupPanel = false;
            // 
            // colCar_Model
            // 
            this.colCar_Model.FieldName = "Car_Model";
            this.colCar_Model.Name = "colCar_Model";
            this.colCar_Model.Visible = true;
            this.colCar_Model.VisibleIndex = 0;
            // 
            // colModel_Name
            // 
            this.colModel_Name.FieldName = "Model_Name";
            this.colModel_Name.Name = "colModel_Name";
            this.colModel_Name.Visible = true;
            this.colModel_Name.VisibleIndex = 1;
            // 
            // colPart_ID
            // 
            this.colPart_ID.FieldName = "Part_ID";
            this.colPart_ID.Name = "colPart_ID";
            this.colPart_ID.Visible = true;
            this.colPart_ID.VisibleIndex = 2;
            // 
            // colPart_Name
            // 
            this.colPart_Name.FieldName = "Part_Name";
            this.colPart_Name.Name = "colPart_Name";
            this.colPart_Name.Visible = true;
            this.colPart_Name.VisibleIndex = 3;
            // 
            // colPart_price
            // 
            this.colPart_price.FieldName = "Part_price";
            this.colPart_price.Name = "colPart_price";
            this.colPart_price.Visible = true;
            this.colPart_price.VisibleIndex = 4;
            // 
            // colPart_details
            // 
            this.colPart_details.FieldName = "Part_details";
            this.colPart_details.Name = "colPart_details";
            this.colPart_details.Visible = true;
            this.colPart_details.VisibleIndex = 5;
            // 
            // colPart_Manuf
            // 
            this.colPart_Manuf.FieldName = "Part_Manuf";
            this.colPart_Manuf.Name = "colPart_Manuf";
            this.colPart_Manuf.Visible = true;
            this.colPart_Manuf.VisibleIndex = 6;
            // 
            // colCar_ID
            // 
            this.colCar_ID.FieldName = "Car_ID";
            this.colCar_ID.Name = "colCar_ID";
            this.colCar_ID.Visible = true;
            this.colCar_ID.VisibleIndex = 7;
            // 
            // colModel_ID
            // 
            this.colModel_ID.FieldName = "Model_ID";
            this.colModel_ID.Name = "colModel_ID";
            this.colModel_ID.Visible = true;
            this.colModel_ID.VisibleIndex = 8;
            // 
            // pnlSrchCtrls
            // 
            this.pnlSrchCtrls.Controls.Add(this.lookUpEdit2);
            this.pnlSrchCtrls.Controls.Add(this.lookUpEdit1);
            this.pnlSrchCtrls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSrchCtrls.Location = new System.Drawing.Point(0, 0);
            this.pnlSrchCtrls.Name = "pnlSrchCtrls";
            this.pnlSrchCtrls.Size = new System.Drawing.Size(586, 35);
            this.pnlSrchCtrls.TabIndex = 3;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SrchFilterBndSrc, "Model_ID", true));
            this.lookUpEdit2.Location = new System.Drawing.Point(138, 10);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DataSource = this.ModelsBindSrc;
            this.lookUpEdit2.Properties.DisplayMember = "MODEL_NAME";
            this.lookUpEdit2.Properties.ValueMember = "MODEL_ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit2.TabIndex = 1;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SrchFilterBndSrc, "Car_ID", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(11, 10);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Car_Model", "Марка", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.CarsBindSrc;
            this.lookUpEdit1.Properties.DisplayMember = "Car_Model";
            this.lookUpEdit1.Properties.ValueMember = "Car_ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(121, 20);
            this.lookUpEdit1.TabIndex = 0;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // SrchFilterBndSrc
            // 
            this.SrchFilterBndSrc.DataMember = "PartsSrchFilter";
            this.SrchFilterBndSrc.DataSource = this.PartsDataSet;
            this.SrchFilterBndSrc.CurrentChanged += new System.EventHandler(this.SrchFilterBndSrc_CurrentChanged);
            this.SrchFilterBndSrc.CurrentItemChanged += new System.EventHandler(this.SrchFilterBndSrc_CurrentItemChanged);
            // 

            // 
            // pnlFormPart
            // 
            this.pnlFormPart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormPart.Location = new System.Drawing.Point(386, 0);
            this.pnlFormPart.Name = "pnlFormPart";
            this.pnlFormPart.Size = new System.Drawing.Size(200, 301);
            this.pnlFormPart.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(383, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 301);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // ModelsBindSrc
            // 

            // 
            // partsSrchFilterTableAdapter
            // 
            this.partsSrchFilterTableAdapter.ClearBeforeFill = true;
            // 
            // TFormSearchParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 301);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlFormPart);
            this.Controls.Add(this.pnlGridParts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TFormSearchParts";
            this.Text = "TFormSearchParts";
            this.Load += new System.EventHandler(this.TFormSearchParts_Load);
            this.pnlGridParts.ResumeLayout(false);
            this.pnlGridPrts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParts)).EndInit();
            this.pnlSrchCtrls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchFilterBndSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGridParts;
        private System.Windows.Forms.Panel pnlFormPart;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraGrid.GridControl GridParts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParts;
        private System.Windows.Forms.BindingSource AllPartsBindSrc;
        private TPartsDataSet PartsDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colCar_Model;
        private DevExpress.XtraGrid.Columns.GridColumn colModel_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPart_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPart_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPart_price;
        private DevExpress.XtraGrid.Columns.GridColumn colPart_details;
        private DevExpress.XtraGrid.Columns.GridColumn colPart_Manuf;
        private DevExpress.XtraGrid.Columns.GridColumn colCar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colModel_ID;
        private System.Windows.Forms.Panel pnlGridPrts;
        private System.Windows.Forms.Panel pnlSrchCtrls;
       // private TCommonDataSet CommonDataSet;
        private System.Windows.Forms.BindingSource CarsBindSrc;
        private System.Windows.Forms.BindingSource SrchFilterBndSrc;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private System.Windows.Forms.BindingSource ModelsBindSrc;
        private TPartsDataSetTableAdapters.PartsSrchFilterTableAdapter partsSrchFilterTableAdapter;

    }
}