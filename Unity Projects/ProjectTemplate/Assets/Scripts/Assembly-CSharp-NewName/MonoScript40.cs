using System.Runtime.CompilerServices;
using UnityEngine;

public class _109B_109FႣႥ႙Ⴃ႙_109DႨ_109F_109B : MonoBehaviour
{
	public enum _႙ႢႡ_109D_109DႤ_109D_109AႢ႙_109C
	{
		Crouch = 0,
		Melee = 1
	}

	private Vector3 ႥႠႣႨ_109AႨႣႠႠ_109A_109E;

	private Vector3 Ⴂ_109DႥႡ_109C_109DႡ_109DႥႣ_109E;

	private Vector3 ႣႢႥႤႧႦ႙Ⴂ_109F_109D_109D;

	private float _႙_109FႦ_109CႧ_109AႤ_109AႤႧႢ;

	private float ႠႨႦႥ_109CႢ_109D_109FႡႤ_109A;

	private Rigidbody _109A_109DႤႤႨႥႨႨႦႨႥ;

	private float _႙ႡႠ_109D_109F_109C႙_109AႨႦႣ;

	private float _109B_109E_109BႤ_109FႨ_109EႧႣ_109A_109F;

	private float ႦႢ_109AႥႨႣႦႣႥႠ_109D;

	public Animator animator;

	public Transform colliders;

	public Transform upperBodyRotation;

	private Vector3 _႙ႨႦႦႨ_109FႠႤႡႧႧ;

	private Vector3 Ⴈ_109C_109CႡႣ_109D_109C_109A_109B_109F_109D;

	private Vector3 Ⴆ_109BႢႥႨႡႢႢ႙Ⴃ_109D;

	private Vector3 Ⴅ_109F_109EႤ_109A_109EႠႠႧႡႧ;

	private Vector3 _109CႡႥႠ_109BႠ_109D_109C႙_109DႦ;

	private float ႧႠႧ_109A_109A_109E_109A႙ႡႣ_109B;

	private float _109DႦ_109B_109CႢ_109CႧ႙႙ႦႦ;

	[HideInInspector]
	public float xRot;

	[HideInInspector]
	public float yRot;

	private Vector3 ႥႧ_109AႥ_109A_109EႥႣႧ_109D_109C;

	private bool ႢႨႤ_109DႠ႙ႠႢႢႧ_109D;

	public Collider playerCollider;

	private float ႣႢ_109AႠ_109DႣႠ႙Ⴇ_109B_109A;

	private float _109D_109AႡႡႦႢ_109DႠႥ႙႙;

	public Transform isGroundedTransform;

	public LayerMask whatIsGround;

	private bool ႦႨ_109B_109CႤ_109E_109DႦ႙ႢႧ;

	private bool Ⴈ႙ႠႦႥ_109F_109EႧႤႣႤ;

	private Collider[] _109EႢ_109EႥ႙_109EႧႡႠႨႢ;

	private float _႙Ⴃ_109B_109FႦႣ_109C_109E_109EႥႢ;

	public Transform itemOrbit;

	private float Ⴅ႙ႥႨႡ_109FႢႣ_109BႢ_109F;

	private float _109AႤ_109F_109BႠ_109BႠႤႡႤ_109E;

	private Vector3 ႤႠ_109C_109F_109D_109A_109BႧ_109FႡႢ;

	public Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C ႥႠႧႢႡ_109D_109F_109C_109DႧ_109F
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

	public void Ⴀ_109C_109CႠႧ_109EႥ_109C_109AႧ_109D(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	[SpecialName]
	public void ႧႨ႙ႥႣႢ_109AႠႤ_109AႠ(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109A_109DႠ_109F_109E_109A_109CႡ႙_109BႢ()
	{
		return null;
	}

	private void ႨႥ_109BႦ_109E_109EႧႡ_109D_109FႡ()
	{
	}

	public void ForcePosition(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetRotation(float Ⴈ_109AႨ_109AႥ႙Ⴂ_109CႠ_109B_109F, float ႥႣ_109FႨ_109DႧႧ_109C_109F_109BႢ)
	{
	}

	private void LateUpdate()
	{
	}

	private void Ⴈ_109B_109BႢႨႨႥ႙ႨႤ_109B()
	{
	}

	private void ႠႤႤ_109A_109EႠႣႥ႙_109CႠ()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetCrouching(bool ႢႨႤ_109DႠ႙ႠႢႢႧ_109D)
	{
	}

	private void Ⴈ_109D_109C႙_109DႥႧ_109BႣ_109FႥ()
	{
	}

	public void ႣႣႣ_109B_109F_109DႡႠႤႢ_109C(float Ⴈ_109AႨ_109AႥ႙Ⴂ_109CႠ_109B_109F, float ႥႣ_109FႨ_109DႧႧ_109C_109F_109BႢ)
	{
	}

	private void _109EႤႢႣႡႧႢ႙ႡႠႧ()
	{
	}

	private void Ⴈ_109BႢႣ_109B_109B_109E႙႙_109FႢ()
	{
	}

	public void ႢႣႥႨ_109DႧႨႦႤႧႣ(bool ႢႨႤ_109DႠ႙ႠႢႢႧ_109D)
	{
	}

	public void SetAnimation(_႙ႢႡ_109D_109DႤ_109D_109AႢ႙_109C _109DႨႨ_109C_109FႤႤ_109EႡ_109CႤ, bool _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E, float ႢႦႠႠႧ_109DႥႦႠႦႠ = 1f)
	{
	}

	private void _109EႣႥ႙_109EႤႣႣ_109EႢ_109D()
	{
	}

	private void _109AႡႣ_109A_109DႣ_109F_109DႢႠႦ()
	{
	}

	public bool IsGrounded()
	{
		return false;
	}

	private void Ⴇ႙_109C႙_109C_109DႠႠႢႢ_109F()
	{
	}

	private void Ⴆ_109AႦ_109D_109CႠ_109FႦႦႨႦ()
	{
	}

	public void ႣႨႢ_109FႡ႙ႧႡ_109EႠႠ(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}

	[SpecialName]
	public Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႠႢ_109A_109B_109DႥႢႤႨ_109E()
	{
		return null;
	}

	private void Ⴅ_109EႠ_109A_109B_109F_109DႡႤႤႡ()
	{
	}

	public void _109CႨႥႨႡႧ_109EႥ_109AႣႦ(_႙ႢႡ_109D_109DႤ_109D_109AႢ႙_109C _109DႨႨ_109C_109FႤႤ_109EႡ_109CႤ, bool _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E, float ႢႦႠႠႧ_109DႥႦႠႦႠ = 1f)
	{
	}

	private void Ⴄ_109D_109CႤ႙Ⴅ_109BႡ_109AႠႠ()
	{
	}

	private void Ⴀ_109DႨႨႢႦႧႨ႙ႣႥ()
	{
	}

	public void SetPosition(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E)
	{
	}
}
