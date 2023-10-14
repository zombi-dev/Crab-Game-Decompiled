using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct HTML_HideToolTip_t
	{
		public const int k_iCallback = 4526;

		public HHTMLBrowser unBrowserHandle;
	}
}
