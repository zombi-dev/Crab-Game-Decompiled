using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 144)]
	public struct UserAchievementIconFetched_t
	{
		public const int k_iCallback = 1109;

		public CGameID m_nGameID;

		private byte[] m_rgchAchievementName_;

		public bool m_bAchieved;

		public int m_nIconHandle;

		public string m_rgchAchievementName
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
