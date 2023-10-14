using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		public const int k_iCallback = 1332;

		public SteamAPICall_t m_hFileReadAsync;

		public EResult m_eResult;

		public uint m_nOffset;

		public uint m_cubRead;
	}
}
