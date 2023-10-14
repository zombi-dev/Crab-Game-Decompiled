using System;

namespace SteamworksNative
{
	[Serializable]
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		public static readonly ManifestId_t Invalid;

		public ulong m_ManifestId;

		public ManifestId_t(ulong value)
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

		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return false;
		}

		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return false;
		}

		public static explicit operator ManifestId_t(ulong value)
		{
			return default(ManifestId_t);
		}

		public static explicit operator ulong(ManifestId_t that)
		{
			return 0uL;
		}

		public bool Equals(ManifestId_t other)
		{
			return false;
		}

		public int CompareTo(ManifestId_t other)
		{
			return 0;
		}
	}
}
