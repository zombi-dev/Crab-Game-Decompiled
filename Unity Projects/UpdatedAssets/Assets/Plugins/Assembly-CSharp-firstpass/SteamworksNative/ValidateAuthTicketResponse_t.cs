using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 20)]
	public struct ValidateAuthTicketResponse_t
	{
		public const int k_iCallback = 143;

		public CSteamID m_SteamID;

		public EAuthSessionResponse m_eAuthSessionResponse;

		public CSteamID m_OwnerSteamID;
	}
}
