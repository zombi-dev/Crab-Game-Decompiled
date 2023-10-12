using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 696)]
	public struct SteamNetConnectionInfo_t
	{
		public SteamNetworkingIdentity m_identityRemote;

		public long m_nUserData;

		public HSteamListenSocket m_hListenSocket;

		public SteamNetworkingIPAddr m_addrRemote;

		public ushort m__pad1;

		public SteamNetworkingPOPID m_idPOPRemote;

		public SteamNetworkingPOPID m_idPOPRelay;

		public ESteamNetworkingConnectionState m_eState;

		public int m_eEndReason;

		private byte[] m_szEndDebug_;

		private byte[] m_szConnectionDescription_;

		public uint[] reserved;

		public string m_szEndDebug
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string m_szConnectionDescription
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
