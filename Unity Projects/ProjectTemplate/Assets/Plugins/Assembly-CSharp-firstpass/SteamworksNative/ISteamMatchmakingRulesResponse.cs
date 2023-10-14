using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	public class ISteamMatchmakingRulesResponse
	{
		public delegate void RulesResponded(string pchRule, string pchValue);

		public delegate void RulesFailedToRespond();

		public delegate void RulesRefreshComplete();

		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		private class VTable
		{
			[NonSerialized]
			public InternalRulesResponded m_VTRulesResponded;

			[NonSerialized]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			[NonSerialized]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private RulesResponded m_RulesResponded;

		private RulesFailedToRespond m_RulesFailedToRespond;

		private RulesRefreshComplete m_RulesRefreshComplete;

		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		~ISteamMatchmakingRulesResponse()
		{
		}

		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
		}

		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
		}

		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return (IntPtr)0;
		}
	}
}
