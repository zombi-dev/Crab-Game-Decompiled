using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct ClientGameServerDeny_t
	{
		public const int k_iCallback = 113;

		public uint m_uAppID;

		public uint m_unGameServerIP;

		public ushort m_usGameServerPort;

		public ushort m_bSecure;

		public uint m_uReason;
	}
}
