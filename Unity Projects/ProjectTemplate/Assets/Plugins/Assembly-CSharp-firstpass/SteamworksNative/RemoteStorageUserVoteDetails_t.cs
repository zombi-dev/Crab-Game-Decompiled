using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct RemoteStorageUserVoteDetails_t
	{
		public const int k_iCallback = 1325;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public EWorkshopVote m_eVote;
	}
}
