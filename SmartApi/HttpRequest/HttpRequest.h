// HttpRequest.h : main header file for the HttpRequest DLL
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resourceppc.h"

// CHttpRequestApp
// See HttpRequest.cpp for the implementation of this class
//

class CHttpRequestApp : public CWinApp
{
public:
	CHttpRequestApp();

// Overrides
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};

