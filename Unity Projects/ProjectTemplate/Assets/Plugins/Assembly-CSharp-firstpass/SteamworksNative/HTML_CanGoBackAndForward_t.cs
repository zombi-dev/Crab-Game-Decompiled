using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct HTML_CanGoBackAndForward_t
	{
		public const int k_iCallback = 4510;

		public HHTMLBrowser unBrowserHandle;

		public bool bCanGoBack;

		public bool bCanGoForward;
	}
}
