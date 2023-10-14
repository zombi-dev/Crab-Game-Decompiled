using System;

namespace SteamworksNative
{
	[Serializable]
	public struct ISteamNetworkingConnectionSignaling
	{
		public bool SendSignal(HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg)
		{
			return false;
		}

		public void Release()
		{
		}
	}
}
