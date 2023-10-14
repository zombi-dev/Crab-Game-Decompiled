using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamNetworkingMicroseconds : IEquatable<SteamNetworkingMicroseconds>, IComparable<SteamNetworkingMicroseconds>
	{
		public long m_SteamNetworkingMicroseconds;

		public SteamNetworkingMicroseconds(long value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			return false;
		}

		public static bool operator !=(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y)
		{
			return false;
		}

		public static explicit operator SteamNetworkingMicroseconds(long value)
		{
			return default(SteamNetworkingMicroseconds);
		}

		public static explicit operator long(SteamNetworkingMicroseconds that)
		{
			return 0L;
		}

		public bool Equals(SteamNetworkingMicroseconds other)
		{
			return false;
		}

		public int CompareTo(SteamNetworkingMicroseconds other)
		{
			return 0;
		}
	}
}
