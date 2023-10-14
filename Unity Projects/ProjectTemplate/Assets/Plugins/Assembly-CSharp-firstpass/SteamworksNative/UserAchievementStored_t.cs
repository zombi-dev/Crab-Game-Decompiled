using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 152)]
	public struct UserAchievementStored_t
	{
		public const int k_iCallback = 1103;

		public ulong m_nGameID;

		public bool m_bGroupAchievement;

		private byte[] m_rgchAchievementName_;

		public uint m_nCurProgress;

		public uint m_nMaxProgress;

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
