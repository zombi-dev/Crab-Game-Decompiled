using System;

namespace SteamworksNative
{
	[Serializable]
	public struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
	{
		public uint m_SteamNetworkingPOPID;

		public SteamNetworkingPOPID(uint value)
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

		public static bool operator ==(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			return false;
		}

		public static bool operator !=(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			return false;
		}

		public static explicit operator SteamNetworkingPOPID(uint value)
		{
			return default(SteamNetworkingPOPID);
		}

		public static explicit operator uint(SteamNetworkingPOPID that)
		{
			return 0u;
		}

		public bool Equals(SteamNetworkingPOPID other)
		{
			return false;
		}

		public int CompareTo(SteamNetworkingPOPID other)
		{
			return 0;
		}
	}
}
