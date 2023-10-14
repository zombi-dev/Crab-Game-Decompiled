using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 32)]
	public struct HTTPRequestCompleted_t
	{
		public const int k_iCallback = 2101;

		public HTTPRequestHandle m_hRequest;

		public ulong m_ulContextValue;

		public bool m_bRequestSuccessful;

		public EHTTPStatusCode m_eStatusCode;

		public uint m_unBodySize;
	}
}
