using System;

namespace SteamworksNative
{
	[Serializable]
	public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
	{
		public static readonly PartyBeaconID_t Invalid;

		public ulong m_PartyBeaconID;

		public PartyBeaconID_t(ulong value)
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

		public static bool operator ==(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			return false;
		}

		public static bool operator !=(PartyBeaconID_t x, PartyBeaconID_t y)
		{
			return false;
		}

		public static explicit operator PartyBeaconID_t(ulong value)
		{
			return default(PartyBeaconID_t);
		}

		public static explicit operator ulong(PartyBeaconID_t that)
		{
			return 0uL;
		}

		public bool Equals(PartyBeaconID_t other)
		{
			return false;
		}

		public int CompareTo(PartyBeaconID_t other)
		{
			return 0;
		}
	}
}
