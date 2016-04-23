
// MFCApplication3Doc.h : interface of the CMFCApplication3Doc class
//


#pragma once
#include "MFCApplication3Set.h"


class CMFCApplication3Doc : public CDocument
{
protected: // create from serialization only
	CMFCApplication3Doc();
	DECLARE_DYNCREATE(CMFCApplication3Doc)

// Attributes
public:
	CMFCApplication3Set m_MFCApplication3Set;

// Operations
public:

// Overrides
public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);
#ifdef SHARED_HANDLERS
	virtual void InitializeSearchContent();
	virtual void OnDrawThumbnail(CDC& dc, LPRECT lprcBounds);
#endif // SHARED_HANDLERS

// Implementation
public:
	virtual ~CMFCApplication3Doc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	DECLARE_MESSAGE_MAP()

#ifdef SHARED_HANDLERS
	// Helper function that sets search content for a Search Handler
	void SetSearchContent(const CString& value);
#endif // SHARED_HANDLERS
};