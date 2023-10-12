using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		public const int k_iCallback = 1330;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;

		public ulong m_ulUnused;
	}
}
