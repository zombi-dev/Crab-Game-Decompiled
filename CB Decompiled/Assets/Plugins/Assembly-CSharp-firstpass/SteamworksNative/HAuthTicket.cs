using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		public static readonly HAuthTicket Invalid;

		public uint m_HAuthTicket;

		public HAuthTicket(uint value)
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

		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return false;
		}

		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return false;
		}

		public static explicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		public static explicit operator uint(HAuthTicket that)
		{
			return 0u;
		}

		public bool Equals(HAuthTicket other)
		{
			return false;
		}

		public int CompareTo(HAuthTicket other)
		{
			return 0;
		}
	}
}
