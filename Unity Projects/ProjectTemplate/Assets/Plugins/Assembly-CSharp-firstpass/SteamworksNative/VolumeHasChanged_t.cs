using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct VolumeHasChanged_t
	{
		public const int k_iCallback = 4002;

		public float m_flNewVolume;
	}
}
