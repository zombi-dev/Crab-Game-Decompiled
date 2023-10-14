using System;

namespace SteamworksNative
{
	[Serializable]
	public struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
	{
		public ulong m_InputHandle;

		public InputHandle_t(ulong value)
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

		public static bool operator ==(InputHandle_t x, InputHandle_t y)
		{
			return false;
		}

		public static bool operator !=(InputHandle_t x, InputHandle_t y)
		{
			return false;
		}

		public static explicit operator InputHandle_t(ulong value)
		{
			return default(InputHandle_t);
		}

		public static explicit operator ulong(InputHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(InputHandle_t other)
		{
			return false;
		}

		public int CompareTo(InputHandle_t other)
		{
			return 0;
		}
	}
}
