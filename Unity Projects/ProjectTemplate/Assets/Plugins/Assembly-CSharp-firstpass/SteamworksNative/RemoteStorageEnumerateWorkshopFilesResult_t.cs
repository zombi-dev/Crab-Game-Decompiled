using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 624)]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		public const int k_iCallback = 1319;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		public PublishedFileId_t[] m_rgPublishedFileId;

		public float[] m_rgScore;

		public AppId_t m_nAppId;

		public uint m_unStartIndex;
	}
}
