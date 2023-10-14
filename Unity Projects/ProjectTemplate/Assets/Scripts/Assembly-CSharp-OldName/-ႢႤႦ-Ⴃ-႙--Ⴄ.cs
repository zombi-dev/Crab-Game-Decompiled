using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SteamworksNative;
using UnityEngine;

public class _109BႢႤႦ_109DႣ_109C႙_109D_109CႤ : MonoBehaviour
{
	public enum Ⴃ_109AႤႡႨႨႣႠႦႥႣ
	{
		ServerClosed = 0,
		Kicked = 1,
		Banned = 2,
		LostConnection = 3
	}

	public enum Ⴄ_109B_109C_109F႙ႣႡႧ_109EႥႣ
	{
		Menu = 0,
		Loading = 1,
		PreGame = 2,
		Started = 3,
		GameOver = 4
	}

	public static Dictionary<ulong, int> steamIdToUID;

	private ulong[] ႥႤႢ_109E_109AႨႢႦ_109D_109CႠ;

	private _႙Ⴆ_109FႨ_109CႦႨႧ_109B႙Ⴄ[] Ⴈ_109CႡႥႦႠ_109DႣႥႧႨ;

	public static Dictionary<ulong, _109D_109FႦ_109FႧ_109C_109BႣ_109F_109AႥ> lobbyPlayers;

	public bool started;

	public List<ulong> assets;

	public Map map;

	public GameModeData gameMode;

	public int nextRoundPlayers;

	public _109F_109DႤႧႢႡ_109B_109B_109C_109FႣ gameSettings;

	public Ⴄ_109B_109C_109F႙ႣႡႧ_109EႥႣ state;

	public _႙_109BႡ_109EႣ_109FႦ_109A_109BႢႣ gameState;

	public bool queueLobby;

	public Ⴁ_109CႠ_109FႣႦ_109D_109CႡႤႦ lobbyUtility;

	public static _109BႢႤႦ_109DႣ_109C႙_109D_109CႤ Instance;

	private ႧႦ_109DႡ႙_109CႤ_109AႠ_109DႡ ႢႨ_109FႥ_109B_109AႨႧႦႡ_109C;

	public Dictionary<ulong, bool> mutedPlayers;

	public static List<ulong> bannedPlayers;

	public bool connectedToSteam;

	public CSteamID _109B႙ႢႢ_109FႣႥ_109EႠႥႦ
	{
		[CompilerGenerated]
		get
		{
			return default(CSteamID);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool[] Ⴃ_109F_109DႨ_109D_109F_109E_109EႨႦ_109B
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool ႨႡႦႡႠ_109A_109FႧႢ_109B႙
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public string _109EႥ_109EႣႨ_109B_109E_109C_109F_109AႤ
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Ⴇ_109DႨ_109CႦႧ_109BႤ_109FႢ_109C(ulong _109CႤႨ_109BႥ_109E႙_109C_109BႦ႙)
	{
	}

	private void Ⴂ_109AႠႤ_109BႣႢႤႦ_109EႢ(CSteamID Ⴅ_109C႙ႤႡႤ_109BႣႢ_109B_109B, bool Ⴃ_109AႡ_109CႢႧႢ_109C_109C႙_109B)
	{
	}

	private void ႠႤႡႣ_109B_109D_109DႦႣ႙_109E()
	{
	}

	public void RequestPracticeLobby(Map _109EႥႨႧႡႦႦ_109A_109EႧ_109A, GameModeData ႣႠ_109FႥႤ႙ႦႠႦ_109E_109D)
	{
	}

	public void ႡႨႢ_109CႨႠ_109BႢႨႥ_109C()
	{
	}

	public void _109BႨႠ_109B_109FႣႧႢႨ_109AႦ()
	{
	}

	private string Ⴁ_109EႥႣႠႨႧႢႤ_109BႡ()
	{
		return null;
	}

	public void ႢႣ_109DႡ_109E_109D_109EႤ_109BႢႢ(ulong _109CႤႨ_109BႥ_109E႙_109C_109BႦ႙)
	{
	}

	public void _109BႡႨႣ႙_109DႣႢ_109CႥ_109B(CSteamID _109E_109A_109FႦ_109B_109BႠႠ_109F_109AႨ, CSteamID Ⴅ_109C႙ႤႡႤ_109BႣႢ_109B_109B)
	{
	}

	public void ႤႥႦႡ႙_109F_109DႢႡႧႧ()
	{
	}

	[SpecialName]
	public CSteamID ႦႠႥ_109CႥႡ_109EႢ႙Ⴄ_109B()
	{
		return default(CSteamID);
	}

	public void ႡႠႣႦႡႨႦ႙႙႙Ⴆ(Map _109EႥႨႧႡႦႦ_109A_109EႧ_109A, GameModeData ႣႠ_109FႥႤ႙ႦႠႦ_109E_109D)
	{
	}

	[SpecialName]
	public CSteamID Ⴂ_109F_109BႨႤႢ_109BႥ_109C_109AႠ()
	{
		return default(CSteamID);
	}

	private string _109AႨ_109FႨႠ_109CႦ_109AႧႨ_109D()
	{
		return null;
	}

	private string _109EႦ_109AႢ_109CႢ_109C_109A_109E_109DႣ()
	{
		return null;
	}

	private string ႣႦႦ႙ႨႥႠ_109DႨႠ_109B()
	{
		return null;
	}

	private string _109A_109BႢ_109DႦ_109AႠ_109B_109AႨ_109F(string _109F_109DႥ႙_109B_109CႤႤႡႨႣ)
	{
		return null;
	}

	private string ႡႨႨ_109E_109DႨႨ_109C_109BႠႡ(string _109F_109DႥ႙_109B_109CႤႤႡႨႣ)
	{
		return null;
	}

	public void ႠႠႢ_109A_109FႣႦႨႨႦ_109D(CSteamID _109E_109A_109FႦ_109B_109BႠႠ_109F_109AႨ, CSteamID Ⴅ_109C႙ႤႡႤ_109BႣႢ_109B_109B)
	{
	}

	public void ႥႢ_109BႢႡႢ႙_109B_109FႥႨ(CSteamID ႢႦႡႠ_109FႢ႙႙_109EႦႨ, bool _႙_109FႨႡ႙ႧႧႧ_109FႦ_109C)
	{
	}

	public void _109C_109A_109DႧႠႡ_109EႥႥ_109B_109C()
	{
	}

	private void _109EႥ_109E_109CႨႧႠႠႥ_109B_109B()
	{
	}

	private void _109CႥ_109F_109A_109F_109DႠ_109F_109AႤႧ()
	{
	}

	public void KickPlayer(ulong _109CႤႨ_109BႥ_109E႙_109C_109BႦ႙)
	{
	}

	public void SetLobby(CSteamID Ⴅ_109C႙ႤႡႤ_109BႣႢ_109B_109B)
	{
	}

	public void OnPlayerJoinLeaveUpdate(CSteamID ႢႦႡႠ_109FႢ႙႙_109EႦႨ, bool _႙_109FႨႡ႙ႧႧႧ_109FႦ_109C)
	{
	}

	public void NewLobbySettings()
	{
	}

	public void _109EႣ႙_109B႙_109B_109AႡႣ_109F_109F()
	{
	}

	[SpecialName]
	public void ႠႦႧ_109CႠ_109C_109BႢႤႡႠ(string _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public void ႦႨႡ_109EႤႤ_109AႦ_109DႨ_109D()
	{
	}

	private string Ⴆ_109F_109B_109C_109CႨႥႨႦႠႨ()
	{
		return null;
	}

	public void ႠႢ_109FႥႧႦ႙_109EႦႣ_109D()
	{
	}

	private string Ⴅ_109EႠႢႦႨ_109C_109DႠႢ_109B()
	{
		return null;
	}

	public void NewMuteList()
	{
	}

	public void _109C_109E_109BႨ_109AႤ_109EႣ_109D_109B_109B(CSteamID Ⴅ_109C႙ႤႡႤ_109BႣႢ_109B_109B)
	{
	}

	[SpecialName]
	public string _႙႙_109C_109E_109EႧႠ_109B_109B_109AႢ()
	{
		return null;
	}

	public void _႙Ⴃ_109E_109BႢ_109C_109DႧ_109E_109C႙()
	{
	}

	private string ႦႣႧႤ_109AႢ_109DႥႨႤ_109E()
	{
		return null;
	}

	public void ႧႣ႙Ⴅ_109AႡ႙ႥႢႤ_109A()
	{
	}

	public void _109FႣ_109B_109EႧႣ႙_109E_109BႧႤ()
	{
	}

	[SpecialName]
	public void ႥႨႧႤႠႦႨ_109A_109F_109DႠ(CSteamID _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public void SetServerVersion()
	{
	}

	public void AddPlayerToLobby(CSteamID ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	private string ႤႤ_109AႦႥႠ_109F_109DႥႠ_109C()
	{
		return null;
	}

	private void Ⴁ႙_109BႣႧႨႠ႙_109F_109FႤ()
	{
	}

	private string ႧႧႣႠ_109AႠႣ_109C႙_109D_109C()
	{
		return null;
	}

	public void ႢႨ_109BႢ_109FႦ႙Ⴄ_109FႢႣ(ulong _109CႤႨ_109BႥ_109E႙_109C_109BႦ႙)
	{
	}

	[SpecialName]
	public CSteamID _109D_109D႙Ⴇ_109B_109FႠႧ_109E_109DႠ()
	{
		return default(CSteamID);
	}

	public void GameEnded()
	{
	}

	public void CloseLobby()
	{
	}

	public void LobbyLoop()
	{
	}

	public _႙Ⴆ_109FႨ_109CႦႨႧ_109B႙Ⴄ GetClient(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
		return null;
	}

	private string ႣႥႥႠႥႤႨႨ႙Ⴁ_109D(string _109EႣႣ_109F႙_109FႨႡႨ႙Ⴅ)
	{
		return null;
	}

	private string _109D_109B_109FႨႠ_109F႙Ⴃ_109A_109F_109B(string _109EႣႣ_109F႙_109FႨႡႨ႙Ⴅ)
	{
		return null;
	}

	private string _109C_109CႨ_109CႠႧ႙Ⴆ_109DႡႥ()
	{
		return null;
	}

	[SpecialName]
	public bool[] ႥႨႨ_109A_109D_109FႠ႙Ⴆ_109B_109A()
	{
		return null;
	}

	[SpecialName]
	public CSteamID Ⴈ_109BႡ_109F_109FႣ_109FႤႨႧ႙()
	{
		return default(CSteamID);
	}

	public void _109EႥ_109AႣႢ_109AႢႥ_109DႠႢ(ulong _109CႤႨ_109BႥ_109E႙_109C_109BႦ႙)
	{
	}

	public string _109BႧႢႥ_109FႥႣ_109B_109AႢ႙()
	{
		return null;
	}

	public void StartLobby()
	{
	}

	public void Ⴈ_109CႠ_109F_109CႦႧႤ_109B_109AႥ()
	{
	}

	private int ႣႤႧ_109AႨ_109FႣႥ_109DႡ_109B()
	{
		return 0;
	}

	private int _109EႠ_109C_109A_109F႙_109E_109AႢ႙_109F()
	{
		return 0;
	}

	public void ႠႠႡႨႦႢ႙_109C_109C_109CႧ(Map _109EႥႨႧႡႦႦ_109A_109EႧ_109A, GameModeData ႣႠ_109FႥႤ႙ႦႠႦ_109E_109D)
	{
	}

	public void RemovePlayerFromLobby(CSteamID ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	private void Awake()
	{
	}

	public void Ⴄ_109B_109B_109F_109E_109EႣႣ_109C_109F_109D()
	{
	}

	private string ႤႠ_109AႨႤႢ_109CႢႤႠ_109D()
	{
		return null;
	}

	public _႙Ⴆ_109FႨ_109CႦႨႧ_109B႙Ⴄ _109B႙ႨႥႧႤႦႥ_109EႤႡ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
		return null;
	}

	public void StartNewLobby(CSteamID _109E_109A_109FႦ_109B_109BႠႠ_109F_109AႨ, CSteamID Ⴅ_109C႙ႤႡႤ_109BႣႢ_109B_109B)
	{
	}

	public void Ⴂ_109A_109CႢႧ_109A႙_109AႧ_109D_109C(Map _109EႥႨႧႡႦႦ_109A_109EႧ_109A, GameModeData ႣႠ_109FႥႤ႙ႦႠႦ_109E_109D)
	{
	}

	private void ႢႠ_109CႣႦ_109AႤ_109BႡႥ_109F()
	{
	}

	private void ႥႥႤ_109BႡ_109EႢႣႥႦႣ()
	{
	}

	public void ChangeColor(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, int ႣႥႢႣႨႣ_109A_109BႣႣႡ)
	{
	}

	public string NameVal()
	{
		return null;
	}

	public void BanPlayer(ulong _109CႤႨ_109BႥ_109E႙_109C_109BႦ႙)
	{
	}

	private int _109CႨ_109BႥႢ_109E_109BႦႥႣ_109D()
	{
		return 0;
	}

	public void _109FႢ_109CႢ_109FႨႡႣ_109CႨ_109E(CSteamID ႢႦႡႠ_109FႢ႙႙_109EႦႨ, bool _႙_109FႨႡ႙ႧႧႧ_109FႦ_109C)
	{
	}

	public void StartPracticeLobby(CSteamID _109E_109A_109FႦ_109B_109BႠႠ_109F_109AႨ, CSteamID Ⴅ_109C႙ႤႡႤ_109BႣႢ_109B_109B)
	{
	}

	public void SetServerName()
	{
	}

	public void ႧႧ_109D_109AႠ႙Ⴈ_109FႤ႙_109C()
	{
	}

	public void ႨႥ_109A_109DႧႢႦ_109B_109D႙Ⴈ()
	{
	}

	private void Ⴄ_109B_109D_109CႦ_109AႥႤ_109B_109C_109D()
	{
	}

	private void Ⴄ_109EႡႤႥ_109C_109EႡႢႦႢ(int ႣႥႢႣႨႣ_109A_109BႣႣႡ, bool Ⴄ_109EႨ_109F_109EႢ႙ႤႢႠ_109C)
	{
	}

	private string _109EႣ႙_109BႡႣႠႧ_109CႢ_109A()
	{
		return null;
	}

	private void ႢႥ_109EႥႥႣႥႡ_109CႡႧ()
	{
	}

	private string Ⴇ_109DႥႤ_109F_109D_109FႥ_109AႡႢ()
	{
		return null;
	}

	public void _႙႙ႣႣ႙_109EႡ_109BႤ_109D_109B()
	{
	}

	public void Ⴂ_109CႧ_109CႣ_109EႨႤ_109BႦ႙()
	{
	}

	private void Ⴆ_109F_109C_109AႠႥ_109AႠ႙႙Ⴁ()
	{
	}

	private void _109B_109C_109CႤ_109AႡ_109EႦႥႨႣ()
	{
	}

	public void ႨႨႤႠႧႥ_109CႡႣႠႧ()
	{
	}

	public void ႨႠႡ_109E_109A_109DႥႦ_109D_109F_109F()
	{
	}

	public string ႤႣ_109EႨႧ_109F_109C႙_109CႣႦ()
	{
		return null;
	}

	private string ႥႢ_109EႦ_109FႥႡ_109F_109FႤ_109B(string _109F_109DႥ႙_109B_109CႤႤႡႨႣ)
	{
		return null;
	}

	[SpecialName]
	public bool Ⴈ_109EႠႡႨႧ_109FႨႣ_109B_109B()
	{
		return false;
	}

	public void _109CႤႡႤႥႢႦႢ_109F_109C႙(CSteamID ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public void ႡႡႤ_109AႣ_109D႙Ⴀ_109E_109D_109F()
	{
	}

	public void Ⴆ_109D႙ႡႧ႙_109EႣႧ_109F_109A(CSteamID ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public void _109B_109FႡႢႡႦႢႧ_109EႣ_109F()
	{
	}

	private void _109DႠႧႢႧႧႨ_109BႨႤႧ()
	{
	}

	public _႙Ⴆ_109FႨ_109CႦႨႧ_109B႙Ⴄ _109CႨႡႢ_109CႡ_109A_109AႡ_109F_109C(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
		return null;
	}

	public _႙Ⴆ_109FႨ_109CႦႨႧ_109B႙Ⴄ[] GetClients()
	{
		return null;
	}

	private void Ⴇ_109E_109D_109F_109A_109AႦ_109CႢ_109AႡ()
	{
	}

	public void _109D_109B_109BႥႣ_109FႢႧႨ_109C_109D()
	{
	}

	[SpecialName]
	public void ႦႠႧႣ_109BႨ_109BႨ႙Ⴀ_109D(bool[] _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public int GetPlayerColorId(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
		return 0;
	}

	private string Ⴅ_109F_109BႧႧႤ_109F_109F_109A_109EႥ(string _109F_109DႥ႙_109B_109CႤႤႡႨႣ)
	{
		return null;
	}

	public void ႠႥ_109EႤ_109F႙_109AႥႨႣႥ()
	{
	}

	private void _109FႧႡ႙_109AႣႠ႙႙ႦႣ(int ႣႥႢႣႨႣ_109A_109BႣႣႡ, bool Ⴄ_109EႨ_109F_109EႢ႙ႤႢႠ_109C)
	{
	}

	private int _109FႨႤ_109FႠ_109C_109AႨႨ_109D_109C()
	{
		return 0;
	}

	[SpecialName]
	public bool _109F_109C_109F_109D_109DႡ_109CႧႡႢ_109A()
	{
		return false;
	}
}
