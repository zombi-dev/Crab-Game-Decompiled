using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct HTTPRequestHeadersReceived_t
	{
		public const int k_iCallback = 2102;

		public HTTPRequestHandle m_hRequest;

		public ulong m_ulContextValue;
	}
}
