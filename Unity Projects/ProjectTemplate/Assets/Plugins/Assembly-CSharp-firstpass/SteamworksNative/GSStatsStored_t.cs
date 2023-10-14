using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 12)]
	public struct GSStatsStored_t
	{
		public const int k_iCallback = 1801;

		public EResult m_eResult;

		public CSteamID m_steamIDUser;
	}
}
