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
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.PartBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.PartsDataSet = new DataManagment.TPartsDataSet();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblIntID = new DevExpress.XtraEditors.LabelControl();
            this.DBLblIntNumb = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.PartBindSrc, "IMG", true));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 187);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(343, 163);
            this.pictureEdit1.TabIndex = 0;
            // 
            // PartBindSrc
            // 
            this.PartBindSrc.DataMember = "Parts";
            this.PartBindSrc.DataSource = this.PartsDataSet;
            // 
            // PartsDataSet
            // 
            this.PartsDataSet.DataSetName = "TPartsDataSet";
            this.PartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(63, 74);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // lblIntID
            // 
            this.lblIntID.Location = new System.Drawing.Point(12, 12);
            this.lblIntID.Name = "lblIntID";
            this.lblIntID.Size = new System.Drawing.Size(89, 13);
            this.lblIntID.TabIndex = 2;
            this.lblIntID.Text = "Вътрешен Номер:";
            // 
            // DBLblIntNumb
            // 
            this.DBLblIntNumb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PartBindSrc, "Part_ID", true));
            this.DBLblIntNumb.Location = new System.Drawing.Point(107, 12);
            this.DBLblIntNumb.Name = "DBLblIntNumb";
            this.DBLblIntNumb.Size = new System.Drawing.Size(89, 13);
            this.DBLblIntNumb.TabIndex = 3;
            this.DBLblIntNumb.Text = "Вътрешен Номер:";
            // 
            // TFormManagePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 362);
            this.Controls.Add(this.DBLblIntNumb);
            this.Controls.Add(this.lblIntID);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TFormManagePart";
            this.Text = "TFormManagePart";
            this.Load += new System.EventHandler(this.TFormManagePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.BindingSource PartBindSrc;
        private TPartsDataSet PartsDataSet;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblIntID;
        private DevExpress.XtraEditors.LabelControl DBLblIntNumb;

    }
}