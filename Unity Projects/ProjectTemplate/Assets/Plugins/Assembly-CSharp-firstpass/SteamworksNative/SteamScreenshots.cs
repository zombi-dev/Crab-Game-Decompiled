namespace SteamworksNative
{
	public static class SteamScreenshots
	{
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		public static void TriggerScreenshot()
		{
		}

		public static void HookScreenshots(bool bHook)
		{
		}

		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return false;
		}

		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			return false;
		}

		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			return false;
		}

		public static bool IsScreenshotsHooked()
		{
			return false;
		}

		public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			return default(ScreenshotHandle);
		}
	}
}
