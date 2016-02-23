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


        public void InitAdapters()
        {
            ClientsTblAdapter = new ClientsTableAdapter();
            ClientByIDTblAdapter = new ClientByIDTableAdapter();
            ClientByID.TableNewRow += new DataTableNewRowEventHandler(ClientByID_OnTableNewRow);
            Clients.RowChanged += Clients_RowChanged;
        }

        void Clients_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            var val = e.Row["CLIENT_ID"];
            LoadClientByID(4);
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

    }
}

