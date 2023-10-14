using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 9760)]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		public const int k_iCallback = 1318;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nCreatorAppID;

		public AppId_t m_nConsumerAppID;

		private byte[] m_rgchTitle_;

		private byte[] m_rgchDescription_;

		public UGCHandle_t m_hFile;

		public UGCHandle_t m_hPreviewFile;

		public ulong m_ulSteamIDOwner;

		public uint m_rtimeCreated;

		public uint m_rtimeUpdated;

		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		public bool m_bBanned;

		private byte[] m_rgchTags_;

		public bool m_bTagsTruncated;

		private byte[] m_pchFileName_;

		public int m_nFileSize;

		public int m_nPreviewFileSize;

		private byte[] m_rgchURL_;

		public EWorkshopFileType m_eFileType;

		public bool m_bAcceptedForUse;

		public string m_rgchTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string m_rgchDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string m_rgchTags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string m_pchFileName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string m_rgchURL
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
