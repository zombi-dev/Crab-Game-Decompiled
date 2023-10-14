namespace SteamworksNative
{
	public static class SteamMusic
	{
		public static bool BIsEnabled()
		{
			return false;
		}

		public static bool BIsPlaying()
		{
			return false;
		}

		public static AudioPlayback_Status GetPlaybackStatus()
		{
			return default(AudioPlayback_Status);
		}

		public static void Play()
		{
		}

		public static void Pause()
		{
		}

		public static void PlayPrevious()
		{
		}

		public static void PlayNext()
		{
		}

		public static void SetVolume(float flVolume)
		{
		}

		public static float GetVolume()
		{
			return 0f;
		}
	}
}
