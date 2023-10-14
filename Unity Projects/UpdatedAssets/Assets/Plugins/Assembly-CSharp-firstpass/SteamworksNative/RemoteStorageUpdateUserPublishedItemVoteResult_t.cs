using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		public const int k_iCallback = 1324;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
}
