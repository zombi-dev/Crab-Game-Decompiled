using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct LobbyGameCreated_t
	{
		public const int k_iCallback = 509;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDGameServer;

		public uint m_unIP;

		public ushort m_usPort;
	}
}
