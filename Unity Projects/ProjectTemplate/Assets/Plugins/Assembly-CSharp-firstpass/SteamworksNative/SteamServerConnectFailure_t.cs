using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct SteamServerConnectFailure_t
	{
		public const int k_iCallback = 102;

		public EResult m_eResult;

		public bool m_bStillRetrying;
	}
}
