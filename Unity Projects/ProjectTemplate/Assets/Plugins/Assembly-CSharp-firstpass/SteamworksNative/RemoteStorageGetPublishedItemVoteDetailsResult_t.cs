using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 32)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		public const int k_iCallback = 1320;

		public EResult m_eResult;

		public PublishedFileId_t m_unPublishedFileId;

		public int m_nVotesFor;

		public int m_nVotesAgainst;

		public int m_nReports;

		public float m_fScore;
	}
}
