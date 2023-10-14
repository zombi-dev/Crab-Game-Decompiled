using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct HTML_ChangedTitle_t
	{
		public const int k_iCallback = 4508;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;
	}
}
