using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		public ulong m_SteamLeaderboardEntries;

		public SteamLeaderboardEntries_t(ulong value)
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

		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return false;
		}

		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return false;
		}

		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return 0uL;
		}

		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return false;
		}

		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return 0;
		}
	}
}
