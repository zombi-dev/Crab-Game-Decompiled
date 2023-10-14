using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct RemoteStoragePublishFileResult_t
	{
		public const int k_iCallback = 1309;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
