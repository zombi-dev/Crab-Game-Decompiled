using System;

namespace SteamworksNative
{
	[Serializable]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		public static readonly UGCQueryHandle_t Invalid;

		public ulong m_UGCQueryHandle;

		public UGCQueryHandle_t(ulong value)
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

		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return false;
		}

		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return false;
		}

		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(UGCQueryHandle_t other)
		{
			return false;
		}

		public int CompareTo(UGCQueryHandle_t other)
		{
			return 0;
		}
	}
}
