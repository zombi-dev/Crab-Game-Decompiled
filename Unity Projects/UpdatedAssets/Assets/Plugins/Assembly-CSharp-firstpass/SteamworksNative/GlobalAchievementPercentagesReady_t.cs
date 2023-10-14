using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct GlobalAchievementPercentagesReady_t
	{
		public const int k_iCallback = 1110;

		public ulong m_nGameID;

		public EResult m_eResult;
	}
}
