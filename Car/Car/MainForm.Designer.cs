namespace Car
{
    partial class MainForm
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
         this.cbxCars = new System.Windows.Forms.ComboBox();
         this.carShopDataSet = new Car.CarShopDataSet();
         this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.carsTableAdapter = new Car.CarShopDataSetTableAdapters.CarsTableAdapter();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.modelsTableAdapter = new Car.CarShopDataSetTableAdapters.ModelsTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.carShopDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // cbxCars
         // 
         this.cbxCars.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
         this.cbxCars.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.cbxCars.DataSource = this.carsBindingSource;
         this.cbxCars.DisplayMember = "Car_Model";
         this.cbxCars.FormattingEnabled = true;
         this.cbxCars.Location = new System.Drawing.Point(13, 13);
         this.cbxCars.Name = "cbxCars";
         this.cbxCars.Size = new System.Drawing.Size(121, 21);
         this.cbxCars.TabIndex = 0;
         this.cbxCars.ValueMember = "Car_ID";
         // 
         // carShopDataSet
         // 
         this.carShopDataSet.DataSetName = "CarShopDataSet";
         this.carShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // carsBindingSource
         // 
         this.carsBindingSource.DataMember = "Cars";
         this.carsBindingSource.DataSource = this.carShopDataSet;
         // 
         // carsTableAdapter
         // 
         this.carsTableAdapter.ClearBeforeFill = true;
         // 
         // comboBox1
         // 
         this.comboBox1.DataSource = this.modelsBindingSource;
         this.comboBox1.DisplayMember = "MODEL_NAME";
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(192, 12);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(121, 21);
         this.comboBox1.TabIndex = 1;
         this.comboBox1.ValueMember = "MODEL_ID";
         // 
         // modelsBindingSource
         // 
         this.modelsBindingSource.DataMember = "Models";
         this.modelsBindingSource.DataSource = this.carShopDataSet;
         // 
         // modelsTableAdapter
         // 
         this.modelsTableAdapter.ClearBeforeFill = true;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(723, 314);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.cbxCars);
         this.Name = "MainForm";
         this.Text = "MainForm";
         this.Load += new System.EventHandler(this.MainForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.carShopDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCars;
        private CarShopDataSet carShopDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarShopDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private CarShopDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;

    }
}