using System;

namespace SteamworksNative
{
	[Serializable]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		public static readonly AppId_t Invalid;

		public uint m_AppId;

		public AppId_t(uint value)
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

		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return false;
		}

		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return false;
		}

		public static explicit operator AppId_t(uint value)
		{
			return default(AppId_t);
		}

		public static explicit operator uint(AppId_t that)
		{
			return 0u;
		}

		public bool Equals(AppId_t other)
		{
			return false;
		}

		public int CompareTo(AppId_t other)
		{
			return 0;
		}
	}
}
