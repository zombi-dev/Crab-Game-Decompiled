using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 64)]
	public struct RequestPlayersForGameResultCallback_t
	{
		public const int k_iCallback = 5212;

		public EResult m_eResult;

		public ulong m_ullSearchID;

		public CSteamID m_SteamIDPlayerFound;

		public CSteamID m_SteamIDLobby;

		public PlayerAcceptState_t m_ePlayerAcceptState;

		public int m_nPlayerIndex;

		public int m_nTotalPlayersFound;

		public int m_nTotalPlayersAcceptedGame;

		public int m_nSuggestedTeamIndex;

		public ulong m_ullUniqueGameID;
	}
}
