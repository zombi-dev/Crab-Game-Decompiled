using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 1)]
	public struct AvailableBeaconLocationsUpdated_t
	{
		public const int k_iCallback = 5305;
	}
}
