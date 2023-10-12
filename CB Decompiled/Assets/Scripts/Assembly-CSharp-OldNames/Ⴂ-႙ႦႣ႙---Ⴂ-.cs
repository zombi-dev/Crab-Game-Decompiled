using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Ⴂ_109A႙ႦႣ႙_109D_109F_109EႢ_109B : MonoBehaviour
{
	private enum _109F_109F႙Ⴆ_109A_109DႠ_109B_109D_109BႧ
	{
		None = 0,
		Crouching = 1,
		Sliding = 2
	}

	private enum ႣႠ႙ႨႢႤႠႧႡ_109CႡ
	{
		Generic = 0,
		Ice = 1,
		Ice2x = 2
	}

	public GameObject playerJumpSmokeFx;

	public GameObject footstepFx;

	public Transform playerCam;

	public Transform orientation;

	private Rigidbody _109A_109DႤႤႨႥႨႨႦႨႥ;

	public bool dead;

	private ObscuredFloat _႙ႡႠ_109D_109F_109C႙_109AႨႦႣ;

	private ObscuredFloat Ⴂ_109B_109BႨ_109BႧႢ_109CႢႥႧ;

	private ObscuredFloat _႙Ⴂ_109BႨႡ_109E_109A_109D_109C_109DႤ;

	private ObscuredFloat ႦႠႨႤ_109AႢႠႢ_109EႨႣ;

	private ObscuredFloat ႣႤ_109AႢႦႤ႙_109F_109EႠႠ;

	private ObscuredFloat Ⴂ႙ႢႢႨ_109BႨႦႣ_109AႠ;

	private ObscuredFloat Ⴄ_109EႣႦႣ_109D_109DႥ_109EႧ_109F;

	private ObscuredFloat Ⴈ_109E႙ႨႥ႙ႧႨႠႥ_109E;

	public bool grounded;

	public LayerMask whatIsGround;

	public LayerMask whatIsGroundOnly;

	public float extraGravity;

	private Vector3 ႥႧ_109AႥ_109A_109EႥႣႧ_109D_109C;

	private Vector3 _႙ႨႦႦႨ_109FႠႤႡႧႧ;

	private float _႙Ⴅ_109E_109A_109A_109B_109B_109E_109D_109EႤ;

	public static float crouchRatio;

	public AudioSource slideStartSfx;

	public AudioSource slideSfx;

	private ObscuredBool Ⴃ_109BႠ႙ႦႡႧႢႤႨ_109B;

	private float _109F_109D႙Ⴁ႙_109D_109EႨ႙႙Ⴇ;

	private float Ⴀ_109A_109EႧ_109E_109DႠ_109FႢ႙Ⴆ;

	private int _႙Ⴈ_109CႠႧႥ_109D_109B_109D_109AႥ;

	private float ႥႣ_109FႨ_109DႧႧ_109C_109F_109BႢ;

	private float Ⴈ_109AႨ_109AႥ႙Ⴂ_109CႠ_109B_109F;

	private float ႤႠ_109DႥ႙Ⴂ_109FႧ_109FႥႤ;

	private float ႣႧႡႠ႙_109FႠႣႠႧ_109C;

	private _109F_109F႙Ⴆ_109A_109DႠ_109B_109D_109BႧ _႙_109BႠႧႦႥ_109C႙_109FႥ_109A;

	public static float slideThresholdSpeed;

	private Vector3 ႧႢႣႣႨႦ_109D_109EႡႧႢ;

	public ParticleSystem ps;

	private ParticleSystem.EmissionModule Ⴃ႙_109BႥႠႠႠႨႠ_109DႧ;

	private Collider Ⴇ_109D_109CႣႧႧႧ_109F_109F_109AႣ;

	private float _႙_109FႦ_109CႧ_109AႤ_109AႤႧႢ;

	public GameObject playerSmokeFx;

	public ႠႠ_109F႙ႨႨႨႧႡ_109A_109F punchPlayers;

	private float Ⴇ_109DႤ_109CႨႧႣႠႤ_109DႣ;

	private bool _109EႣႤႤ_109AႠႣႤႢႧ_109B;

	public Transform feet;

	private float ႥႥႢႣႣႠႣႤ_109B_109B_109A;

	private bool ႣႠႡႥ_109AႤႧ_109A_109A_109BႤ;

	private bool _109AႢႤ_109E_109E_109DႠႢႢႣ_109C;

	private float ႣႢ_109EႠႦႤႠ႙_109D_109AႨ;

	private float _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ;

	private ObscuredFloat Ⴇ_109B_109B_109D_109C_109BႢ_109EႣႣ_109C;

	private ObscuredFloat ႣႡ_109A_109DႡႦ_109EႨႠႧႢ;

	public ObscuredBool isUnderwater;

	private Vector2 _109EႧ႙ႡႨႠႣ႙ႧႣ_109F;

	private float _109AႡ_109EႣႣႦႦႧႨႡႦ;

	private float _109A_109FႦႣႦ႙Ⴆ_109DႤႦႢ;

	private float _109E_109D_109E_109AႧႣႨႨႨ_109EႧ;

	private bool _109DႧ_109D_109A_109AႧ_109EႨႨ႙_109E;

	private Vector3 _109C_109DႠ_109F_109A_109E_109C_109AႡႤ_109D;

	private Transform _109EႦ႙_109A_109AႥႤႥ_109BႦ_109D;

	private float Ⴆ႙_109D႙_109AႦ႙_109AႤ_109A_109C;

	private bool Ⴀ_109EႥႠႨ႙_109A_109CႡ_109D_109D;

	private float ႦႦႧ_109CႤႧ_109F_109B_109F_109AႡ;

	private Vector3 Ⴄ႙_109AႥႠႣႥ_109CႢႨ႙;

	private Vector3 _႙_109AႢႣႠႡႥ_109BႣ_109B_109D;

	private float _109BႧ_109C႙ႤႠႦ_109EႠ_109AႥ;

	private bool _109E_109BႦႦႣႠ_109CႢႢ_109F_109F;

	private float ႣႥႡႠႢႦ_109A_109F_109AႤ_109C;

	private float _႙Ⴄ_109D_109E_109A႙ႨႨ_109FႤႡ;

	private bool Ⴄ႙ႤႠႤႧႥ_109CႥႠ_109A;

	private int ႡႣႤ_109FႣႣ_109D_109AႥႨ_109E;

	private int _109DႧ_109EႨ႙_109AႣႦႤႡ႙;

	private int Ⴁ႙ႠႤ_109E_109BႦႡႤႠႥ;

	private float _109DႣႦ_109B_109BႡ_109BႤ႙ႤႢ;

	private float _႙Ⴇ_109D_109DႡႣႤႦႦ_109AႣ;

	private float ႠႡ_109CႧႣ_109E_109D_109EႣႥ_109E;

	private float Ⴁ_109C_109DႤ_109CႨ_109FႧ_109F႙Ⴈ;

	private float _႙Ⴀ_109EႥႥႨ_109DႢ_109DႢႦ;

	private int _109EႥႦ_109EႧ_109A_109C_109EႢႤႥ;

	private int _109C_109A_109CႨႨႥႣႨႠ_109CႠ;

	private float _109FႢ_109C_109B_109C_109C႙_109D_109EႣႠ;

	private bool _109E_109BႠႧ_109CႧႠႣႦႠႣ;

	private float _႙ႧႥႨ႙_109AႥ_109E_109C_109CႡ;

	private float _109FႢႤ_109F_109E႙ႦႤ_109A_109B_109D;

	private bool ႦႧ႙_109F_109CႠႤ_109DႡႢ_109D;

	private ႣႠ႙ႨႢႤႠႧႡ_109CႡ Ⴀ_109DႧႠႢႣႥ_109FႨ_109A႙;

	private float ႤႥ_109A_109E_109CႡႠႣႣ႙_109B;

	private float ႦႢႨႧ_109B႙Ⴄ_109BႤႤႦ;

	private bool Ⴄ_109AႧ_109A_109CႧ_109F_109AႧ_109D_109D;

	private bool Ⴃ႙_109D_109FႠ_109AႢ_109E_109CႢႥ;

	private bool _109BႨ_109B_109E_109AႣႦႤႡႢ_109B;

	private bool _109CႡႨ_109A_109C႙ႨႨႢႢ႙;

	private float _109EႤႨ_109AႧႥႧႦႨႨႨ;

	private int ႢႦ_109BႡ_109EႤႠ_109F_109DႤ_109A;

	private int ႡႢႤႤႣ_109CႠႦႠႡႦ;

	private int _109CႣႡႢႥႧႣႤႡ_109DႡ;

	public LayerMask whatIsHittable;

	private float _109CႢႠ_109E_109CႦႤ_109CႢႧ_109E;

	public float Ⴃ_109EႡႣ_109AႦႠ_109D_109A႙Ⴃ
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool Ⴈ႙ႠႦႥ_109F_109EႧႤႣႤ
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

	public bool ႢႨႤ_109DႠ႙ႠႢႢႧ_109D
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

	public bool _109E_109F_109DႡႨ_109FႧ_109D_109BႠႧ
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static Ⴂ_109A႙ႦႣ႙_109D_109F_109EႢ_109B _109AႨႢႢႣ_109EႥႣ_109FႧႤ
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

	private void _109DႧႤႢ_109AႥႢႢ႙Ⴃ_109A()
	{
	}

	public float GetFallSpeed()
	{
		return 0f;
	}

	public void _109BႣႣႧ_109CႦႡ_109CႡႡႢ(Transform _109EႦ႙_109A_109AႥႤႥ_109BႦ_109D)
	{
	}

	private void Ⴇ_109EႤႡႨ_109D႙ႧႧ_109A_109C()
	{
	}

	public void SetLadder(bool _109F_109DႥ႙_109B_109CႤႤႡႨႣ, Transform _109EႦ႙_109A_109AႥႤႥ_109BႦ_109D)
	{
	}

	public void Movement(float ႥႣ_109FႨ_109DႧႧ_109C_109F_109BႢ, float Ⴈ_109AႨ_109AႥ႙Ⴂ_109CႠ_109B_109F)
	{
	}

	private void ႠႢႦ႙႙ႠႧႧႤ_109BႡ()
	{
	}

	[SpecialName]
	public void _109CႣ_109E_109EႣႢႦ_109EႧ_109DႨ(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void Update()
	{
	}

	private void _႙Ⴈ_109FႥႣႦႦႣ႙ႠႧ(Vector2 _109EႧ႙ႡႨႠႣ႙ႧႣ_109F)
	{
	}

	private void Ⴇ_109CႡႡ_109EႡႧ႙Ⴅ_109DႨ()
	{
	}

	public Vector2 _109FႦႤႣႨ_109BႧ_109A_109F_109F_109F()
	{
		return default(Vector2);
	}

	public Rigidbody GetRb()
	{
		return null;
	}

	public void _109C႙Ⴃ_109AႣႠႦႡႨႡ_109F(Vector3 _109E_109DႧ_109BႤႠႥႥ_109C_109EႠ)
	{
	}

	public Vector2 ႣႣႨႠ_109B_109CႨႢႡႢႦ()
	{
		return default(Vector2);
	}

	private bool ႨႥ_109CႥ_109A_109EႣႣ_109BႤ_109C()
	{
		return false;
	}

	private void _109B_109A_109C_109E_109BႢ_109BႥႤ_109C_109D()
	{
	}

	private void ႧႥႤ႙ႦႨႧႢ_109AႠ_109E()
	{
	}

	private bool _109DႡႧ_109C_109F_109AႣ_109B_109AႤ_109F(Vector3 ႠႡႨႢႥ_109F_109CႡ_109FႡႨ)
	{
		return false;
	}

	private void _႙_109D_109BႥ_109AႢႦႢ_109FႤႦ()
	{
	}

	private void _109B_109F_109DႠႣႦႤႦ_109A႙Ⴀ()
	{
	}

	public Vector3 HitPoint()
	{
		return default(Vector3);
	}

	private bool ႢႤႥ_109F_109BႧႥႡႡႢ_109B(Vector3 ႠႡႨႢႥ_109F_109CႡ_109FႡႨ)
	{
		return false;
	}

	public Collider GetPlayerCollider()
	{
		return null;
	}

	public bool IsSliding()
	{
		return false;
	}

	private void ႤႦ_109CႦႠႨ_109C_109FႣ_109DႠ()
	{
	}

	private void OnCollisionStay(Collision _109F_109C_109DႤႨႣ႙Ⴀ_109D႙Ⴁ)
	{
	}

	private bool ႢႢႧႡ႙Ⴀ_109E_109E_109DႨ_109A(Vector2 _109CႢႠ_109E_109CႦႤ_109CႢႧ_109E)
	{
		return false;
	}

	public void PushPlayer(Vector3 _109E_109DႧ_109BႤႠႥႥ_109C_109EႠ)
	{
	}

	private void _109F_109BႥ႙_109C_109DႨႤႣ_109AႧ()
	{
	}

	public bool IsUnderwater()
	{
		return false;
	}

	public bool ႦႤ_109DႤႥ_109BႤႠႧ_109D_109C()
	{
		return false;
	}

	private void _109AႣႡႥ_109A_109AႠ_109B_109EႦႦ()
	{
	}

	private void Ⴆ_109EႡႠ_109FႤႧႣႡႥ_109D()
	{
	}

	private void ႣႨ_109E_109E_109EႡႤႣႧ႙Ⴁ()
	{
	}

	public void Jump()
	{
	}

	public void StopCrouch()
	{
	}

	private bool ႨႢႥႠႢႧႧ_109C_109BႠ_109C(Vector3 Ⴃ_109F_109DႢ_109BႥ_109F_109AႠႤ_109A, Collision _109F_109C_109DႤႨႣ႙Ⴀ_109D႙Ⴁ)
	{
		return false;
	}

	private void Start()
	{
	}

	private bool ႡႢ_109CႦႠ_109DႨ_109AႨႡႠ(Vector2 _109CႢႠ_109E_109CႦႤ_109CႢႧ_109E)
	{
		return false;
	}

	[SpecialName]
	public void _109AႢ_109E_109BႨႤ_109E_109FႠႣႢ(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public void ResetState()
	{
	}

	public bool IsCrouching()
	{
		return false;
	}

	private bool _109A_109DႡ_109FႠ_109F_109D_109FႧ_109BႥ()
	{
		return false;
	}

	private bool _109FႦႧ_109CႦႤ_109A_109DႠ_109BႦ()
	{
		return false;
	}

	public void SetInput(Vector2 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ, bool ႢႨႤ_109DႠ႙ႠႢႢႧ_109D, bool Ⴈ႙ႠႦႥ_109F_109EႧႤႣႤ, bool _109E_109F_109DႡႨ_109FႧ_109D_109BႠႧ)
	{
	}

	private bool ႠႢႢႧႠ_109D_109B_109A_109E႙Ⴇ(Vector2 _109CႢႠ_109E_109CႦႤ_109CႢႧ_109E)
	{
		return false;
	}

	private void Ⴈ_109C_109E_109DႡ႙_109C_109DႥႥ_109E()
	{
	}

	private void _109EႡႧႢ_109B_109CႥႦ_109DႥ_109E(float ႥႣ_109FႨ_109DႧႧ_109C_109F_109BႢ, float Ⴈ_109AႨ_109AႥ႙Ⴂ_109CႠ_109B_109F, Vector2 _109EႧ႙ႡႨႠႣ႙ႧႣ_109F)
	{
	}

	private void _109CႡႡ_109A_109A_109FႠ႙_109D_109B_109C(float ႥႣ_109FႨ_109DႧႧ_109C_109F_109BႢ, float Ⴈ_109AႨ_109AႥ႙Ⴂ_109CႠ_109B_109F, Vector2 _109EႧ႙ႡႨႠႣ႙ႧႣ_109F)
	{
	}

	private void Ⴇ႙Ⴅ_109E_109BႣ_109AႣႧ_109C_109E(float ႥႣ_109FႨ_109DႧႧ_109C_109F_109BႢ, float Ⴈ_109AႨ_109AႥ႙Ⴂ_109CႠ_109B_109F, Vector2 _109EႧ႙ႡႨႠႣ႙ႧႣ_109F)
	{
	}

	public bool IsDead()
	{
		return false;
	}

	private void OnCollisionEnter(Collision _109F_109C_109DႤႨႣ႙Ⴀ_109D႙Ⴁ)
	{
	}

	private bool _109CႥႠႥႥ႙ႠႣႨႨ_109B()
	{
		return false;
	}

	private bool ႣႤ_109F_109BႡ႙ႣႥႨ_109C_109E(Vector3 ႠႡႨႢႥ_109F_109CႡ_109FႡႨ)
	{
		return false;
	}

	private void _109DႣႦ_109CႧႠ_109CႦ_109AႦ_109A()
	{
	}

	public void RefreshLadder(Transform _109EႦ႙_109A_109AႥႤႥ_109BႦ_109D)
	{
	}

	private void ႡႡႧႠႦ_109AႥ_109CႥ_109CႥ()
	{
	}

	private bool _109AႧ_109EႠ_109FႨႤႥ_109FႣ႙(Vector3 ႠႡႨႢႥ_109F_109CႡ_109FႡႨ)
	{
		return false;
	}

	public Vector2 FindVelRelativeToLook()
	{
		return default(Vector2);
	}

	private void Ⴁ_109BႠ_109AႥႦ_109A_109DႠ_109AႥ()
	{
	}

	private void Awake()
	{
	}

	public float GetSpeedHorizontal()
	{
		return 0f;
	}

	private void ႦႢႥ_109DႨႨ_109C_109EႥ_109CႠ()
	{
	}

	private void _109F_109C_109FႦႠ_109AႤ_109C_109A_109AႧ()
	{
	}

	public Transform GetPlayerCamTransform()
	{
		return null;
	}

	private void _109AႥ႙ႣႧ_109AႤႧ_109DႧ_109F(bool _109F_109DႥ႙_109B_109CႤႤႡႨႣ)
	{
	}

	private bool _109B_109AႡႦ_109E_109DႢႤႠႦ_109A(Vector3 ႠႡႨႢႥ_109F_109CႡ_109FႡႨ)
	{
		return false;
	}

	private bool _109D_109C႙_109BႤ_109DႤႤႢ႙Ⴆ()
	{
		return false;
	}

	public void StartCrouch()
	{
	}

	private bool _109CႧႧ_109C_109FႧ_109EႣ_109A_109F_109A(Vector3 ႠႡႨႢႥ_109F_109CႡ_109FႡႨ)
	{
		return false;
	}

	private bool ႡႧ_109BႤ_109DႤ_109BႣ_109EႥ႙()
	{
		return false;
	}

	private bool _႙_109BႤႥႨႧႢႣ_109F႙_109A(Vector3 ႠႡႨႢႥ_109F_109CႡ_109FႡႨ)
	{
		return false;
	}

	private void _109BႠႠႣႥ႙_109E_109B_109A႙႙(bool _109F_109DႥ႙_109B_109CႤႤႡႨႣ)
	{
	}

	private void ႦႢႣႨ႙ႦႦႤႦႡ_109C()
	{
	}

	public float ႧႦ_109B_109BႤႠႠႨ႙ႢႢ()
	{
		return 0f;
	}

	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	private void Ⴂ_109D႙_109BႣ_109A_109EႨႧ႙Ⴁ()
	{
	}

	private void Ⴈ_109BႨႠႤႣႠ_109DႥႦႨ(Collision _109F_109C_109DႤႨႣ႙Ⴀ_109D႙Ⴁ)
	{
	}

	public void BouncePlayer(Vector3 _109E_109DႧ_109BႤႠႥႥ_109C_109EႠ)
	{
	}

	public void _109F_109A_109A_109C_109AႣႨ႙_109D_109FႨ()
	{
	}

	private void _႙_109C_109CႨ_109EႢႥ_109FႠႡႡ()
	{
	}
}
