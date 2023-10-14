using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	internal static class NativeMethods
	{
		internal const string NativeLibraryName = "steam_api64_net";

		internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64";

		[PreserveSig]
		public static extern bool SteamAPI_Init();

		[PreserveSig]
		public static extern void SteamAPI_Shutdown();

		[PreserveSig]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[PreserveSig]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		[PreserveSig]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		[PreserveSig]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		[PreserveSig]
		public static extern void SteamAPI_RunCallbacks();

		[PreserveSig]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		[PreserveSig]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		[PreserveSig]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		public static extern bool SteamAPI_IsSteamRunning();

		[PreserveSig]
		public static extern int SteamAPI_GetSteamInstallPath();

		[PreserveSig]
		public static extern int SteamAPI_GetHSteamPipe();

		[PreserveSig]
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks);

		[PreserveSig]
		public static extern int SteamAPI_GetHSteamUser();

		[PreserveSig]
		public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData);

		[PreserveSig]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		[PreserveSig]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		[PreserveSig]
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID);

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_Init();

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg);

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		public static extern void SteamGameServer_Shutdown();

		[PreserveSig]
		public static extern void SteamGameServer_RunCallbacks();

		[PreserveSig]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		[PreserveSig]
		public static extern bool SteamGameServer_BSecure();

		[PreserveSig]
		public static extern ulong SteamGameServer_GetSteamID();

		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamPipe();

		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamUser();

		[PreserveSig]
		public static extern bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		public static extern IntPtr SteamClient();

		[PreserveSig]
		public static extern IntPtr SteamGameServerClient();

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_Clear(ref SteamNetworkingIPAddr self);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(ref SteamNetworkingIPAddr self);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6(ref SteamNetworkingIPAddr self, [In][Out] byte[] ipv6, ushort nPort);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv4(ref SteamNetworkingIPAddr self, uint nIP, ushort nPort);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv4(ref SteamNetworkingIPAddr self);

		[PreserveSig]
		public static extern uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(ref SteamNetworkingIPAddr self);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(ref SteamNetworkingIPAddr self, ushort nPort);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsLocalHost(ref SteamNetworkingIPAddr self);

		[PreserveSig]
		public static extern void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr self, IntPtr buf, uint cbBuf, bool bWithPort);

		[PreserveSig]
		public static extern bool SteamNetworkingIPAddr_ParseString(ref SteamNetworkingIPAddr self, InteropHelp.UTF8StringHandle pszStr);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsEqualTo(ref SteamNetworkingIPAddr self, ref SteamNetworkingIPAddr x);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_Clear(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsInvalid(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID(ref SteamNetworkingIdentity self, ulong steamID);

		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID64(ref SteamNetworkingIdentity self, ulong steamID);

		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString);

		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_SetIPAddr(ref SteamNetworkingIdentity self, ref SteamNetworkingIPAddr addr);

		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetIPAddr(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetLocalHost(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsLocalHost(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString);

		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericString(ref SteamNetworkingIdentity self);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericBytes(ref SteamNetworkingIdentity self, [In][Out] byte[] data, uint cbLen);

		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericBytes(ref SteamNetworkingIdentity self, out int cbLen);

		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsEqualTo(ref SteamNetworkingIdentity self, ref SteamNetworkingIdentity x);

		[PreserveSig]
		public static extern void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity self, IntPtr buf, uint cbBuf);

		[PreserveSig]
		public static extern bool SteamNetworkingIdentity_ParseString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszStr);

		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr self);

		[PreserveSig]
		public static extern bool SteamAPI_ISteamNetworkingConnectionSignaling_SendSignal(ref ISteamNetworkingConnectionSignaling self, HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg);

		[PreserveSig]
		public static extern void SteamAPI_ISteamNetworkingConnectionSignaling_Release(ref ISteamNetworkingConnectionSignaling self);

		[PreserveSig]
		public static extern IntPtr SteamAPI_ISteamNetworkingSignalingRecvContext_OnConnectRequest(ref ISteamNetworkingSignalingRecvContext self, HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort);

		[PreserveSig]
		public static extern void SteamAPI_ISteamNetworkingSignalingRecvContext_SendRejectionSignal(ref ISteamNetworkingSignalingRecvContext self, ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg);

		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket([In][Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In][Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey);

		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		[PreserveSig]
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsTicketSigned([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, [In][Out] byte[] pubRSAKey, uint cubRSAKey);

		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsLicenseBorrowed([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsLicenseTemporary([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		public static extern uint ISteamAppList_GetNumInstalledApps(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamAppList_GetInstalledApps(IntPtr instancePtr, [In][Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		[PreserveSig]
		public static extern int ISteamAppList_GetAppName(IntPtr instancePtr, AppId_t nAppID, IntPtr pchName, int cchNameMax);

		[PreserveSig]
		public static extern int ISteamAppList_GetAppInstallDir(IntPtr instancePtr, AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		[PreserveSig]
		public static extern int ISteamAppList_GetAppBuildId(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID);

		[PreserveSig]
		public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID);

		[PreserveSig]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr);

		[PreserveSig]
		public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly);

		[PreserveSig]
		public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		[PreserveSig]
		public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		[PreserveSig]
		public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID);

		[PreserveSig]
		public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName);

		[PreserveSig]
		public static extern int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine);

		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedFromFamilySharing(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamApps_BIsTimedTrial(IntPtr instancePtr, out uint punSecondsAllowed, out uint punSecondsPlayed);

		[PreserveSig]
		public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType);

		[PreserveSig]
		public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, ref SteamIPAddress_t unIP, ushort usPort);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName);

		[PreserveSig]
		public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In][Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		[PreserveSig]
		public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		[PreserveSig]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In][Out] CSteamID[] psteamIDClans, int cClansToRequest);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend);

		[PreserveSig]
		public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource);

		[PreserveSig]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag);

		[PreserveSig]
		public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly);

		[PreserveSig]
		public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer);

		[PreserveSig]
		public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey);

		[PreserveSig]
		public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		[PreserveSig]
		public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser);

		[PreserveSig]
		public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		[PreserveSig]
		public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser);

		[PreserveSig]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[PreserveSig]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[PreserveSig]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[PreserveSig]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled);

		[PreserveSig]
		public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		[PreserveSig]
		public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex);

		[PreserveSig]
		public static extern bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern int ISteamFriends_GetNumChatsWithUnreadPriorityMessages(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern bool ISteamFriends_RegisterProtocolInOverlayBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchProtocol);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialogConnectString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectString);

		[PreserveSig]
		public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct);

		[PreserveSig]
		public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription);

		[PreserveSig]
		public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir);

		[PreserveSig]
		public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated);

		[PreserveSig]
		public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken);

		[PreserveSig]
		public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamGameServer_LogOff(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax);

		[PreserveSig]
		public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers);

		[PreserveSig]
		public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName);

		[PreserveSig]
		public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName);

		[PreserveSig]
		public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected);

		[PreserveSig]
		public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort);

		[PreserveSig]
		public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName);

		[PreserveSig]
		public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags);

		[PreserveSig]
		public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData);

		[PreserveSig]
		public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion);

		[PreserveSig]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		[PreserveSig]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamGameServer_SendUserDisconnect(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		[PreserveSig]
		public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		[PreserveSig]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		[PreserveSig]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup);

		[PreserveSig]
		public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr);

		[PreserveSig]
		public static extern SteamIPAddress_t ISteamGameServer_GetPublicIP(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort);

		[PreserveSig]
		public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		[PreserveSig]
		public static extern void ISteamGameServer_EnableHeartbeats(IntPtr instancePtr, bool bActive);

		[PreserveSig]
		public static extern void ISteamGameServer_SetHeartbeatInterval(IntPtr instancePtr, int iHeartbeatInterval);

		[PreserveSig]
		public static extern void ISteamGameServer_ForceHeartbeat(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer);

		[PreserveSig]
		public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_OpenDeveloperTools(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult);

		[PreserveSig]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		[PreserveSig]
		public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[PreserveSig]
		public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[PreserveSig]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify);

		[PreserveSig]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		public static extern bool ISteamInput_Init(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamInput_Shutdown(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamInput_RunFrame(IntPtr instancePtr);

		[PreserveSig]
		public static extern int ISteamInput_GetConnectedControllers(IntPtr instancePtr, [In][Out] InputHandle_t[] handlesOut);

		[PreserveSig]
		public static extern ulong ISteamInput_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName);

		[PreserveSig]
		public static extern void ISteamInput_ActivateActionSet(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle);

		[PreserveSig]
		public static extern ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern void ISteamInput_ActivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		[PreserveSig]
		public static extern void ISteamInput_DeactivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		[PreserveSig]
		public static extern void ISteamInput_DeactivateAllActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern int ISteamInput_GetActiveActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle, [In][Out] InputActionSetHandle_t[] handlesOut);

		[PreserveSig]
		public static extern ulong ISteamInput_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		[PreserveSig]
		public static extern InputDigitalActionData_t ISteamInput_GetDigitalActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle);

		[PreserveSig]
		public static extern int ISteamInput_GetDigitalActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, [In][Out] EInputActionOrigin[] originsOut);

		[PreserveSig]
		public static extern ulong ISteamInput_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		[PreserveSig]
		public static extern InputAnalogActionData_t ISteamInput_GetAnalogActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle);

		[PreserveSig]
		public static extern int ISteamInput_GetAnalogActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, [In][Out] EInputActionOrigin[] originsOut);

		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin);

		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin);

		[PreserveSig]
		public static extern void ISteamInput_StopAnalogActionMomentum(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction);

		[PreserveSig]
		public static extern InputMotionData_t ISteamInput_GetMotionData(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern void ISteamInput_TriggerVibration(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed);

		[PreserveSig]
		public static extern void ISteamInput_SetLEDColor(IntPtr instancePtr, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		[PreserveSig]
		public static extern void ISteamInput_TriggerHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		[PreserveSig]
		public static extern void ISteamInput_TriggerRepeatedHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		[PreserveSig]
		public static extern bool ISteamInput_ShowBindingPanel(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex);

		[PreserveSig]
		public static extern int ISteamInput_GetGamepadIndexForController(IntPtr instancePtr, InputHandle_t ulinputHandle);

		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin);

		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin);

		[PreserveSig]
		public static extern EInputActionOrigin ISteamInput_GetActionOriginFromXboxOrigin(IntPtr instancePtr, InputHandle_t inputHandle, EXboxOrigin eOrigin);

		[PreserveSig]
		public static extern EInputActionOrigin ISteamInput_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin);

		[PreserveSig]
		public static extern bool ISteamInput_GetDeviceBindingRevision(IntPtr instancePtr, InputHandle_t inputHandle, out int pMajor, out int pMinor);

		[PreserveSig]
		public static extern uint ISteamInput_GetRemotePlaySessionID(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[PreserveSig]
		public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[PreserveSig]
		public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[PreserveSig]
		public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[PreserveSig]
		public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		[PreserveSig]
		public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In][Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		[PreserveSig]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[PreserveSig]
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In][Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		[PreserveSig]
		public static extern ulong ISteamInventory_StartPurchase(IntPtr instancePtr, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		public static extern ulong ISteamInventory_RequestPrices(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] ulong[] pCurrentPrices, [In][Out] ulong[] pBasePrices, uint unArrayLength);

		[PreserveSig]
		public static extern bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice);

		[PreserveSig]
		public static extern ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName);

		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyString(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, InteropHelp.UTF8StringHandle pchPropertyValue);

		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyBool(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, bool bValue);

		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyInt64(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, long nValue);

		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyFloat(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, float flValue);

		[PreserveSig]
		public static extern bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		public static extern bool ISteamInventory_InspectItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, InteropHelp.UTF8StringHandle pchItemToken);

		[PreserveSig]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		[PreserveSig]
		public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable);

		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter);

		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults);

		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee);

		[PreserveSig]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody);

		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers);

		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest);

		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		[PreserveSig]
		public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		[PreserveSig]
		public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AddGameSearchParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToFind, InteropHelp.UTF8StringHandle pchValuesToFind);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameWithLobby(IntPtr instancePtr, CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameSolo(IntPtr instancePtr, int nPlayerMin, int nPlayerMax);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AcceptGame(IntPtr instancePtr);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_DeclineGame(IntPtr instancePtr);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RetrieveConnectionDetails(IntPtr instancePtr, CSteamID steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGameSearch(IntPtr instancePtr);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetGameHostParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetConnectionDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectionDetails, int cubConnectionDetails);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RequestPlayersForGame(IntPtr instancePtr, int nPlayerMin, int nPlayerMax, int nMaxTeamSize);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_HostConfirmGameStart(IntPtr instancePtr, ulong ullUniqueGameID);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_CancelRequestPlayersForGame(IntPtr instancePtr);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SubmitPlayerResult(IntPtr instancePtr, ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult);

		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGame(IntPtr instancePtr, ulong ullUniqueGameID);

		[PreserveSig]
		public static extern uint ISteamParties_GetNumActiveBeacons(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamParties_GetBeaconByIndex(IntPtr instancePtr, uint unIndex);

		[PreserveSig]
		public static extern bool ISteamParties_GetBeaconDetails(IntPtr instancePtr, PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata);

		[PreserveSig]
		public static extern ulong ISteamParties_JoinParty(IntPtr instancePtr, PartyBeaconID_t ulBeaconID);

		[PreserveSig]
		public static extern bool ISteamParties_GetNumAvailableBeaconLocations(IntPtr instancePtr, out uint puNumLocations);

		[PreserveSig]
		public static extern bool ISteamParties_GetAvailableBeaconLocations(IntPtr instancePtr, [In][Out] SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations);

		[PreserveSig]
		public static extern ulong ISteamParties_CreateBeacon(IntPtr instancePtr, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, InteropHelp.UTF8StringHandle pchConnectString, InteropHelp.UTF8StringHandle pchMetadata);

		[PreserveSig]
		public static extern void ISteamParties_OnReservationCompleted(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser);

		[PreserveSig]
		public static extern void ISteamParties_CancelReservation(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser);

		[PreserveSig]
		public static extern ulong ISteamParties_ChangeNumOpenSlots(IntPtr instancePtr, PartyBeaconID_t ulBeacon, uint unOpenSlots);

		[PreserveSig]
		public static extern bool ISteamParties_DestroyBeacon(IntPtr instancePtr, PartyBeaconID_t ulBeacon);

		[PreserveSig]
		public static extern bool ISteamParties_GetBeaconLocationData(IntPtr instancePtr, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut);

		[PreserveSig]
		public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr);

		[PreserveSig]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamMusic_Play(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamMusic_Pause(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamMusic_PlayNext(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume);

		[PreserveSig]
		public static extern float ISteamMusic_GetVolume(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID);

		[PreserveSig]
		public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel);

		[PreserveSig]
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[PreserveSig]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[PreserveSig]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow);

		[PreserveSig]
		public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable);

		[PreserveSig]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort);

		[PreserveSig]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket);

		[PreserveSig]
		public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket);

		[PreserveSig]
		public static extern EResult ISteamNetworkingMessages_SendMessageToUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel);

		[PreserveSig]
		public static extern int ISteamNetworkingMessages_ReceiveMessagesOnChannel(IntPtr instancePtr, int nLocalChannel, [In][Out] IntPtr[] ppOutMessages, int nMaxMessages);

		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_AcceptSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote);

		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_CloseSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote);

		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_CloseChannelWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nLocalChannel);

		[PreserveSig]
		public static extern ESteamNetworkingConnectionState ISteamNetworkingMessages_GetSessionConnectionInfo(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetworkingQuickConnectionStatus pQuickStatus);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketIP(IntPtr instancePtr, ref SteamNetworkingIPAddr localAddress, int nOptions, [In][Out] SteamNetworkingConfigValue_t[] pOptions);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectByIPAddress(IntPtr instancePtr, ref SteamNetworkingIPAddr address, int nOptions, [In][Out] SteamNetworkingConfigValue_t[] pOptions);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketP2P(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In][Out] SteamNetworkingConfigValue_t[] pOptions);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectP2P(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In][Out] SteamNetworkingConfigValue_t[] pOptions);

		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_AcceptConnection(IntPtr instancePtr, HSteamNetConnection hConn);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CloseConnection(IntPtr instancePtr, HSteamNetConnection hPeer, int nReason, InteropHelp.UTF8StringHandle pszDebug, bool bEnableLinger);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CloseListenSocket(IntPtr instancePtr, HSteamListenSocket hSocket);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer, long nUserData);

		[PreserveSig]
		public static extern long ISteamNetworkingSockets_GetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer);

		[PreserveSig]
		public static extern void ISteamNetworkingSockets_SetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, InteropHelp.UTF8StringHandle pszName);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, IntPtr pszName, int nMaxLen);

		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_SendMessageToConnection(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber);

		[PreserveSig]
		public static extern void ISteamNetworkingSockets_SendMessages(IntPtr instancePtr, int nMessages, [In][Out] SteamNetworkingMessage_t[] pMessages, [In][Out] long[] pOutMessageNumberOrResult);

		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_FlushMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn);

		[PreserveSig]
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn, [In][Out] IntPtr[] ppOutMessages, int nMaxMessages);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetConnectionInfo(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetQuickConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetworkingQuickConnectionStatus pStats);

		[PreserveSig]
		public static extern int ISteamNetworkingSockets_GetDetailedConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pszBuf, int cbBuf);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetListenSocketAddress(IntPtr instancePtr, HSteamListenSocket hSocket, out SteamNetworkingIPAddr address);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CreateSocketPair(IntPtr instancePtr, out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetIdentity(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity);

		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_InitAuthentication(IntPtr instancePtr);

		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr instancePtr, out SteamNetAuthenticationStatus_t pDetails);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreatePollGroup(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_DestroyPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetConnectionPollGroup(IntPtr instancePtr, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup);

		[PreserveSig]
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup, [In][Out] IntPtr[] ppOutMessages, int nMaxMessages);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_ReceivedRelayAuthTicket(IntPtr instancePtr, IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket);

		[PreserveSig]
		public static extern int ISteamNetworkingSockets_FindRelayAuthTicketForServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectToHostedDedicatedServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In][Out] SteamNetworkingConfigValue_t[] pOptions);

		[PreserveSig]
		public static extern ushort ISteamNetworkingSockets_GetHostedDedicatedServerPort(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(IntPtr instancePtr);

		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetHostedDedicatedServerAddress(IntPtr instancePtr, out SteamDatagramHostedAddress pRouting);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In][Out] SteamNetworkingConfigValue_t[] pOptions);

		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetGameCoordinatorServerLogin(IntPtr instancePtr, out SteamDatagramGameCoordinatorServerLogin pLoginInfo, out int pcbSignedBlob, IntPtr pBlob);

		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectP2PCustomSignaling(IntPtr instancePtr, out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In][Out] SteamNetworkingConfigValue_t[] pOptions);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_ReceivedP2PCustomSignal(IntPtr instancePtr, IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetCertificateRequest(IntPtr instancePtr, out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg);

		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetCertificate(IntPtr instancePtr, IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg);

		[PreserveSig]
		public static extern void ISteamNetworkingSockets_RunCallbacks(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamNetworkingUtils_AllocateMessage(IntPtr instancePtr, int cbAllocateBuffer);

		[PreserveSig]
		public static extern void ISteamNetworkingUtils_InitRelayNetworkAccess(IntPtr instancePtr);

		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr instancePtr, out SteamRelayNetworkStatus_t pDetails);

		[PreserveSig]
		public static extern float ISteamNetworkingUtils_GetLocalPingLocation(IntPtr instancePtr, out SteamNetworkPingLocation_t result);

		[PreserveSig]
		public static extern int ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(IntPtr instancePtr, ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2);

		[PreserveSig]
		public static extern int ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(IntPtr instancePtr, ref SteamNetworkPingLocation_t remoteLocation);

		[PreserveSig]
		public static extern void ISteamNetworkingUtils_ConvertPingLocationToString(IntPtr instancePtr, ref SteamNetworkPingLocation_t location, IntPtr pszBuf, int cchBufSize);

		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_ParsePingLocationString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszString, out SteamNetworkPingLocation_t result);

		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_CheckPingDataUpToDate(IntPtr instancePtr, float flMaxAgeSeconds);

		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPingToDataCenter(IntPtr instancePtr, SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP);

		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetDirectPingToPOP(IntPtr instancePtr, SteamNetworkingPOPID popID);

		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPOPCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPOPList(IntPtr instancePtr, out SteamNetworkingPOPID list, int nListSz);

		[PreserveSig]
		public static extern long ISteamNetworkingUtils_GetLocalTimestamp(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SetDebugOutputFunction(IntPtr instancePtr, ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc);

		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg);

		[PreserveSig]
		public static extern ESteamNetworkingGetConfigValueResult ISteamNetworkingUtils_GetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, out ulong cbResult);

		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_GetConfigValueInfo(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, IntPtr pOutName, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope, out ESteamNetworkingConfigValue pOutNextValue);

		[PreserveSig]
		public static extern ESteamNetworkingConfigValue ISteamNetworkingUtils_GetFirstConfigValue(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(IntPtr instancePtr, ref SteamNetworkingIPAddr addr, IntPtr buf, uint cbBuf, bool bWithPort);

		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(IntPtr instancePtr, out SteamNetworkingIPAddr pAddr, InteropHelp.UTF8StringHandle pszStr);

		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(IntPtr instancePtr, ref SteamNetworkingIdentity identity, IntPtr buf, uint cbBuf);

		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity, InteropHelp.UTF8StringHandle pszStr);

		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature);

		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature);

		[PreserveSig]
		public static extern uint ISteamRemotePlay_GetSessionCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamRemotePlay_GetSessionID(IntPtr instancePtr, int iSessionIndex);

		[PreserveSig]
		public static extern ulong ISteamRemotePlay_GetSessionSteamID(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		[PreserveSig]
		public static extern IntPtr ISteamRemotePlay_GetSessionClientName(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		[PreserveSig]
		public static extern ESteamDeviceFormFactor ISteamRemotePlay_GetSessionClientFormFactor(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		[PreserveSig]
		public static extern bool ISteamRemotePlay_BGetSessionClientResolution(IntPtr instancePtr, RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY);

		[PreserveSig]
		public static extern bool ISteamRemotePlay_BSendRemotePlayTogetherInvite(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData);

		[PreserveSig]
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		[PreserveSig]
		public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		[PreserveSig]
		public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		[PreserveSig]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		[PreserveSig]
		public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook);

		[PreserveSig]
		public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		[PreserveSig]
		public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID);

		[PreserveSig]
		public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		[PreserveSig]
		public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename);

		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestPage(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestCursor(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, InteropHelp.UTF8StringHandle pchCursor);

		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCTagDisplayName(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryFirstUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, InteropHelp.UTF8StringHandle pchKey, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredTagGroup(IntPtr instancePtr, UGCQueryHandle_t handle, IntPtr pTagGroups);

		[PreserveSig]
		public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly);

		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[PreserveSig]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[PreserveSig]
		public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag);

		[PreserveSig]
		public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[PreserveSig]
		public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[PreserveSig]
		public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[PreserveSig]
		public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[PreserveSig]
		public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		public static extern bool ISteamUGC_SetAllowLegacyUpload(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAllowLegacyUpload);

		[PreserveSig]
		public static extern bool ISteamUGC_RemoveAllItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle);

		[PreserveSig]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		[PreserveSig]
		public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index);

		[PreserveSig]
		public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[PreserveSig]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[PreserveSig]
		public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp);

		[PreserveSig]
		public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[PreserveSig]
		public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority);

		[PreserveSig]
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		[PreserveSig]
		public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend);

		[PreserveSig]
		public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		[PreserveSig]
		public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		[PreserveSig]
		public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		[PreserveSig]
		public static extern int ISteamUser_InitiateGameConnection(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		[PreserveSig]
		public static extern void ISteamUser_TerminateGameConnection(IntPtr instancePtr, uint unIPServer, ushort usPortServer);

		[PreserveSig]
		public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		[PreserveSig]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer);

		[PreserveSig]
		public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr);

		[PreserveSig]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		[PreserveSig]
		public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		[PreserveSig]
		public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		[PreserveSig]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		[PreserveSig]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		[PreserveSig]
		public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		[PreserveSig]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude);

		[PreserveSig]
		public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil);

		[PreserveSig]
		public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL);

		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamUser_GetMarketEligibility(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamUser_GetDurationControl(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUser_BSetDurationControlOnlineState(IntPtr instancePtr, EDurationControlOnlineState eNewState);

		[PreserveSig]
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		[PreserveSig]
		public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		[PreserveSig]
		public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement);

		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo);

		[PreserveSig]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		[PreserveSig]
		public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName);

		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		[PreserveSig]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In][Out] CSteamID[] prgUsers, int cUsers);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		[PreserveSig]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		[PreserveSig]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		[PreserveSig]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr);

		[PreserveSig]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetGlobalStatInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetGlobalStatDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData);

		[PreserveSig]
		public static extern int ISteamUserStats_GetGlobalStatHistoryInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In][Out] long[] pData, uint cubData);

		[PreserveSig]
		public static extern int ISteamUserStats_GetGlobalStatHistoryDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In][Out] double[] pData, uint cubData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementProgressLimitsInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pnMinProgress, out int pnMaxProgress);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementProgressLimitsFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pfMinProgress, out float pfMaxProgress);

		[PreserveSig]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr);

		[PreserveSig]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition);

		[PreserveSig]
		public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName);

		[PreserveSig]
		public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[PreserveSig]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText);

		[PreserveSig]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset);

		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr);

		[PreserveSig]
		public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled);

		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamChinaLauncher(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUtils_InitFilterText(IntPtr instancePtr, uint unFilterOptions);

		[PreserveSig]
		public static extern int ISteamUtils_FilterText(IntPtr instancePtr, ETextFilteringContext eContext, CSteamID sourceSteamID, InteropHelp.UTF8StringHandle pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText);

		[PreserveSig]
		public static extern ESteamIPv6ConnectivityState ISteamUtils_GetIPv6ConnectivityState(IntPtr instancePtr, ESteamIPv6ConnectivityProtocol eProtocol);

		[PreserveSig]
		public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID);

		[PreserveSig]
		public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers);

		[PreserveSig]
		public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID);

		[PreserveSig]
		public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize);
	}
}
