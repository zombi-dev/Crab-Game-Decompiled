using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct LobbyInvite_t
	{
		public const int k_iCallback = 503;

		public ulong m_ulSteamIDUser;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulGameID;
	}
}
