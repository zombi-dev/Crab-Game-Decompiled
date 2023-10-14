using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _109DႦ_109EႣႧႢႣႨႨ_109EႡ : MonoBehaviour
{
	public enum _109EႣ႙Ⴀ_109FႢႤ_109C_109A႙_109E
	{
		Server = 1
	}

	public RawImage overlay;

	public TMP_InputField inputField;

	public TextMeshProUGUI messages;

	public Color localPlayer;

	public Color onlinePlayer;

	public Color deadPlayer;

	public Color server;

	private Color ႢႠႥႢ_109BႡႠ႙_109C_109FႧ;

	private int _႙ႤႤႥ_109D_109CႤႢႤႦ_109A;

	private int ႧႨ_109AႦႢ႙ႢႢ_109AႢႤ;

	private int _႙_109A_109A_109A_109CႥႦႤႥ_109E_109E;

	public static _109DႦ_109EႣႧႢႣႨႨ_109EႡ Instance;

	public TextAsset profanityList;

	private List<string> Ⴈ႙ႥႨႢႣႧႣႣ_109C_109B;

	private string ႠႥ႙Ⴀ_109C_109BႧ_109DႧႨႠ;

	private string Ⴇ_109E_109DႤ_109D_109C႙_109FႥႣႨ;

	private string Ⴃ_109AႠ_109CႢႧႢႣႡႧ_109D;

	private bool _109E_109CႡႨ႙ႦႤ_109C_109EႡ_109F;

	private static readonly Regex _109DႧႦႥႤ_109A_109CႥႧႦႣ;

	private int _႙Ⴀ_109EႥႥႨ_109DႢ_109DႢႦ;

	public bool _109CႢႢႤ_109DႢ_109AႤႢႦႧ
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

	private void ႣႨ_109A_109D_109CႥ_109E_109DႦ႙_109E()
	{
	}

	public void ႢႢႨ_109AႢ႙ႢႠ_109CႦ_109C(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void Ⴆ႙Ⴄ_109D_109AႧ႙႙_109D_109F_109D()
	{
	}

	public static string _109AႣ_109EႧ_109DႢႧ႙ႠႧႨ(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	public static string ႦႧႡ_109C_109D_109A႙ႢႡႥႤ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	private void _109BႣႡ_109D_109F_109EႢႢ_109D_109AႧ()
	{
	}

	private void _109D_109BႢ_109AႤ_109CႡ_109F_109A႙_109D()
	{
	}

	public static string ႠႦႦႨ_109F႙ႠႣ_109E_109CႢ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	private void _109C႙Ⴀ_109AႣ_109CႧ_109C_109A႙_109C()
	{
	}

	private void _109CႡႣႥႧႧႠ_109C_109DႥ႙()
	{
	}

	public void ႢႦႨႥ_109B_109AႤ_109CႣ_109D႙(ulong Ⴂ_109BႥ႙Ⴁ_109FႣႠ_109BႣ_109B, string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C, string Ⴂ_109C_109A_109A႙ႡႡ_109CႦ_109FႠ)
	{
	}

	private void _႙_109CႤႨ_109FႡႨ_109EႤႧႥ()
	{
	}

	private void _109BႨႥႠႡ႙_109BႢ_109F_109AႡ()
	{
	}

	public void _109D_109CႨႦႨႣႣ_109B႙ႢႨ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private string _109D_109AႧ_109CႡ_109CႢ႙ႣႢႧ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	private void _109BႨႥ႙ႥႣ႙Ⴀ_109D_109DႠ()
	{
	}

	private void Ⴈ_109CႠ_109D_109D_109CႣ_109E႙Ⴃ_109B()
	{
	}

	public void _႙_109F_109AႨႤ_109D_109D_109EႣ႙Ⴆ(ulong Ⴂ_109BႥ႙Ⴁ_109FႣႠ_109BႣ_109B, string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C, string Ⴂ_109C_109A_109A႙ႡႡ_109CႦ_109FႠ)
	{
	}

	public static bool Ⴅ_109EႠႠ_109B_109DႧႦႣႡႢ(string ႢႨ_109CႥ_109E႙Ⴈ_109DႡႣႢ, int ႦႧ_109F_109F_109D_109B_109BႠႡႢႣ)
	{
		return false;
	}

	private void _109BႢ_109E႙႙_109A_109E႙_109D_109BႤ()
	{
	}

	private void Ⴈ_109CႠႤႡ_109CႥႡ_109A_109BႦ()
	{
	}

	public void Ⴆ႙Ⴈ_109F_109AႡႧ႙Ⴄ_109BႧ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void Awake()
	{
	}

	private void Ⴃ_109B႙႙_109FႡႤ_109FႤႠ_109B()
	{
	}

	private void ႨႨ_109D_109FႢ_109EႨႧႣႥႨ()
	{
	}

	public static string Ⴀ_109C_109B_109AႠႤ_109F_109C_109D_109AႤ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	private void ႦႧႠႧ_109C_109C_109DႦႤ_109EႧ()
	{
	}

	public static string ႨႦႥ_109BႦ႙_109F_109EႢ_109EႣ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	private void Ⴁ႙Ⴈ_109F႙ႧႧႤႠ_109B_109A()
	{
	}

	public static string ႤႢႥ_109CႤႧႨ_109DႨႠႥ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	[SpecialName]
	public bool _႙ႣႤႨႥႨႡ_109DႡ_109DႣ()
	{
		return false;
	}

	[SpecialName]
	public bool _109AႣႦ_109F_109C_109F_109CႨႣႢ_109C()
	{
		return false;
	}

	public static bool ႤႤ_109E_109CႢႦ_109F_109C႙ႤႧ(string ႢႨ_109CႥ_109E႙Ⴈ_109DႡႣႢ, int ႦႧ_109F_109F_109D_109B_109BႠႡႢႣ)
	{
		return false;
	}

	[SpecialName]
	public bool _109B_109E_109DႨ_109E႙Ⴁ_109B႙Ⴈ_109F()
	{
		return false;
	}

	private void Ⴀ႙_109F_109DႧႧႧႧႤႥ_109B()
	{
	}

	public void _109F_109E႙Ⴀ_109BႨ_109D_109AႢ႙Ⴀ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public static string _109DႠ႙Ⴀ႙႙Ⴂ_109D_109E_109F႙(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	public void _109DႢႠႡႨ_109E_109E_109FႢႢ_109C(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public static string _109AႤႡ_109B_109D_109CႢ_109AႤႦ_109A(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	private void ႧႦႣ_109E_109AႣ_109C_109AႨ_109F_109F()
	{
	}

	private void _109EႡ_109BႦႦ_109D_109A႙ႠႡႨ()
	{
	}

	private string _109E_109D_109EႤ_109CႥႤ_109B႙႙Ⴅ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	[SpecialName]
	public void ႨႤ_109A႙ႣႦ႙ႣႥ႙_109A(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private string ႡႧႡႣႤ_109DႠ႙ႢႤႨ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	[SpecialName]
	public bool ႦႦႦ_109DႡႢႦႠႧႠႣ()
	{
		return false;
	}

	private void Ⴂ_109CႥ_109A_109FႦႥႣ_109A_109EႦ()
	{
	}

	public void Ⴃ_109FႠႥ_109F_109A_109D_109C_109EႨႤ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void _႙Ⴀ_109CႢ_109D_109BႡ_109AႢ_109BႨ()
	{
	}

	public void ႢႥ_109AႣႣႠႤႦ_109DႨႢ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void Ⴃ_109C_109E_109FႤ_109D_109E႙Ⴂ_109AႣ()
	{
	}

	[SpecialName]
	public void ႥႤ_109B_109BႢ_109E_109BႦႨႣႦ(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public void Ⴀ_109EႧႦ႙ႡႡ_109CႨ_109D_109B(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public void ႨႧ_109A_109DႣႦ_109F_109D_109F_109EႤ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void Ⴂ_109F_109FႦ_109EႨ_109CႡႨႢႠ()
	{
	}

	private void _109A_109DႥ_109AႦ_109F_109E_109D႙_109EႧ()
	{
	}

	private void _109FႣႤႦႡႡ_109D႙Ⴀ_109EႤ()
	{
	}

	public static string _109F_109CႡႦ_109A_109CႣႤ_109A_109EႥ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	public void ႤႤႠႧ_109AႡႣႧ_109AႣ_109B(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void _109C_109FႨ_109FႠ_109C_109E_109C_109FႦ_109E()
	{
	}

	[SpecialName]
	public bool ႡႥ_109BႤ_109E_109DႢ႙Ⴀ_109CႠ()
	{
		return false;
	}

	private void Ⴁ_109E_109FႡႨ႙ႧႤႥ႙_109B()
	{
	}

	public static string RemoveWhitespace(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	private void Ⴅ႙_109CႢႡႤ_109C_109A_109F_109C_109D()
	{
	}

	private void ႡႣ_109BႤႠႡႦႡ႙ႣႨ()
	{
	}

	public static string RemoveRichText(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	private void _109BႢႢ_109C_109CႦ႙ႢႠႨ_109E()
	{
	}

	private void Ⴁ_109AႡႦ_109AႣႦ_109A႙Ⴄ_109B()
	{
	}

	[SpecialName]
	public bool ႡႤ႙_109AႤ_109CႧ_109AႦႣ_109E()
	{
		return false;
	}

	public void _109D_109D_109FႧႡ_109CႢႨႢ႙_109A(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public static string _109BႨ_109E_109FႤႧႢႠ_109D_109CႥ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	public static bool _109A_109F_109BႧႢ_109BႢႢႦႢ႙(string ႢႨ_109CႥ_109E႙Ⴈ_109DႡႣႢ, int ႦႧ_109F_109F_109D_109B_109BႠႡႢႣ)
	{
		return false;
	}

	private void _109B_109A_109BႦႧႤႡႨႣႠ_109E()
	{
	}

	private void Ⴁ_109DႧႣ_109AႣ_109D_109A_109AႢ_109C()
	{
	}

	public void Ⴁ_109AႨႡ_109B_109F_109FႤႤ_109DႣ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public void Ⴁ_109DႦႤႧႨႡ_109BႨႠ_109C(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public void ႣႣ_109DႠႡႨ_109F_109D_109AႧႧ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public static bool _109F_109AႥႨ_109DႨ_109AႢႡႠ႙(string ႢႨ_109CႥ_109E႙Ⴈ_109DႡႣႢ, int ႦႧ_109F_109F_109D_109B_109BႠႡႢႣ)
	{
		return false;
	}

	[SpecialName]
	public bool ႨႣႠႢ_109AႢ_109D_109A_109C_109CႨ()
	{
		return false;
	}

	private void _109FႦႥ႙ႠႦႡ_109FႥႤႧ()
	{
	}

	public static string ႧႣ_109FႦႡႥႠ_109B_109C_109C႙(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	[SpecialName]
	public bool ႤႦႠ_109A_109AႣႨ_109AႧႢႨ()
	{
		return false;
	}

	public void Ⴆ_109FႤ႙_109A_109E_109EႧႥႨႢ(ulong Ⴂ_109BႥ႙Ⴁ_109FႣႠ_109BႣ_109B, string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C, string Ⴂ_109C_109A_109A႙ႡႡ_109CႦ_109FႠ)
	{
	}

	[SpecialName]
	public bool _109EႦ_109B_109B_109D_109AႦႤႠႣ_109B()
	{
		return false;
	}

	private void ႢႨ_109FႠ_109A_109AႥႨႦႨ_109D()
	{
	}

	private void ႤႢ_109BႣႡ_109B_109EႧ_109A_109AႤ()
	{
	}

	private void _109A_109AႥ_109A_109FႡ_109FႡႤႤႣ()
	{
	}

	private void Ⴃ_109FႢႥ_109B_109AႣႡ_109C_109E_109B()
	{
	}

	private void Update()
	{
	}

	[SpecialName]
	public void ႡႡႠ႙_109A_109CႨႡႠ_109B_109A(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	[SpecialName]
	public void _109CႡ_109BႧ_109B႙_109EႨႠ_109CႥ(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public void ႤႠႡ_109C_109F_109B_109BႢ_109B_109E႙(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void _109D_109B_109EႧႨႣ_109CႦ_109AႠႥ()
	{
	}

	[SpecialName]
	public void _109AႡႤႣ႙ႨႤႤႢႦ_109A(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public static string Ⴈ_109AႥႠႦႠႦ_109E႙ႧႤ(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	private string Ⴆ_109E_109A_109BႥႦႦ႙_109BႦႠ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	private void _109DႦႨႢ_109F_109C_109B႙ႧႦႠ()
	{
	}

	private void ႥႢႦ_109EႦႣ_109FႠ_109FႢႤ()
	{
	}

	public void Ⴁ႙ႧႧ_109DႦ_109EႡ_109FႥ_109C(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void ႨႨ_109DႠ_109EႣႣႥႨႤ_109B()
	{
	}

	private void _109F_109FႢႤႤႡ_109B႙ႨႤ_109E()
	{
	}

	public static string _109E_109AႥ_109CႠႥ_109DႨ႙ႠႨ(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	[SpecialName]
	public void Ⴀ_109BႣႡ_109CႡ_109B_109B_109E_109D_109D(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void _109BႦႠ_109EႨႡ_109FႧ႙ႤႥ()
	{
	}

	private void Ⴁ႙_109D_109DႨႠ_109DႥ႙_109AႨ()
	{
	}

	private void ႥႤ_109DႣႥ_109D_109CႦႤႡႢ()
	{
	}

	private void _109DႠ႙_109EႥ_109BႦႤႧႣ_109F()
	{
	}

	private void _109F_109EႠႣႡႧႧႣ_109BႢ_109F()
	{
	}

	[SpecialName]
	public void _109A_109EႤ_109B_109CႣႤ_109BႨ_109FႡ(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	private void Ⴂ_109BႡႣႢႨႧႥ_109BႨ_109D()
	{
	}

	public static string _109EႤ_109C_109BႨ_109EႤ႙ႧႣ_109B(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	private void ႨႣ_109DႤႨ_109AႣႧ႙Ⴅ_109C()
	{
	}

	private void ႣႣ_109A_109AႠ_109FႡ_109B_109AႦႧ()
	{
	}

	public static string ႧႣႨႥႦ_109DႣႨ႙ႧႡ(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	[SpecialName]
	public bool Ⴇ_109EႡ႙_109AႦ_109C_109EႢ_109F_109B()
	{
		return false;
	}

	public void ForceMessage(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	public static string _109CႥႥ႙Ⴅ_109EႢ_109E_109CႧႢ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	public void Ⴀ_109BႠ_109EႠ_109C_109FႤႦ_109B_109E(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private string _109EႡႤႡႧ_109D_109BႠႦ_109F_109C(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	private string ႤႡႠႥႨႢႤႤႡႧ_109F(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	private void ႠႠႤႦႧ_109D_109FႡႢႡႠ()
	{
	}

	[SpecialName]
	public void _109EႥ_109EႣ_109C_109B_109DႠႣႨႠ(bool _109D_109E_109FႡႠႨႠ_109FႢႥႧ)
	{
	}

	public static string _109DႤ_109F႙Ⴂ_109F_109AႣႦႥ_109E(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	private void Ⴆ_109A_109EႠ႙_109EႣႡ_109CႣ_109F()
	{
	}

	[SpecialName]
	public bool ႤႠႨႤႧႨ_109EႥ_109FႠ_109D()
	{
		return false;
	}

	private void _109CႤႠ_109CႢႠႦႠ_109A_109DႠ()
	{
	}

	public static bool HasConsecutiveChars(string ႢႨ_109CႥ_109E႙Ⴈ_109DႡႣႢ, int ႦႧ_109F_109F_109D_109B_109BႠႡႢႣ)
	{
		return false;
	}

	private string _109BႧႠ_109EႥ_109FႢႥႥႥ_109E(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	public void AppendMessage(ulong Ⴂ_109BႥ႙Ⴁ_109FႣႠ_109BႣ_109B, string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C, string Ⴂ_109C_109A_109A႙ႡႡ_109CႦ_109FႠ)
	{
	}

	private void _109EႧ_109B_109C႙Ⴄ_109CႡႢ_109E_109F()
	{
	}

	private void ႤႥႨႡႦႡႦ_109A႙Ⴃ_109C()
	{
	}

	public static string _109CႤႥႤႢႨႣႤ_109DႢႦ(string ႥႧ_109DႢ_109E_109AႥ_109EႥ_109D_109E)
	{
		return null;
	}

	private void ႦႡႧ_109E_109EႤ႙ႨႠႥ_109D()
	{
	}

	private void _109BႦႠ႙_109C_109CႣ_109CႡႤႣ()
	{
	}

	private void Ⴃ_109EႥႣ_109EႢႣ႙_109AႤ_109A()
	{
	}

	private string ႠႧ_109FႦႦႠႤ_109B_109F_109AႡ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	public static string _109DႥႡႢႡ_109AႢႧ႙_109DႧ(string ႨႡ_109B_109BႠႧႤႢႤႤႨ)
	{
		return null;
	}

	public void SendMessage(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}

	private void _109C_109D_109FႠႢႥႢ_109DႨ႙Ⴆ()
	{
	}

	private void ႠႦ႙ႤႠ_109B_109B_109B_109C_109C_109D()
	{
	}

	private string ႢႨ_109D႙ႧႥႡႥႡႨႤ(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
		return null;
	}

	private void _109DႡႥႣႤႤႣႥ_109CႢႨ()
	{
	}

	[SpecialName]
	public bool _109EႣႠ_109CႣႤႡ_109AႤ_109B_109B()
	{
		return false;
	}

	public static bool _109EႢ_109E_109FႠ_109BႠႧႠ_109FႢ(string ႢႨ_109CႥ_109E႙Ⴈ_109DႡႣႢ, int ႦႧ_109F_109F_109D_109B_109BႠႡႢႣ)
	{
		return false;
	}

	private void Ⴆ_109F_109A_109E_109CႤႡႣႢ_109F_109A()
	{
	}

	public void Ⴁ_109CႦႣ_109AႠႠႦႥႦ_109E(string Ⴆ_109B_109BႨ_109D႙Ⴇ_109A_109DႧ_109C)
	{
	}
}
