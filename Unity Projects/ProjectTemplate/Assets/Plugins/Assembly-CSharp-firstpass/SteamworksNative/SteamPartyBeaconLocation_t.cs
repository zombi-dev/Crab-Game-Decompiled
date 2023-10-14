using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct SteamPartyBeaconLocation_t
	{
		public ESteamPartyBeaconLocationType m_eType;

		public ulong m_ulLocationID;
	}
}
