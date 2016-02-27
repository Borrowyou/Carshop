using DataManagment.ClientsDataSetTableAdapters;
using System.Data;
using System;
using System.Data.SqlClient;


namespace DataManagment

{
    
    
    public partial class ClientsDataSet
    {

        public ClientsTableAdapter ClientsTblAdapter { get; set; }
        public ClientByIDTableAdapter ClientByIDTblAdapter { get; set; }
        public CarsTableAdapter CarsTblAdapter { get; set; }
        public CLIENT_CARSTableAdapter ClientsCarsTblAdapter { get; set; }
        public ModelsTableAdapter ModelsTblAdapter { get; set; }
        public ModelYearsTableAdapter ModelYearsTblAdapter { get; set; }
        public FUN_YEARS_BETWEEN_LISTTableAdapter YearsBtwnTblAdapter { get; set; }
        public LOOKUP_ITEMSTableAdapter LookUpsTblAdapter { get; set; }

        public void InitAdapters()
        {
            ClientsTblAdapter = new ClientsTableAdapter();
            ClientByIDTblAdapter = new ClientByIDTableAdapter();
            CarsTblAdapter = new CarsTableAdapter();
            ClientsCarsTblAdapter = new CLIENT_CARSTableAdapter();
            ModelsTblAdapter = new ModelsTableAdapter();
            ModelYearsTblAdapter = new ModelYearsTableAdapter();
            YearsBtwnTblAdapter = new FUN_YEARS_BETWEEN_LISTTableAdapter();
            LookUpsTblAdapter = new LOOKUP_ITEMSTableAdapter();
            ClientByID.TableNewRow += new DataTableNewRowEventHandler(ClientByID_OnTableNewRow);
            Clients.RowChanged += Clients_RowChanged;
            CLIENT_CARS.RowChanged += CLIENT_CARS_RowChanged;
            CLIENT_CARS.TableNewRow += new DataTableNewRowEventHandler(Clients_Cars_OnTableNewRow);
            CLIENT_CARS.ColumnChanged += new DataColumnChangeEventHandler(Clients_Cars_ColumnChanged);
        }

        void Clients_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            int val = (int)e.Row["CLIENT_ID"];
            LoadClientByID(val);
        }

        void CLIENT_CARS_RowChanged(object sender, DataRowChangeEventArgs e)
        {
          /*  var r = e;
            var Row = e.Row["CAR_ID"];

            var Val = Convert.ToInt32(e.Row["CAR_ID"]);
            ModelsTblAdapter.FillModelsByCarID(Models, Val);
            
     
            var CarID = Convert.ToInt32(e.Row["CAR_ID"]);
            var ModelID = Convert.ToInt32(e.Row["MODEL_ID"]);
            var Model_Name = ModelsTblAdapter.GetModelNameByID(ModelID);
            ModelYearsTblAdapter.FillModelYearsByModel(ModelYears, CarID, Model_Name);

            var From = Convert.ToInt32(ModelYears.Rows[0]["YEARFROM"]);
            var To = Convert.ToInt32(ModelYears.Rows[0]["YEARTO"]);
            YearsBtwnTblAdapter.Fill(FUN_YEARS_BETWEEN_LIST, From, To);*/
           
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

        public void LoadClients()
        {
            ClientsTblAdapter.Fill(Clients);
        }
        public void LoadClientByID(int ClientID)
        {
            ClientByIDTblAdapter.FillClientByID(ClientByID, ClientID);
        }
        public void SaveClientByID()
        {
            try
            {
                ClientByIDTblAdapter.Update(ClientByID);
            }
            catch
            {
            }
        }
        private void  ClientByID_OnTableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["CLIENT_ID"] = GEN_ID("CLIENTS");
        }

        private void Clients_Cars_OnTableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["CLIENT_CAR_ID"] = GEN_ID("CLIENTS_CAR_ID");
            e.Row["Client_ID"] = ClientByID.Rows[0]["CLIENT_ID"];
        }

        public void LoadMarks()
        {
            CarsTblAdapter.Fill(Cars);
        }

        private void Clients_Cars_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ToString() == "CAR_ID")
            {
                var r = e;
                var Row = e.Row["CAR_ID"];

                var Val = Convert.ToInt32(e.Row["CAR_ID"]);
                ModelsTblAdapter.FillModelsByCarID(Models, Val);
            }
            else if (e.Column.ToString() == "MODEL_ID")
            { 
                var CarID = Convert.ToInt32(e.Row["CAR_ID"]);
                var ModelID = Convert.ToInt32(e.Row["MODEL_ID"]);
                var Model_Name = ModelsTblAdapter.GetModelNameByID(ModelID);
                ModelYearsTblAdapter.FillModelYearsByModel(ModelYears, CarID, Model_Name);

                var From = Convert.ToInt32(ModelYears.Rows[0]["YEARFROM"]);
                var To = Convert.ToInt32(ModelYears.Rows[0]["YEARTO"]);
                YearsBtwnTblAdapter.Fill(FUN_YEARS_BETWEEN_LIST, From, To);
            }
        }

        public void LoadLookUpByName(string LName)
        {
            LookUpsTblAdapter.FillLookUpByName(LOOKUP_ITEMS, LName);
        }

    }
}

