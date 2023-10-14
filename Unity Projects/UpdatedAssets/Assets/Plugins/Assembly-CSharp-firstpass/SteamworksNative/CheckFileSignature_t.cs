using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct CheckFileSignature_t
	{
		public const int k_iCallback = 705;

		public ECheckFileSignature m_eCheckFileSignature;
	}
}
