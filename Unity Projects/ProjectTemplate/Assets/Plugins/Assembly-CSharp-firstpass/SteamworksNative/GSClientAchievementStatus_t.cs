using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 144)]
	public struct GSClientAchievementStatus_t
	{
		public const int k_iCallback = 206;

		public ulong m_SteamID;

		private byte[] m_pchAchievement_;

		public bool m_bUnlocked;

		public string m_pchAchievement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
