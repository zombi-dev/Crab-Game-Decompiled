using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		public int m_HSteamUser;

		public HSteamUser(int value)
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

		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return false;
		}

		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return false;
		}

		public static explicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		public static explicit operator int(HSteamUser that)
		{
			return 0;
		}

		public bool Equals(HSteamUser other)
		{
			return false;
		}

		public int CompareTo(HSteamUser other)
		{
			return 0;
		}
	}
}
