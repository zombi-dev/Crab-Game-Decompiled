using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct LobbyKicked_t
	{
		public const int k_iCallback = 512;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDAdmin;

		public byte m_bKickedDueToDisconnect;
	}
}
