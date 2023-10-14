using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		public static readonly HServerQuery Invalid;

		public int m_HServerQuery;

		public HServerQuery(int value)
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

		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return false;
		}

		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return false;
		}

		public static explicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		public static explicit operator int(HServerQuery that)
		{
			return 0;
		}

		public bool Equals(HServerQuery other)
		{
			return false;
		}

		public int CompareTo(HServerQuery other)
		{
			return 0;
		}
	}
}
