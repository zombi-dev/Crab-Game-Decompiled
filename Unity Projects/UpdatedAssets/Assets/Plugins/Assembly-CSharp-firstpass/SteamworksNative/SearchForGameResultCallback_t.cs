using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 32)]
	public struct SearchForGameResultCallback_t
	{
		public const int k_iCallback = 5202;

		public ulong m_ullSearchID;

		public EResult m_eResult;

		public int m_nCountPlayersInGame;

		public int m_nCountAcceptedGame;

		public CSteamID m_steamIDHost;

		public bool m_bFinalCallback;
	}
}
