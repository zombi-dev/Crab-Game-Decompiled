using System;

namespace SteamworksNative
{
	internal static class CSteamGameServerAPIContext
	{
		private static IntPtr m_pSteamClient;

		private static IntPtr m_pSteamGameServer;

		private static IntPtr m_pSteamUtils;

		private static IntPtr m_pSteamNetworking;

		private static IntPtr m_pSteamGameServerStats;

		private static IntPtr m_pSteamHTTP;

		private static IntPtr m_pSteamInventory;

		private static IntPtr m_pSteamUGC;

		private static IntPtr m_pSteamApps;

		private static IntPtr m_pSteamNetworkingUtils;

		private static IntPtr m_pSteamNetworkingSockets;

		private static IntPtr m_pSteamNetworkingMessages;

		internal static void Clear()
		{
		}

		internal static bool Init()
		{
			return false;
		}

		internal static IntPtr GetSteamClient()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamGameServer()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamUtils()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamNetworking()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamGameServerStats()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamHTTP()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamInventory()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamUGC()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamApps()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamNetworkingUtils()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamNetworkingSockets()
		{
			return (IntPtr)0;
		}

		internal static IntPtr GetSteamNetworkingMessages()
		{
			return (IntPtr)0;
		}
	}
}
