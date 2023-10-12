namespace SteamworksNative
{
	public static class SteamGameServerStats
	{
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

		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			return false;
		}

		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			return false;
		}

		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return false;
		}

		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return false;
		}

		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return false;
		}

		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}
	}
}
