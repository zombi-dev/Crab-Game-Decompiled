using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct HTML_FileOpenDialog_t
	{
		public const int k_iCallback = 4516;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;

		public string pchInitialFile;
	}
}
