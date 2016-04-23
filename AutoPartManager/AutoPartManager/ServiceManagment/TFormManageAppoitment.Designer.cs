namespace ServiceManagment
{
    partial class TFormManageAppoitment
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
            this.lblClient = new System.Windows.Forms.Label();
            this.ClientsBndSrc = new System.Windows.Forms.BindingSource(this.components);
            this.CommonDataSet = new ServiceManagment.TCommonDataSet();
            this.SrchClient = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.AppmntBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.AppointmentsDataset = new ServiceManagment.TAppointmentsDataset();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.AppntDate = new System.Windows.Forms.DateTimePicker();
            this.AppTime = new DevExpress.XtraEditors.TimeEdit();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.SrchClientCar = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ClientCarsBindSrc = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cLIENT_CARSTableAdapter = new ServiceManagment.TAppointmentsDatasetTableAdapters.CLIENT_CARSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBndSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppmntBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchClientCar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCarsBindSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(21, 25);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Клиент";
            // 
            // ClientsBndSrc
            // 
            this.ClientsBndSrc.DataMember = "Clients";
            this.ClientsBndSrc.DataSource = this.CommonDataSet;
            // 
            // CommonDataSet
            // 
            this.CommonDataSet.DataSetName = "TCommonDataSet";
            this.CommonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SrchClient
            // 
            this.SrchClient.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AppmntBindSrc, "CLIENT_ID", true));
            this.SrchClient.Location = new System.Drawing.Point(102, 22);
            this.SrchClient.Name = "SrchClient";
            this.SrchClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SrchClient.Properties.DataSource = this.ClientsBndSrc;
            this.SrchClient.Properties.DisplayMember = "CLIENT_NAME";
            this.SrchClient.Properties.ValueMember = "CLIENT_ID";
            this.SrchClient.Properties.View = this.searchLookUpEdit1View;
            this.SrchClient.Size = new System.Drawing.Size(238, 20);
            this.SrchClient.TabIndex = 3;
            // 
            // AppmntBindSrc
            // 
            this.AppmntBindSrc.DataMember = "APPOITMENTS";
            this.AppmntBindSrc.DataSource = this.AppointmentsDataset;
            // 
            // AppointmentsDataset
            // 
            this.AppointmentsDataset.DataSetName = "TAppointmentsDataset";
            this.AppointmentsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(21, 60);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(62, 13);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Дата и час";
            // 
            // AppntDate
            // 
            this.AppntDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.AppmntBindSrc, "APPOITMENT_DATE", true));
            this.AppntDate.Location = new System.Drawing.Point(102, 60);
            this.AppntDate.Name = "AppntDate";
            this.AppntDate.Size = new System.Drawing.Size(238, 20);
            this.AppntDate.TabIndex = 5;
            // 
            // AppTime
            // 
            this.AppTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AppmntBindSrc, "APPOITMENT_DATE", true));
            this.AppTime.EditValue = new System.DateTime(2016, 3, 13, 0, 0, 0, 0);
            this.AppTime.Location = new System.Drawing.Point(102, 95);
            this.AppTime.Name = "AppTime";
            this.AppTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AppTime.Size = new System.Drawing.Size(100, 20);
            this.AppTime.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(21, 98);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Дата и час";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(21, 130);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(35, 13);
            this.lblCar.TabIndex = 8;
            this.lblCar.Text = "Кола:";
            // 
            // SrchClientCar
            // 
            this.SrchClientCar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AppmntBindSrc, "CLIENT_CAR_ID", true));
            this.SrchClientCar.Location = new System.Drawing.Point(102, 127);
            this.SrchClientCar.Name = "SrchClientCar";
            this.SrchClientCar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SrchClientCar.Properties.DataSource = this.ClientCarsBindSrc;
            this.SrchClientCar.Properties.DisplayMember = "MODEL_ID";
            this.SrchClientCar.Properties.ValueMember = "CLIENT_CAR_ID";
            this.SrchClientCar.Properties.View = this.gridView1;
            this.SrchClientCar.Size = new System.Drawing.Size(238, 20);
            this.SrchClientCar.TabIndex = 9;
            // 
            // ClientCarsBindSrc
            // 
            this.ClientCarsBindSrc.DataMember = "CLIENT_CARS";
            this.ClientCarsBindSrc.DataSource = this.AppointmentsDataset;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(368, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cLIENT_CARSTableAdapter
            // 
            this.cLIENT_CARSTableAdapter.ClearBeforeFill = true;
            // 
            // TFormManageAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 386);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SrchClientCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.AppTime);
            this.Controls.Add(this.AppntDate);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.SrchClient);
            this.Controls.Add(this.lblClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TFormManageAppoitment";
            this.Text = "TFormManageAppoitment";
            this.Load += new System.EventHandler(this.TFormManageAppoitment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBndSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppmntBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrchClientCar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCarsBindSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.BindingSource AppmntBindSrc;
        private TAppointmentsDataset AppointmentsDataset;
        private TCommonDataSet CommonDataSet;
        private System.Windows.Forms.BindingSource ClientsBndSrc;
        private DevExpress.XtraEditors.SearchLookUpEdit SrchClient;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker AppntDate;
        private DevExpress.XtraEditors.TimeEdit AppTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCar;
        private DevExpress.XtraEditors.SearchLookUpEdit SrchClientCar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource ClientCarsBindSrc;
        private TAppointmentsDatasetTableAdapters.CLIENT_CARSTableAdapter cLIENT_CARSTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}