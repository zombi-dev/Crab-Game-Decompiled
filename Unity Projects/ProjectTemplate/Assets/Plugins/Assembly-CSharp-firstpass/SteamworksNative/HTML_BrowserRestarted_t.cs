using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct HTML_BrowserRestarted_t
	{
		public const int k_iCallback = 4527;

		public HHTMLBrowser unBrowserHandle;

		public HHTMLBrowser unOldBrowserHandle;
	}
}
