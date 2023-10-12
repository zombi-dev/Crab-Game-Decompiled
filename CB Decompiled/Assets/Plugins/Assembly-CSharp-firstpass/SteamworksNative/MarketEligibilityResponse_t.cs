using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 20)]
	public struct MarketEligibilityResponse_t
	{
		public const int k_iCallback = 166;

		public bool m_bAllowed;

		public EMarketNotAllowedReasonFlags m_eNotAllowedReason;

		public RTime32 m_rtAllowedAtTime;

		public int m_cdaySteamGuardRequiredDays;

		public int m_cdayNewDeviceCooldown;
	}
}
