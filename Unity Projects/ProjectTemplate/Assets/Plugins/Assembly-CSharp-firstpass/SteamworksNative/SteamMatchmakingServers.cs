namespace SteamworksNative
{
	public static class SteamMatchmakingServers
	{
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return null;
		}

		public static void CancelQuery(HServerListRequest hRequest)
		{
		}

		public static void RefreshQuery(HServerListRequest hRequest)
		{
		}

		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			return false;
		}

		public static int GetServerCount(HServerListRequest hRequest)
		{
			return 0;
		}

		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
		}
	}
}
