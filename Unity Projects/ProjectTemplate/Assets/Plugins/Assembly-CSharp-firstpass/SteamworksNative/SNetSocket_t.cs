using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		public uint m_SNetSocket;

		public SNetSocket_t(uint value)
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

		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return false;
		}

		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return false;
		}

		public static explicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		public static explicit operator uint(SNetSocket_t that)
		{
			return 0u;
		}

		public bool Equals(SNetSocket_t other)
		{
			return false;
		}

		public int CompareTo(SNetSocket_t other)
		{
			return 0;
		}
	}
}
