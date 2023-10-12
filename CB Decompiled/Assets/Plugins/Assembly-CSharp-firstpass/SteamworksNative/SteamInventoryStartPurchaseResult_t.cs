using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		public const int k_iCallback = 4704;

		public EResult m_result;

		public ulong m_ulOrderID;

		public ulong m_ulTransID;
	}
}
