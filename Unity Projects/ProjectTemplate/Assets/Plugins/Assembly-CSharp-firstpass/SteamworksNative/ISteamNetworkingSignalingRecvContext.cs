using System;

namespace SteamworksNative
{
	[Serializable]
	public struct ISteamNetworkingSignalingRecvContext
	{
		public IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort)
		{
			return (IntPtr)0;
		}

		public void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg)
		{
		}
	}
}
