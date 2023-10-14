using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 28)]
	public struct FavoritesListChanged_t
	{
		public const int k_iCallback = 502;

		public uint m_nIP;

		public uint m_nQueryPort;

		public uint m_nConnPort;

		public uint m_nAppID;

		public uint m_nFlags;

		public bool m_bAdd;

		public AccountID_t m_unAccountId;
	}
}
