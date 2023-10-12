using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SiteId_t : IEquatable<SiteId_t>, IComparable<SiteId_t>
	{
		public static readonly SiteId_t Invalid;

		public ulong m_SiteId;

		public SiteId_t(ulong value)
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

		public static bool operator ==(SiteId_t x, SiteId_t y)
		{
			return false;
		}

		public static bool operator !=(SiteId_t x, SiteId_t y)
		{
			return false;
		}

		public static explicit operator SiteId_t(ulong value)
		{
			return default(SiteId_t);
		}

		public static explicit operator ulong(SiteId_t that)
		{
			return 0uL;
		}

		public bool Equals(SiteId_t other)
		{
			return false;
		}

		public int CompareTo(SiteId_t other)
		{
			return 0;
		}
	}
}
