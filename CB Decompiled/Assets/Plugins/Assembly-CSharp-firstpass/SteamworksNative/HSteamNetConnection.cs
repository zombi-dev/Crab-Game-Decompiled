using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection>
	{
		public static readonly HSteamNetConnection Invalid;

		public uint m_HSteamNetConnection;

		public HSteamNetConnection(uint value)
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

		public static bool operator ==(HSteamNetConnection x, HSteamNetConnection y)
		{
			return false;
		}

		public static bool operator !=(HSteamNetConnection x, HSteamNetConnection y)
		{
			return false;
		}

		public static explicit operator HSteamNetConnection(uint value)
		{
			return default(HSteamNetConnection);
		}

		public static explicit operator uint(HSteamNetConnection that)
		{
			return 0u;
		}

		public bool Equals(HSteamNetConnection other)
		{
			return false;
		}

		public int CompareTo(HSteamNetConnection other)
		{
			return 0;
		}
	}
}
