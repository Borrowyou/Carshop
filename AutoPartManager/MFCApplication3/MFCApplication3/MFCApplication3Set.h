
// MFCApplication3Set.h: interface of the CMFCApplication3Set class
//


#pragma once

// code generated on 23 април 2016 г., 00:11 ч.

[
	
// The connection string below may contain plain text passwords and/or
// other sensitive information. Please remove the #error after reviewing
// the connection string for any security related issues. You may want to
// store the password in some other form or use a different user authentication.
db_source(L"Provider=SQLNCLI10.1;Integrated Security=\"\";Persist Security Info=False;User ID=fit;Initial Catalog=CarShop;Data Source=SERVER1;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=SERVER1;Initial File Name=\"\";Use Encryption for Data=False;Tag with column collation when possible=False;MARS Connection=False;DataTypeCompatibility=0;Trust Server Certificate=False"),
	db_table(L"dbo.CLIENT_CARS")
]
class CMFCApplication3Set
{
public:
	[ db_column(ordinal=L"CLIENT_CAR_ID", status=L"m_dwCLIENT_CAR_IDStatus", length=L"m_dwCLIENT_CAR_IDLength") ] LONG m_CLIENT_CAR_ID;
	[ db_column(ordinal=L"CLIENT_ID", status=L"m_dwCLIENT_IDStatus", length=L"m_dwCLIENT_IDLength") ] LONG m_CLIENT_ID;
	[ db_column(ordinal=L"CAR_ID", status=L"m_dwCAR_IDStatus", length=L"m_dwCAR_IDLength") ] LONG m_CAR_ID;
	[ db_column(ordinal=L"MODEL_ID", status=L"m_dwMODEL_IDStatus", length=L"m_dwMODEL_IDLength") ] LONG m_MODEL_ID;
	[ db_column(ordinal=L"CAR_YEAR", status=L"m_dwCAR_YEARStatus", length=L"m_dwCAR_YEARLength") ] LONG m_CAR_YEAR;
	[ db_column(ordinal=L"ENGINE_TYPE", status=L"m_dwENGINE_TYPEStatus", length=L"m_dwENGINE_TYPELength") ] TCHAR m_ENGINE_TYPE[21];
	[ db_column(ordinal=L"ENGINE_SIZE", status=L"m_dwENGINE_SIZEStatus", length=L"m_dwENGINE_SIZELength") ] double m_ENGINE_SIZE;

	// The following wizard-generated data members contain status
	// values for the corresponding fields. You
	// can use these values to hold NULL values that the database
	// returns or to hold error information when the compiler returns
	// errors. See Field Status Data Members in Wizard-Generated
	// Accessors in the Visual C++ documentation for more information
	// on using these fields.
	// NOTE: You must initialize these fields before setting/inserting data!

	DBSTATUS m_dwCLIENT_CAR_IDStatus;
	DBSTATUS m_dwCLIENT_IDStatus;
	DBSTATUS m_dwCAR_IDStatus;
	DBSTATUS m_dwMODEL_IDStatus;
	DBSTATUS m_dwCAR_YEARStatus;
	DBSTATUS m_dwENGINE_TYPEStatus;
	DBSTATUS m_dwENGINE_SIZEStatus;

	// The following wizard-generated data members contain length
	// values for the corresponding fields.
	// NOTE: For variable-length columns, you must initialize these
	//       fields before setting/inserting data!

	DBLENGTH m_dwCLIENT_CAR_IDLength;
	DBLENGTH m_dwCLIENT_IDLength;
	DBLENGTH m_dwCAR_IDLength;
	DBLENGTH m_dwMODEL_IDLength;
	DBLENGTH m_dwCAR_YEARLength;
	DBLENGTH m_dwENGINE_TYPELength;
	DBLENGTH m_dwENGINE_SIZELength;


	void GetRowsetProperties(CDBPropSet* pPropSet)
	{
		pPropSet->AddProperty(DBPROP_CANFETCHBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
		pPropSet->AddProperty(DBPROP_CANSCROLLBACKWARDS, true, DBPROPOPTIONS_OPTIONAL);
	}
};

