using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct RequestPlayersForGameProgressCallback_t
	{
		public const int k_iCallback = 5211;

		public EResult m_eResult;

		public ulong m_ullSearchID;
	}
}
