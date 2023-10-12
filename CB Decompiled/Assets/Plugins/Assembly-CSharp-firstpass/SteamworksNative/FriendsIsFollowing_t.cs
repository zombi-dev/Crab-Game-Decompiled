using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 16)]
	public struct FriendsIsFollowing_t
	{
		public const int k_iCallback = 345;

		public EResult m_eResult;

		public CSteamID m_steamID;

		public bool m_bIsFollowing;
	}
}
