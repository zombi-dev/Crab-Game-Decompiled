using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct LeaderboardFindResult_t
	{
		public const int k_iCallback = 1104;

		public SteamLeaderboard_t m_hSteamLeaderboard;

		public byte m_bLeaderboardFound;
	}
}
