using System.Data;
using System;
using System.Data.SqlClient;
using ServiceManagment.TAppointmentsDatasetTableAdapters;
namespace ServiceManagment {
   
    public partial class TAppointmentsDataset
    {
        TCommonDataSet CommonDSet;
        APPOITMENTSTableAdapter AppointmAdapter;
        CLIENT_CARSTableAdapter ClientCarsAdapter;

        public CLIENT_CARSTableAdapter ClientCarsTblAdapter
        {
            get
            {
                if (ClientCarsAdapter == null)
                    ClientCarsAdapter = new CLIENT_CARSTableAdapter();
                return ClientCarsAdapter;
            }
            set { ClientCarsAdapter = value; }
        }

        public APPOITMENTSTableAdapter AppointmTblAdapter
        {
            get
            {
                if (AppointmAdapter == null)
                    AppointmAdapter = new APPOITMENTSTableAdapter();
                return AppointmAdapter;
            }
            set { AppointmAdapter = value; }
        }

        public TCommonDataSet CommonDataset
        {
            get
            {
                if (CommonDSet == null)
                    CommonDSet = new TCommonDataSet();
                return CommonDSet;
            }

            set { CommonDSet = value; }

        }
        public int GEN_ID(String sGenerator)
        {
            bool Success = false;
            int GenValue = -1;
            while (!Success)
            {
                try
                {
                    string Conn = "Data Source=SERVER1;Initial Catalog=CarShop;User ID=fit;Password=fit";
                    using (SqlConnection conn = new SqlConnection(Conn))
                    using (SqlCommand cmd = new SqlCommand("dbo.SP_GEN_ID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // set up the parameters
                        cmd.Parameters.Add("@GENERATOR_NAME", SqlDbType.VarChar, 32);
                        cmd.Parameters.Add("@GENERATOR_STEP", SqlDbType.Int);
                        cmd.Parameters.Add("@NEW_VALUE", SqlDbType.Int).Direction = ParameterDirection.Output;

                        // set parameter values
                        cmd.Parameters["@GENERATOR_NAME"].Value = sGenerator;
                        cmd.Parameters["@GENERATOR_STEP"].Value = 1;
                        // open connection and execute stored procedure
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // read output value from @NewId
                        GenValue = Convert.ToInt32(cmd.Parameters["@NEW_VALUE"].Value);
                        conn.Close();
                        Success = true;

                    }
                }
                catch
                { }
            }
            return GenValue;
        }

        public void SetEvents()
        {
            APPOITMENTS.ColumnChanged += new DataColumnChangeEventHandler(Appoitments_ColumnChanged);
            APPOITMENTS.TableNewRow += new DataTableNewRowEventHandler(Appoitments_TableNewRow);
        }

        public void LoadAppmntByID(int AppID)
        { 
        
        }

        public void LoadClientCars(int ClientID)
        {
            ClientCarsTblAdapter.FillClientCarsByID(CLIENT_CARS, ClientID);
        }

        private void Appoitments_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ToString() == "CLIENT_ID")
            {
                int ClientID = Convert.ToInt32(e.Row["CLIENT_ID"]);
                LoadClientCars(ClientID);
            }
        }

        private void Appoitments_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["APPOITMENT_ID"] = GEN_ID("APPOITMENTS_ID");
        }

        public void SaveAppoitment()
        {
            APPOITMENTS.EndInit();
            AppointmTblAdapter.Update(APPOITMENTS);
        }
    }
}
