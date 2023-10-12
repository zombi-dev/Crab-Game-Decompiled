using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 12)]
	public struct GameConnectedFriendChatMsg_t
	{
		public const int k_iCallback = 343;

		public CSteamID m_steamIDUser;

		public int m_iMessageID;
	}
}
