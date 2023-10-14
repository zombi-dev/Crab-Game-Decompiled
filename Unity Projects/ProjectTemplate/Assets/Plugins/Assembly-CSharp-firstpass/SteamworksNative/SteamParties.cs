namespace SteamworksNative
{
	public static class SteamParties
	{
		public static uint GetNumActiveBeacons()
		{
			return 0u;
		}

		public static PartyBeaconID_t GetBeaconByIndex(uint unIndex)
		{
			return default(PartyBeaconID_t);
		}

		public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata)
		{
			pSteamIDBeaconOwner = default(CSteamID);
			pLocation = default(SteamPartyBeaconLocation_t);
			pchMetadata = null;
			return false;
		}

		public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID)
		{
			return default(SteamAPICall_t);
		}

		public static bool GetNumAvailableBeaconLocations(out uint puNumLocations)
		{
			puNumLocations = default(uint);
			return false;
		}

		public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations)
		{
			return false;
		}

		public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
		{
			return default(SteamAPICall_t);
		}

		public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
		}

		public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
		}

		public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots)
		{
			return default(SteamAPICall_t);
		}

		public static bool DestroyBeacon(PartyBeaconID_t ulBeacon)
		{
			return false;
		}

		public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut)
		{
			pchDataStringOut = null;
			return false;
		}
	}
}
