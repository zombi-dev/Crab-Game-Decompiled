using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 12)]
	public struct GSClientKick_t
	{
		public const int k_iCallback = 203;

		public CSteamID m_SteamID;

		public EDenyReason m_eDenyReason;
	}
}
