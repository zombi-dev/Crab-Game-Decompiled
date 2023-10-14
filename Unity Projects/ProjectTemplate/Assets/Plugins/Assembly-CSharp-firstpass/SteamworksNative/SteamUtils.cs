using System;

namespace SteamworksNative
{
	public static class SteamUtils
	{
		public static uint GetSecondsSinceAppActive()
		{
			return 0u;
		}

		public static uint GetSecondsSinceComputerActive()
		{
			return 0u;
		}

		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		public static uint GetServerRealTime()
		{
			return 0u;
		}

		public static string GetIPCountry()
		{
			return null;
		}

		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			pnWidth = default(uint);
			pnHeight = default(uint);
			return false;
		}

		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return false;
		}

		public static byte GetCurrentBatteryPower()
		{
			return 0;
		}

		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			pbFailed = default(bool);
			return false;
		}

		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			pbFailed = default(bool);
			return false;
		}

		public static uint GetIPCCallCount()
		{
			return 0u;
		}

		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		public static bool IsOverlayEnabled()
		{
			return false;
		}

		public static bool BOverlayNeedsPresent()
		{
			return false;
		}

		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return false;
		}

		public static uint GetEnteredGamepadTextLength()
		{
			return 0u;
		}

		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			pchText = null;
			return false;
		}

		public static string GetSteamUILanguage()
		{
			return null;
		}

		public static bool IsSteamRunningInVR()
		{
			return false;
		}

		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		public static bool IsSteamInBigPictureMode()
		{
			return false;
		}

		public static void StartVRDashboard()
		{
		}

		public static bool IsVRHeadsetStreamingEnabled()
		{
			return false;
		}

		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}

		public static bool IsSteamChinaLauncher()
		{
			return false;
		}

		public static bool InitFilterText(uint unFilterOptions = 0u)
		{
			return false;
		}

		public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText)
		{
			pchOutFilteredText = null;
			return 0;
		}

		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol)
		{
			return default(ESteamIPv6ConnectivityState);
		}
	}
}
