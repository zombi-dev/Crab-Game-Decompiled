using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct DownloadItemResult_t
	{
		public const int k_iCallback = 3406;

		public AppId_t m_unAppID;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;
	}
}
