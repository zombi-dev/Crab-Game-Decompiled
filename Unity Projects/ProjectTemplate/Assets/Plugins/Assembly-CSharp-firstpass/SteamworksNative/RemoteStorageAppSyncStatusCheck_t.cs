using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		public const int k_iCallback = 1305;

		public AppId_t m_nAppID;

		public EResult m_eResult;
	}
}
