using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[Serializable]
	[StructLayout(0, Pack = 8, Size = 2984)]
	public struct SteamDatagramRelayAuthTicket
	{
		[StructLayout(0, Pack = 8, Size = 160)]
		private struct ExtraField
		{
			private enum EType
			{
				k_EType_String = 0,
				k_EType_Int = 1,
				k_EType_Fixed64 = 2
			}

			[StructLayout(2)]
			private struct OptionValue
			{
				[FieldOffset(0)]
				private byte[] m_szStringValue;

				[FieldOffset(0)]
				private long m_nIntValue;

				[FieldOffset(0)]
				private ulong m_nFixed64Value;
			}

			private EType m_eType;

			private byte[] m_szName;

			private OptionValue m_val;
		}

		private SteamNetworkingIdentity m_identityGameserver;

		private SteamNetworkingIdentity m_identityAuthorizedClient;

		private uint m_unPublicIP;

		private RTime32 m_rtimeTicketExpiry;

		private SteamDatagramHostedAddress m_routing;

		private uint m_nAppID;

		private int m_nRestrictToVirtualPort;

		private const int k_nMaxExtraFields = 16;

		private int m_nExtraFields;

		private ExtraField[] m_vecExtraFields;

		public void Clear()
		{
		}
	}
}
