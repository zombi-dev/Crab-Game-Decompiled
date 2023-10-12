using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 412)]
	public struct FriendsEnumerateFollowingList_t
	{
		public const int k_iCallback = 346;

		public EResult m_eResult;

		public CSteamID[] m_rgSteamID;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;
	}
}
