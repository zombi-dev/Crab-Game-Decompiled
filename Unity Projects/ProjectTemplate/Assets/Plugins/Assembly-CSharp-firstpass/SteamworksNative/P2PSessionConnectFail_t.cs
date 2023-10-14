using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 1, Size = 9)]
	public struct P2PSessionConnectFail_t
	{
		public const int k_iCallback = 1203;

		public CSteamID m_steamIDRemote;

		public byte m_eP2PSessionError;
	}
}
