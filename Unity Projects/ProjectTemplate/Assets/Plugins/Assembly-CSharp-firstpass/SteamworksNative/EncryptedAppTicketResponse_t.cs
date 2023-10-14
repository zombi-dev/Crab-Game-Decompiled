using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct EncryptedAppTicketResponse_t
	{
		public const int k_iCallback = 154;

		public EResult m_eResult;
	}
}
