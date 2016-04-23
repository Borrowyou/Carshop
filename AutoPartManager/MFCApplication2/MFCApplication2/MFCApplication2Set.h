
// MFCApplication2Set.h: interface of the CMFCApplication2Set class
//


#pragma once

// code generated on 21 април 2016 г., 21:38 ч.

class CMFCApplication2SetAccessor
{
public:
	LONG m_APPOITMENT_ID;
	DBTIMESTAMP m_APPOITMENT_DATE;
	LONG m_CLIENT_ID;
	LONG m_CLIENT_CAR_ID;

	// The following wizard-generated data members contain status
	// values for the corresponding fields in the column map. You
	// can use these values to hold NULL values that the database
	// returns or to hold error information when the compiler returns
	// errors. See Field Status Data Members in Wizard-Generated
	// Accessors in the Visual C++ documentation for more information
	// on using these fields.
	// NOTE: You must initialize these fields before setting/inserting data!

	DBSTATUS m_dwAPPOITMENT_IDStatus;
	DBSTATUS m_dwAPPOITMENT_DATEStatus;
	DBSTATUS m_dwCLIENT_IDStatus;
	DBSTATUS m_dwCLIENT_CAR_IDStatus;

	// The following wizard-generated data members contain length
	// values for the corresponding fields in the column map.
	// NOTE: For variable-length columns, you must initialize these
	//       fields before setting/inserting data!

	DBLENGTH m_dwAPPOITMENT_IDLength;
	DBLENGTH m_dwAPPOITMENT_DATELength;
	DBLENGTH m_dwCLIENT_IDLength;
	DBLENGTH m_dwCLIENT_CAR_IDLength;


	void GetRowsetProperties(CDBPropSet* pPropSet)
	{
		pPropSet->AddProperty(DBPROP_CANFETCHBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
		pPropSet->AddProperty(DBPROP_CANSCROLLBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
	}

	HRESULT OpenDataSource()
	{
		CDataSource _db;
		HRESULT hr;
#error Security Issue: The connection string may contain a password
// The connection string below may contain plain text passwords and/or
// other sensitive information. Please remove the #error after reviewing
// the connection string for any security related issues. You may want to
// store the password in some other form or use a different user authentication.
		hr = _db.OpenFromInitializationString(L"Provider=SQLNCLI10.1;Integrated Security=\"\";Persist Security Info=False;User ID=fit;Initial Catalog=CarShop;Data Source=SERVER1;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=SERVER1;Initial File Name=\"\";Use Encryption for Data=False;Tag with column collation when possible=False;MARS Connection=False;DataTypeCompatibility=0;Trust Server Certificate=False");
		if (FAILED(hr))
		{
#ifdef _DEBUG
			AtlTraceErrorRecords(hr);
#endif
			return hr;
		}
		return m_session.Open(_db);
	}

	void CloseDataSource()
	{
		m_session.Close();
	}

	operator const CSession&()
	{
		return m_session;
	}

	CSession m_session;

	BEGIN_COLUMN_MAP(CMFCApplication2SetAccessor)
		COLUMN_ENTRY_LENGTH_STATUS(1, m_APPOITMENT_ID, m_dwAPPOITMENT_IDLength, m_dwAPPOITMENT_IDStatus)
		COLUMN_ENTRY_LENGTH_STATUS(2, m_APPOITMENT_DATE, m_dwAPPOITMENT_DATELength, m_dwAPPOITMENT_DATEStatus)
		COLUMN_ENTRY_LENGTH_STATUS(3, m_CLIENT_ID, m_dwCLIENT_IDLength, m_dwCLIENT_IDStatus)
		COLUMN_ENTRY_LENGTH_STATUS(4, m_CLIENT_CAR_ID, m_dwCLIENT_CAR_IDLength, m_dwCLIENT_CAR_IDStatus)
	END_COLUMN_MAP()
};

class CMFCApplication2Set : public CTable<CAccessor<CMFCApplication2SetAccessor> >
{
public:
	HRESULT OpenAll()
	{
		HRESULT hr;
		hr = OpenDataSource();
		if (FAILED(hr))
			return hr;
		__if_exists(GetRowsetProperties)
		{
			CDBPropSet propset(DBPROPSET_ROWSET);
			__if_exists(HasBookmark)
			{
				if( HasBookmark() )
					propset.AddProperty(DBPROP_IRowsetLocate, true);
			}
			GetRowsetProperties(&propset);
			return OpenRowset(&propset);
		}
		__if_not_exists(GetRowsetProperties)
		{
			__if_exists(HasBookmark)
			{
				if( HasBookmark() )
				{
					CDBPropSet propset(DBPROPSET_ROWSET);
					propset.AddProperty(DBPROP_IRowsetLocate, true);
					return OpenRowset(&propset);
				}
			}
		}
		return OpenRowset();
	}

	HRESULT OpenRowset(DBPROPSET *pPropSet = NULL)
	{
		HRESULT hr = Open(m_session, L"dbo.APPOITMENTS", pPropSet);
#ifdef _DEBUG
		if(FAILED(hr))
			AtlTraceErrorRecords(hr);
#endif
		return hr;
	}

	void CloseAll()
	{
		Close();
		CloseDataSource();
	}
};

