using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 40)]
	public struct SearchForGameProgressCallback_t
	{
		public const int k_iCallback = 5201;

		public ulong m_ullSearchID;

		public EResult m_eResult;

		public CSteamID m_lobbyID;

		public CSteamID m_steamIDEndedSearch;

		public int m_nSecondsRemainingEstimate;

		public int m_cPlayersSearching;
	}
}
