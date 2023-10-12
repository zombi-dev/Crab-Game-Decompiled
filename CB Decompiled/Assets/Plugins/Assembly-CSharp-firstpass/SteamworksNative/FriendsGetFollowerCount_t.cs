using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 16)]
	public struct FriendsGetFollowerCount_t
	{
		public const int k_iCallback = 344;

		public EResult m_eResult;

		public CSteamID m_steamID;

		public int m_nCount;
	}
}
