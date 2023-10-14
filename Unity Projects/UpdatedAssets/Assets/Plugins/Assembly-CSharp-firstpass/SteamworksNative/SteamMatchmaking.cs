namespace SteamworksNative
{
	public static class SteamMatchmaking
	{
		public static int GetFavoriteGameCount()
		{
			return 0;
		}

		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			pnAppID = default(AppId_t);
			pnIP = default(uint);
			pnConnPort = default(ushort);
			pnQueryPort = default(ushort);
			punFlags = default(uint);
			pRTime32LastPlayedOnServer = default(uint);
			return false;
		}

		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return 0;
		}

		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return false;
		}

		public static SteamAPICall_t RequestLobbyList()
		{
			return default(SteamAPICall_t);
		}

		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
		}

		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			return default(CSteamID);
		}

		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			return false;
		}

		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return 0;
		}

		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return null;
		}

		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			return false;
		}

		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			return 0;
		}

		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			pchKey = null;
			pchValue = null;
			return false;
		}

		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return false;
		}

		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			return null;
		}

		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
		}

		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			return false;
		}

		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			pSteamIDUser = default(CSteamID);
			peChatEntryType = default(EChatEntryType);
			return 0;
		}

		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			return false;
		}

		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
		}

		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			punGameServerIP = default(uint);
			punGameServerPort = default(ushort);
			psteamIDGameServer = default(CSteamID);
			return false;
		}

		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			return false;
		}

		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			return 0;
		}

		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			return false;
		}

		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return false;
		}

		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}

		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			return false;
		}

		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			return false;
		}
	}
}
