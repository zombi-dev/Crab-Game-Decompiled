using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct GCMessageAvailable_t
	{
		public const int k_iCallback = 1701;

		public uint m_nMessageSize;
	}
}
