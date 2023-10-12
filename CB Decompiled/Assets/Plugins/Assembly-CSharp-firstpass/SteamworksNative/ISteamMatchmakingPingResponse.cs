using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	public class ISteamMatchmakingPingResponse
	{
		public delegate void ServerResponded(gameserveritem_t server);

		public delegate void ServerFailedToRespond();

		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		[StructLayout(0)]
		private class VTable
		{
			[NonSerialized]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private ServerResponded m_ServerResponded;

		private ServerFailedToRespond m_ServerFailedToRespond;

		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
		}

		~ISteamMatchmakingPingResponse()
		{
		}

		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return (IntPtr)0;
		}
	}
}
