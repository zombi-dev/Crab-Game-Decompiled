using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 40)]
	public struct HTML_NewWindow_t
	{
		public const int k_iCallback = 4521;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public uint unX;

		public uint unY;

		public uint unWide;

		public uint unTall;

		public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE;
	}
}
