using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[Serializable]
	[StructLayout(0, Pack = 1, Size = 136)]
	public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
	{
		public ESteamNetworkingIdentityType m_eType;

		private int m_cbSize;

		private uint[] m_reserved;

		public const int k_cchMaxString = 128;

		public const int k_cchMaxGenericString = 32;

		public const int k_cbMaxGenericBytes = 32;

		public void Clear()
		{
		}

		public bool IsInvalid()
		{
			return false;
		}

		public void SetSteamID(CSteamID steamID)
		{
		}

		public CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		public void SetSteamID64(ulong steamID)
		{
		}

		public ulong GetSteamID64()
		{
			return 0uL;
		}

		public void SetIPAddr(SteamNetworkingIPAddr addr)
		{
		}

		public SteamNetworkingIPAddr GetIPAddr()
		{
			return default(SteamNetworkingIPAddr);
		}

		public void SetLocalHost()
		{
		}

		public bool IsLocalHost()
		{
			return false;
		}

		public bool SetGenericString(string pszString)
		{
			return false;
		}

		public string GetGenericString()
		{
			return null;
		}

		public bool SetGenericBytes(byte[] data, uint cbLen)
		{
			return false;
		}

		public byte[] GetGenericBytes(out int cbLen)
		{
			cbLen = default(int);
			return null;
		}

		public bool Equals(SteamNetworkingIdentity x)
		{
			return false;
		}

		public void ToString(out string buf)
		{
			buf = null;
		}

		public bool ParseString(string pszStr)
		{
			return false;
		}
	}
}
