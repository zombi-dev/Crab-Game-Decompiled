using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct RegisterActivationCodeResponse_t
	{
		public const int k_iCallback = 1008;

		public ERegisterActivationCodeResult m_eResult;

		public uint m_unPackageRegistered;
	}
}
