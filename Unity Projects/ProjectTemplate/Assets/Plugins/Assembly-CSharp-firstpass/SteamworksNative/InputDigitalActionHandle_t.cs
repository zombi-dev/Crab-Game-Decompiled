using System;

namespace SteamworksNative
{
	[Serializable]
	public struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t>
	{
		public ulong m_InputDigitalActionHandle;

		public InputDigitalActionHandle_t(ulong value)
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

		public static bool operator ==(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			return false;
		}

		public static bool operator !=(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			return false;
		}

		public static explicit operator InputDigitalActionHandle_t(ulong value)
		{
			return default(InputDigitalActionHandle_t);
		}

		public static explicit operator ulong(InputDigitalActionHandle_t that)
		{
			return 0uL;
		}

		public bool Equals(InputDigitalActionHandle_t other)
		{
			return false;
		}

		public int CompareTo(InputDigitalActionHandle_t other)
		{
			return 0;
		}
	}
}
