using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct NumberOfCurrentPlayers_t
	{
		public const int k_iCallback = 1107;

		public byte m_bSuccess;

		public int m_cPlayers;
	}
}
