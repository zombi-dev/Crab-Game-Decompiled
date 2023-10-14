using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct HTML_SetCursor_t
	{
		public const int k_iCallback = 4522;

		public HHTMLBrowser unBrowserHandle;

		public uint eMouseCursor;
	}
}
