using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 696)]
	public struct SteamNetworkingMessagesSessionFailed_t
	{
		public const int k_iCallback = 1252;

		public SteamNetConnectionInfo_t m_info;
	}
}
