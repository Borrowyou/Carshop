using DataManagment.TPartsDataSetTableAdapters;
using System.Data;
using System;
using System.Data.SqlClient;

namespace DataManagment {

    public partial class TPartsDataSet 
    {
        
    //    private ModelPartsTableAdapter _ModelPartsTblAdapter;
    //    private PartsTableAdapter _PartsTableAdapter;
    //    private TCommonDataSet _CommonDataSet;
    //    private PartsSrchFilterTableAdapter PartFilterAdapter;

    //    public TCommonDataSet CommonDataSet
    //    {
    //        get 
    //        {
    //            if (_CommonDataSet == null)
    //                _CommonDataSet = new TCommonDataSet();
    //            return this._CommonDataSet;
    //        }

    //        set { _CommonDataSet = value; }

    //    }

    //    public void SetEvents()
    //    {
    //        this.ModelParts.ColumnChanged += new DataColumnChangeEventHandler(ModelParts_ColumnChanged);
    //        this.PartsSrchFilter.ColumnChanged += new DataColumnChangeEventHandler(SrchFilter_Cars_ColumnChanged);
    //    }

    //    public PartsSrchFilterTableAdapter PartFilterTblAdapter
    //    {
    //        get {
    //            if (PartFilterAdapter == null)
    //                PartFilterAdapter = new PartsSrchFilterTableAdapter();
    //            return PartFilterAdapter;
    //            }
    //        set
    //        { PartFilterAdapter = value; }
    //    }

    //    public ModelPartsTableAdapter ModelPartsTblAdapter
    //    {
    //        get
    //        {
    //            if (_ModelPartsTblAdapter == null)
    //                _ModelPartsTblAdapter = new ModelPartsTableAdapter();
    //            return _ModelPartsTblAdapter;
    //        }
    //        set
    //        { _ModelPartsTblAdapter = value; }
    //    }


    //    public PartsTableAdapter PartsTblAdapter
    //    {
    //        get
    //        {
    //            if (_PartsTableAdapter == null)
    //                _PartsTableAdapter = new PartsTableAdapter();
    //            return _PartsTableAdapter;
    //        }
    //        set
    //        { _PartsTableAdapter = value; }
    //    }

    //    public void LoadAllParts()
    //    {
    //        InsSearchFilter();
    //        SetEvents();
    //        ModelPartsTblAdapter.Fill(ModelParts);
    //    }

    //    private void ModelParts_ColumnChanged(object sender, DataColumnChangeEventArgs e)
    //    { 
        
    //    }

    //    public void LoadPartByID(int PartID)
    //    {
    //        PartsTblAdapter.FillPartByID(Parts, PartID);   
    //    }

    //    private void SrchFilter_Cars_ColumnChanged(object sender, DataColumnChangeEventArgs e)
    //    {
    //        if (e.Column.ToString() == "Car_ID")
    //        {

    //            var ValCarID = Convert.ToInt32(e.Row["CAR_ID"]);

    //            var ValModel = Convert.ToInt32(e.Row["Model_ID"]);
    //            CommonDataSet.LoadModelsByCarID(ValCarID);
    //            LoadModelsPartsByModel(ValCarID, ValModel);

    //        }
    //        else if (e.Column.ToString() == "Model_ID")
    //        {
    //            var ValCarID = Convert.ToInt32(e.Row["CAR_ID"]);

    //            var ValModel = Convert.ToInt32(e.Row["Model_ID"]);
    //            LoadModelsPartsByModel(ValCarID, ValModel);
    //        }


    //    }

    //    private void InsSearchFilter()
    //    {
    //        PartFilterTblAdapter.FillSrchFilter(PartsSrchFilter);
    //    }

    //    public void LoadModelsPartsByModel(int CarID, int ModelID)
    //    {
    //        ModelPartsTblAdapter.FilModelPartsByCarModelID(ModelParts, CarID, ModelID);
    //    }
    //
    }
}
