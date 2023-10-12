using System;

namespace SteamworksNative
{
	[Serializable]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		public static readonly PublishedFileId_t Invalid;

		public ulong m_PublishedFileId;

		public PublishedFileId_t(ulong value)
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

		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return false;
		}

		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return false;
		}

		public static explicit operator PublishedFileId_t(ulong value)
		{
			return default(PublishedFileId_t);
		}

		public static explicit operator ulong(PublishedFileId_t that)
		{
			return 0uL;
		}

		public bool Equals(PublishedFileId_t other)
		{
			return false;
		}

		public int CompareTo(PublishedFileId_t other)
		{
			return 0;
		}
	}
}
