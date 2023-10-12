using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct GetAuthSessionTicketResponse_t
	{
		public const int k_iCallback = 163;

		public HAuthTicket m_hAuthTicket;

		public EResult m_eResult;
	}
}
