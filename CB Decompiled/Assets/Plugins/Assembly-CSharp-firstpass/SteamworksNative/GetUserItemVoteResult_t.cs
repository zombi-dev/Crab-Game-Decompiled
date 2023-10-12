using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct GetUserItemVoteResult_t
	{
		public const int k_iCallback = 3409;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;

		public bool m_bVotedUp;

		public bool m_bVotedDown;

		public bool m_bVoteSkipped;
	}
}
