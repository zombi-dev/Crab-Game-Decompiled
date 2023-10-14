using System;

namespace SteamworksNative
{
	[Serializable]
	public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		public static readonly HHTMLBrowser Invalid;

		public uint m_HHTMLBrowser;

		public HHTMLBrowser(uint value)
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

		public static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			return false;
		}

		public static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			return false;
		}

		public static explicit operator HHTMLBrowser(uint value)
		{
			return default(HHTMLBrowser);
		}

		public static explicit operator uint(HHTMLBrowser that)
		{
			return 0u;
		}

		public bool Equals(HHTMLBrowser other)
		{
			return false;
		}

		public int CompareTo(HHTMLBrowser other)
		{
			return 0;
		}
	}
}
