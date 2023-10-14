namespace SteamworksNative
{
	public static class SteamGameSearch
	{
		public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t AcceptGame()
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t DeclineGame()
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails)
		{
			pchConnectionDetails = null;
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t EndGameSearch()
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t CancelRequestPlayersForGame()
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult)
		{
			return default(EGameSearchErrorCode_t);
		}

		public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID)
		{
			return default(EGameSearchErrorCode_t);
		}
	}
}
