using System;

namespace SteamworksNative
{
	[Serializable]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		public enum EGameIDType
		{
			k_EGameIDTypeApp = 0,
			k_EGameIDTypeGameMod = 1,
			k_EGameIDTypeShortcut = 2,
			k_EGameIDTypeP2P = 3
		}

		public ulong m_GameID;

		public CGameID(ulong GameID)
		{
		}

		public CGameID(AppId_t nAppID)
		{
		}

		public CGameID(AppId_t nAppID, uint nModID)
		{
		}

		public bool IsSteamApp()
		{
			return false;
		}

		public bool IsMod()
		{
			return false;
		}

		public bool IsShortcut()
		{
			return false;
		}

		public bool IsP2PFile()
		{
			return false;
		}

		public AppId_t AppID()
		{
			return default(AppId_t);
		}

		public EGameIDType Type()
		{
			return default(EGameIDType);
		}

		public uint ModID()
		{
			return 0u;
		}

		public bool IsValid()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Set(ulong GameID)
		{
		}

		private void SetAppID(AppId_t other)
		{
		}

		private void SetType(EGameIDType other)
		{
		}

		private void SetModID(uint other)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(CGameID x, CGameID y)
		{
			return false;
		}

		public static bool operator !=(CGameID x, CGameID y)
		{
			return false;
		}

		public static explicit operator CGameID(ulong value)
		{
			return default(CGameID);
		}

		public static explicit operator ulong(CGameID that)
		{
			return 0uL;
		}

		public bool Equals(CGameID other)
		{
			return false;
		}

		public int CompareTo(CGameID other)
		{
			return 0;
		}
	}
}
