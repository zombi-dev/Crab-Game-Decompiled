using System;

namespace SteamworksNative
{
	public static class SteamHTMLSurface
	{
		public static bool Init()
		{
			return false;
		}

		public static bool Shutdown()
		{
			return false;
		}

		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(SteamAPICall_t);
		}

		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = false)
		{
		}

		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0u, bool bSecure = false, bool bHTTPOnly = false)
		{
		}

		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
		}

		public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
		}

		public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle)
		{
		}

		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
		}
	}
}
