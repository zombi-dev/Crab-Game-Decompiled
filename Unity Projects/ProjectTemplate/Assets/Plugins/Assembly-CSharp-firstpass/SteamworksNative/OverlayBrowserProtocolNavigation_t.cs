using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 1024)]
	public struct OverlayBrowserProtocolNavigation_t
	{
		public const int k_iCallback = 349;

		private byte[] rgchURI_;

		public string rgchURI
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
