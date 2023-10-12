using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ႡႠႡ_109EႥႡ_109DႨႥ႙_109A : MonoBehaviour
{
	public Dictionary<ulong, Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C> activePlayers;

	public Dictionary<ulong, Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C> spectators;

	public GameObject onlinePlayer;

	public GameObject localPlayer;

	public GameObject playerRagdoll;

	public GameObject explodedPlayer;

	public GameObject spectatorCamera;

	public GameObject spectatorPrefab;

	public LayerMask whatIsGround;

	public LayerMask whatIsHittableBullet;

	public LayerMask whatIsHurtbox;

	public LayerMask whatIsPlayer;

	public GameMode gameMode;

	public _109AႢႠႠႧ_109BႣႣႥ_109EႧ gameAudio;

	public static ႡႠႡ_109EႥႡ_109DႨႥ႙_109A Instance;

	private GameObject ႤႧ_109BႧႨႥ_109BႡႢႥႥ;

	private ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ;

	private Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙;

	private float ႥႠႦႠႢ_109CႡ_109DႡ_109DႢ;

	private float _႙_109B_109DႣ_109DႡႠႠ_109DႧႥ;

	private _109B_109FႣႥ႙Ⴃ႙_109DႨ_109F_109B._႙ႢႡ_109D_109DႤ_109D_109AႢ႙_109C _109DႨႨ_109C_109FႤႤ_109EႡ_109CႤ;

	private bool _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E;

	private int ႧႧ_109BႠႣႠႤႦ_109BႧ_109E;

	private IEnumerator _109F႙ႧႠႤႢႦႦ_109AႦႢ(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A, float _109FႡ_109FႨ_109EႣ_109BႧ_109AႥ_109E)
	{
		return null;
	}

	public void ႤႦ_109EႡ_109D_109F_109DႤႡ_109D_109E(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void SyncObject(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private void _109A_109B_109AႠ_109FႡႦ႙Ⴅ_109CႤ()
	{
	}

	public void _႙႙_109CႨႡႧႣႡႦႧ_109A(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void _109D႙ႣႧ_109A_109EႣႦႡႤ႙(ulong _႙_109DႢႣႦႢႦ_109B႙Ⴇ_109C, ulong Ⴀ_109D_109DႡႦႧႡႠႥ_109A႙, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public void PunchPlayer(ulong _109DႥႦႠႦ_109D_109BႨႧႠႦ, ulong Ⴆ_109DႨ_109D_109A_109AႠ_109AႧ_109C_109D, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public void ႧႢ_109AႢႠ_109FႡ_109F_109FႦႤ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	private void Ⴄ_109CႠႣႢ_109E_109AႠ_109EႠ႙()
	{
	}

	private void ႡႧႦ_109BႣ_109A႙_109DႣႦႣ()
	{
	}

	public void _႙Ⴇ_109D_109EႣ႙_109CႦႧႦႨ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void ႧႧႢႢႧ_109D႙_109B_109D_109BႧ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private void Ⴆ_109FႤ_109DႠ_109E႙ႤႨ_109F_109B()
	{
	}

	public void _109CႨႧ႙ႠႥႤႥ_109BႨႡ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void Ⴁ႙Ⴈ႙ႥႥႡ_109C_109F႙Ⴃ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void _109EႢ_109B_109FႨႠႢႨ_109E_109AႠ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void SpawnPlayer(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	public void _႙Ⴂ_109D_109CႡ_109E_109D_109C_109F_109AႠ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void ႢႨႥႨ_109E_109F_109CႤႦႨႤ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public int Ⴈ_109CႨ႙_109C_109BႧႥႥႥႦ()
	{
		return 0;
	}

	public void RemovePlayer(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	private void ႢႦ_109D_109DႤ_109D_109C_109BႧႤႤ()
	{
	}

	public void SetPlayerRotation(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void _109A႙_109CႨ_109B႙_109A_109EႥႧ_109C(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private IEnumerator Ⴈ_109CႡႤ႙ႥႡ_109B_109CႥ_109E(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A, float _109FႡ_109FႨ_109EႣ_109BႧ_109AႥ_109E)
	{
		return null;
	}

	public void ႣႧ_109BႥႢႡႦ႙Ⴇ_109C_109B(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	public void Ⴀ_109BႢႦႣ_109DႥ_109CႢႥ႙(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private void Ⴁ_109F_109FႨ_109CႡ_109EႡ_109FႡ_109E(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	private void _109CႢ_109CႤ႙_109CႦ_109F_109CႤႠ()
	{
	}

	public void Ⴃ_109FႧ_109D_109CႦႢႧႧႥႢ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	public void ႣႣႠႧႡႣ_109AႢ႙Ⴂ႙(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void Ⴃ႙ႡႣႡႠ_109A႙_109D_109CႧ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	private void _109C_109B_109DႣ_109EႤႧႣႨႡႣ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	public void Ⴁ_109F_109E_109A_109C႙_109FႢ_109B႙Ⴈ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	private void Start()
	{
	}

	private void Ⴃ_109C_109D႙Ⴇ_109DႠႥႦ_109CႥ()
	{
	}

	public void Ⴃ_109BႢႧ_109E_109EႡႧ_109D_109FႦ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	public void Ⴅ_109A႙_109E_109C_109FႥႥႨႢ_109B(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void ႡႦႦ_109BႨႧ႙_109DႦ_109C_109D(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public void ႧႦ_109CႣႥႤ_109F_109FႦ_109D႙(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	public void _႙_109AႠႡႤႥ_109E_109C_109CႣႢ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private IEnumerator ႦႡႦ_109C_109DႢႥႡ_109AႣ႙(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A, float _109FႡ_109FႨ_109EႣ_109BႧ_109AႥ_109E)
	{
		return null;
	}

	public void SpawnSpectator(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public void ႤႨ႙ႨႣ_109EႧႢႣႥႦ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	private void Update()
	{
	}

	public void Ⴄ_109F_109AႠႨႦႡ_109BႦ_109AႧ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	public void RespawnPlayer(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	public void _109FႠႤ_109EႠ_109AႢႣႨ_109BႤ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private void _109FႨႦႣႧ_109A_109FႣႣ_109A_109E()
	{
	}

	public int GetPlayersAlive()
	{
		return 0;
	}

	public void ႦႣ_109E_109FႧ_109F_109AႥႢႢႢ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void _109E႙ႦႦႧ႙ႡႣႧႢႦ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private IEnumerator _109CႧႦ_109CႣ႙Ⴇ႙ႣႠ_109A(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A, float _109FႡ_109FႨ_109EႣ_109BႧ_109AႥ_109E)
	{
		return null;
	}

	public int Ⴂ_109AႥ႙ႠႣ_109E_109F_109B_109CႨ()
	{
		return 0;
	}

	public void _109C_109AႧ_109A_109BႠ_109DႠ_109CႤႦ(ulong _109DႥႦႠႦ_109D_109BႨႧႠႦ, ulong Ⴆ_109DႨ_109D_109A_109AႠ_109AႧ_109C_109D, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public void ႠႠ_109BႢႥႦ_109AႢ_109BႥႡ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void Ⴆ_109AႥ_109BႦႧ_109D_109F_109DႦႡ(ulong _႙_109DႢႣႦႢႦ_109B႙Ⴇ_109C, ulong Ⴀ_109D_109DႡႦႧႡႠႥ_109A႙, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public void _109EႢႨ_109B_109DႧႠႥ_109E_109FႡ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public int ႨႠႡ_109E_109DႡႧႥႥ_109B_109A()
	{
		return 0;
	}

	private void _109D_109CႥ_109C_109BႣႤ_109A_109DႧႠ()
	{
	}

	private void _109FႨႣႣ_109C_109FႧႠႨႨႦ()
	{
	}

	public void SetPlayerAnimation(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void _109BႢ_109AႧႢႡႢႠႦႢႣ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public void _႙_109F_109EႦ_109DႡ_109F_109EႡႨႦ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	private IEnumerator _109E_109F_109F_109C_109EႥႦ_109FႥ_109C႙(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A, float _109FႡ_109FႨ_109EႣ_109BႧ_109AႥ_109E)
	{
		return null;
	}

	public void _109CႣ_109FႥႦ_109E႙Ⴃ_109EႦ_109D(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	public void ႠႧႠႦ_109E_109AႥႧႥႠႣ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public int Ⴈ_109F_109CႦ႙_109B_109BႤ_109DႣႦ()
	{
		return 0;
	}

	public void ႤႥႨႤႢ_109F_109FႧ_109DႡႥ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private void _109DႥႨ_109DႤ_109F_109A_109EႥႦ႙()
	{
	}

	private void ႤႥႢႧႢ_109BႨ_109EႣႤ_109E()
	{
	}

	private void Ⴅ_109CႡ_109AႦ_109DႦႡႧႣ_109D()
	{
	}

	private void ႥႠႨ_109FႧ_109EႧႥ႙_109DႧ()
	{
	}

	public void SetPlayerPosition(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private void _႙ႥႥႡႡႥႡႧႠ_109E_109D()
	{
	}

	private void Ⴅ_109E႙_109EႧ႙_109A_109DႧ_109A_109A(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	public void PlayerTookDamage(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	private void Ⴆ_109D_109F_109DႤႥႡ_109A႙_109A႙()
	{
	}

	private void ႢႣႡႨ_109F_109CႨ႙_109D_109DႤ()
	{
	}

	private void Awake()
	{
	}

	public void ႤႡ႙ႦႢႢႡ_109C_109B_109F_109B(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	public void ႤႨႠႦႦ_109BႢႨႥႨႧ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void PhysicsObjectSnapshot(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void Ⴆ_109B_109EႡႨႣႤႥ႙ႣႨ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void Ⴈ_109BႨ_109CႧႢႧႤႨႣႡ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void ႦႡ_109A_109FႤ_109DႥႤ_109DႤ_109B(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ)
	{
	}

	public void ႤႢႨႥႤႣ_109D_109CႨ_109EႥ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	public void PlayerDied(ulong _႙_109DႢႣႦႢႦ_109B႙Ⴇ_109C, ulong Ⴀ_109D_109DႡႦႧႡႠႥ_109A႙, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public void ႠႧ_109C_109EႡႣႤ_109C_109D_109FႦ(ulong _႙_109DႢႣႦႢႦ_109B႙Ⴇ_109C, ulong Ⴀ_109D_109DႡႦႧႡႠႥ_109A႙, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public void _109E႙Ⴀ_109AႣႤႥ_109FႨႡ_109E(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void ႦႢ_109EႤ_109BႧႨ_109D_109CႥႤ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void _109FႠႡႧ_109CႤႣ_109DႡႡႢ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	public void ႥႡ႙_109D_109E_109DႥႠႢႡႣ(ulong ႢႦႡႠ_109FႢ႙႙_109EႦႨ, Vector3 ႤႦ_109CႧႨႡ_109D_109A႙Ⴀ႙, int Ⴁ_109C_109FႥႦ_109C_109AႢႦ_109E_109D, bool ႦႥႣ_109BႢႢႣႣ_109CႠႤ, byte[] _109A_109AႡ_109A_109BႢႦႢ႙_109BႧ, int ႡႦ႙႙_109CႦ_109AႦ႙ႥႦ)
	{
	}

	private IEnumerator _109BႢႠ_109D_109DႦႥႣ_109CႢ_109A(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A, float _109FႡ_109FႨ_109EႣ_109BႧ_109AႥ_109E)
	{
		return null;
	}

	private void ႡႨႦႦႥႦ_109AႨ_109AႤ_109B()
	{
	}

	public void ႥႥ႙_109C_109AႠႦ_109FႦ_109A_109A(ulong _႙_109DႢႣႦႢႦ_109B႙Ⴇ_109C, ulong Ⴀ_109D_109DႡႦႧႡႠႥ_109A႙, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public void _109E_109CႧႠႨႨ_109C_109C_109F_109A_109C(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void Ⴇ_109CႨႡ_109BႠ_109FႡႦႣႥ(ulong _109DႥႦႠႦ_109D_109BႨႧႠႦ, ulong Ⴆ_109DႨ_109D_109A_109AႠ_109AႧ_109C_109D, Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	public int _109C_109E_109DႥႤ_109C_109DႤ_109AႠႤ()
	{
		return 0;
	}

	private IEnumerator Ⴇ_109FႡႠ_109B_109D_109AႧႢ႙Ⴈ(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A, float _109FႡ_109FႨ_109EႣ_109BႧ_109AႥ_109E)
	{
		return null;
	}

	public void _109DႥႢ_109A႙_109F_109EႣႢ_109CႨ(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public void ႦႧႤ_109E_109BႧႢႤႥ႙_109A(Ⴅ_109CႤ႙ႠႣ_109B_109DႤႦ_109D _109DႣႢ_109AႧ_109AႧ_109D_109C_109CႢ)
	{
	}

	public int ႢႤ_109A_109AႠႢ_109A_109EႢ႙Ⴈ()
	{
		return 0;
	}
}
