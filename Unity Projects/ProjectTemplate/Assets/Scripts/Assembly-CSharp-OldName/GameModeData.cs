using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameModeData : ScriptableObject
{
	public enum _109EႨ_109E_109FႥ_109D_109CႠ_109DႣႤ
	{
		Waiting = 0,
		RedLightGreenLight = 1,
		Baseball = 2,
		SteppingStones = 3,
		Tag = 4,
		HideAndSeek = 5,
		BombTag = 6,
		LightsOut = 7,
		FallingPlatforms = 8,
		KingOfTheHill = 9,
		TileDrive = 10,
		HatKing = 11,
		Race = 12,
		BustlingButtons = 13,
		Practice = 14,
		Standoff = 15,
		DeathFromAbove = 16,
		ColorDrop = 17,
		SnowBrawl = 18,
		DodgeBall = 19,
		CrabFight = 20
	}

	public _109EႨ_109E_109FႥ_109D_109CႠ_109DႣႤ type;

	public Ⴃ_109AႧႥႦႠ_109B_109FႨႥႠ._109B_109DႦႧ႙_109EႧႧ_109AႣႠ musicType;

	public int minPlayers;

	public int maxPlayers;

	public int longModeTime;

	public int mediumModeTime;

	public int shortModeTime;

	public int modeTime;

	public bool waitForRoundOverToDeclareSoloWinner;

	public string modeName;

	[TextArea]
	public string modeDescription;

	public Map[] compatibleMaps;

	public Map[] largeMaps;

	public Map[] mediumMaps;

	public Map[] smallMaps;

	public int id;

	public bool isPlayable;

	public bool skipAsString;

	public int bigOnlyMapPlayers;

	public int bigAndMediumMapPlayers;

	public int mediumAndSmallMapPlayers;

	public int smallMapsOnlyPlayers;

	public Map ႠႢ_109F_109F_109A_109BႠ_109BႣႤႤ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	private List<Map> ႤႤ_109D_109E_109EႤ_109F_109B_109CႨႢ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public Type _႙_109EႥႤႨႢႦႣႠႨ_109A()
	{
		return null;
	}

	public Type Ⴈ_109BႠႥႡႠႣႥႦ_109DႦ()
	{
		return null;
	}

	private List<Map> _109EႥႥႥ_109D_109F_109BႣ_109FႠ_109A(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public int ႥႣႧ_109AႦ_109BႧႡ_109D_109DႠ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public Map _109E_109CႠ_109F_109F_109BႣႤႡ_109EႡ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	private List<Map> ႧႣ_109F_109AႠႧႧ_109CႥႣ_109F(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public Type Ⴆ_109EႢႤ_109E_109CႧ_109DႨ_109CႣ()
	{
		return null;
	}

	public bool _109CႣႡႧႠ_109F_109AႢ_109DႨ႙(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	public int Ⴂ_109AႨႡႢ_109E_109B_109AႡႦႢ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public int ႨႤႧ႙ႤႦႨ႙_109E႙_109B(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public bool ႡႢႣႦ_109F_109B_109D_109DႨ_109CႧ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	private List<Map> _109BႤႦ_109CႥ႙ႡႥႠႦႢ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public Type Ⴃ_109FႣ_109C_109CႧ_109DႤႣႤ_109D()
	{
		return null;
	}

	public bool _109DႣႣ႙Ⴂ႙Ⴇ_109BႢ_109C_109D(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	public Type _109CႥ_109FႣႦ႙Ⴈ_109E_109DႦႤ()
	{
		return null;
	}

	public Type _109FႨႣႠႤ_109B_109AႦႡ_109AႥ()
	{
		return null;
	}

	public Map _109EႦႤ_109B_109C_109D_109A_109E_109CႥ_109B(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	private List<Map> Ⴁ_109E_109CႣႧႥႢႡ_109FႤႢ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	private List<Map> ႡႤ_109AႡ_109FႢႠ_109DႤ_109BႢ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public bool ႧႧ_109CႣ_109A_109AႧ႙_109AႠႡ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	public int _109FႢႣႦႧႣ_109DႨႡႡ_109E(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public Type _109C_109FႦ႙ႢႧ_109C_109D_109BႧ_109B()
	{
		return null;
	}

	public Type ႢႧႣ_109E_109A႙Ⴈ_109DႧႡ႙()
	{
		return null;
	}

	public Type ႤႦ_109B_109CႥ_109AႢ_109CႣႥႠ()
	{
		return null;
	}

	public int ႦႢ_109DႤ႙ႤႡႢ_109AႣ_109F(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public int Ⴇ_109AႥႦႦႠ_109E_109BႤ_109E_109E(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public Map _109FႦ_109DႡႦ_109EႢ_109CႢႦ_109B(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	public bool _109E_109F_109CႨ႙Ⴇ႙႙ႠႥ_109B(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	public bool Ⴀ_109EႣ_109EႡႨႦ_109D_109BႢႥ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	public int _109B_109FႡႠႠႤ_109D_109A႙ႨႠ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public int _109FႧ_109DႡႤ_109A_109D_109BႦ_109E_109F(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public bool ႠႡ_109AႢ_109EႦႤႠႧႠႨ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	private List<Map> Ⴀ_109BႦ_109CႠႤ_109E_109CႤႥႥ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public int _109FႨ_109BႠႠ_109EႤ႙Ⴇ႙Ⴃ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public Map _႙ႦႡ_109C_109EႡႢႢ_109B_109AႦ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	private List<Map> ႤႣႣ_109CႥ_109D_109EႠႢႨႦ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public bool ႡႢ_109EႨ_109AႤႤႣ_109DႡႢ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	public int Ⴅ_109D_109C_109AႦ_109A_109C_109BႦႤႥ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public Map Ⴇ_109F_109EႣႨႤႤ_109DႧႦ_109A(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	public int ႣႥႦ_109D_109A_109FႥႣႥ_109AႨ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public Type _႙ႡႢ_109DႢႣႠႦႥႦ႙()
	{
		return null;
	}

	public Type _109DႧႧႠႠႨႡႡႢႠႨ()
	{
		return null;
	}

	private List<Map> _109D_109CႧႡႣ_109FႣ_109F_109A_109AႧ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public bool _109DႣ_109C_109D_109E_109DႤႨႦႦႣ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	public Map _႙Ⴆ_109F_109A_109CႧႤ_109BႨႡႢ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	private List<Map> _109A_109BႧ_109F_109AႨ႙_109F_109DႢႠ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	private List<Map> _109E_109BႥ_109BႢ_109EႤ_109C႙ႤႠ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public bool _109E_109EႢႠႣ_109FႥႤႣ_109BႨ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return false;
	}

	private List<Map> ႡႧ_109B_109AႧ_109D_109F_109D_109BႦ႙(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	private List<Map> ႦႢ_109C_109DႧ_109EႤ_109A_109CႤႤ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public int _109CႧႨ_109DႠ_109C_109C_109BႤ_109C_109F(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	private List<Map> Ⴅ_109CႤႠႡ႙႙ႡႠ_109DႨ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public Map ႡႦ_109C_109F႙_109D_109AႢ႙_109B_109C(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	public Type Ⴃ႙_109AႤႧႡ_109EႥ_109A_109B_109D()
	{
		return null;
	}

	public Map ႦႤႧ_109D_109DႧႤႥႨ_109FႨ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	private List<Map> Ⴄ_109EႦႧႡႤႠႢႡႦႤ(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}

	public int ႥႣႤ_109B_109AႠႥႢ_109C_109B_109E(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return 0;
	}

	public Type ႢႤ႙Ⴅ႙ႠႨ_109EႥႤ_109C()
	{
		return null;
	}

	public Map Ⴁ_109AႠႤႦႨ_109AႥႤႤႤ(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	public Type ႢႠႣ႙Ⴆ_109AႠႤ_109CႢႧ()
	{
		return null;
	}

	public Map _109BႤႢႡႣ_109E_109E_109DႠႠ_109E(int _109E_109C_109A႙Ⴁ_109DႡ_109FႤႤ_109F)
	{
		return null;
	}

	public Type ႧႣ_109B႙ႣႨ_109C_109B_109AႠႥ()
	{
		return null;
	}

	public Type _109B_109E_109DႧ_109AႡ_109CႦ_109BႦ_109E()
	{
		return null;
	}

	public Type ႢႣႢႦ_109FႤ_109FႨ႙_109D_109D()
	{
		return null;
	}

	public Type _109CႦ႙Ⴄ႙ႠႣႦ႙Ⴂ_109F()
	{
		return null;
	}

	private List<Map> Ⴄ_109B_109CႤ_109CႡႦႢႨႥ_109F(List<Map._109EႥႣႣ_109C႙_109DႡႤ_109BႣ> ႠႥႢ_109CႦ_109FႣ_109FႦ_109B_109C)
	{
		return null;
	}
}
