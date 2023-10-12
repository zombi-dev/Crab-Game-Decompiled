namespace SteamworksNative
{
	public static class SteamParentalSettings
	{
		public static bool BIsParentalLockEnabled()
		{
			return false;
		}

		public static bool BIsParentalLockLocked()
		{
			return false;
		}

		public static bool BIsAppBlocked(AppId_t nAppID)
		{
			return false;
		}

		public static bool BIsAppInBlockList(AppId_t nAppID)
		{
			return false;
		}

		public static bool BIsFeatureBlocked(EParentalFeature eFeature)
		{
			return false;
		}

		public static bool BIsFeatureInBlockList(EParentalFeature eFeature)
		{
			return false;
		}
	}
}
