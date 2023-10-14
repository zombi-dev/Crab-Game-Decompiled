using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct SteamParamStringArray_t
	{
		public IntPtr m_ppStrings;

		public int m_nNumStrings;
	}
}
