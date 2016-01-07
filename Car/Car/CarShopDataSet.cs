using System;
using System.Data;
using System.Data.SqlClient;
using Car.CarShopDataSetTableAdapters;

namespace Car {
    
    
    public partial class CarShopDataSet {
       // CarsTableAdapter CarsTblAdapter;
       // PROVIDER_CATEGORIESTableAdapter ProvCategoryAdapter;
        
        public CarsTableAdapter CarsTblAdapter  { get; set; }
        public PROVIDER_CATEGORIESTableAdapter ProvCategoryAdapter { get; set; }
        public SUB_CATEGORIESTableAdapter SubCategoryAdapter { get; set; }
        public void InitAdapters()
        {
            CarsTblAdapter = new CarsTableAdapter();
            ProvCategoryAdapter = new PROVIDER_CATEGORIESTableAdapter();
            SubCategoryAdapter = new SUB_CATEGORIESTableAdapter();
        }

        public int GEN_ID(String sGenerator)
        {
            using (SqlConnection conn = new SqlConnection(CarsTblAdapter.Connection.ConnectionString.ToString()))
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
                int GenValue = Convert.ToInt32(cmd.Parameters["@NEW_VALUE"].Value);
                conn.Close();
                return GenValue;
            }

        } //bla
    }
}
