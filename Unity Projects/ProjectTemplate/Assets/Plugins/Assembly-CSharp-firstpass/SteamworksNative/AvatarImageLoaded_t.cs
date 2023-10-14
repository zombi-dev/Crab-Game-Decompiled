using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 4, Size = 20)]
	public struct AvatarImageLoaded_t
	{
		public const int k_iCallback = 334;

		public CSteamID m_steamID;

		public int m_iImage;

		public int m_iWide;

		public int m_iTall;
	}
}
