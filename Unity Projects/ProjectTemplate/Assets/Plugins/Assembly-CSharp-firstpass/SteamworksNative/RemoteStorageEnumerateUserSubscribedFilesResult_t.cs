using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 616)]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		public const int k_iCallback = 1314;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		public PublishedFileId_t[] m_rgPublishedFileId;

		public uint[] m_rgRTimeSubscribed;
	}
}
