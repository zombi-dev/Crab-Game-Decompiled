using System.Collections.Generic;

namespace SteamworksNative
{
	public static class SteamUGC
	{
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null)
		{
			return default(UGCQueryHandle_t);
		}

		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			pDetails = default(SteamUGCDetails_t);
			return false;
		}

		public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index)
		{
			return 0u;
		}

		public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			pchValue = null;
			return false;
		}

		public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			pchValue = null;
			return false;
		}

		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			pchURL = null;
			return false;
		}

		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			pchMetadata = null;
			return false;
		}

		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return false;
		}

		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			pStatValue = default(ulong);
			return false;
		}

		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return 0u;
		}

		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			pchURLOrVideoID = null;
			pchOriginalFileName = null;
			pPreviewType = default(EItemPreviewType);
			return false;
		}

		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return 0u;
		}

		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			pchKey = null;
			pchValue = null;
			return false;
		}

		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize)
		{
			pchValue = null;
			return false;
		}

		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return false;
		}

		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return false;
		}

		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups)
		{
			return false;
		}

		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return false;
		}

		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return false;
		}

		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return false;
		}

		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return false;
		}

		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return false;
		}

		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return false;
		}

		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return false;
		}

		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return false;
		}

		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return false;
		}

		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return false;
		}

		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return false;
		}

		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return false;
		}

		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return false;
		}

		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return false;
		}

		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return false;
		}

		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return false;
		}

		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return false;
		}

		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return false;
		}

		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return false;
		}

		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return false;
		}

		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return false;
		}

		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return false;
		}

		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return false;
		}

		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return false;
		}

		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
		{
			return false;
		}

		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			return false;
		}

		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return false;
		}

		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return false;
		}

		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return false;
		}

		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return false;
		}

		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return false;
		}

		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return false;
		}

		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return false;
		}

		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			punBytesProcessed = default(ulong);
			punBytesTotal = default(ulong);
			return default(EItemUpdateStatus);
		}

		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static uint GetNumSubscribedItems()
		{
			return 0u;
		}

		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return 0u;
		}

		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return 0u;
		}

		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			punSizeOnDisk = default(ulong);
			pchFolder = null;
			punTimeStamp = default(uint);
			return false;
		}

		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			punBytesDownloaded = default(ulong);
			punBytesTotal = default(ulong);
			return false;
		}

		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return false;
		}

		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return false;
		}

		public static void SuspendDownloads(bool bSuspend)
		{
		}

		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}
	}
}
