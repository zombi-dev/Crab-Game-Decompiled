using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 12)]
	public struct RemoteStorageAppSyncedServer_t
	{
		public const int k_iCallback = 1302;

		public AppId_t m_nAppID;

		public EResult m_eResult;

		public int m_unNumUploads;
	}
}
