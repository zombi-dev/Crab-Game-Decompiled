using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 24)]
	public struct SubmitPlayerResultResultCallback_t
	{
		public const int k_iCallback = 5214;

		public EResult m_eResult;

		public ulong ullUniqueGameID;

		public CSteamID steamIDPlayer;
	}
}
