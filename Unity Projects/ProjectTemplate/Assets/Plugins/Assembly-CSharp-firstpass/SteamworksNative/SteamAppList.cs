namespace SteamworksNative
{
	public static class SteamAppList
	{
		public static uint GetNumInstalledApps()
		{
			return 0u;
		}

		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			return 0u;
		}

		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			pchName = null;
			return 0;
		}

		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			pchDirectory = null;
			return 0;
		}

		public static int GetAppBuildId(AppId_t nAppID)
		{
			return 0;
		}
	}
}
