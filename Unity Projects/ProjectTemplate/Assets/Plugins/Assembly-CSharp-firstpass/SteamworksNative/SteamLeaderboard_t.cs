using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		public ulong m_SteamLeaderboard;

		public SteamLeaderboard_t(ulong value)
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

		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return false;
		}

		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return false;
		}

		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return 0uL;
		}

		public bool Equals(SteamLeaderboard_t other)
		{
			return false;
		}

		public int CompareTo(SteamLeaderboard_t other)
		{
			return 0;
		}
	}
}
