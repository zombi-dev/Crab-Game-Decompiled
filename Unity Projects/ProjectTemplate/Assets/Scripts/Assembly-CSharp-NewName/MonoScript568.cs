using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class Ⴆ_109D_109BႤ_109CႨႥႣႦ_109BႦ : MonoBehaviour
{
	public enum _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ
	{
		OutlineAll = 0,
		OutlineVisible = 1,
		OutlineHidden = 2,
		OutlineAndSilhouette = 3,
		SilhouetteOnly = 4
	}

	[Serializable]
	private class ListVector3
	{
		public List<Vector3> data;
	}

	private static HashSet<Mesh> _109C_109CႧ_109B_109D႙_109AႢႡ_109BႤ;

	[SerializeField]
	private _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ outlineMode;

	[SerializeField]
	private Color outlineColor;

	[SerializeField]
	private float outlineWidth;

	[SerializeField]
	private bool precomputeOutline;

	[SerializeField]
	[HideInInspector]
	private List<Mesh> bakeKeys;

	[SerializeField]
	[HideInInspector]
	private List<ListVector3> bakeValues;

	private Renderer[] Ⴆ_109B႙Ⴅ_109DႨႨ_109B_109DႨႣ;

	private Material ႦႠ_109AႦႢႥႣႦႧႢႦ;

	private Material _109C_109DႦႡႣႨႤ_109EႠ_109AႠ;

	private bool ႤႡ_109D႙ႧႧ_109EႦ_109E_109DႨ;

	public _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109A_109EႦႠႥႧႨႧ_109AႠႠ
	{
		get
		{
			return default(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ);
		}
		set
		{
		}
	}

	public Color _109F_109A_109FႦ_109AႠႣႣႧ႙_109E
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float ႦႨႨ_109E_109C_109BႧႤႧ_109BႤ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[SpecialName]
	public void _109D_109CႢ_109DႢ_109BႣ_109A_109A_109F႙(Color _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public void Ⴈ_109E_109DႧႠ_109EႠႡ႙ႧႣ(Color _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public Color Ⴅ_109EႨ_109E_109B႙ႥႧႤႧ_109E()
	{
		return default(Color);
	}

	[SpecialName]
	public void _109EႢ_109B_109E_109FႧ႙႙ႥႨ_109E(Color _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public float _109B_109FႢ႙Ⴆ_109CႣ_109B႙_109AႤ()
	{
		return 0f;
	}

	private void _109E_109A_109D_109DႠႢ_109CႣႦႧ_109B()
	{
	}

	private void Ⴈ_109CႥႦႡႤႥ_109FႦႢ႙()
	{
	}

	private void OnEnable()
	{
	}

	[SpecialName]
	public void ႥႧႤႣႨႦႤ_109FႥ_109D_109C(float _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public Color Ⴀ_109BႧႦႥႡ_109AႡ_109D_109AႤ()
	{
		return default(Color);
	}

	private void ႥႠ_109DႢႦႠႡႤႦ_109FႤ()
	{
	}

	private List<Vector3> Ⴁ_109BႢႡႠႧႠ_109E_109B_109E_109F(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	private List<Vector3> ႤႧႥႠ_109AႣ_109CႢ_109A_109FႦ(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	[SpecialName]
	public void ႣႡႨ_109EႨ_109BႢႥႠႣႣ(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public void Ⴆ႙ႣႧ_109C_109B_109E_109FႤ_109E_109D(Color _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void ႧႦ_109EႤႠ_109C႙ႠႥ႙Ⴆ()
	{
	}

	[SpecialName]
	public float _109EႦႣ႙ႣႠႢႡႨႢ႙()
	{
		return 0f;
	}

	[SpecialName]
	public void ႣႤ_109EႧ_109BႡႢ_109CႠႣႨ(Color _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public float Ⴈ_109AႨႢႡႣႣႣႠႥ႙()
	{
		return 0f;
	}

	private void OnValidate()
	{
	}

	private void Ⴀ_109E_109FႧႥ_109F_109BႥ႙Ⴄ_109F()
	{
	}

	private void ႥႦ_109C_109A_109BႠႢႦ႙ႨႥ()
	{
	}

	private void OnDisable()
	{
	}

	[SpecialName]
	public void _109FႤႤႥႣႣ_109D_109E႙ႠႠ(float _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public void ႢႢႦ_109CႦႦ_109A_109DႦ_109C_109C(float _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void Update()
	{
	}

	[SpecialName]
	public float _109FႢ_109BႠႣႨ_109C_109CႧႡ႙()
	{
		return 0f;
	}

	[SpecialName]
	public Color _109CႢ_109D_109BႤ_109A႙ႨႧႧႦ()
	{
		return default(Color);
	}

	private void ႡႡ_109FႣႥ_109FႣႥ_109D_109D_109A()
	{
	}

	[SpecialName]
	public _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109D_109C_109DႡႡႧႦ_109E႙ႠႦ()
	{
		return default(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ);
	}

	private void _109BႧ_109AႣႧႥ_109FႡႦ႙Ⴇ()
	{
	}

	private void _109A_109B႙Ⴁ_109FႢႦ_109BႦႤႨ()
	{
	}

	private void _109CႡ_109F_109D_109CႤႡ႙Ⴈ_109C_109C()
	{
	}

	private void _109F_109FႧ_109EႥ_109B_109DႥႥ_109A႙()
	{
	}

	[SpecialName]
	public void Ⴇ_109A_109AႥႠႥႥ႙_109E_109DႣ(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private List<Vector3> _109BႤႧ_109F_109EႢႥႤႤႨႡ(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	private void Ⴄ_109EႧႤ_109E႙Ⴀ_109DႣႥ႙()
	{
	}

	[SpecialName]
	public void _109FႤႠႣ_109D_109F_109FႨ_109DႢ_109E(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void Ⴃ_109BႧႢ_109DႧႦႠ_109EႡႦ()
	{
	}

	private void _109D_109CႥႦ႙Ⴈ_109CႢ_109A_109AႠ()
	{
	}

	[SpecialName]
	public Color Ⴁ_109B_109BႨႢ_109BႧႤႧႥ႙()
	{
		return default(Color);
	}

	[SpecialName]
	public void _109F႙ႢႠႧႤႤ_109FႨ_109DႡ(Color _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void _109BႧႡ_109FႠ_109CႠႨႠ_109AႨ()
	{
	}

	private void Ⴅ႙ႥႧႤ႙ႠႤႧႥႢ()
	{
	}

	[SpecialName]
	public void ႦႥႠ_109B_109A_109AႥႥႡႧႤ(float _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void ႨႢ_109C_109E_109A_109DႢႥႠႡ_109C()
	{
	}

	private void Ⴈ_109D_109D_109C_109F_109BႤ_109E_109C_109BႥ()
	{
	}

	private void Ⴆ_109CႧ_109D_109F_109FႦ_109EႠ_109EႣ()
	{
	}

	private void _109A_109EႤႤ_109BႡႢ_109FႡႧ_109F()
	{
	}

	private List<Vector3> ႡႥႣ_109F_109F_109E_109D_109FႦႤ_109C(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	private void _109EႡ_109C_109C႙_109BႠႤ_109E႙Ⴅ()
	{
	}

	private void _109BႦႨ_109C_109FႣ႙Ⴀ_109BႤ_109C()
	{
	}

	[SpecialName]
	public void _109F_109A႙ႤႦႡ_109FႡ_109C_109E_109C(float _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private List<Vector3> Ⴈ_109BႨႡႢႡ_109CႠႨ_109BႤ(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	private void _109F_109B_109F_109A_109AႧႠႥႢႡ_109B()
	{
	}

	private void _109EႦႠ_109FႨႠႨႤႥ_109AႢ()
	{
	}

	[SpecialName]
	public _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ Ⴄ_109A_109E_109EႦ_109EႦႣ_109AႠႨ()
	{
		return default(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ);
	}

	private void _109B_109BႣႢ_109C_109FႨႧႥႡႦ()
	{
	}

	[SpecialName]
	public float Ⴇ_109FႤ_109DႧႣႦ_109E_109EႦႢ()
	{
		return 0f;
	}

	private void ႧႤႢႡ_109E_109E_109A_109B_109FႣႠ()
	{
	}

	[SpecialName]
	public _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _႙ႢႤ_109DႦ႙_109AႨ_109FႨ_109F()
	{
		return default(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ);
	}

	private void Awake()
	{
	}

	[SpecialName]
	public void ႥႨႢ_109B_109CႧႤႣႢ_109DႥ(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void OnDestroy()
	{
	}

	private void Ⴇ_109F_109D_109D_109AႣ_109DႣ_109FႣ႙()
	{
	}

	private void ႧႤႢ႙_109F_109AႠ_109DႨႥ႙()
	{
	}

	private void ႠႢႨႣ_109FႦ_109BႤႦႤႤ()
	{
	}

	private List<Vector3> _႙_109AႢႠ႙Ⴄ_109CႦ_109FႦႨ(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	private void _109F_109E_109F_109AႡ_109B_109F_109A_109BႨႠ()
	{
	}

	private void _109C_109F_109EႨႦႧ_109FႡ_109CႨ_109A()
	{
	}

	private void _109FႧ႙Ⴇ_109E_109FႢ_109A_109F_109EႣ()
	{
	}

	private List<Vector3> Ⴆ_109CႢႧႦ_109B_109B_109B_109EႠ_109A(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	private void ႨႣႤႧ_109FႥ_109EႦ_109BႨ_109F()
	{
	}

	[SpecialName]
	public _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ Ⴆ_109C_109AႡ_109CႨ_109FႡ_109D_109D_109F()
	{
		return default(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ);
	}

	private void Ⴃ_109E_109A_109C_109EႣႣႦႠ_109AႤ()
	{
	}

	private List<Vector3> _109EႠႤႨႧ_109C_109AႠႤ_109F_109D(Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D)
	{
		return null;
	}

	private void _109BႢႢ_109C_109CႦ႙ႢႠႨ_109E()
	{
	}

	private void ႡႢ႙_109D_109AႥ_109C_109B_109CႦ႙()
	{
	}

	private void Ⴆ_109FႨ_109E_109F_109FႦႣႧ_109E_109D()
	{
	}

	[SpecialName]
	public void _႙႙_109AႦ_109DႥ_109EႤ_109CႡ႙(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void _109D_109E_109CႣႣ_109D႙ႢႡႡႧ()
	{
	}

	private void _109BႦ_109E_109FႡႦႦ_109BႢႤ_109E()
	{
	}

	private void Ⴃ_109D_109AႥ_109CႡ႙ႤႦႢႠ()
	{
	}

	[SpecialName]
	public void _109BႣႥႡႧႢႥ_109A_109CႦႢ(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void Ⴇ_109BႣႢ_109E_109BႤ_109CႠ_109B_109A()
	{
	}

	[SpecialName]
	public _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109EႧႦႥႢႥႢ_109B_109B_109F_109F()
	{
		return default(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ);
	}

	[SpecialName]
	public _109BႢႦ_109DႤ_109FႢႢ_109CႡႣ _109E_109BႢ_109BႥႨႤႨ_109CႦႡ()
	{
		return default(_109BႢႦ_109DႤ_109FႢႢ_109CႡႣ);
	}
}
