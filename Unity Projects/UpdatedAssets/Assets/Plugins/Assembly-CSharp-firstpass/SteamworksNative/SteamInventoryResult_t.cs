using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		public static readonly SteamInventoryResult_t Invalid;

		public int m_SteamInventoryResult;

		public SteamInventoryResult_t(int value)
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

		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return false;
		}

		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return false;
		}

		public static explicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		public static explicit operator int(SteamInventoryResult_t that)
		{
			return 0;
		}

		public bool Equals(SteamInventoryResult_t other)
		{
			return false;
		}

		public int CompareTo(SteamInventoryResult_t other)
		{
			return 0;
		}
	}
}
