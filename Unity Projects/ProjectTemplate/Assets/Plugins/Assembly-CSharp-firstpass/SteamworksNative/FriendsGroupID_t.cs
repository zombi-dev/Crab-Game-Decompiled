using System;

namespace SteamworksNative
{
	[Serializable]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		public static readonly FriendsGroupID_t Invalid;

		public short m_FriendsGroupID;

		public FriendsGroupID_t(short value)
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

		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return false;
		}

		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return false;
		}

		public static explicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		public static explicit operator short(FriendsGroupID_t that)
		{
			return 0;
		}

		public bool Equals(FriendsGroupID_t other)
		{
			return false;
		}

		public int CompareTo(FriendsGroupID_t other)
		{
			return 0;
		}
	}
}
