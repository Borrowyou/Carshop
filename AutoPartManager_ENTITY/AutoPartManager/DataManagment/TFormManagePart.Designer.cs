namespace DataManagment
{
    partial class TFormManagePart
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
            System.Windows.Forms.Label part_IDLabel;
            System.Windows.Forms.Label part_detailsLabel;
            System.Windows.Forms.Label part_nameLabel;
            System.Windows.Forms.Label part_manufLabel;
            System.Windows.Forms.Label part_priceLabel;
            System.Windows.Forms.Label lblMark;
            System.Windows.Forms.Label lblModel;
            this.part_IDLabel1 = new System.Windows.Forms.Label();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.part_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.part_manufTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iMGPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.MarksBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.ModelsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            part_IDLabel = new System.Windows.Forms.Label();
            part_detailsLabel = new System.Windows.Forms.Label();
            part_nameLabel = new System.Windows.Forms.Label();
            part_manufLabel = new System.Windows.Forms.Label();
            part_priceLabel = new System.Windows.Forms.Label();
            lblMark = new System.Windows.Forms.Label();
            lblModel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_manufTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // part_IDLabel
            // 
            part_IDLabel.AutoSize = true;
            part_IDLabel.Location = new System.Drawing.Point(12, 9);
            part_IDLabel.Name = "part_IDLabel";
            part_IDLabel.Size = new System.Drawing.Size(98, 13);
            part_IDLabel.TabIndex = 1;
            part_IDLabel.Text = "Вътрешен Номер:";
            // 
            // part_detailsLabel
            // 
            part_detailsLabel.AutoSize = true;
            part_detailsLabel.Location = new System.Drawing.Point(11, 153);
            part_detailsLabel.Name = "part_detailsLabel";
            part_detailsLabel.Size = new System.Drawing.Size(51, 13);
            part_detailsLabel.TabIndex = 2;
            part_detailsLabel.Text = "Детайли";
            // 
            // part_nameLabel
            // 
            part_nameLabel.AutoSize = true;
            part_nameLabel.Location = new System.Drawing.Point(12, 34);
            part_nameLabel.Name = "part_nameLabel";
            part_nameLabel.Size = new System.Drawing.Size(83, 13);
            part_nameLabel.TabIndex = 4;
            part_nameLabel.Text = "Име на частта:";
            // 
            // part_manufLabel
            // 
            part_manufLabel.AutoSize = true;
            part_manufLabel.Location = new System.Drawing.Point(12, 64);
            part_manufLabel.Name = "part_manufLabel";
            part_manufLabel.Size = new System.Drawing.Size(83, 13);
            part_manufLabel.TabIndex = 6;
            part_manufLabel.Text = "Пройзводител:";
            // 
            // part_priceLabel
            // 
            part_priceLabel.AutoSize = true;
            part_priceLabel.Location = new System.Drawing.Point(12, 90);
            part_priceLabel.Name = "part_priceLabel";
            part_priceLabel.Size = new System.Drawing.Size(36, 13);
            part_priceLabel.TabIndex = 8;
            part_priceLabel.Text = "Цена:";
            // 
            // lblMark
            // 
            lblMark.AutoSize = true;
            lblMark.Location = new System.Drawing.Point(12, 117);
            lblMark.Name = "lblMark";
            lblMark.Size = new System.Drawing.Size(43, 13);
            lblMark.TabIndex = 15;
            lblMark.Text = "Марка:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new System.Drawing.Point(212, 117);
            lblModel.Name = "lblModel";
            lblModel.Size = new System.Drawing.Size(36, 13);
            lblModel.TabIndex = 16;
            lblModel.Text = "Model";
            // 
            // part_IDLabel1
            // 
            this.part_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part_ID", true));
            this.part_IDLabel1.Location = new System.Drawing.Point(116, 9);
            this.part_IDLabel1.Name = "part_IDLabel1";
            this.part_IDLabel1.Size = new System.Drawing.Size(100, 23);
            this.part_IDLabel1.TabIndex = 2;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(AutoPartDataModels.Parts);
            this.partsBindingSource.CurrentItemChanged += new System.EventHandler(this.partsBindingSource_CurrentItemChanged);
            // 
            // part_nameTextEdit
            // 
            this.part_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "part_name", true));
            this.part_nameTextEdit.Location = new System.Drawing.Point(96, 31);
            this.part_nameTextEdit.Name = "part_nameTextEdit";
            this.part_nameTextEdit.Size = new System.Drawing.Size(285, 20);
            this.part_nameTextEdit.TabIndex = 5;
            // 
            // part_manufTextEdit
            // 
            this.part_manufTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "part_manuf", true));
            this.part_manufTextEdit.Location = new System.Drawing.Point(96, 57);
            this.part_manufTextEdit.Name = "part_manufTextEdit";
            this.part_manufTextEdit.Size = new System.Drawing.Size(285, 20);
            this.part_manufTextEdit.TabIndex = 7;
            // 
            // iMGPictureEdit
            // 
            this.iMGPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "IMG", true));
            this.iMGPictureEdit.Location = new System.Drawing.Point(10, 220);
            this.iMGPictureEdit.Name = "iMGPictureEdit";
            this.iMGPictureEdit.Size = new System.Drawing.Size(371, 185);
            this.iMGPictureEdit.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "part_details", true));
            this.richTextBox1.Location = new System.Drawing.Point(95, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 62);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "part_price", true));
            this.txtPrice.Location = new System.Drawing.Point(95, 87);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 17;
            // 
            // MarksBindSrc
            // 
            this.MarksBindSrc.DataSource = typeof(AutoPartDataModels.Cars);
            this.MarksBindSrc.CurrentItemChanged += new System.EventHandler(this.MarksBindSrc_CurrentItemChanged);
            // 
            // ModelsBindSrc
            // 
            this.ModelsBindSrc.DataSource = typeof(AutoPartDataModels.Models);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Запази";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "Car_ID", true));
            this.searchLookUpEdit1.Location = new System.Drawing.Point(95, 113);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Car_Model", "Марка", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.searchLookUpEdit1.Properties.DataSource = this.MarksBindSrc;
            this.searchLookUpEdit1.Properties.DisplayMember = "Car_Model";
            this.searchLookUpEdit1.Properties.ValueMember = "Car_ID";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.searchLookUpEdit1.TabIndex = 13;
            // 
            // searchLookUpEdit2
            // 
            this.searchLookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "Model_ID", true));
            this.searchLookUpEdit2.Location = new System.Drawing.Point(261, 113);
            this.searchLookUpEdit2.Name = "searchLookUpEdit2";
            this.searchLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MODEL_NAME", "Модел", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.searchLookUpEdit2.Properties.DataSource = this.ModelsBindSrc;
            this.searchLookUpEdit2.Properties.DisplayMember = "MODEL_NAME";
            this.searchLookUpEdit2.Properties.ValueMember = "MODEL_ID";
            this.searchLookUpEdit2.Size = new System.Drawing.Size(119, 20);
            this.searchLookUpEdit2.TabIndex = 14;
            // 
            // TFormManagePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 465);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(lblModel);
            this.Controls.Add(lblMark);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.iMGPictureEdit);
            this.Controls.Add(part_priceLabel);
            this.Controls.Add(part_manufLabel);
            this.Controls.Add(this.part_manufTextEdit);
            this.Controls.Add(part_nameLabel);
            this.Controls.Add(this.part_nameTextEdit);
            this.Controls.Add(part_detailsLabel);
            this.Controls.Add(part_IDLabel);
            this.Controls.Add(this.part_IDLabel1);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.searchLookUpEdit2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TFormManagePart";
            this.Text = "Авточаст";
            this.Load += new System.EventHandler(this.TFormManagePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_manufTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.Label part_IDLabel1;
        private DevExpress.XtraEditors.TextEdit part_nameTextEdit;
        private DevExpress.XtraEditors.TextEdit part_manufTextEdit;
        private DevExpress.XtraEditors.PictureEdit iMGPictureEdit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource MarksBindSrc;
        private System.Windows.Forms.BindingSource ModelsBindSrc;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit searchLookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit searchLookUpEdit2;


    }
}