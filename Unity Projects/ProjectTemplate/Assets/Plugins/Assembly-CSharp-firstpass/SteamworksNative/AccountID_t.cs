using System;

namespace SteamworksNative
{
	[Serializable]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		public uint m_AccountID;

		public AccountID_t(uint value)
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

		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return false;
		}

		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return false;
		}

		public static explicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		public static explicit operator uint(AccountID_t that)
		{
			return 0u;
		}

		public bool Equals(AccountID_t other)
		{
			return false;
		}

		public int CompareTo(AccountID_t other)
		{
			return 0;
		}
	}
}
