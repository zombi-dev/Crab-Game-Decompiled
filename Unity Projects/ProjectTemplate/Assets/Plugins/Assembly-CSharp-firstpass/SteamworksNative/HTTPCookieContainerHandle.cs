using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		public static readonly HTTPCookieContainerHandle Invalid;

		public uint m_HTTPCookieContainerHandle;

		public HTTPCookieContainerHandle(uint value)
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

		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return false;
		}

		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return false;
		}

		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return 0u;
		}

		public bool Equals(HTTPCookieContainerHandle other)
		{
			return false;
		}

		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return 0;
		}
	}
}
