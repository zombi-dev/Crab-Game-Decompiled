using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 32)]
	public struct LobbyChatUpdate_t
	{
		public const int k_iCallback = 506;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDUserChanged;

		public ulong m_ulSteamIDMakingChange;

		public uint m_rgfChatMemberStateChange;
	}
}
