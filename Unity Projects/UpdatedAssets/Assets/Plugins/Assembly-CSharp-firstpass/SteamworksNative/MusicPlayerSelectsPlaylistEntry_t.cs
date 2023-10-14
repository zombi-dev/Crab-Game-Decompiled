using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		public const int k_iCallback = 4013;

		public int nID;
	}
}
