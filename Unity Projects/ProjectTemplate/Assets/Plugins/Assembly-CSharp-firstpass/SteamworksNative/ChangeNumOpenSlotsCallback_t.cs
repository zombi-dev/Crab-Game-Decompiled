using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct ChangeNumOpenSlotsCallback_t
	{
		public const int k_iCallback = 5304;

		public EResult m_eResult;
	}
}
