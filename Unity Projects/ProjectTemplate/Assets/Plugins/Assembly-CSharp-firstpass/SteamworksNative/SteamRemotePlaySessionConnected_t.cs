using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct SteamRemotePlaySessionConnected_t
	{
		public const int k_iCallback = 5701;

		public RemotePlaySessionID_t m_unSessionID;
	}
}
