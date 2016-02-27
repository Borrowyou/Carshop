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
            this.components = new System.ComponentModel.Container();
            this.lblCar = new DevExpress.XtraEditors.LabelControl();
            this.lblModel = new DevExpress.XtraEditors.LabelControl();
            this.lblYear = new DevExpress.XtraEditors.LabelControl();
            this.lblEngineType = new DevExpress.XtraEditors.LabelControl();
            this.lblSize = new DevExpress.XtraEditors.LabelControl();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsDSet = new DataManagment.ClientsDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ModelYearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBxModel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cBxFrom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CBoxEngine = new DevExpress.XtraEditors.ComboBoxEdit();
            this.YearsListBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.carsTableAdapter = new DataManagment.ClientsDataSetTableAdapters.CarsTableAdapter();
            this.LupCBoxCars = new DevExpress.XtraEditors.LookUpEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ClientCars = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENT_CARSTableAdapter = new DataManagment.ClientsDataSetTableAdapters.CLIENT_CARSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBxModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBxFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBoxEngine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsListBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupCBoxCars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCars)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCar
            // 
            this.lblCar.Location = new System.Drawing.Point(7, 32);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(36, 13);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Марка:";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(149, 32);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(37, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Модел:";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(6, 59);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Година:";
            // 
            // lblEngineType
            // 
            this.lblEngineType.Location = new System.Drawing.Point(149, 59);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(53, 13);
            this.lblEngineType.TabIndex = 3;
            this.lblEngineType.Text = "Двигател:";
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(7, 83);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(53, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Кубатура:";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.ClientsDSet;
            // 
            // ClientsDSet
            // 
            this.ClientsDSet.DataSetName = "ClientsDataSet";
            this.ClientsDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(7, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(19, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "-";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cBxModel
            // 
            this.cBxModel.Location = new System.Drawing.Point(206, 29);
            this.cBxModel.Name = "cBxModel";
            this.cBxModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBxModel.Size = new System.Drawing.Size(86, 20);
            this.cBxModel.TabIndex = 11;
            // 
            // cBxFrom
            // 
            this.cBxFrom.Location = new System.Drawing.Point(52, 57);
            this.cBxFrom.Name = "cBxFrom";
            this.cBxFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBxFrom.Size = new System.Drawing.Size(86, 20);
            this.cBxFrom.TabIndex = 12;
            // 
            // CBoxEngine
            // 
            this.CBoxEngine.Location = new System.Drawing.Point(206, 55);
            this.CBoxEngine.Name = "CBoxEngine";
            this.CBoxEngine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBoxEngine.Size = new System.Drawing.Size(86, 20);
            this.CBoxEngine.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // LupCBoxCars
            // 
            this.LupCBoxCars.Location = new System.Drawing.Point(52, 33);
            this.LupCBoxCars.Name = "LupCBoxCars";
            this.LupCBoxCars.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LupCBoxCars.Properties.DataSource = this.carsBindingSource;
            this.LupCBoxCars.Properties.DisplayMember = "Car_Model";
            this.LupCBoxCars.Properties.ValueMember = "Car_ID";
            this.LupCBoxCars.Size = new System.Drawing.Size(86, 20);
            this.LupCBoxCars.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carsBindingSource;
            this.comboBox1.DisplayMember = "Car_Model";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Car_ID";
            // 
            // ClientCars
            // 
            this.ClientCars.DataMember = "CLIENT_CARS";
            this.ClientCars.DataSource = this.ClientsDSet;
            // 
            // cLIENT_CARSTableAdapter
            // 
            this.cLIENT_CARSTableAdapter.ClearBeforeFill = true;
            // 
            // PanelClientCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LupCBoxCars);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBoxEngine);
            this.Controls.Add(this.cBxFrom);
            this.Controls.Add(this.cBxModel);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblEngineType);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblCar);
            this.Name = "PanelClientCar";
            this.Size = new System.Drawing.Size(303, 101);
            this.Load += new System.EventHandler(this.PanelClientCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBxModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBxFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBoxEngine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsListBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupCBoxCars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCar;
        private DevExpress.XtraEditors.LabelControl lblModel;
        private DevExpress.XtraEditors.LabelControl lblYear;
        private DevExpress.XtraEditors.LabelControl lblEngineType;
        private DevExpress.XtraEditors.LabelControl lblSize;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private System.Windows.Forms.BindingSource ModelYearsBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit cBxModel;
        private DevExpress.XtraEditors.ComboBoxEdit cBxFrom;
        private DevExpress.XtraEditors.ComboBoxEdit CBoxEngine;
        private System.Windows.Forms.BindingSource YearsListBindSrc;
        private System.Windows.Forms.Button button1;
        private ClientsDataSet ClientsDSet;
        private ClientsDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit LupCBoxCars;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ClientCars;
        private ClientsDataSetTableAdapters.CLIENT_CARSTableAdapter cLIENT_CARSTableAdapter;
    }
}
