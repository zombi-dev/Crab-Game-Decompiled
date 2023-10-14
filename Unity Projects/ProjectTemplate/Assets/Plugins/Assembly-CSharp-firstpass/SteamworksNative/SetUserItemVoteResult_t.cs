using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct SetUserItemVoteResult_t
	{
		public const int k_iCallback = 3408;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;

		public bool m_bVoteUp;
	}
}
