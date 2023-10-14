using System;

namespace SteamworksNative
{
	[Serializable]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		public static readonly DepotId_t Invalid;

		public uint m_DepotId;

		public DepotId_t(uint value)
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

		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return false;
		}

		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return false;
		}

		public static explicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		public static explicit operator uint(DepotId_t that)
		{
			return 0u;
		}

		public bool Equals(DepotId_t other)
		{
			return false;
		}

		public int CompareTo(DepotId_t other)
		{
			return 0;
		}
	}
}
