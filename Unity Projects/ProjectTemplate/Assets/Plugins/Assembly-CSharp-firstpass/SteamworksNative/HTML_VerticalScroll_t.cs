using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct HTML_VerticalScroll_t
	{
		public const int k_iCallback = 4512;

		public HHTMLBrowser unBrowserHandle;

		public uint unScrollMax;

		public uint unScrollCurrent;

		public float flPageScale;

		public bool bVisible;

		public uint unPageSize;
	}
}
