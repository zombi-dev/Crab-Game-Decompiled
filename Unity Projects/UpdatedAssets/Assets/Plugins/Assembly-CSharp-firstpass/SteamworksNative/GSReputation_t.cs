using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 40)]
	public struct GSReputation_t
	{
		public const int k_iCallback = 209;

		public EResult m_eResult;

		public uint m_unReputationScore;

		public bool m_bBanned;

		public uint m_unBannedIP;

		public ushort m_usBannedPort;

		public ulong m_ulBannedGameID;

		public uint m_unBanExpires;
	}
}
