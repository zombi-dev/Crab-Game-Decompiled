using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 280)]
	public struct RemoteStorageFileShareResult_t
	{
		public const int k_iCallback = 1307;

		public EResult m_eResult;

		public UGCHandle_t m_hFile;

		private byte[] m_rgchFilename_;

		public string m_rgchFilename
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
