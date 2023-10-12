namespace SteamworksNative
{
	public static class SteamVideo
	{
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
		}

		public static bool IsBroadcasting(out int pnNumViewers)
		{
			pnNumViewers = default(int);
			return false;
		}

		public static void GetOPFSettings(AppId_t unVideoAppID)
		{
		}

		public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			pchBuffer = null;
			return false;
		}
	}
}
