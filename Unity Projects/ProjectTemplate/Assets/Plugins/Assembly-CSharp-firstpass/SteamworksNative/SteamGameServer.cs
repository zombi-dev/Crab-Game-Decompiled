namespace SteamworksNative
{
	public static class SteamGameServer
	{
		public static void SetProduct(string pszProduct)
		{
		}

		public static void SetGameDescription(string pszGameDescription)
		{
		}

		public static void SetModDir(string pszModDir)
		{
		}

		public static void SetDedicatedServer(bool bDedicated)
		{
		}

		public static void LogOn(string pszToken)
		{
		}

		public static void LogOnAnonymous()
		{
		}

		public static void LogOff()
		{
		}

		public static bool BLoggedOn()
		{
			return false;
		}

		public static bool BSecure()
		{
			return false;
		}

		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		public static bool WasRestartRequested()
		{
			return false;
		}

		public static void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		public static void SetBotPlayerCount(int cBotplayers)
		{
		}

		public static void SetServerName(string pszServerName)
		{
		}

		public static void SetMapName(string pszMapName)
		{
		}

		public static void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		public static void ClearAllKeyValues()
		{
		}

		public static void SetKeyValue(string pKey, string pValue)
		{
		}

		public static void SetGameTags(string pchGameTags)
		{
		}

		public static void SetGameData(string pchGameData)
		{
		}

		public static void SetRegion(string pszRegion)
		{
		}

		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			pSteamIDUser = default(CSteamID);
			return false;
		}

		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			return default(CSteamID);
		}

		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
		}

		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			return false;
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

		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			return false;
		}

		public static void GetGameplayStats()
		{
		}

		public static SteamAPICall_t GetServerReputation()
		{
			return default(SteamAPICall_t);
		}

		public static SteamIPAddress_t GetPublicIP()
		{
			return default(SteamIPAddress_t);
		}

		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			return false;
		}

		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			pNetAdr = default(uint);
			pPort = default(ushort);
			return 0;
		}

		public static void EnableHeartbeats(bool bActive)
		{
		}

		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
		}

		public static void ForceHeartbeat()
		{
		}

		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			return default(SteamAPICall_t);
		}
	}
}
