using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct SteamInventoryFullUpdate_t
	{
		public const int k_iCallback = 4701;

		public SteamInventoryResult_t m_handle;
	}
}
