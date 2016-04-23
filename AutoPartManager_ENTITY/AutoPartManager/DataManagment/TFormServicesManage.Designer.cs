namespace DataManagment
{
    partial class TFormServicesManage
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
            this.gridServices = new DevExpress.XtraGrid.GridControl();
            this.gridViewServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ServiceBindSrc = new System.Windows.Forms.BindingSource();
            this.CommonDataSet = new DataManagment.TCommonDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridServices
            // 
            this.gridServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridServices.Location = new System.Drawing.Point(0, 0);
            this.gridServices.MainView = this.gridViewServices;
            this.gridServices.Name = "gridServices";
            this.gridServices.Size = new System.Drawing.Size(533, 287);
            this.gridServices.TabIndex = 0;
            this.gridServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServices});
            // 
            // gridViewServices
            // 
            this.gridViewServices.GridControl = this.gridServices;
            this.gridViewServices.Name = "gridViewServices";
            // 
            // ServiceBindSrc
            // 
            this.ServiceBindSrc.DataMember = "SERVICES";
            this.ServiceBindSrc.DataSource = this.CommonDataSet;
            // 
            // tCommonDataSet
            // 
            this.CommonDataSet.DataSetName = "TCommonDataSet";
            this.CommonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TFormServicesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 287);
            this.Controls.Add(this.gridServices);
            this.Name = "TFormServicesManage";
            this.Text = "TFormServicesManage";
            this.Load += new System.EventHandler(this.TFormServicesManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridServices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewServices;
        private System.Windows.Forms.BindingSource ServiceBindSrc;
        private TCommonDataSet CommonDataSet;
    }
}