using System.Runtime.CompilerServices;
using UnityEngine;

public class ႢႣ_109B_109AႦ_109EႣႣႦ႙_109F : MonoBehaviour
{
	public enum ႧႠႤႧႥ_109BႢ_109E_109D_109DႨ
	{
		Player = 0,
		PlayerDeath = 1,
		Spectate = 2,
		Freecam = 3
	}

	public Transform player;

	public Vector3 offset;

	public Vector3 desyncOffset;

	public Vector3 vaultOffset;

	private Camera _109DႤႢႦႥႨႤႡ_109D_109BႢ;

	private Rigidbody _109A_109DႤႤႨႥႨႨႦႨႥ;

	public PlayerInput playerInput;

	public Transform raycastCamera;

	public bool cinematic;

	private float _109D_109BႨႢ_109B_109F_109D_109FႤ_109AႨ;

	private float ႦႠႦ_109C႙ႣႡႠ႙_109DႦ;

	private Vector3 ႠႦႣ_109D_109CႣႥႧႧႠ_109E;

	private Transform Ⴈ_109EႨႨႣ_109D_109CႨႢႢႡ;

	private Vector3 ႠႠႡႤ_109DႧႤ_109E_109DႧ_109E;

	private Transform _႙_109B_109B_109CႢ႙_109CႣ_109B_109B_109E;

	public LayerMask whatIsGround;

	private int _109B_109B_109D_109AႠ_109E_109B_109E_109B_109DႥ;

	private float ႠႢႣ_109FႨ_109EႦႠႤႡ_109E;

	private float _109DႥႢႢႢႦႢႤ_109BႡႡ;

	public Vector3 cameraRot;

	private ulong _109C_109AႣ_109DႧႢ_109F_109CႢႠႧ;

	private Vector3 Ⴈ_109F_109D႙_109D_109CႣႡ႙Ⴄ_109C;

	private Vector3 _109DႢႣႤႨ_109EႡႣ_109FႧႡ;

	private float ႥႥ_109EႦႧ_109CႡႤ_109DႦ_109D;

	private float _109CႢ_109F_109E_109E_109A_109AႦ_109AႠ_109A;

	public Camera mainCam;

	public static ႢႣ_109B_109AႦ_109EႣႣႦ႙_109F _109AႨႢႢႣ_109EႥႣ_109FႧႤ
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ႧႠႤႧႥ_109BႢ_109E_109D_109DႨ _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E
	{
		[CompilerGenerated]
		get
		{
			return default(ႧႠႤႧႥ_109BႢ_109E_109D_109DႨ);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Ⴈ_109E_109D_109CႣႣ_109FႦႣ_109BႠ()
	{
	}

	public void ႥႠ_109B႙_109BႠ_109CႧ_109B႙Ⴂ(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	private void Ⴅ_109A_109AႣႡႦႥႧ_109A_109AႡ()
	{
	}

	public void BobOnce(Vector3 ႤႣ_109A_109E_109DႨႨ_109FႠ_109BႥ)
	{
	}

	private void _109C_109A႙႙႙_109A_109C_109D_109E_109B႙()
	{
	}

	public void StartSpectating()
	{
	}

	private void _109BႠ_109AႣႣႣ_109BႠ_109E_109CႨ()
	{
	}

	public void ႧႡ_109D_109BႧႨႢႥ_109CႠႨ(Vector3 ႤႣ_109A_109E_109DႨႨ_109FႠ_109BႥ)
	{
	}

	private bool ႡႡႢ႙Ⴃ_109BႦႢႥႡ_109C()
	{
		return false;
	}

	private bool _109EႥႡ႙ႨႦႡႠႥႠႠ()
	{
		return false;
	}

	private void ႠႨ_109EႨ_109BႡႥႤ_109DႧႢ(int _109EႤႥႠႣႢႠႦ_109D႙Ⴅ)
	{
	}

	private void Ⴃ_109CႧ_109A_109B႙_109EႠႧ_109BႠ()
	{
	}

	private void ႣႧႤႡႧႥ_109A_109B_109BႦ_109A()
	{
	}

	private void Start()
	{
	}

	private bool _109EႡႦ_109EႦ_109EႠႦႤႢ_109C()
	{
		return false;
	}

	[SpecialName]
	public static ႢႣ_109B_109AႦ_109EႣႣႦ႙_109F _႙Ⴇ႙_109BႠႤ_109EႠ_109DႧ_109E()
	{
		return null;
	}

	private void _109C_109E_109B႙ႦႥႣႣႢ_109BႢ()
	{
	}

	private Vector3 ႥႥႡႦႨႢႠႤႧႢ_109F(Vector3 _109B_109F_109A_109BႦ_109B_109A_109DႢႧ_109B, float Ⴃ_109EႥ_109EႣ_109B_109FႧႡ_109DႥ, float _109FႨႤႦႠႥႢႥႤႠႠ)
	{
		return default(Vector3);
	}

	private void _109FႦႡႤႦႨ_109E_109EႦႨႣ()
	{
	}

	private void ႨႢ_109FႠ_109EႠ_109D_109CႦ_109EႥ()
	{
	}

	private void ႤႦ_109AႦႣႤႦႦ_109CႣႤ()
	{
	}

	public void PlayerDied(Transform ႤႨ_109BႥႢႧ_109C_109EႦ_109A_109D)
	{
	}

	public void UpdateFov(float ႢႦ_109EႦ႙ႥႤႢ_109C_109CႤ)
	{
	}

	private void ႡႠႡ_109AႢ႙_109FႤႡ_109F_109A()
	{
	}

	private void _109CႡ_109C_109DႢႠ_109CႣႥ_109CႢ()
	{
	}

	private void _႙Ⴀ_109EႨႢႧႦ_109AႤ_109AႨ()
	{
	}

	public void _109F_109E_109B_109D_109E_109E_109DႦႥႥ_109A()
	{
	}

	private void Ⴂ_109B႙_109FႥႤႦႠ႙_109BႧ()
	{
	}

	private void LateUpdate()
	{
	}

	public void PlayerRespawn(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	public void ႣႨ_109C_109F_109CႧႣႥႥႨ႙(Vector3 ႤႣ_109A_109E_109DႨႨ_109FႠ_109BႥ)
	{
	}

	[SpecialName]
	private static void _109BႡ_109D_109F_109D_109B_109CႦႣႥႡ(ႢႣ_109B_109AႦ_109EႣႣႦ႙_109F _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void Awake()
	{
	}

	private Vector3 Ⴀ_109FႠႢႢႨ႙႙Ⴅ_109D_109D(Vector3 _109B_109F_109A_109BႦ_109B_109A_109DႢႧ_109B, float Ⴃ_109EႥ_109EႣ_109B_109FႧႡ_109DႥ, float _109FႨႤႦႠႥႢႥႤႠႠ)
	{
		return default(Vector3);
	}

	public void ႣႡ_109A_109FႡ႙Ⴃ_109BႥႧႣ(Transform ႤႨ_109BႥႢႧ_109C_109EႦ_109A_109D)
	{
	}

	private void _109B_109C_109EႢႧ_109CႨ႙Ⴂ_109F_109D()
	{
	}

	private void _109E_109C_109FႦ႙ႦႠ_109F_109FႡႡ()
	{
	}

	private Vector3 Ⴈ_109EႨ႙ႨႡႦႠႥႨႧ(Vector3 _109B_109F_109A_109BႦ_109B_109A_109DႢႧ_109B, float Ⴃ_109EႥ_109EႣ_109B_109FႧႡ_109DႥ, float _109FႨႤႦႠႥႢႥႤႠႠ)
	{
		return default(Vector3);
	}

	public void Ⴇ_109EႡ_109BႤ_109DႤ႙ႧႥႡ()
	{
	}

	private void _႙ႤႨႣႤႦႨႠ_109FႤ_109D()
	{
	}

	public void StartPlaying()
	{
	}

	private void ႤႤ_109DႤႢ_109FႦႧႠႡႨ()
	{
	}

	public void ႦႨႥ_109BႣႤႨ_109AႧႧႠ(float ႢႦ_109EႦ႙ႥႤႢ_109C_109CႤ)
	{
	}

	private bool _109D_109EႠႧႧ_109CႨႣ_109D_109CႢ()
	{
		return false;
	}

	private void _109FႠႠ_109AႨ_109D_109C_109DႡ_109AႢ()
	{
	}

	private void _109BႡ_109EႨႨ_109A_109DႣႥ_109FႤ()
	{
	}

	private void Ⴇ_109E_109C_109F႙Ⴆ႙_109A_109D_109D႙()
	{
	}
}
