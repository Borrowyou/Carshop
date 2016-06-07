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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFormSearchParts));
            this.pnlGridHolder = new DevExpress.XtraEditors.PanelControl();
            this.partsGridParts = new DevExpress.XtraGrid.GridControl();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPart_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpart_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpart_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpart_details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpart_manuf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCATEGORY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCars = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_WORK_PARTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlFrameHolder = new DevExpress.XtraEditors.PanelControl();
            this.pnlForm = new DevExpress.XtraEditors.PanelControl();
            this.pnlFrameBtns = new DevExpress.XtraEditors.PanelControl();
            this.btnADd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LupYearList = new DevExpress.XtraEditors.LookUpEdit();
            this.SubModelBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.lblSubModel = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblModel = new DevExpress.XtraEditors.LabelControl();
            this.lblMark = new DevExpress.XtraEditors.LabelControl();
            this.LookUpModels = new DevExpress.XtraEditors.LookUpEdit();
            this.ModelsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpMarks = new DevExpress.XtraEditors.LookUpEdit();
            this.MarksBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridHolder)).BeginInit();
            this.pnlGridHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFrameHolder)).BeginInit();
            this.pnlFrameHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFrameBtns)).BeginInit();
            this.pnlFrameBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LupYearList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubModelBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpModels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGridHolder
            // 
            this.pnlGridHolder.Controls.Add(this.partsGridParts);
            this.pnlGridHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridHolder.Location = new System.Drawing.Point(2, 33);
            this.pnlGridHolder.Name = "pnlGridHolder";
            this.pnlGridHolder.Size = new System.Drawing.Size(607, 410);
            this.pnlGridHolder.TabIndex = 0;
            // 
            // partsGridParts
            // 
            this.partsGridParts.DataSource = this.partsBindingSource;
            this.partsGridParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsGridParts.Location = new System.Drawing.Point(2, 2);
            this.partsGridParts.MainView = this.gridView1;
            this.partsGridParts.Name = "partsGridParts";
            this.partsGridParts.Size = new System.Drawing.Size(603, 406);
            this.partsGridParts.TabIndex = 1;
            this.partsGridParts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.partsGridParts.DoubleClick += new System.EventHandler(this.partsGridParts_DoubleClick);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(AutoPartDataModels.Parts);
            this.partsBindingSource.PositionChanged += new System.EventHandler(this.partsBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPart_ID,
            this.colpart_name,
            this.colpart_price,
            this.colpart_details,
            this.colpart_manuf,
            this.colCar_ID,
            this.colModel_ID,
            this.colCATEGORY_ID,
            this.colIMG,
            this.colCars,
            this.colModels,
            this.colSERVICE_WORK_PARTS});
            this.gridView1.GridControl = this.partsGridParts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPart_ID
            // 
            this.colPart_ID.FieldName = "Part_ID";
            this.colPart_ID.Name = "colPart_ID";
            // 
            // colpart_name
            // 
            this.colpart_name.Caption = "Име на част";
            this.colpart_name.FieldName = "part_name";
            this.colpart_name.Name = "colpart_name";
            this.colpart_name.Visible = true;
            this.colpart_name.VisibleIndex = 0;
            // 
            // colpart_price
            // 
            this.colpart_price.Caption = "Цена";
            this.colpart_price.DisplayFormat.FormatString = "c";
            this.colpart_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colpart_price.FieldName = "part_price";
            this.colpart_price.Name = "colpart_price";
            this.colpart_price.Visible = true;
            this.colpart_price.VisibleIndex = 3;
            // 
            // colpart_details
            // 
            this.colpart_details.Caption = "Описание";
            this.colpart_details.FieldName = "part_details";
            this.colpart_details.Name = "colpart_details";
            this.colpart_details.Visible = true;
            this.colpart_details.VisibleIndex = 1;
            // 
            // colpart_manuf
            // 
            this.colpart_manuf.Caption = "Пройзводител";
            this.colpart_manuf.FieldName = "part_manuf";
            this.colpart_manuf.Name = "colpart_manuf";
            this.colpart_manuf.Visible = true;
            this.colpart_manuf.VisibleIndex = 2;
            // 
            // colCar_ID
            // 
            this.colCar_ID.FieldName = "Car_ID";
            this.colCar_ID.Name = "colCar_ID";
            // 
            // colModel_ID
            // 
            this.colModel_ID.FieldName = "Model_ID";
            this.colModel_ID.Name = "colModel_ID";
            // 
            // colCATEGORY_ID
            // 
            this.colCATEGORY_ID.FieldName = "CATEGORY_ID";
            this.colCATEGORY_ID.Name = "colCATEGORY_ID";
            // 
            // colIMG
            // 
            this.colIMG.FieldName = "IMG";
            this.colIMG.Name = "colIMG";
            // 
            // colCars
            // 
            this.colCars.FieldName = "Cars";
            this.colCars.Name = "colCars";
            // 
            // colModels
            // 
            this.colModels.FieldName = "Models";
            this.colModels.Name = "colModels";
            // 
            // colSERVICE_WORK_PARTS
            // 
            this.colSERVICE_WORK_PARTS.FieldName = "SERVICE_WORK_PARTS";
            this.colSERVICE_WORK_PARTS.Name = "colSERVICE_WORK_PARTS";
            // 
            // pnlFrameHolder
            // 
            this.pnlFrameHolder.Controls.Add(this.pnlForm);
            this.pnlFrameHolder.Controls.Add(this.pnlFrameBtns);
            this.pnlFrameHolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFrameHolder.Location = new System.Drawing.Point(614, 2);
            this.pnlFrameHolder.Name = "pnlFrameHolder";
            this.pnlFrameHolder.Size = new System.Drawing.Size(404, 441);
            this.pnlFrameHolder.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(2, 40);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(400, 399);
            this.pnlForm.TabIndex = 1;
            // 
            // pnlFrameBtns
            // 
            this.pnlFrameBtns.Controls.Add(this.btnADd);
            this.pnlFrameBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFrameBtns.Location = new System.Drawing.Point(2, 2);
            this.pnlFrameBtns.Name = "pnlFrameBtns";
            this.pnlFrameBtns.Size = new System.Drawing.Size(400, 38);
            this.pnlFrameBtns.TabIndex = 0;
            // 
            // btnADd
            // 
            this.btnADd.Location = new System.Drawing.Point(5, 6);
            this.btnADd.Name = "btnADd";
            this.btnADd.Size = new System.Drawing.Size(86, 24);
            this.btnADd.TabIndex = 0;
            this.btnADd.Text = "Добави част";
            this.btnADd.Click += new System.EventHandler(this.btnADd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.LupYearList);
            this.panelControl1.Controls.Add(this.lblSubModel);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.lblModel);
            this.panelControl1.Controls.Add(this.lblMark);
            this.panelControl1.Controls.Add(this.LookUpModels);
            this.panelControl1.Controls.Add(this.lookUpMarks);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(607, 31);
            this.panelControl1.TabIndex = 1;
            // 
            // LupYearList
            // 
            this.LupYearList.Location = new System.Drawing.Point(362, 6);
            this.LupYearList.Name = "LupYearList";
            this.LupYearList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LupYearList.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Yearlist", "Година", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LupYearList.Properties.DataSource = this.SubModelBindSrc;
            this.LupYearList.Properties.DisplayMember = "Yearlist";
            this.LupYearList.Properties.NullText = "Избери година";
            this.LupYearList.Properties.ValueMember = "SubModel";
            this.LupYearList.Size = new System.Drawing.Size(100, 20);
            this.LupYearList.TabIndex = 6;
            this.LupYearList.EditValueChanged += new System.EventHandler(this.LupYearList_EditValueChanged);
            // 
            // lblSubModel
            // 
            this.lblSubModel.Location = new System.Drawing.Point(315, 8);
            this.lblSubModel.Name = "lblSubModel";
            this.lblSubModel.Size = new System.Drawing.Size(41, 13);
            this.lblSubModel.TabIndex = 5;
            this.lblSubModel.Text = "Година:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(472, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Зареди";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(153, 8);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(37, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Модел:";
            // 
            // lblMark
            // 
            this.lblMark.Location = new System.Drawing.Point(5, 8);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(36, 13);
            this.lblMark.TabIndex = 2;
            this.lblMark.Text = "Марка:";
            // 
            // LookUpModels
            // 
            this.LookUpModels.Location = new System.Drawing.Point(196, 5);
            this.LookUpModels.Name = "LookUpModels";
            this.LookUpModels.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpModels.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MODEL_NAME", "Модел", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookUpModels.Properties.DataSource = this.ModelsBindSrc;
            this.LookUpModels.Properties.DisplayMember = "MODEL_NAME";
            this.LookUpModels.Properties.NullText = "Избери модел";
            this.LookUpModels.Properties.ValueMember = "MODEL_ID";
            this.LookUpModels.Size = new System.Drawing.Size(100, 20);
            this.LookUpModels.TabIndex = 1;
            this.LookUpModels.EditValueChanged += new System.EventHandler(this.LookUpModels_EditValueChanged);
            // 
            // ModelsBindSrc
            // 
            this.ModelsBindSrc.DataSource = typeof(AutoPartDataModels.Models);
            this.ModelsBindSrc.CurrentItemChanged += new System.EventHandler(this.ModelsBindSrc_CurrentItemChanged);
            // 
            // lookUpMarks
            // 
            this.lookUpMarks.Location = new System.Drawing.Point(47, 5);
            this.lookUpMarks.Name = "lookUpMarks";
            this.lookUpMarks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMarks.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Car_Model", "Марка", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpMarks.Properties.DataSource = this.MarksBindSrc;
            this.lookUpMarks.Properties.DisplayMember = "Car_Model";
            this.lookUpMarks.Properties.NullText = "Избери марка";
            this.lookUpMarks.Properties.ValueMember = "Car_ID";
            this.lookUpMarks.Size = new System.Drawing.Size(100, 20);
            this.lookUpMarks.TabIndex = 0;
            this.lookUpMarks.EditValueChanged += new System.EventHandler(this.lookUpMarks_EditValueChanged);
            // 
            // MarksBindSrc
            // 
            this.MarksBindSrc.DataSource = typeof(AutoPartDataModels.Cars);
            this.MarksBindSrc.PositionChanged += new System.EventHandler(this.MarksBindSrc_PositionChanged);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(609, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 441);
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlGridHolder);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Controls.Add(this.splitterControl1);
            this.panelControl2.Controls.Add(this.pnlFrameHolder);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1020, 445);
            this.panelControl2.TabIndex = 0;
            // 
            // TFormSearchParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 445);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TFormSearchParts";
            this.Text = "Авточасти";
            this.Load += new System.EventHandler(this.TFormSearchParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridHolder)).EndInit();
            this.pnlGridHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsGridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFrameHolder)).EndInit();
            this.pnlFrameHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFrameBtns)).EndInit();
            this.pnlFrameBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LupYearList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubModelBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpModels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlGridHolder;
        private DevExpress.XtraEditors.PanelControl pnlFrameHolder;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private DevExpress.XtraGrid.GridControl partsGridParts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPart_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpart_name;
        private DevExpress.XtraGrid.Columns.GridColumn colpart_price;
        private DevExpress.XtraGrid.Columns.GridColumn colpart_details;
        private DevExpress.XtraGrid.Columns.GridColumn colpart_manuf;
        private DevExpress.XtraGrid.Columns.GridColumn colCar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colModel_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCATEGORY_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colIMG;
        private DevExpress.XtraGrid.Columns.GridColumn colCars;
        private DevExpress.XtraGrid.Columns.GridColumn colModels;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_WORK_PARTS;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.LabelControl lblModel;
        private DevExpress.XtraEditors.LabelControl lblMark;
        private DevExpress.XtraEditors.LookUpEdit LookUpModels;
        private DevExpress.XtraEditors.LookUpEdit lookUpMarks;
        private System.Windows.Forms.BindingSource MarksBindSrc;
        private System.Windows.Forms.BindingSource ModelsBindSrc;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pnlFrameBtns;
        private DevExpress.XtraEditors.SimpleButton btnADd;
        private DevExpress.XtraEditors.PanelControl pnlForm;
        private DevExpress.XtraEditors.LookUpEdit LupYearList;
        private DevExpress.XtraEditors.LabelControl lblSubModel;
        private System.Windows.Forms.BindingSource SubModelBindSrc;


    }
}