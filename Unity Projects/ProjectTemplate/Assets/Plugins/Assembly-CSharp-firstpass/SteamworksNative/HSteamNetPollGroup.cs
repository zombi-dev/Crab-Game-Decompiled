using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
	{
		public static readonly HSteamNetPollGroup Invalid;

		public uint m_HSteamNetPollGroup;

		public HSteamNetPollGroup(uint value)
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

		public static bool operator ==(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			return false;
		}

		public static bool operator !=(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			return false;
		}

		public static explicit operator HSteamNetPollGroup(uint value)
		{
			return default(HSteamNetPollGroup);
		}

		public static explicit operator uint(HSteamNetPollGroup that)
		{
			return 0u;
		}

		public bool Equals(HSteamNetPollGroup other)
		{
			return false;
		}

		public int CompareTo(HSteamNetPollGroup other)
		{
			return 0;
		}
	}
}
