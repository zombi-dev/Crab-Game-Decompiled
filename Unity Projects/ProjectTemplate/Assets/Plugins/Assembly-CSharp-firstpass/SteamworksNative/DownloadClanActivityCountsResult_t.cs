using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 1)]
	public struct DownloadClanActivityCountsResult_t
	{
		public const int k_iCallback = 341;

		public bool m_bSuccess;
	}
}
