
// MFCApplication3View.h : interface of the CMFCApplication3View class
//

#pragma once

class CMFCApplication3Set;

class CMFCApplication3View : public COleDBRecordView
{
protected: // create from serialization only
	CMFCApplication3View();
	DECLARE_DYNCREATE(CMFCApplication3View)

public:
	enum{ IDD = IDD_MFCAPPLICATION3_FORM };
	CMFCApplication3Set* m_pSet;

// Attributes
public:
	CMFCApplication3Doc* GetDocument() const;

// Operations
public:

// Overrides
public:
	virtual CRowset<>* OnGetRowset();
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual void OnInitialUpdate(); // called first time after construct
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// Implementation
public:
	virtual ~CMFCApplication3View();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in MFCApplication3View.cpp
inline CMFCApplication3Doc* CMFCApplication3View::GetDocument() const
   { return reinterpret_cast<CMFCApplication3Doc*>(m_pDocument); }
#endif

