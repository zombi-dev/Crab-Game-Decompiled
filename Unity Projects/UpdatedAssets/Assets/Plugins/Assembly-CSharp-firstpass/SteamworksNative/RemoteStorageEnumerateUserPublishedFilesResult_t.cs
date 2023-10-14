using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 416)]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		public const int k_iCallback = 1312;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		public PublishedFileId_t[] m_rgPublishedFileId;
	}
}
