using System;
using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[Serializable]
	[StructLayout(0, Pack = 4, Size = 8)]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		public static readonly CSteamID Nil;

		public static readonly CSteamID OutofDateGS;

		public static readonly CSteamID LanModeGS;

		public static readonly CSteamID NotInitYetGS;

		public static readonly CSteamID NonSteamGS;

		public ulong m_SteamID;

		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		public CSteamID(ulong ulSteamID)
		{
		}

		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		public void Clear()
		{
		}

		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
		}

		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
		}

		public bool BBlankAnonAccount()
		{
			return false;
		}

		public bool BGameServerAccount()
		{
			return false;
		}

		public bool BPersistentGameServerAccount()
		{
			return false;
		}

		public bool BAnonGameServerAccount()
		{
			return false;
		}

		public bool BContentServerAccount()
		{
			return false;
		}

		public bool BClanAccount()
		{
			return false;
		}

		public bool BChatAccount()
		{
			return false;
		}

		public bool IsLobby()
		{
			return false;
		}

		public bool BIndividualAccount()
		{
			return false;
		}

		public bool BAnonAccount()
		{
			return false;
		}

		public bool BAnonUserAccount()
		{
			return false;
		}

		public bool BConsoleUserAccount()
		{
			return false;
		}

		public void SetAccountID(AccountID_t other)
		{
		}

		public void SetAccountInstance(uint other)
		{
		}

		public void SetEAccountType(EAccountType other)
		{
		}

		public void SetEUniverse(EUniverse other)
		{
		}

		public AccountID_t GetAccountID()
		{
			return default(AccountID_t);
		}

		public uint GetUnAccountInstance()
		{
			return 0u;
		}

		public EAccountType GetEAccountType()
		{
			return default(EAccountType);
		}

		public EUniverse GetEUniverse()
		{
			return default(EUniverse);
		}

		public bool IsValid()
		{
			return false;
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

		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return false;
		}

		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return false;
		}

		public static explicit operator CSteamID(ulong value)
		{
			return default(CSteamID);
		}

		public static explicit operator ulong(CSteamID that)
		{
			return 0uL;
		}

		public bool Equals(CSteamID other)
		{
			return false;
		}

		public int CompareTo(CSteamID other)
		{
			return 0;
		}
	}
}
