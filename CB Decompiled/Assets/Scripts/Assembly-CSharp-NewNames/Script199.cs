using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ႤႤႠႧ_109D_109CႡ_109AႨႢႦ : MonoBehaviour
{
	public enum _109EႨႤႠႡ_109C႙ႧႦ_109E_109A
	{
		Close = 0,
		Medium = 1,
		Far = 2,
		Any = 3
	}

	public Transform root;

	public Transform cam;

	private int _႙Ⴈ_109A_109D_109BႡႣ_109D႙႙Ⴄ;

	private float ႤႦႢႤႡႥႦ_109E_109BႨႦ;

	private float ႤႥ_109AႤ_109AႠ_109EႧ_109D႙႙;

	private float _109EႥ_109BႧ_109CႤႣႢႦႧ_109F;

	private Vector3 ႦႠ_109CႧႦ_109FႡ_109D_109EႥႨ;

	private float ႡႨ_109F_109BႥ_109FႢႡႥႧ_109F;

	private float ႦႢ_109AႤ_109E_109C_109FႡႠ_109F_109A;

	private float _109A_109E_109A_109E_109F_109C_109FႢ_109CႤႤ;

	private float ႡႣႨႧ_109C_109D_109FႣႥ_109C_109A;

	private float Ⴁ_109B_109E_109FႤႧႧ_109FႤ_109BႦ;

	public static readonly float posUpdatesPerSecondClose;

	public static readonly float posUpdatesPerSecondMedium;

	public static readonly float posUpdatesPerSecondFar;

	public static readonly float rotUpdatesPerSecondClose;

	public static readonly float rotUpdatesPerSecondMedium;

	public static readonly float rotUpdatesPerSecondFar;

	public static float posUpdateFrequencyClose;

	public static float posUpdateFrequencyMedium;

	public static float posUpdateFrequencyFar;

	public static float rotUpdateFrequencyClose;

	public static float rotUpdateFrequencyMedium;

	public static float rotUpdateFrequencyFar;

	private float _109AႧႣ_109EႢႡ႙_109A_109BႠ_109E;

	private float ႢႦ_109A_109C_109DႧ_109BႥႤ_109DႥ;

	private float _႙_109BႢ_109DႠ႙Ⴁ_109E_109E_109D_109A;

	private float Ⴅ_109CႤႧ_109CႧ_109FႨ_109EႥႧ;

	public static ႤႤႠႧ_109D_109CႡ_109AႨႢႦ Instance;

	private bool _109AႧႦႡႥ_109DႡ_109B_109EႡ႙;

	private int ႦႨ_109AႥႠႥႤႥ_109BႠႢ;

	public Dictionary<ulong, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A> idToDistance;

	private IEnumerator ႨႨႡ႙_109FႣႨႥႣႢ႙(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	public void Ⴂ_109B႙ႡႣႡႥ_109F_109E_109AႥ()
	{
	}

	private void ႡႤ_109D_109BႥႠ_109CႡ_109BႡ႙()
	{
	}

	private void ႥႤႠႡႧ_109A_109E_109EႧႦႢ()
	{
	}

	private void Ⴁ_109D_109B_109BႧႡ_109FႢ_109BႠ_109D(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
	}

	private void Ⴇ_109EႠ႙႙_109EႥ_109CႥ_109FႣ()
	{
	}

	private void ႡႦ_109BႡ႙ႦႦ_109DႢ_109BႨ()
	{
	}

	public void _109A_109E႙႙Ⴅ_109EႥ_109FႣႥ_109B()
	{
	}

	private void _109BႨႠႨႤႢ႙ႧႠ_109B႙()
	{
	}

	private IEnumerator _109D႙Ⴄ႙_109AႡ_109DႧႥႥ_109B(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	public void ForceMovementUpdate()
	{
	}

	private IEnumerator Ⴄ_109C_109AႤ_109FႧႥႣႥႨႦ(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private void Ⴂ႙_109A_109EႣ႙_109FႧ_109F_109BႦ()
	{
	}

	private void Ⴁ_109EႦ႙_109FႡ_109B႙႙ႦႡ()
	{
	}

	private void _109F႙_109F_109BႦႥႧႧ_109B_109EႥ()
	{
	}

	private IEnumerator _109CႣ_109F_109F_109CႤ_109F႙႙ႢႤ(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private void _109FႡ_109F_109F႙ႣႨ_109C_109AႤ_109B()
	{
	}

	private void OnEnable()
	{
	}

	private void ႥႠႨ_109FႨႤ_109BႤ_109CႧႢ()
	{
	}

	private IEnumerator Ⴇ_109BႡႡႢႤ_109D_109FႤႨ_109F(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private IEnumerator ႧႡ_109E_109B_109DႠ_109F_109B႙ႣႡ(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private IEnumerator ႡႦႨႦႦ_109DႠ_109E_109D႙Ⴀ(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private IEnumerator Ⴁ႙ႦႥ_109DႦ_109BႣ_109DႦ႙(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private void _႙_109CႢႨႤ_109BႡ_109BႠႥ_109C()
	{
	}

	public void _109C_109CႢႠႧႨ_109BႥ_109C_109DႧ()
	{
	}

	private void Start()
	{
	}

	public void Ⴇ_109DႧ_109AႣ_109F_109D_109FႥ_109BႠ()
	{
	}

	private IEnumerator _109D_109C_109BႠႥ_109AႥႦႧႡႨ(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private void ႠႡႥႧ_109A_109F_109BႦ_109B႙_109B()
	{
	}

	public void Ⴇ႙Ⴄ_109F႙ႣႨႧ_109BႧ_109A()
	{
	}

	private void ႠႧႣ_109D_109A႙Ⴃ႙Ⴈ_109FႠ()
	{
	}

	public void _109A_109F_109A_109E_109CႡႨႨ_109EႧႥ()
	{
	}

	private void _109FႤ_109BႦ_109DႢႣႡ_109EႢႢ(float Ⴆ_109E_109DႢႤ_109EႧႥႦ_109EႢ, float _႙႙႙_109BႨႢႡ_109CႨႤႧ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
	}

	private void Awake()
	{
	}

	public void ႦႦႨ_109DႡ_109EႡ_109FႡႧႤ()
	{
	}

	private void Ⴆ_109AႧ_109B_109FႠ_109EႦ႙Ⴇ_109E(float Ⴆ_109E_109DႢႤ_109EႧႥႦ_109EႢ, float _႙႙႙_109BႨႢႡ_109CႨႤႧ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
	}

	private void _109BႦႡႧ_109F_109BႤႢႤႧ_109D()
	{
	}

	private void Ⴁ_109AႠႢႧ_109A_109CႤ_109AႣႨ()
	{
	}

	private IEnumerator ႣႠႨ_109EႡ_109CႥ_109BႨ_109F႙(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private IEnumerator ႨႧႤ႙ႠႢ_109CႨႦႦႨ(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private void _109B_109A႙ႢႦႡ_109A_109DႤႤႣ(float Ⴆ_109E_109DႢႤ_109EႧႥႦ_109EႢ, float _႙႙႙_109BႨႢႡ_109CႨႤႧ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
	}

	private void _109D_109B_109B_109CႡႦ_109AႨ_109D_109EႦ()
	{
	}

	private void Ⴂ_109FႤ_109EႨ_109D_109D႙_109EႣ_109C(float Ⴆ_109E_109DႢႤ_109EႧႥႦ_109EႢ, float _႙႙႙_109BႨႢႡ_109CႨႤႧ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
	}

	private IEnumerator _109A_109F႙ႠႧ_109C_109EႨ_109BႧႧ(float Ⴄ_109DႣ႙ႥႧႨ_109AႨႡႦ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
		return null;
	}

	private void Ⴈ_109A_109E႙Ⴃ_109C_109EႤ_109C_109DႨ()
	{
	}

	private void _109EႢႣ_109FႧ_109EႨ_109F_109BႡ႙()
	{
	}

	private void Ⴃ_109BႧ_109BႨႡ_109F_109D_109D_109B_109E(float Ⴆ_109E_109DႢႤ_109EႧႥႦ_109EႢ, float _႙႙႙_109BႨႢႡ_109CႨႤႧ, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
	}

	public void ႧႥ_109AႥႧ_109C_109FႧႦ႙_109A()
	{
	}

	private void Ⴅ႙ႢႢႧ႙ႢႦႥ_109FႢ(Vector3 Ⴂ_109F_109A_109DႤႨႦႤႢႥ_109E, _109EႨႤႠႡ_109C႙ႧႦ_109E_109A _109A_109A_109DႥ_109F_109EႧႦ_109DႠႣ)
	{
	}
}
