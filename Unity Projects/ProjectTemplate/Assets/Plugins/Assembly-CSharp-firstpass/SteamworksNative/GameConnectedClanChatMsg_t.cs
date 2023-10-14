using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 20)]
	public struct GameConnectedClanChatMsg_t
	{
		public const int k_iCallback = 338;

		public CSteamID m_steamIDClanChat;

		public CSteamID m_steamIDUser;

		public int m_iMessageID;
	}
}
