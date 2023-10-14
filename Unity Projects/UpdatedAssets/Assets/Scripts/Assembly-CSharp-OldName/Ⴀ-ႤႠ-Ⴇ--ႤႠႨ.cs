using System.Collections;
using System.Collections.Generic;
using MilkShake;
using UnityEngine;
using UnityEngine.UI;

public class Ⴀ_109BႤႠ_109EႧ_109A_109BႤႠႨ : MonoBehaviour
{
	public GameObject crate;

	public GameObject groundHitPrefab;

	public Transform hitFxTransform;

	public Ⴀ_109D_109C_109C႙_109A_109AႥႠ_109B_109F sfxs;

	public SkinnedMeshRenderer rend;

	public static Ⴀ_109BႤႠ_109EႧ_109A_109BႤႠႨ Instance;

	public CosmeticItem testItem;

	private Vector3 _109BႦ႙_109CႡ႙Ⴆ_109A_109FႠ_109D;

	private Vector3 ႢႨႥႡႥႥႠႤႤႠႡ;

	private Vector3 ႧႤႣႤႢႡႡႣႢႤႨ;

	private Vector3 ႡႦ႙_109B_109FႨႤႡ႙_109AႡ;

	private Vector3 _109EႧ_109EႢႡႢႥ_109DႤႥႠ;

	private Vector3 _109DႧႦႥႡ႙ႧႨ_109A႙_109C;

	private Vector3 ႨႢ_109C_109AႡ_109D_109C_109EႥႢႠ;

	private Vector3 Ⴇ_109EႥ_109FႣႣႣ_109DႣႡႨ;

	private Vector3 Ⴄ႙_109EႤႡႥႥ_109CႣ_109FႧ;

	private Vector3 Ⴆ_109B_109E႙ႣႤ_109AႡ_109A_109AႠ;

	public Quaternion itemStartRotation;

	public RawImage itemDisplay;

	public Transform itemTransform;

	public MeshRenderer itemRend;

	public MeshFilter itemFilter;

	public Material yikeBlack;

	public Material yikeWhite;

	private bool Ⴄ_109C_109D_109AႡႡ_109D_109F_109B_109B_109D;

	public Transform room;

	public ShakePreset shakePreset;

	public Animator crateAnimator;

	private float Ⴂ_109CႡ_109BႡႡႥႦႢႣႦ;

	private float _႙Ⴀ႙Ⴇ_109FႦႥႡ_109F႙Ⴁ;

	public Shaker shakerMain;

	public Shaker shakerRenderTexture;

	private void ႠႠႣ_109AႢႧႤႠ_109CႡႧ()
	{
	}

	public void ႠႥႦႠ_109DႨ႙Ⴈ_109FႤႣ(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void ႦႥႠ_109D_109D_109EႤ_109CႠ_109F_109C(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void ႢႨ_109A_109BႡႨႥႤ_109C_109DႦ()
	{
	}

	public void _109F_109BႦႠ_109E႙_109D_109A_109FႦႧ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private void _109DႡ_109BႦႧ_109DႡႣႦ_109E_109F()
	{
	}

	public void _109C_109AႦႢႦႤႥ_109DႨ_109CႢ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void ႣႣ႙ႧႠႡ_109FႦ_109D႙_109C()
	{
	}

	private void Update()
	{
	}

	public void _109CႢ_109E_109FႢႠ_109FႣႧႦႣ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void LateUpdate()
	{
	}

	public void ႢႦႡႥ_109DႥႠႧ_109EႥႨ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	public void ႣႡႧႠ_109BႡ_109DႡႧ_109E_109E(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	private void _109CႤႡ_109A_109BႣ_109DႨ_109CႡႠ()
	{
	}

	private IEnumerator ႤႦ_109DႠႡ႙_109EႣႤႡ_109F(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void ႢႧႨႤ႙_109BႦႢ႙ႢႡ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void _109C_109A_109D႙_109D_109F_109FႣႧႨႥ()
	{
	}

	public void _109D႙Ⴃ_109C_109BႡႤ_109AႧ_109AႠ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private IEnumerator Ⴅ_109C_109F_109EႤ_109EႤ_109C_109D_109FႣ(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	private void _109F_109EႡႣ_109CႧႣႧ_109EႤႢ()
	{
	}

	private void Awake()
	{
	}

	public void OpenNewCrate(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	private void ႦႡႣ_109F_109DႢ႙ႤႠ_109AႣ()
	{
	}

	private IEnumerator ႨႤႣႤ႙ႦႣႡႡႦ_109B(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void ႠႡႦ_109A_109E_109EႣႦႥ_109E_109B(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void _109F_109D_109AႦ_109C_109AႠ_109BႣႣႧ()
	{
	}

	public void ႨႨႣ_109F႙Ⴂ႙႙_109D_109CႠ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void _109EႨႥ_109EႦႡ_109E_109CႦ_109A_109E()
	{
	}

	public void _109CႢႤႡ_109E_109A_109CႥ_109EႥႨ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void ႧႣႡ_109E_109D႙ႠႨ႙ႤႤ()
	{
	}

	public void ႢႡ_109F_109E_109A_109B_109EႠ_109EႤႢ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	public void ႧႢ_109E_109FႦ_109FႦႠႨ_109BႤ(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void ႧႤ_109FႠႤႢ_109EႥ_109E_109BႠ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	private IEnumerator _109DႥႨႥႤႦ_109C_109FႡႡ_109F(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void ႦႧႧႡ႙Ⴇ႙_109C_109CႣႧ(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void ႦႤႢ_109AႨ_109A_109CႧ_109DႧႨ(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	private void _109C_109BႤႤႦႦႢ႙Ⴈ_109F_109E()
	{
	}

	private void ႢႡႨ_109EႢ_109CႣ_109FႨ_109CႨ()
	{
	}

	public void _109F_109AႢႦႨ_109AႤ_109DႢႤ_109D(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private void Ⴄ_109FႢႣ_109CႠႧ_109AႡ_109D႙()
	{
	}

	private void ႠႢႧ_109FႡ_109B_109C_109FႣ႙Ⴂ()
	{
	}

	public void _109BႦ_109DႦ႙_109C_109EႥ_109AႣ_109E(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	public void ႧႤႨ႙Ⴆ_109FႨႣ_109E_109F_109F(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	private IEnumerator _109BႣ_109DႠႡႣႨႡႢႤ_109B(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void ႦႦ_109C_109D_109FႡႥႤႢႡႡ(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void ႦႧႢႧ႙ႧႡႨ_109F_109FႠ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	public void _109E႙_109DႦႤ_109BႧ_109DႨ_109D_109D(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void ႡႢႦႣႤႦႡႨ_109A႙_109F(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	private IEnumerator ႠႢ_109E_109AႢ_109CႤႨႣႡႤ(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	private void ႠႢ_109F_109FႦႢႠႠႣႢ႙()
	{
	}

	public void _109BႥ႙_109E_109CႤႤ_109BႦႣ_109D(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	public void SetMesh(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	public void _109F_109CႥႤ_109E_109A_109AႡႡႢ_109A(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	public void _109B_109C_109CႥႣ_109BႠ_109F_109DႨႧ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void _109FႣ_109DႧႨ_109F_109AႨ_109C_109FႧ()
	{
	}

	private IEnumerator ႣႥ႙႙ႠႤ_109A_109DႦႨ_109C(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	private void ႥႠ_109AႨ_109EႣ_109BႣႠႠ_109B()
	{
	}

	private void ႨႣႥ_109CႡ_109EႠႢႦႤႡ()
	{
	}

	private void Ⴅ_109CႢႡႦႨ_109CႨႡႨႨ()
	{
	}

	private IEnumerator ႠႤ_109A_109B_109FႡ_109FႢ_109BႢ_109C(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	private void ႣႨႦႤႣ_109AႡႢႧႧ_109F()
	{
	}

	public void _109AႧႣႥႥႦႧႥ_109B_109AႦ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private IEnumerator _109BႡႤ႙႙_109DႢႧ_109CႢႠ(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	private IEnumerator ႦႢ႙ႡႠႠ႙_109AႦ_109C_109F(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void _109CႡႨ_109C_109DႥႦႨ႙Ⴂ_109F(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void Ⴄ_109EႡႠႠ_109B_109AႨႥႢ_109B(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void _109B_109E_109FႢႢႠႧႥ႙Ⴆ_109B()
	{
	}

	private void Ⴀ႙_109F_109DႧႧႧႧႤႥ_109B()
	{
	}

	private IEnumerator Ⴆ႙_109CႥ_109C႙_109FႦ_109D_109AႥ(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	private void ႣႣႦႥႠႨ_109FႥ_109AႣ_109E()
	{
	}

	public void _109DႥႧ႙႙႙Ⴅ_109E_109AႣႥ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	public void Ⴆ_109B_109E_109E_109B_109F_109F_109E_109F_109BႧ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private void ႡႠႡ_109AႢ႙_109FႤႡ_109F_109A()
	{
	}

	public void _109C_109CႣ_109A_109FႨႦ_109AႤႤႦ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private void ႠႥႨ_109E_109BႧ_109E႙ႦႧႧ()
	{
	}

	private IEnumerator Ⴂ႙_109D_109DႤ_109DႤႧ_109AႦႦ(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void _109FႧႣ႙ႢႠ႙_109F_109AႡႧ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	public void Ⴆ_109FႥ_109B_109B_109D_109C_109A႙_109AႤ(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	private void _109DႦႥႧႢႠ႙ႢႤႢ_109C()
	{
	}

	private void ႥႦ႙ႦႥႢႤ_109E_109A_109B_109B()
	{
	}

	public void _109CႨႦႤႠႥ႙ႡႢ႙Ⴄ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private void _109CႡ_109AႨႨ_109CႦ_109AႠႢ_109B()
	{
	}

	public void ႠႡႣ_109EႦႤ_109C_109B႙ႦႡ(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void ႦႦ႙ႦႨႥႤ_109CႨႨႤ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	private IEnumerator ႢႨႨ_109F_109FႡႧ_109AႠႤ_109E(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void _109C_109AႨႥ_109B_109DႣႣႨႤ_109B(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	private IEnumerator _109C_109F_109D_109BႠႡ_109A_109B_109E_109D_109E(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	private void _109DႡႧႠ_109AႡႤႥႣႤႦ()
	{
	}

	public void ႢႥ_109A_109D_109CႧႦ_109C_109D_109CႦ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void ႤႥ_109FႣႣႥ_109E_109EႤႧ႙()
	{
	}

	public void Ⴃ_109CႠႥႨ_109F_109AႧႣႢ_109D(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, AudioClip Ⴆ_109F_109B_109BႧ_109CႥႤ႙Ⴁ_109C, Dictionary<string, string> ႥႦႢ_109CႥ႙_109F_109AႤႧ_109A)
	{
	}

	private void _109A_109F_109F_109DႠႢႦႤႥႣ_109D()
	{
	}

	public void _109B_109FႧ_109BႢႥ_109EႡ_109F_109E_109A(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	private void ႨႢ_109A_109A_109D_109E_109F_109B_109B_109EႨ()
	{
	}

	public void ႦႤႤႧ႙_109BႦႦႨ_109BႤ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private void ႢႥႡႠ_109C_109FႡ_109FႢႨႨ()
	{
	}

	private IEnumerator ႠႠ_109BႤႤႤႧ_109DႢႦႨ(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void _109BႦ_109FႥႦႡ_109EႦ_109B_109E_109A(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	public void Ⴄ_109A_109A_109D_109B_109C_109DႤႥႡႧ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	public void _109CႦ_109CႦ_109F_109D_109B_109FႣ_109B_109A(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}

	private void Ⴀ_109B_109EႧ_109EႡ_109BႧႤႨႢ()
	{
	}

	public void ႥႠ_109CႦႣ_109E_109EႢႡႢႡ(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	private IEnumerator Ⴀ_109EႨႥ_109A႙Ⴂ_109CႠႤႧ(AudioClip Ⴄ_109AႢႣႨႦႣႦႦ_109DႦ)
	{
		return null;
	}

	public void _109AႨႦႥႢ_109AႧႤ႙ႥႣ(CosmeticItem _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ, Dictionary<string, string> ႧႨႣ_109AႤႢႧႦႣႦ_109A)
	{
	}

	public void ShakeWithPresetAndRatio(Shaker ႧႤ_109DႡႥ_109A_109AႢ_109F_109EႡ, ShakePreset ႥႣ႙ႣႢ_109CႨႨ_109DႦ႙, float _109AႠ_109B_109F_109B_109C႙_109DႦႨႢ)
	{
	}

	public void SetCrateType(ႤႥ႙Ⴃ႙_109FႡႥႢႨႠ._109A_109AႤ_109FႠ႙_109D_109E_109EႡ_109E _109BႢႨႣ_109DႧ_109D_109C_109A_109CႣ)
	{
	}
}
