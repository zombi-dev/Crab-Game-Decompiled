namespace SteamworksNative
{
	public static class SteamUser
	{
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		public static bool BLoggedOn()
		{
			return false;
		}

		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		public static int InitiateGameConnection(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return 0;
		}

		public static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
		{
		}

		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
		}

		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			pchBuffer = null;
			return false;
		}

		public static void StartVoiceRecording()
		{
		}

		public static void StopVoiceRecording()
		{
		}

		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed)
		{
			pcbCompressed = default(uint);
			return default(EVoiceResult);
		}

		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten)
		{
			nBytesWritten = default(uint);
			return default(EVoiceResult);
		}

		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			nBytesWritten = default(uint);
			return default(EVoiceResult);
		}

		public static uint GetVoiceOptimalSampleRate()
		{
			return 0u;
		}

		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			pcbTicket = default(uint);
			return default(HAuthTicket);
		}

		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		public static void EndAuthSession(CSteamID steamID)
		{
		}

		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		public static bool BIsBehindNAT()
		{
			return false;
		}

		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			return default(SteamAPICall_t);
		}

		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			pcbTicket = default(uint);
			return false;
		}

		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return 0;
		}

		public static int GetPlayerSteamLevel()
		{
			return 0;
		}

		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(SteamAPICall_t);
		}

		public static bool BIsPhoneVerified()
		{
			return false;
		}

		public static bool BIsTwoFactorEnabled()
		{
			return false;
		}

		public static bool BIsPhoneIdentifying()
		{
			return false;
		}

		public static bool BIsPhoneRequiringVerification()
		{
			return false;
		}

		public static SteamAPICall_t GetMarketEligibility()
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t GetDurationControl()
		{
			return default(SteamAPICall_t);
		}

		public static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState)
		{
			return false;
		}
	}
}
