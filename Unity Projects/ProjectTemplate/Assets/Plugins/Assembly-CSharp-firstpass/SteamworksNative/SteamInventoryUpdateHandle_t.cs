using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
	{
		public static readonly SteamInventoryUpdateHandle_t Invalid;

		public ulong m_SteamInventoryUpdateHandle;

		public SteamInventoryUpdateHandle_t(ulong value)
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

		public static bool operator ==(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return false;
		}

		public static bool operator !=(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return false;
		}

		public static explicit operator SteamInventoryUpdateHandle_t(ulong value)
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		public static explicit operator ulong(SteamInventoryUpdateHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(SteamInventoryUpdateHandle_t other)
		{
			return false;
		}

		public int CompareTo(SteamInventoryUpdateHandle_t other)
		{
			return 0;
		}
	}
}
