using System;

namespace SteamworksNative
{
	[Serializable]
	public struct servernetadr_t
	{
		private ushort m_usConnectionPort;

		private ushort m_usQueryPort;

		private uint m_unIP;

		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
		}

		public ushort GetQueryPort()
		{
			return 0;
		}

		public void SetQueryPort(ushort usPort)
		{
		}

		public ushort GetConnectionPort()
		{
			return 0;
		}

		public void SetConnectionPort(ushort usPort)
		{
		}

		public uint GetIP()
		{
			return 0u;
		}

		public void SetIP(uint unIP)
		{
		}

		public string GetConnectionAddressString()
		{
			return null;
		}

		public string GetQueryAddressString()
		{
			return null;
		}

		public static string ToString(uint unIP, ushort usPort)
		{
			return null;
		}

		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return false;
		}

		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return false;
		}

		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return false;
		}

		public bool Equals(servernetadr_t other)
		{
			return false;
		}

		public int CompareTo(servernetadr_t other)
		{
			return 0;
		}
	}
}
