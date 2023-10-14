using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct LobbyEnter_t
	{
		public const int k_iCallback = 504;

		public ulong m_ulSteamIDLobby;

		public uint m_rgfChatPermissions;

		public bool m_bLocked;

		public uint m_EChatRoomEnterResponse;
	}
}
