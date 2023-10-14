using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[Serializable]
	[StructLayout(0, Pack = 8, Size = 132)]
	public struct SteamDatagramHostedAddress
	{
		public int m_cbSize;

		public byte[] m_data;

		public void Clear()
		{
		}
	}
}
