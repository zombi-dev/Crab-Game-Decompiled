using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct GetOPFSettingsResult_t
	{
		public const int k_iCallback = 4624;

		public EResult m_eResult;

		public AppId_t m_unVideoAppID;
	}
}
