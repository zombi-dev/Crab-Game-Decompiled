using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 12)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		public const int k_iCallback = 342;

		public CSteamID m_steamIDClanChat;

		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}
