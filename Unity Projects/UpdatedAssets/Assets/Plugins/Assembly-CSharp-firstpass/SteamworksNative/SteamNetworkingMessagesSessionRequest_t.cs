using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 136)]
	public struct SteamNetworkingMessagesSessionRequest_t
	{
		public const int k_iCallback = 1251;

		public SteamNetworkingIdentity m_identityRemote;
	}
}
