using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct HTML_JSAlert_t
	{
		public const int k_iCallback = 4514;

		public HHTMLBrowser unBrowserHandle;

		public string pchMessage;
	}
}
