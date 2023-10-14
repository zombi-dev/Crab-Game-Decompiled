using System.Runtime.InteropServices;

namespace SteamworksNative
{
	public static class Packsize
	{
		[StructLayout(0, Pack = 8, Size = 32)]
		private struct ValvePackingSentinel_t
		{
			private uint m_u32;

			private ulong m_u64;

			private ushort m_u16;

			private double m_d;
		}

		public const int value = 8;

		public static bool Test()
		{
			return false;
		}
	}
}
