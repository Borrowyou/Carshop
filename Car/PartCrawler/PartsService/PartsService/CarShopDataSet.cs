using System;
using System.Data;
using System.Data.SqlClient;
using PartsService.CarShopDataSetTableAdapters;
using CommonFuncsU;
using ResStringU;
namespace PartsService
{

    public partial class CarShopDataSet
    {

        public CarsTableAdapter CarsTblAdapter { get; set; }
        public PROVIDER_CATEGORIESTableAdapter ProvCategoryAdapter { get; set; }
        public SUB_CATEGORIESTableAdapter SubCategoryAdapter { get; set; }
        public PARTS_LINKTableAdapter PartLinkTblAdapter { get; set; }
        public PartsTableAdapter PartsTblAdapter { get; set; }
        public ModelsTableAdapter ModelsTblAdapter { get; set; }
        public void InitAdapters()
        {
            CarsTblAdapter = new CarsTableAdapter();
            ModelsTblAdapter = new ModelsTableAdapter();
            ProvCategoryAdapter = new PROVIDER_CATEGORIESTableAdapter();
            SubCategoryAdapter = new SUB_CATEGORIESTableAdapter();
            PartLinkTblAdapter = new PARTS_LINKTableAdapter();
            PartsTblAdapter = new PartsTableAdapter();
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

        public int GetCarIDByName(string sCarName)
        {
            return CarsTblAdapter.GetCarIDByName(sCarName).GetValueOrDefault(-1);
        }

        public int GetOrInsertCarIDByName(string sCarName)
        {
            int CarID = -1;
            CarID = GetCarIDByName(sCarName);
            if (CarID == -1)
            {
                CarID = GEN_ID("Cars");
                CarsTblAdapter.Insert(CarID, sCarName);
            }
            return CarID;

        }

        public int GetSubCategIDByName(string sSubCategName)
        {
            return SubCategoryAdapter.GetSubCategIDByName(sSubCategName).GetValueOrDefault(-1);
        }

        public int GetModelIDByModelInfo(int CarID, string[] ModelData)
        {
            return ModelsTblAdapter.GetModelIDByModelData(CarID, ModelData[0], CommonFuncs.StringToNInt(ModelData[1])
                                                   , CommonFuncs.StringToNInt(ModelData[2])).GetValueOrDefault(-1);
        }

        public int GetOrInsertModelIDByName(int CarID, string[] ModelData)
        {
            int ModelID = GetModelIDByModelInfo(CarID, ModelData);
            if (ModelID == -1)
            {
                ModelID = GEN_ID("Models");
                ModelsTblAdapter.Insert(ModelID, ModelData[0], CommonFuncs.StringToNInt(ModelData[1]),
                                CommonFuncs.StringToNInt(ModelData[2]), CarID, "");
            }
            return ModelID;
        }
        public int GetPrimaryCategIDByName(string PrimCategoryName)
        {
            return 0;
        }
        public void LoadPartsLink()
        {
            PartLinkTblAdapter.FillLinks(PARTS_LINK);
        }

    }
}

