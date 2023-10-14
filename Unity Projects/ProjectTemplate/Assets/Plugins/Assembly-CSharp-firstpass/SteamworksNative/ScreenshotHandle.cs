using System;

namespace SteamworksNative
{
	[Serializable]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		public static readonly ScreenshotHandle Invalid;

		public uint m_ScreenshotHandle;

		public ScreenshotHandle(uint value)
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

		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return false;
		}

		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return false;
		}

		public static explicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		public static explicit operator uint(ScreenshotHandle that)
		{
			return 0u;
		}

		public bool Equals(ScreenshotHandle other)
		{
			return false;
		}

		public int CompareTo(ScreenshotHandle other)
		{
			return 0;
		}
	}
}
