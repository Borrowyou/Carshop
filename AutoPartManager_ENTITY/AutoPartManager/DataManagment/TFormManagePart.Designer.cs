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
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.part_IDLabel1 = new System.Windows.Forms.Label();
            this.part_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.part_manufTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.part_priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.iMGPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            part_IDLabel = new System.Windows.Forms.Label();
            part_detailsLabel = new System.Windows.Forms.Label();
            part_nameLabel = new System.Windows.Forms.Label();
            part_manufLabel = new System.Windows.Forms.Label();
            part_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_manufTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_priceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGPictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(AutoPartDataModels.Parts);
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
            // part_IDLabel1
            // 
            this.part_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part_ID", true));
            this.part_IDLabel1.Location = new System.Drawing.Point(116, 9);
            this.part_IDLabel1.Name = "part_IDLabel1";
            this.part_IDLabel1.Size = new System.Drawing.Size(100, 23);
            this.part_IDLabel1.TabIndex = 2;
            this.part_IDLabel1.Text = "label1";
            // 
            // part_detailsLabel
            // 
            part_detailsLabel.AutoSize = true;
            part_detailsLabel.Location = new System.Drawing.Point(12, 119);
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
            // part_nameTextEdit
            // 
            this.part_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "part_name", true));
            this.part_nameTextEdit.Location = new System.Drawing.Point(96, 31);
            this.part_nameTextEdit.Name = "part_nameTextEdit";
            this.part_nameTextEdit.Size = new System.Drawing.Size(285, 20);
            this.part_nameTextEdit.TabIndex = 5;
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
            // part_manufTextEdit
            // 
            this.part_manufTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "part_manuf", true));
            this.part_manufTextEdit.Location = new System.Drawing.Point(96, 57);
            this.part_manufTextEdit.Name = "part_manufTextEdit";
            this.part_manufTextEdit.Size = new System.Drawing.Size(285, 20);
            this.part_manufTextEdit.TabIndex = 7;
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
            // part_priceSpinEdit
            // 
            this.part_priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "part_price", true));
            this.part_priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.part_priceSpinEdit.Location = new System.Drawing.Point(96, 87);
            this.part_priceSpinEdit.Name = "part_priceSpinEdit";
            this.part_priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.part_priceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.part_priceSpinEdit.TabIndex = 9;
            // 
            // iMGPictureEdit
            // 
            this.iMGPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partsBindingSource, "IMG", true));
            this.iMGPictureEdit.Location = new System.Drawing.Point(10, 220);
            this.iMGPictureEdit.Name = "iMGPictureEdit";
            this.iMGPictureEdit.Size = new System.Drawing.Size(371, 233);
            this.iMGPictureEdit.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "part_details", true));
            this.richTextBox1.Location = new System.Drawing.Point(96, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // TFormManagePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 465);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.iMGPictureEdit);
            this.Controls.Add(part_priceLabel);
            this.Controls.Add(this.part_priceSpinEdit);
            this.Controls.Add(part_manufLabel);
            this.Controls.Add(this.part_manufTextEdit);
            this.Controls.Add(part_nameLabel);
            this.Controls.Add(this.part_nameTextEdit);
            this.Controls.Add(part_detailsLabel);
            this.Controls.Add(part_IDLabel);
            this.Controls.Add(this.part_IDLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TFormManagePart";
            this.Text = "TFormManagePart";
            this.Load += new System.EventHandler(this.TFormManagePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_manufTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_priceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGPictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.Label part_IDLabel1;
        private DevExpress.XtraEditors.TextEdit part_nameTextEdit;
        private DevExpress.XtraEditors.TextEdit part_manufTextEdit;
        private DevExpress.XtraEditors.SpinEdit part_priceSpinEdit;
        private DevExpress.XtraEditors.PictureEdit iMGPictureEdit;
        private System.Windows.Forms.RichTextBox richTextBox1;


    }
}