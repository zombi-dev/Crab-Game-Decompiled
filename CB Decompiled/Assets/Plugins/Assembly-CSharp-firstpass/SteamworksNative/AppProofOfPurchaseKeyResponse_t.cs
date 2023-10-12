using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 252)]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		public const int k_iCallback = 1021;

		public EResult m_eResult;

		public uint m_nAppID;

		public uint m_cchKeyLength;

		private byte[] m_rgchKey_;

		public string m_rgchKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
