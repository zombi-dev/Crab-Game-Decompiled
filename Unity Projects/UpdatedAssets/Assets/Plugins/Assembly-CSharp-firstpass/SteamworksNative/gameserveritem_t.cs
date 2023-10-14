using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[Serializable]
	[StructLayout(0, Pack = 4, Size = 372)]
	public class gameserveritem_t
	{
		public servernetadr_t m_NetAdr;

		public int m_nPing;

		public bool m_bHadSuccessfulResponse;

		public bool m_bDoNotRefresh;

		private byte[] m_szGameDir;

		private byte[] m_szMap;

		private byte[] m_szGameDescription;

		public uint m_nAppID;

		public int m_nPlayers;

		public int m_nMaxPlayers;

		public int m_nBotPlayers;

		public bool m_bPassword;

		public bool m_bSecure;

		public uint m_ulTimeLastPlayed;

		public int m_nServerVersion;

		private byte[] m_szServerName;

		private byte[] m_szGameTags;

		public CSteamID m_steamID;

		public string GetGameDir()
		{
			return null;
		}

		public void SetGameDir(string dir)
		{
		}

		public string GetMap()
		{
			return null;
		}

		public void SetMap(string map)
		{
		}

		public string GetGameDescription()
		{
			return null;
		}

		public void SetGameDescription(string desc)
		{
		}

		public string GetServerName()
		{
			return null;
		}

		public void SetServerName(string name)
		{
		}

		public string GetGameTags()
		{
			return null;
		}

		public void SetGameTags(string tags)
		{
		}
	}
}
