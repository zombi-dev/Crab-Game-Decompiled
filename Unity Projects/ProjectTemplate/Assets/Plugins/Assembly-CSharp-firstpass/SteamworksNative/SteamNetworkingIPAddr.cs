using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[Serializable]
	[StructLayout(0, Pack = 1, Size = 18)]
	public struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr>
	{
		public byte[] m_ipv6;

		public ushort m_port;

		public const int k_cchMaxString = 48;

		public void Clear()
		{
		}

		public bool IsIPv6AllZeros()
		{
			return false;
		}

		public void SetIPv6(byte[] ipv6, ushort nPort)
		{
		}

		public void SetIPv4(uint nIP, ushort nPort)
		{
		}

		public bool IsIPv4()
		{
			return false;
		}

		public uint GetIPv4()
		{
			return 0u;
		}

		public void SetIPv6LocalHost(ushort nPort = 0)
		{
		}

		public bool IsLocalHost()
		{
			return false;
		}

		public void ToString(out string buf, bool bWithPort)
		{
			buf = null;
		}

		public bool ParseString(string pszStr)
		{
			return false;
		}

		public bool Equals(SteamNetworkingIPAddr x)
		{
			return false;
		}
	}
}
