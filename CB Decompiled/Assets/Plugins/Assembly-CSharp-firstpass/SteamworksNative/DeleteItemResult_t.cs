using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct DeleteItemResult_t
	{
		public const int k_iCallback = 3417;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
}
