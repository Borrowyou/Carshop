namespace DataManagment
{
    partial class PanelClientCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label cAR_REG_NUMBLabel;
            this.LupCBoxCars = new DevExpress.XtraEditors.LookUpEdit();
            this.cLIENT_CARSBindingSource = new System.Windows.Forms.BindingSource();
            this.AllCarsBindSrc = new System.Windows.Forms.BindingSource();
            this.ClientsDset = new DataManagment.ClientsDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblSize = new DevExpress.XtraEditors.LabelControl();
            this.lblEngineType = new DevExpress.XtraEditors.LabelControl();
            this.lblYear = new DevExpress.XtraEditors.LabelControl();
            this.lblModel = new DevExpress.XtraEditors.LabelControl();
            this.lblCar = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.YearsList = new System.Windows.Forms.BindingSource();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.ModelsBindSrc = new System.Windows.Forms.BindingSource();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.EngTypeBindSrc = new System.Windows.Forms.BindingSource();
            this.txtEngSize = new DevExpress.XtraEditors.TextEdit();
            this.cAR_REG_NUMBTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ModelYearsBindSrc = new System.Windows.Forms.BindingSource();
            this.lblRama = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblEngNumb = new DevExpress.XtraEditors.LabelControl();
            this.lblHorsePower = new DevExpress.XtraEditors.LabelControl();
            this.txtEditHP = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lblKW = new DevExpress.XtraEditors.LabelControl();
            this.txtKW = new DevExpress.XtraEditors.TextEdit();
            cAR_REG_NUMBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LupCBoxCars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_CARSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngTypeBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEngSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_REG_NUMBTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKW.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cAR_REG_NUMBLabel
            // 
            cAR_REG_NUMBLabel.AutoSize = true;
            cAR_REG_NUMBLabel.Location = new System.Drawing.Point(154, 83);
            cAR_REG_NUMBLabel.Name = "cAR_REG_NUMBLabel";
            cAR_REG_NUMBLabel.Size = new System.Drawing.Size(53, 13);
            cAR_REG_NUMBLabel.TabIndex = 21;
            cAR_REG_NUMBLabel.Text = "Рег. Ном";
            // 
            // LupCBoxCars
            // 
            this.LupCBoxCars.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "CAR_ID", true));
            this.LupCBoxCars.Location = new System.Drawing.Point(52, 33);
            this.LupCBoxCars.Name = "LupCBoxCars";
            this.LupCBoxCars.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LupCBoxCars.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Car_Model", "Марка", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LupCBoxCars.Properties.DataSource = this.AllCarsBindSrc;
            this.LupCBoxCars.Properties.DisplayMember = "Car_Model";
            this.LupCBoxCars.Properties.NullText = "Марка";
            this.LupCBoxCars.Properties.ValueMember = "Car_ID";
            this.LupCBoxCars.Size = new System.Drawing.Size(101, 20);
            this.LupCBoxCars.TabIndex = 0;
            // 
            // cLIENT_CARSBindingSource
            // 
            this.cLIENT_CARSBindingSource.DataSource = typeof(AutoPartDataModels.CLIENT_CARS);
            this.cLIENT_CARSBindingSource.CurrentChanged += new System.EventHandler(this.cLIENT_CARSBindingSource_CurrentChanged);
            this.cLIENT_CARSBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.cLIENT_CARSBindingSource_ListChanged);
            // 
            // AllCarsBindSrc
            // 
            this.AllCarsBindSrc.DataSource = typeof(AutoPartDataModels.Cars);
            // 
            // ClientsDset
            // 
            this.ClientsDset.DataSetName = "ClientsDset";
            this.ClientsDset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(7, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Премахни";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(7, 83);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Обем:";
            // 
            // lblEngineType
            // 
            this.lblEngineType.Location = new System.Drawing.Point(157, 59);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(53, 13);
            this.lblEngineType.TabIndex = 3;
            this.lblEngineType.Text = "Двигател:";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(6, 59);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Година:";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(157, 36);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(37, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Модел:";
            // 
            // lblCar
            // 
            this.lblCar.Location = new System.Drawing.Point(7, 32);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(36, 13);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Марка:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "CAR_YEAR", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(52, 56);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("yr", "Година", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.YearsList;
            this.lookUpEdit1.Properties.DisplayMember = "yr";
            this.lookUpEdit1.Properties.NullText = "Година";
            this.lookUpEdit1.Properties.ValueMember = "yr";
            this.lookUpEdit1.Size = new System.Drawing.Size(101, 20);
            this.lookUpEdit1.TabIndex = 2;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // YearsList
            // 
            this.YearsList.DataSource = typeof(AutoPartDataModels.FUN_YEARS_BETWEEN_LIST_Result);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "MODEL_ID", true));
            this.lookUpEdit2.Location = new System.Drawing.Point(206, 29);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MODEL_NAME", "Модел", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.ModelsBindSrc;
            this.lookUpEdit2.Properties.DisplayMember = "MODEL_NAME";
            this.lookUpEdit2.Properties.NullText = "Модел";
            this.lookUpEdit2.Properties.ValueMember = "MODEL_ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(97, 20);
            this.lookUpEdit2.TabIndex = 1;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // ModelsBindSrc
            // 
            this.ModelsBindSrc.DataSource = typeof(AutoPartDataModels.Models);
            this.ModelsBindSrc.CurrentChanged += new System.EventHandler(this.ModelsBindSrc_CurrentChanged);
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "ENGINE_TYPE", true));
            this.lookUpEdit3.Location = new System.Drawing.Point(208, 55);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_NAME", "Вид", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit3.Properties.DataSource = this.EngTypeBindSrc;
            this.lookUpEdit3.Properties.DisplayMember = "ITEM_NAME";
            this.lookUpEdit3.Properties.NullText = "Двигател";
            this.lookUpEdit3.Properties.ValueMember = "ITEM_CODE";
            this.lookUpEdit3.Size = new System.Drawing.Size(95, 20);
            this.lookUpEdit3.TabIndex = 3;
            // 
            // EngTypeBindSrc
            // 
            this.EngTypeBindSrc.DataSource = typeof(AutoPartDataModels.LOOKUP_ITEMS);
            // 
            // txtEngSize
            // 
            this.txtEngSize.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "ENGINE_SIZE", true));
            this.txtEngSize.Location = new System.Drawing.Point(52, 82);
            this.txtEngSize.Name = "txtEngSize";
            this.txtEngSize.Size = new System.Drawing.Size(101, 20);
            this.txtEngSize.TabIndex = 4;
            // 
            // cAR_REG_NUMBTextEdit
            // 
            this.cAR_REG_NUMBTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "CAR_REG_NUMB", true));
            this.cAR_REG_NUMBTextEdit.Location = new System.Drawing.Point(208, 80);
            this.cAR_REG_NUMBTextEdit.Name = "cAR_REG_NUMBTextEdit";
            this.cAR_REG_NUMBTextEdit.Size = new System.Drawing.Size(95, 20);
            this.cAR_REG_NUMBTextEdit.TabIndex = 5;
            // 
            // ModelYearsBindSrc
            // 
            this.ModelYearsBindSrc.DataSource = typeof(AutoPartDataModels.Models);
            // 
            // lblRama
            // 
            this.lblRama.Location = new System.Drawing.Point(6, 108);
            this.lblRama.Name = "lblRama";
            this.lblRama.Size = new System.Drawing.Size(28, 13);
            this.lblRama.TabIndex = 22;
            this.lblRama.Text = "Рама:";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "RAMPH_NUMB", true));
            this.textEdit1.Location = new System.Drawing.Point(52, 105);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(101, 20);
            this.textEdit1.TabIndex = 6;
            // 
            // lblEngNumb
            // 
            this.lblEngNumb.Location = new System.Drawing.Point(7, 131);
            this.lblEngNumb.Name = "lblEngNumb";
            this.lblEngNumb.Size = new System.Drawing.Size(39, 13);
            this.lblEngNumb.TabIndex = 24;
            this.lblEngNumb.Text = "№ Двг:";
            // 
            // lblHorsePower
            // 
            this.lblHorsePower.Location = new System.Drawing.Point(157, 108);
            this.lblHorsePower.Name = "lblHorsePower";
            this.lblHorsePower.Size = new System.Drawing.Size(26, 13);
            this.lblHorsePower.TabIndex = 25;
            this.lblHorsePower.Text = "К.С.:";
            // 
            // txtEditHP
            // 
            this.txtEditHP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "HOURSE_POWER", true));
            this.txtEditHP.Location = new System.Drawing.Point(206, 105);
            this.txtEditHP.Name = "txtEditHP";
            this.txtEditHP.Size = new System.Drawing.Size(95, 20);
            this.txtEditHP.TabIndex = 7;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "ENGINE_NUMB", true));
            this.textEdit2.Location = new System.Drawing.Point(52, 129);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(101, 20);
            this.textEdit2.TabIndex = 8;
            // 
            // lblKW
            // 
            this.lblKW.Location = new System.Drawing.Point(157, 135);
            this.lblKW.Name = "lblKW";
            this.lblKW.Size = new System.Drawing.Size(20, 13);
            this.lblKW.TabIndex = 28;
            this.lblKW.Text = "KW:";
            // 
            // txtKW
            // 
            this.txtKW.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cLIENT_CARSBindingSource, "KILOWATS", true));
            this.txtKW.Location = new System.Drawing.Point(206, 128);
            this.txtKW.Name = "txtKW";
            this.txtKW.Size = new System.Drawing.Size(95, 20);
            this.txtKW.TabIndex = 9;
            // 
            // PanelClientCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtKW);
            this.Controls.Add(this.lblKW);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.txtEditHP);
            this.Controls.Add(this.lblHorsePower);
            this.Controls.Add(this.lblEngNumb);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lblRama);
            this.Controls.Add(cAR_REG_NUMBLabel);
            this.Controls.Add(this.cAR_REG_NUMBTextEdit);
            this.Controls.Add(this.txtEngSize);
            this.Controls.Add(this.lookUpEdit3);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.LupCBoxCars);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblEngineType);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblCar);
            this.Name = "PanelClientCar";
            this.Size = new System.Drawing.Size(321, 152);
            this.Load += new System.EventHandler(this.PanelClientCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LupCBoxCars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_CARSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngTypeBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEngSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_REG_NUMBTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKW.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit LupCBoxCars;
        private ClientsDataSet ClientsDset;
        private System.Windows.Forms.BindingSource AllCarsBindSrc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblSize;
        private DevExpress.XtraEditors.LabelControl lblEngineType;
        private DevExpress.XtraEditors.LabelControl lblYear;
        private DevExpress.XtraEditors.LabelControl lblModel;
        private DevExpress.XtraEditors.LabelControl lblCar;
        private System.Windows.Forms.BindingSource YearsList;
        private System.Windows.Forms.BindingSource ModelYearsBindSrc;
        private System.Windows.Forms.BindingSource EngTypeBindSrc;
        private System.Windows.Forms.BindingSource ModelsBindSrc;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.TextEdit txtEngSize;
        private System.Windows.Forms.BindingSource cLIENT_CARSBindingSource;
        private DevExpress.XtraEditors.TextEdit cAR_REG_NUMBTextEdit;
        private DevExpress.XtraEditors.LabelControl lblRama;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblEngNumb;
        private DevExpress.XtraEditors.LabelControl lblHorsePower;
        private DevExpress.XtraEditors.TextEdit txtEditHP;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl lblKW;
        private DevExpress.XtraEditors.TextEdit txtKW;

    }
}
