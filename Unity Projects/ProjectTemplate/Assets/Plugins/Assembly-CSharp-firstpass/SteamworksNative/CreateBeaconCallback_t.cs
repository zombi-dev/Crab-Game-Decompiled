using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct CreateBeaconCallback_t
	{
		public const int k_iCallback = 5302;

		public EResult m_eResult;

		public PartyBeaconID_t m_ulBeaconID;
	}
}
