using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct RemoteStoragePublishFileProgress_t
	{
		public const int k_iCallback = 1329;

		public double m_dPercentFile;

		public bool m_bPreview;
	}
}
