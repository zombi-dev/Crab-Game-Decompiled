using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		public static readonly SteamItemInstanceID_t Invalid;

		public ulong m_SteamItemInstanceID;

		public SteamItemInstanceID_t(ulong value)
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

		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return false;
		}

		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return false;
		}

		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return default(SteamItemInstanceID_t);
		}

		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return 0uL;
		}

		public bool Equals(SteamItemInstanceID_t other)
		{
			return false;
		}

		public int CompareTo(SteamItemInstanceID_t other)
		{
			return 0;
		}
	}
}
