using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct SteamRemotePlaySessionDisconnected_t
	{
		public const int k_iCallback = 5702;

		public RemotePlaySessionID_t m_unSessionID;
	}
}
