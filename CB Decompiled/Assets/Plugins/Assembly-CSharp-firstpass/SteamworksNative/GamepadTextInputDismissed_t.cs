using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 8)]
	public struct GamepadTextInputDismissed_t
	{
		public const int k_iCallback = 714;

		public bool m_bSubmitted;

		public uint m_unSubmittedText;
	}
}
