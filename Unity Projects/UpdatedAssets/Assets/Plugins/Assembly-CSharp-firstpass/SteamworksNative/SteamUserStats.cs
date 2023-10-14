namespace SteamworksNative
{
	public static class SteamUserStats
	{
		public static bool RequestCurrentStats()
		{
			return false;
		}

		public static bool GetStat(string pchName, out int pData)
		{
			pData = default(int);
			return false;
		}

		public static bool GetStat(string pchName, out float pData)
		{
			pData = default(float);
			return false;
		}

		public static bool SetStat(string pchName, int nData)
		{
			return false;
		}

		public static bool SetStat(string pchName, float fData)
		{
			return false;
		}

		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return false;
		}

		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			pbAchieved = default(bool);
			return false;
		}

		public static bool SetAchievement(string pchName)
		{
			return false;
		}

		public static bool ClearAchievement(string pchName)
		{
			return false;
		}

		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			pbAchieved = default(bool);
			punUnlockTime = default(uint);
			return false;
		}

		public static bool StoreStats()
		{
			return false;
		}

		public static int GetAchievementIcon(string pchName)
		{
			return 0;
		}

		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return false;
		}

		public static uint GetNumAchievements()
		{
			return 0u;
		}

		public static string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			pData = default(int);
			return false;
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			pData = default(float);
			return false;
		}

		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			pbAchieved = default(bool);
			return false;
		}

		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			pbAchieved = default(bool);
			punUnlockTime = default(uint);
			return false;
		}

		public static bool ResetAllStats(bool bAchievementsToo)
		{
			return false;
		}

		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			return default(SteamAPICall_t);
		}

		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return 0;
		}

		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardSortMethod);
		}

		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardDisplayType);
		}

		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			return default(SteamAPICall_t);
		}

		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			pLeaderboardEntry = default(LeaderboardEntry_t);
			return false;
		}

		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			return default(SteamAPICall_t);
		}

		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			pchName = null;
			pflPercent = default(float);
			pbAchieved = default(bool);
			return 0;
		}

		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			pchName = null;
			pflPercent = default(float);
			pbAchieved = default(bool);
			return 0;
		}

		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			pflPercent = default(float);
			return false;
		}

		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			return default(SteamAPICall_t);
		}

		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			pData = default(long);
			return false;
		}

		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			pData = default(double);
			return false;
		}

		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			return 0;
		}

		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			return 0;
		}

		public static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress)
		{
			pnMinProgress = default(int);
			pnMaxProgress = default(int);
			return false;
		}

		public static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress)
		{
			pfMinProgress = default(float);
			pfMaxProgress = default(float);
			return false;
		}
	}
}
