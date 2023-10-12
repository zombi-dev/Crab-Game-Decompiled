using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 20)]
	public struct P2PSessionState_t
	{
		public byte m_bConnectionActive;

		public byte m_bConnecting;

		public byte m_eP2PSessionError;

		public byte m_bUsingRelay;

		public int m_nBytesQueuedForSend;

		public int m_nPacketsQueuedForSend;

		public uint m_nRemoteIP;

		public ushort m_nRemotePort;
	}
}
