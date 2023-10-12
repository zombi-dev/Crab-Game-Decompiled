namespace SteamworksNative
{
	public static class SteamMusicRemote
	{
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			return false;
		}

		public static bool DeregisterSteamMusicRemote()
		{
			return false;
		}

		public static bool BIsCurrentMusicRemote()
		{
			return false;
		}

		public static bool BActivationSuccess(bool bValue)
		{
			return false;
		}

		public static bool SetDisplayName(string pchDisplayName)
		{
			return false;
		}

		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			return false;
		}

		public static bool EnablePlayPrevious(bool bValue)
		{
			return false;
		}

		public static bool EnablePlayNext(bool bValue)
		{
			return false;
		}

		public static bool EnableShuffled(bool bValue)
		{
			return false;
		}

		public static bool EnableLooped(bool bValue)
		{
			return false;
		}

		public static bool EnableQueue(bool bValue)
		{
			return false;
		}

		public static bool EnablePlaylists(bool bValue)
		{
			return false;
		}

		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			return false;
		}

		public static bool UpdateShuffled(bool bValue)
		{
			return false;
		}

		public static bool UpdateLooped(bool bValue)
		{
			return false;
		}

		public static bool UpdateVolume(float flValue)
		{
			return false;
		}

		public static bool CurrentEntryWillChange()
		{
			return false;
		}

		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return false;
		}

		public static bool UpdateCurrentEntryText(string pchText)
		{
			return false;
		}

		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return false;
		}

		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			return false;
		}

		public static bool CurrentEntryDidChange()
		{
			return false;
		}

		public static bool QueueWillChange()
		{
			return false;
		}

		public static bool ResetQueueEntries()
		{
			return false;
		}

		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return false;
		}

		public static bool SetCurrentQueueEntry(int nID)
		{
			return false;
		}

		public static bool QueueDidChange()
		{
			return false;
		}

		public static bool PlaylistWillChange()
		{
			return false;
		}

		public static bool ResetPlaylistEntries()
		{
			return false;
		}

		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return false;
		}

		public static bool SetCurrentPlaylistEntry(int nID)
		{
			return false;
		}

		public static bool PlaylistDidChange()
		{
			return false;
		}
	}
}
