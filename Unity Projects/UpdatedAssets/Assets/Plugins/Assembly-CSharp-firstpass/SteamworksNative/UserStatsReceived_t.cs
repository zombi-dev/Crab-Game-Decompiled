using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(2, Pack = 1, Size = 24)]
	public struct UserStatsReceived_t
	{
		[FieldOffset(0)]
		public const int k_iCallback = 1101;

		[FieldOffset(0)]
		public ulong m_nGameID;

		[FieldOffset(8)]
		public EResult m_eResult;

		[FieldOffset(12)]
		public CSteamID m_steamIDUser;
	}
}
