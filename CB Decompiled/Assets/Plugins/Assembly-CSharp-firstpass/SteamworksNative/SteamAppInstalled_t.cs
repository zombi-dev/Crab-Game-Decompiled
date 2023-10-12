using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct SteamAppInstalled_t
	{
		public const int k_iCallback = 3901;

		public AppId_t m_nAppID;
	}
}