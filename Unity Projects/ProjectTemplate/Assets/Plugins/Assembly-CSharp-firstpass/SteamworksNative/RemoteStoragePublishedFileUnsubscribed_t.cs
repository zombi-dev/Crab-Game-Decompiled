using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		public const int k_iCallback = 1322;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
}
