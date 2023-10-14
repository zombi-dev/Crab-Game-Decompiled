using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		public int m_HSteamPipe;

		public HSteamPipe(int value)
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

		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return false;
		}

		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return false;
		}

		public static explicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		public static explicit operator int(HSteamPipe that)
		{
			return 0;
		}

		public bool Equals(HSteamPipe other)
		{
			return false;
		}

		public int CompareTo(HSteamPipe other)
		{
			return 0;
		}
	}
}
