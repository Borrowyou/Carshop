using System.Data;
using System;
using System.Data.SqlClient;
using DataManagment.TCommonDataSetTableAdapters;
namespace DataManagment {

    public partial class TCommonDataSet
    {
        LOOKUP_ITEMSTableAdapter LookUpItmsAdapter;
        CarsTableAdapter CarsAdapter;
        ModelsTableAdapter ModelsAdapter;


        public ModelsTableAdapter ModelsTblAdapter
        {
            get
            {
                if (ModelsAdapter == null)
                    ModelsAdapter = new ModelsTableAdapter();
                return ModelsAdapter;
            }
            set { ModelsAdapter = value; }
        }
        public CarsTableAdapter CarsTblAdapter {
            get
            { 
                if (CarsAdapter == null)
                    CarsAdapter = new CarsTableAdapter();
                return CarsAdapter;
            }
            set { CarsAdapter = value; } 
        }
        public LOOKUP_ITEMSTableAdapter LUpsTblAdapter
        {
            get
            {
                if (LookUpItmsAdapter == null)
                    LookUpItmsAdapter = new LOOKUP_ITEMSTableAdapter();
                return LookUpItmsAdapter;
            }

            set { this.LookUpItmsAdapter = value; }
        }

        public void LoadAllCarMarks()
        {
            CarsTblAdapter.Fill(Cars);
            var CarID = Convert.ToInt32(Cars.Rows[0]["Car_ID"]);
            ModelsTblAdapter.FillModelsByCarID(Models, CarID);
        }

        public void LoadLookUpByName(string LName)
        {
            LUpsTblAdapter.FillLookUpByName(LOOKUP_ITEMS, LName);
        }

        public void LoadModelsByCarID(int CarID)
        {
            ModelsTblAdapter.FillModelsByCarID(Models, CarID);
        }
    }

}

