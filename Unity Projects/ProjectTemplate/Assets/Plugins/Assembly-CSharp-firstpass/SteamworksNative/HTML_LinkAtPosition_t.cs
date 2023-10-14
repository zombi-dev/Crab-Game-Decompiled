using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 32)]
	public struct HTML_LinkAtPosition_t
	{
		public const int k_iCallback = 4513;

		public HHTMLBrowser unBrowserHandle;

		public uint x;

		public uint y;

		public string pchURL;

		public bool bInput;

		public bool bLiveLink;
	}
}
