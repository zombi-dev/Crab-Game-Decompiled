namespace SteamworksNative
{
	public static class SteamGameServerApps
	{
		public static bool BIsSubscribed()
		{
			return false;
		}

		public static bool BIsLowViolence()
		{
			return false;
		}

		public static bool BIsCybercafe()
		{
			return false;
		}

		public static bool BIsVACBanned()
		{
			return false;
		}

		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return false;
		}

		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return false;
		}

		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return 0u;
		}

		public static bool BIsSubscribedFromFreeWeekend()
		{
			return false;
		}

		public static int GetDLCCount()
		{
			return 0;
		}

		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			pAppID = default(AppId_t);
			pbAvailable = default(bool);
			pchName = null;
			return false;
		}

		public static void InstallDLC(AppId_t nAppID)
		{
		}

		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			pchName = null;
			return false;
		}

		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return false;
		}

		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return 0u;
		}

		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			pchFolder = null;
			return 0u;
		}

		public static bool BIsAppInstalled(AppId_t appID)
		{
			return false;
		}

		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			punBytesDownloaded = default(ulong);
			punBytesTotal = default(ulong);
			return false;
		}

		public static int GetAppBuildId()
		{
			return 0;
		}

		public static void RequestAllProofOfPurchaseKeys()
		{
		}

		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			return default(SteamAPICall_t);
		}

		public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine)
		{
			pszCommandLine = null;
			return 0;
		}

		public static bool BIsSubscribedFromFamilySharing()
		{
			return false;
		}

		public static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed)
		{
			punSecondsAllowed = default(uint);
			punSecondsPlayed = default(uint);
			return false;
		}
	}
}
