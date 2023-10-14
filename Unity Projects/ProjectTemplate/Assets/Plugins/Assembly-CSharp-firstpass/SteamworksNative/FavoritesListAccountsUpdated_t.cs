using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct FavoritesListAccountsUpdated_t
	{
		public const int k_iCallback = 516;

		public EResult m_eResult;
	}
}
