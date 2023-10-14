using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct GSStatsUnloaded_t
	{
		public const int k_iCallback = 1108;

		public CSteamID m_steamIDUser;
	}
}
