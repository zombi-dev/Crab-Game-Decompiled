using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct LobbyDataUpdate_t
	{
		public const int k_iCallback = 505;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDMember;

		public byte m_bSuccess;
	}
}
