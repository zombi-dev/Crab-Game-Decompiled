using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		public uint m_SNetListenSocket;

		public SNetListenSocket_t(uint value)
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

		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return false;
		}

		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return false;
		}

		public static explicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		public static explicit operator uint(SNetListenSocket_t that)
		{
			return 0u;
		}

		public bool Equals(SNetListenSocket_t other)
		{
			return false;
		}

		public int CompareTo(SNetListenSocket_t other)
		{
			return 0;
		}
	}
}
