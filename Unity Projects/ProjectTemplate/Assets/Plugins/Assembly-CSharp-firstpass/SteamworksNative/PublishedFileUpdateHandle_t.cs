using System;

namespace SteamworksNative
{
	[Serializable]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		public static readonly PublishedFileUpdateHandle_t Invalid;

		public ulong m_PublishedFileUpdateHandle;

		public PublishedFileUpdateHandle_t(ulong value)
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

		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return false;
		}

		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return false;
		}

		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return false;
		}

		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return 0;
		}
	}
}
