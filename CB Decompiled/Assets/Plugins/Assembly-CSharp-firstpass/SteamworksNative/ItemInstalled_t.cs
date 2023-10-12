using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct ItemInstalled_t
	{
		public const int k_iCallback = 3405;

		public AppId_t m_unAppID;

		public PublishedFileId_t m_nPublishedFileId;
	}
}
