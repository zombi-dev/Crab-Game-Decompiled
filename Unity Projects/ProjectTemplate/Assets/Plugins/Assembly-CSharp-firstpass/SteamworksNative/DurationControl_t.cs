using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 32)]
	public struct DurationControl_t
	{
		public const int k_iCallback = 167;

		public EResult m_eResult;

		public AppId_t m_appid;

		public bool m_bApplicable;

		public int m_csecsLast5h;

		public EDurationControlProgress m_progress;

		public EDurationControlNotification m_notification;

		public int m_csecsToday;

		public int m_csecsRemaining;
	}
}
