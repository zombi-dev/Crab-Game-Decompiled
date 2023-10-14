using System;
using System.Net;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[Serializable]
	[StructLayout(0, Pack = 1, Size = 20)]
	public struct SteamIPAddress_t
	{
		private long m_ip0;

		private long m_ip1;

		private ESteamIPType m_eType;

		public SteamIPAddress_t(IPAddress iPAddress)
		{
		}

		public IPAddress ToIPAddress()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public ESteamIPType GetIPType()
		{
			return default(ESteamIPType);
		}

		public bool IsSet()
		{
			return false;
		}
	}
}
