namespace DataManagment
{
    partial class FormManageMarkAndModels
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveMark = new DevExpress.XtraEditors.SimpleButton();
            this.lblCarName = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.CarBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveModel = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.ModelBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.AllMarksBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.lblModel = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSaveSubModel = new DevExpress.XtraEditors.SimpleButton();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.SubModelBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.calcEditYFrom = new DevExpress.XtraEditors.CalcEdit();
            this.lblYearFrom = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.AllModelsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllMarksBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubModelBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditYFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllModelsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnSaveMark);
            this.groupControl1.Controls.Add(this.lblCarName);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Location = new System.Drawing.Point(2, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(956, 64);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Добаваня на марка";
            // 
            // btnSaveMark
            // 
            this.btnSaveMark.Location = new System.Drawing.Point(216, 24);
            this.btnSaveMark.Name = "btnSaveMark";
            this.btnSaveMark.Size = new System.Drawing.Size(75, 25);
            this.btnSaveMark.TabIndex = 2;
            this.btnSaveMark.Text = "Запази";
            this.btnSaveMark.Click += new System.EventHandler(this.btnSaveMark_Click);
            // 
            // lblCarName
            // 
            this.lblCarName.Location = new System.Drawing.Point(10, 31);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(83, 13);
            this.lblCarName.TabIndex = 1;
            this.lblCarName.Text = "Име на марката:";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.CarBindSrc, "Car_Model", true));
            this.textEdit1.Location = new System.Drawing.Point(99, 28);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // CarBindSrc
            // 
            this.CarBindSrc.DataSource = typeof(AutoPartDataModels.Cars);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnSaveModel);
            this.groupControl2.Controls.Add(this.textEdit2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.lookUpEdit1);
            this.groupControl2.Controls.Add(this.lblModel);
            this.groupControl2.Location = new System.Drawing.Point(2, 82);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(956, 64);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Добаваня на модел";
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Location = new System.Drawing.Point(323, 30);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(77, 24);
            this.btnSaveModel.TabIndex = 4;
            this.btnSaveModel.Text = "Запази";
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ModelBindSrc, "MODEL_NAME", true));
            this.textEdit2.Location = new System.Drawing.Point(205, 32);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // ModelBindSrc
            // 
            this.ModelBindSrc.DataSource = typeof(AutoPartDataModels.Models);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(162, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Модел:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ModelBindSrc, "CAR_ID", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(52, 32);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Car_Model", "Марка:", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.AllMarksBindSrc;
            this.lookUpEdit1.Properties.DisplayMember = "Car_Model";
            this.lookUpEdit1.Properties.ValueMember = "Car_ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit1.TabIndex = 1;
            // 
            // AllMarksBindSrc
            // 
            this.AllMarksBindSrc.DataSource = typeof(AutoPartDataModels.Cars);
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(10, 35);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Марка:";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.BtnSaveSubModel);
            this.groupControl3.Controls.Add(this.calcEdit1);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.calcEditYFrom);
            this.groupControl3.Controls.Add(this.lblYearFrom);
            this.groupControl3.Controls.Add(this.lookUpEdit3);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.lookUpEdit2);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Location = new System.Drawing.Point(2, 152);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(956, 64);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Добаваня на подмодел";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // BtnSaveSubModel
            // 
            this.BtnSaveSubModel.Location = new System.Drawing.Point(728, 35);
            this.BtnSaveSubModel.Name = "BtnSaveSubModel";
            this.BtnSaveSubModel.Size = new System.Drawing.Size(77, 24);
            this.BtnSaveSubModel.TabIndex = 5;
            this.BtnSaveSubModel.Text = "Запази";
            this.BtnSaveSubModel.Click += new System.EventHandler(this.BtnSaveSubModel_Click);
            // 
            // calcEdit1
            // 
            this.calcEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SubModelBindSrc, "YEAR_STOP", true));
            this.calcEdit1.Location = new System.Drawing.Point(637, 36);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Size = new System.Drawing.Size(85, 20);
            this.calcEdit1.TabIndex = 10;
            // 
            // SubModelBindSrc
            // 
            this.SubModelBindSrc.DataSource = typeof(AutoPartDataModels.SUB_MODELS);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(526, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Край пройзводство:";
            // 
            // calcEditYFrom
            // 
            this.calcEditYFrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SubModelBindSrc, "YEAR_MANUF", true));
            this.calcEditYFrom.Location = new System.Drawing.Point(432, 36);
            this.calcEditYFrom.Name = "calcEditYFrom";
            this.calcEditYFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditYFrom.Size = new System.Drawing.Size(85, 20);
            this.calcEditYFrom.TabIndex = 8;
            // 
            // lblYearFrom
            // 
            this.lblYearFrom.Location = new System.Drawing.Point(311, 39);
            this.lblYearFrom.Name = "lblYearFrom";
            this.lblYearFrom.Size = new System.Drawing.Size(115, 13);
            this.lblYearFrom.TabIndex = 7;
            this.lblYearFrom.Text = "Начало пройзводство:";
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SubModelBindSrc, "MODEL_ID", true));
            this.lookUpEdit3.Location = new System.Drawing.Point(205, 36);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MODEL_NAME", "Модел", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit3.Properties.DataSource = this.AllModelsBindSrc;
            this.lookUpEdit3.Properties.DisplayMember = "MODEL_NAME";
            this.lookUpEdit3.Properties.ValueMember = "MODEL_ID";
            this.lookUpEdit3.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit3.TabIndex = 6;
            // 
            // AllModelsBindSrc
            // 
            this.AllModelsBindSrc.DataSource = typeof(AutoPartDataModels.Models);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(162, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Модел:";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(52, 36);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Car_Model", "Марка", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.AllMarksBindSrc;
            this.lookUpEdit2.Properties.DisplayMember = "Car_Model";
            this.lookUpEdit2.Properties.ValueMember = "Car_ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit2.TabIndex = 3;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Марка:";
            // 
            // FormManageMarkAndModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 262);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormManageMarkAndModels";
            this.Text = "Въвеждане на нови марки и модели";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllMarksBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubModelBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditYFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllModelsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblCarName;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnSaveMark;
        private DevExpress.XtraEditors.SimpleButton btnSaveModel;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl lblModel;
        private DevExpress.XtraEditors.CalcEdit calcEditYFrom;
        private DevExpress.XtraEditors.LabelControl lblYearFrom;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnSaveSubModel;
        private System.Windows.Forms.BindingSource CarBindSrc;
        private System.Windows.Forms.BindingSource ModelBindSrc;
        private System.Windows.Forms.BindingSource SubModelBindSrc;
        private System.Windows.Forms.BindingSource AllMarksBindSrc;
        private System.Windows.Forms.BindingSource AllModelsBindSrc;
    }
}