using System;

namespace SteamworksNative
{
	[Serializable]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		public static readonly UGCFileWriteStreamHandle_t Invalid;

		public ulong m_UGCFileWriteStreamHandle;

		public UGCFileWriteStreamHandle_t(ulong value)
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

		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return false;
		}

		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return false;
		}

		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return false;
		}

		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return 0;
		}
	}
}
