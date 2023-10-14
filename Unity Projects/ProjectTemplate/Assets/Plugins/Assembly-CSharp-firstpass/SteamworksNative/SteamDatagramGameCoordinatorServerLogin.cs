using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 2328)]
	public struct SteamDatagramGameCoordinatorServerLogin
	{
		public SteamNetworkingIdentity m_identity;

		public SteamDatagramHostedAddress m_routing;

		public AppId_t m_nAppID;

		public RTime32 m_rtime;

		public int m_cbAppData;

		public byte[] m_appData;
	}
}
