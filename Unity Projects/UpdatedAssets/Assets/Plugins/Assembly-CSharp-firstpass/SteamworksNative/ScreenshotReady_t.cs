using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct ScreenshotReady_t
	{
		public const int k_iCallback = 2301;

		public ScreenshotHandle m_hLocal;

		public EResult m_eResult;
	}
}
