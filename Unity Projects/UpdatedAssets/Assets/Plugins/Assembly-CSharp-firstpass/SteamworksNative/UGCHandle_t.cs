using System;

namespace SteamworksNative
{
	[Serializable]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		public static readonly UGCHandle_t Invalid;

		public ulong m_UGCHandle;

		public UGCHandle_t(ulong value)
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

		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return false;
		}

		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return false;
		}

		public static explicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		public static explicit operator ulong(UGCHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(UGCHandle_t other)
		{
			return false;
		}

		public int CompareTo(UGCHandle_t other)
		{
			return 0;
		}
	}
}
