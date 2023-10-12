namespace SteamworksNative
{
	public struct SteamRelayNetworkStatus_t
	{
		public const int k_iCallback = 1281;

		public ESteamNetworkingAvailability m_eAvail;

		public int m_bPingMeasurementInProgress;

		public ESteamNetworkingAvailability m_eAvailNetworkConfig;

		public ESteamNetworkingAvailability m_eAvailAnyRelay;

		private byte[] m_debugMsg_;

		public string m_debugMsg
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
