using System;

namespace SteamworksNative
{
	[Serializable]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		public static readonly UGCUpdateHandle_t Invalid;

		public ulong m_UGCUpdateHandle;

		public UGCUpdateHandle_t(ulong value)
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

		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return false;
		}

		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return false;
		}

		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(UGCUpdateHandle_t other)
		{
			return false;
		}

		public int CompareTo(UGCUpdateHandle_t other)
		{
			return 0;
		}
	}
}
