using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct HTML_BrowserReady_t
	{
		public const int k_iCallback = 4501;

		public HHTMLBrowser unBrowserHandle;
	}
}
