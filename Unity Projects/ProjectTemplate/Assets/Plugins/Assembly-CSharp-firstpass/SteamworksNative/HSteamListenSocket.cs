using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket>
	{
		public static readonly HSteamListenSocket Invalid;

		public uint m_HSteamListenSocket;

		public HSteamListenSocket(uint value)
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

		public static bool operator ==(HSteamListenSocket x, HSteamListenSocket y)
		{
			return false;
		}

		public static bool operator !=(HSteamListenSocket x, HSteamListenSocket y)
		{
			return false;
		}

		public static explicit operator HSteamListenSocket(uint value)
		{
			return default(HSteamListenSocket);
		}

		public static explicit operator uint(HSteamListenSocket that)
		{
			return 0u;
		}

		public bool Equals(HSteamListenSocket other)
		{
			return false;
		}

		public int CompareTo(HSteamListenSocket other)
		{
			return 0;
		}
	}
}
