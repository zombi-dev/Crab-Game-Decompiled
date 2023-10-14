using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct MusicPlayerWantsVolume_t
	{
		public const int k_iCallback = 4011;

		public float m_flNewVolume;
	}
}
