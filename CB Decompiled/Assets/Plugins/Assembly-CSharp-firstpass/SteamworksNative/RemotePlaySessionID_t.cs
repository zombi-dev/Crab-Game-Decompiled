using System;

namespace SteamworksNative
{
	[Serializable]
	public struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
	{
		public uint m_RemotePlaySessionID;

		public RemotePlaySessionID_t(uint value)
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

		public static bool operator ==(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			return false;
		}

		public static bool operator !=(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			return false;
		}

		public static explicit operator RemotePlaySessionID_t(uint value)
		{
			return default(RemotePlaySessionID_t);
		}

		public static explicit operator uint(RemotePlaySessionID_t that)
		{
			return 0u;
		}

		public bool Equals(RemotePlaySessionID_t other)
		{
			return false;
		}

		public int CompareTo(RemotePlaySessionID_t other)
		{
			return 0;
		}
	}
}
