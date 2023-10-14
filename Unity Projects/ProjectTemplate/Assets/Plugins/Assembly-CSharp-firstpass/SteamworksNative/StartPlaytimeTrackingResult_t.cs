using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct StartPlaytimeTrackingResult_t
	{
		public const int k_iCallback = 3410;

		public EResult m_eResult;
	}
}
