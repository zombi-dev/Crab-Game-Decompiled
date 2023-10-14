using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct RemoveUGCDependencyResult_t
	{
		public const int k_iCallback = 3413;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
