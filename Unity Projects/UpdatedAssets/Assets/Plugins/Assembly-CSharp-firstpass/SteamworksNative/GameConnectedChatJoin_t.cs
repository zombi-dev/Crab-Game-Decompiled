using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct GameConnectedChatJoin_t
	{
		public const int k_iCallback = 339;

		public CSteamID m_steamIDClanChat;

		public CSteamID m_steamIDUser;
	}
}
