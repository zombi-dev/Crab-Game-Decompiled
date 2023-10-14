using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		public static readonly HTTPRequestHandle Invalid;

		public uint m_HTTPRequestHandle;

		public HTTPRequestHandle(uint value)
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

		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return false;
		}

		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return false;
		}

		public static explicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		public static explicit operator uint(HTTPRequestHandle that)
		{
			return 0u;
		}

		public bool Equals(HTTPRequestHandle other)
		{
			return false;
		}

		public int CompareTo(HTTPRequestHandle other)
		{
			return 0;
		}
	}
}
