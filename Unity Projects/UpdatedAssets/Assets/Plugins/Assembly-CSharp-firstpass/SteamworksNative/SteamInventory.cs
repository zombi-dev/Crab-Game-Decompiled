namespace SteamworksNative
{
	public static class SteamInventory
	{
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return false;
		}

		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			pchValueBuffer = null;
			return false;
		}

		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return 0u;
		}

		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return false;
		}

		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			punOutBufferSize = default(uint);
			return false;
		}

		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			pOutResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static void SendItemDropHeartbeat()
		{
		}

		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool LoadItemDefinitions()
		{
			return false;
		}

		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return false;
		}

		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			pchValueBuffer = null;
			return false;
		}

		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return false;
		}

		public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t RequestPrices()
		{
			return default(SteamAPICall_t);
		}

		public static uint GetNumItemsWithPrices()
		{
			return 0u;
		}

		public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength)
		{
			return false;
		}

		public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice)
		{
			pCurrentPrice = default(ulong);
			pBasePrice = default(ulong);
			return false;
		}

		public static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName)
		{
			return false;
		}

		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue)
		{
			return false;
		}

		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue)
		{
			return false;
		}

		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue)
		{
			return false;
		}

		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue)
		{
			return false;
		}

		public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}

		public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			pResultHandle = default(SteamInventoryResult_t);
			return false;
		}
	}
}
