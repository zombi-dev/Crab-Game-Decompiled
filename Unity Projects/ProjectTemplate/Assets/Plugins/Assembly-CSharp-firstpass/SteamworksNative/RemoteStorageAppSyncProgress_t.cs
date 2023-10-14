using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 288)]
	public struct RemoteStorageAppSyncProgress_t
	{
		public const int k_iCallback = 1303;

		private byte[] m_rgchCurrentFile_;

		public AppId_t m_nAppID;

		public uint m_uBytesTransferredThisChunk;

		public double m_dAppPercentComplete;

		public bool m_bUploading;

		public string m_rgchCurrentFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
