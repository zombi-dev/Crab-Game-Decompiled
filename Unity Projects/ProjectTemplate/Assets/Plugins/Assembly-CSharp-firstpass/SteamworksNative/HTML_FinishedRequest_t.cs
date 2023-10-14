using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct HTML_FinishedRequest_t
	{
		public const int k_iCallback = 4506;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchPageTitle;
	}
}
