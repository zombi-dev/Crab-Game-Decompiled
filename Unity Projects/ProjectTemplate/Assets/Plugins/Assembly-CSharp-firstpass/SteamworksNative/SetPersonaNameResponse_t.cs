using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct SetPersonaNameResponse_t
	{
		public const int k_iCallback = 347;

		public bool m_bSuccess;

		public bool m_bLocalSuccess;

		public EResult m_result;
	}
}
