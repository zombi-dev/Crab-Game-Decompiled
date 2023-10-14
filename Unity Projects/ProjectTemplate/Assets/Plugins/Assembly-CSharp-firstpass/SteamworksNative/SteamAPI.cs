namespace SteamworksNative
{
	public static class SteamAPI
	{
		public static bool Init()
		{
			return false;
		}

		public static void Shutdown()
		{
		}

		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			return false;
		}

		public static void ReleaseCurrentThreadMemory()
		{
		}

		public static void RunCallbacks()
		{
		}

		public static bool IsSteamRunning()
		{
			return false;
		}

		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
}
