using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct LeaderboardUGCSet_t
	{
		public const int k_iCallback = 1111;

		public EResult m_eResult;

		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}
