namespace SteamworksNative
{
	public static class SteamRemotePlay
	{
		public static uint GetSessionCount()
		{
			return 0u;
		}

		public static RemotePlaySessionID_t GetSessionID(int iSessionIndex)
		{
			return default(RemotePlaySessionID_t);
		}

		public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID)
		{
			return default(CSteamID);
		}

		public static string GetSessionClientName(RemotePlaySessionID_t unSessionID)
		{
			return null;
		}

		public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID)
		{
			return default(ESteamDeviceFormFactor);
		}

		public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY)
		{
			pnResolutionX = default(int);
			pnResolutionY = default(int);
			return false;
		}

		public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend)
		{
			return false;
		}
	}
}
