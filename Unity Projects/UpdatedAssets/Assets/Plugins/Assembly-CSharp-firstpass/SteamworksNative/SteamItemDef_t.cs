using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		public int m_SteamItemDef;

		public SteamItemDef_t(int value)
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

		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return false;
		}

		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return false;
		}

		public static explicit operator SteamItemDef_t(int value)
		{
			return default(SteamItemDef_t);
		}

		public static explicit operator int(SteamItemDef_t that)
		{
			return 0;
		}

		public bool Equals(SteamItemDef_t other)
		{
			return false;
		}

		public int CompareTo(SteamItemDef_t other)
		{
			return 0;
		}
	}
}
