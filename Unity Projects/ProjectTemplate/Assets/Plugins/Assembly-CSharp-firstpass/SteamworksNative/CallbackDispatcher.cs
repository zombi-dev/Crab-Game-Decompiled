using System;
using System.Collections.Generic;

namespace SteamworksNative
{
	public static class CallbackDispatcher
	{
		private static Dictionary<int, List<Callback>> m_registeredCallbacks;

		private static Dictionary<int, List<Callback>> m_registeredGameServerCallbacks;

		private static Dictionary<ulong, List<CallResult>> m_registeredCallResults;

		private static object m_sync;

		private static IntPtr m_pCallbackMsg;

		private static int m_initCount;

		public static bool IsInitialized => false;

		public static void ExceptionHandler(Exception e)
		{
		}

		internal static void Initialize()
		{
		}

		internal static void Shutdown()
		{
		}

		internal static void Register(Callback cb)
		{
		}

		internal static void Register(SteamAPICall_t asyncCall, CallResult cr)
		{
		}

		internal static void Unregister(Callback cb)
		{
		}

		internal static void Unregister(SteamAPICall_t asyncCall, CallResult cr)
		{
		}

		private static void UnregisterAll()
		{
		}

		internal static void RunFrame(bool isGameServer)
		{
		}
	}
}
