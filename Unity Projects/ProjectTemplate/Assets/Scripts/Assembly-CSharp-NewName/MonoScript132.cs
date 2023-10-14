using UnityEngine;
using UnityEngine.UI;

public class _109DႨ_109AႣ_109AႨ_109A_109BႧ_109D_109C : MonoBehaviour
{
	public enum Ⴃ_109FႧႥ_109FႠ_109AႧ_109D_109CႨ
	{
		Off = 0,
		On = 1
	}

	public enum ႣႥႠ_109B_109F_109CႡႧ_109B႙_109B
	{
		Off = 0,
		Always = 1,
		Half = 2
	}

	public enum ႣႦႡ_109F_109DႡႢႣႧႡႠ
	{
		Off = 0,
		Hard = 1,
		Soft = 2
	}

	public enum _109C_109E_109FႤႥႠႢ_109A_109DႨ႙
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}

	public enum _109FႨႨႠ႙_109BႣ_109AႠ_109DႢ
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}

	public enum Ⴁ_109F_109C_109B႙ႡႨႧႤႨႧ
	{
		None = 0,
		Two = 1,
		Four = 2
	}

	public enum _႙_109FႡ_109E_109D_109D_109E_109C_109CႠ_109F
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}

	public enum _109AႤႤ_109F႙_109CႡႧႢ႙Ⴈ
	{
		Off = 0,
		x2 = 1,
		x4 = 2,
		x8 = 3
	}

	public enum Ⴃ_109B_109FႡႤႦႦႥႡႤ_109E
	{
		Off = 0,
		Fast = 1,
		Fancy = 2
	}

	public enum _109AႨ_109C_109D_109FႢ_109EႤ_109DႣ_109A
	{
		Off = 0,
		HoldToUse = 1,
		VoiceActivation = 2
	}

	public Button backBtn;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ camShake;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ fov;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ sens;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ inputDelay;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ invertedHor;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ invertedVer;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ grass;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ tutorial;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ chat;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ streamerMode;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E forward;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E backward;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E left;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E right;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E jump;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E sprint;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E interact;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E inventory;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E drop;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E map;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E crouch;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ holdCrouch;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E leftClick;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E rightClick;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ shadowQuality;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ shadowResolution;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ shadowDistance;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ shadowCascades;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ textureQuality;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ antiAliasing;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ softParticles;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ bloom;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ motionBlur;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ ao;

	public Ⴁ႙ႣႧ_109EႥႧ႙ႠႥ_109C resolution;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ fullscreen;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ fullscreenMode;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ vSync;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ fpsLimit;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ volume;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ music;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ voipVolume;

	public _109F_109EႢ_109E_109DႠႧႤ_109BႡႤ inputVolume;

	public Ⴅ_109FႥႨ_109EႣႠႧႢ_109A႙ micSetting;

	public Ⴆ_109D_109FႦႤ_109FႧႤ႙_109F_109E micButtonSetting;

	public ႠႨ_109FႣ_109F_109E႙ႠႤႢႣ deaf;

	public ႦႠႢႡႥ_109AႨ႙ႥႨႡ devices;

	private int ႥႨႧ_109A_109A_109A_109FႡ_109BႡႢ(float ႢႦ_109EႦ႙ႥႤႢ_109C_109CႤ)
	{
		return 0;
	}

	private void Ⴈ_109AႧႠႨႥႧႤႦႡႡ()
	{
	}

	private void _109D_109E_109FႡႧႤႡႥႦ_109FႧ()
	{
	}

	private void _109AႤႦ_109DႦႨႥႤႢ_109CႠ()
	{
	}

	private void _109B_109A_109F_109C_109BႢႠ_109FႡႨႢ()
	{
	}

	private void Ⴆ_109E_109A_109DႡႦ_109B႙Ⴀ_109DႣ()
	{
	}

	private void Ⴂ_109E_109AႣ႙႙ႧႨ_109FႠ_109C()
	{
	}

	private void _109CႠႢႡႨ_109DႦ_109EႨ_109CႠ()
	{
	}

	private void _109DႣႨႧႤႦႨ_109AႨႠႨ()
	{
	}

	private void ႠႥ_109B႙Ⴄ_109AႦ_109F_109EႥႦ()
	{
	}

	private void _109B_109CႠ႙_109C_109CႤ_109AႧႢႥ()
	{
	}

	private void Ⴄ_109F_109F_109C_109CႦ_109A႙_109AႦ_109F()
	{
	}

	private void _109AႡႣ_109A_109D_109DႠႦ_109D_109BႨ()
	{
	}

	private void ႨႦႥႤ_109EႡႦႥ_109AႢႢ()
	{
	}

	private void Ⴁ႙Ⴀ_109FႦႡႢ_109C_109CႨ_109B()
	{
	}

	private void _109EႤ_109EႧ_109EႦႠႨႣ႙Ⴂ()
	{
	}

	private void Ⴈ႙ႧႧႢႧႡ႙_109A_109A_109B()
	{
	}

	private void Ⴄ_109AႧ_109DႨ႙ႤႠႦႡႥ()
	{
	}

	private void _႙_109E_109EႡႢ_109D_109DႢ_109AႢ_109D()
	{
	}

	private void ႨႧႣ_109CႨႥႡႢ_109DႥႣ()
	{
	}

	private void _109EႧႡႥ_109CႦ႙ႤႤ_109BႧ()
	{
	}

	private void ႨႣႨႠႢႣႠႠ_109BႡ႙()
	{
	}

	private void ႤႡ_109FႦ_109AႣ_109DႦ_109AႣ_109E()
	{
	}

	private void _109BႧ_109B႙_109D_109F_109D_109BႥ_109EႨ()
	{
	}

	private void ႨႥ_109E႙_109CႤ_109F_109BႤ_109FႤ()
	{
	}

	private void Ⴇ_109C_109E_109F_109B႙ႨႡႠႠႣ()
	{
	}

	private void _႙Ⴀ_109E_109CႦႧႣ_109F႙ႣႦ()
	{
	}

	private void _109AႦ_109EႢ႙Ⴈ_109E_109DႡ_109BႢ()
	{
	}

	private void Ⴆ_109E_109DႢႨႦ_109DႢ_109FႦ_109D()
	{
	}

	private void Ⴈ႙ႨႦႦ_109F_109A႙_109E_109BႥ()
	{
	}

	private void _109DႣ_109FႡ_109C_109EႠႢ_109EႠ_109C()
	{
	}

	private void _109AႣႣ_109D_109AႢ_109BႦ_109C_109C_109A()
	{
	}

	private void ႧႦႧ_109F_109DႡႠ_109B_109C_109EႦ()
	{
	}

	private void Ⴃ_109FႢႡ_109AႠႥ_109BႨ_109E_109C()
	{
	}

	private void _႙_109DႦႧႡ_109CႢ_109F_109B_109FႦ()
	{
	}

	private void ႧႦႢ_109A_109DႣ_109E_109A႙ႤႧ()
	{
	}

	private void Ⴈ_109EႧႣႥႨ_109F_109D_109C_109E_109A()
	{
	}

	private void _109DႣ_109B႙_109E_109A_109C_109BႦႨႣ()
	{
	}

	private void _109BႢ႙ႡႥႠ_109B_109FႠႡႨ()
	{
	}

	private void _109FႦႣႤ႙ႡႧ_109C_109E_109C_109F()
	{
	}

	private void _109F_109FႧႢႥႥ_109F_109E_109FႥ_109E()
	{
	}

	private void _109A_109F_109BႧ_109EႧႡ_109EႧ_109A_109E()
	{
	}

	private void _109AႡ_109C႙ႢႠ_109BႢႦႤ_109B()
	{
	}

	private void _109BႤ_109D_109FႥႣ_109B_109EႤႢႡ()
	{
	}

	private void ႥႠ_109FႨ_109A_109FႤႣႣႣႡ()
	{
	}

	private void ႨႡႢႣႦႦႣႧႨႥႣ()
	{
	}

	private void _109FႥႧ_109DႢႤႧႢ_109EႧႦ()
	{
	}

	private void _109D_109F_109C_109E_109AႤႨ_109BႠ_109CႢ()
	{
	}

	private float Ⴃ႙႙_109B_109B_109CႣႢႧ_109D႙(int _႙Ⴁ_109CႨႤ႙ႧႥ_109C_109F_109D)
	{
		return 0f;
	}

	private void ႤႨ_109B_109F_109CႣႡႢႨႧ_109A()
	{
	}

	private void Ⴄ_109F_109BႢႨႧႥ_109D_109F_109BႨ()
	{
	}

	private void _109CႥႥႢႨႧ_109FႢ_109C႙Ⴅ()
	{
	}

	private void _109DႨ႙_109B႙Ⴈ_109DႦ_109C_109DႥ()
	{
	}

	private void _109C_109C_109A_109A_109CႨႣႤ_109E_109D႙()
	{
	}

	private void Ⴅ_109AႡ_109BႠႢ_109F_109DႢႠႡ()
	{
	}

	public static bool ႡႥႠႢႢႠႣႢ_109AႣႧ(int _႙Ⴁ_109CႨႤ႙ႧႥ_109C_109F_109D)
	{
		return false;
	}

	private void _109BႦႧ_109FႨ_109CႥ_109B႙Ⴈ_109A()
	{
	}

	private int _109FႨ_109C_109D_109BႨ_109EႧႦႤႦ(bool _109F_109DႥ႙_109B_109CႤႤႡႨႣ)
	{
		return 0;
	}

	private float _109DႡ႙႙_109FႥႥႥႥ_109CႠ(int _႙Ⴁ_109CႨႤ႙ႧႥ_109C_109F_109D)
	{
		return 0f;
	}

	public static bool IntToBool(int _႙Ⴁ_109CႨႤ႙ႧႥ_109C_109F_109D)
	{
		return false;
	}

	private void ႥႠႢႢႦ_109AႤႦ႙_109AႧ()
	{
	}

	public void ResetSaveFile()
	{
	}

	private void Ⴄ_109FႣႨ_109CႡႣႧ_109AႠႣ()
	{
	}

	private void ႤႣ_109EႡ_109EႤႡႠ_109CႠ_109E()
	{
	}

	private void _109EႥႢႢႣ_109C_109AႣႢ႙_109F()
	{
	}

	private void Start()
	{
	}

	private void ႠႠ_109FႥႣႠ_109F႙ႡႤ_109D()
	{
	}

	private int Ⴆ႙႙Ⴀ႙ႢႤႨ_109E႙_109E(float ႢႦ_109EႦ႙ႥႤႢ_109C_109CႤ)
	{
		return 0;
	}

	private void Ⴈ_109F_109B_109A_109FႠႥ႙႙Ⴆ_109C()
	{
	}

	private void _႙_109EႢႧ_109C_109F_109EႢႠႡ_109A()
	{
	}

	private void _109BႠ_109AႣႣႣ_109BႠ_109E_109CႨ()
	{
	}

	private void ႥႧႧ_109D_109FႡႠ_109FႡ_109EႦ()
	{
	}

	private void _109EႢ_109EႤ_109CႡ႙_109F_109F_109C_109C()
	{
	}

	private void ႢႢႦ_109EႦ႙_109CႤ_109FႨ႙()
	{
	}

	private void ႨႨ_109DႦ_109BႦ_109BႧႠႡ_109E()
	{
	}

	private void _႙_109BႥ_109DႢႧ_109EႢႢ႙_109C()
	{
	}

	private void _109E_109C႙Ⴃ_109FႠႡႦ_109AႠႨ()
	{
	}

	private void _႙_109B_109DႡ_109A_109F_109D_109CႨႦႡ()
	{
	}

	private void Ⴅ_109DႨ_109AႧႥႣႦ_109AႢ႙()
	{
	}

	private void ႧႥ_109BႣႡ_109AႠႨ_109D_109BႠ()
	{
	}

	private void _109FႧႠ_109BႨ_109F_109B_109DႧႧ_109D()
	{
	}

	private void _109B_109C_109CႠ_109C႙_109E_109E_109C႙_109E()
	{
	}

	private void Ⴁ_109AႡႥ_109DႧ_109E_109BႦႣ_109B()
	{
	}

	private void _109A_109AႣႥႢႡ႙Ⴃ_109B_109A_109E()
	{
	}

	private void Ⴀ႙_109BႡ_109F႙_109E႙_109D_109B_109B()
	{
	}

	private void _109EႤ_109DႧႥႡ႙_109EႠႨႡ()
	{
	}

	private void Ⴈ_109A_109B_109CႨႣႤ_109F_109BႤႣ()
	{
	}

	private void Ⴈ_109BႠ_109FႡႠ႙Ⴃ႙ႢႡ()
	{
	}

	private void _109F_109AႦႧႢႦ_109BႥႧႤႧ()
	{
	}

	private void ႢႧ_109B_109FႢ႙Ⴄ_109D_109CႤႧ()
	{
	}

	private void _109B_109D_109D႙_109E_109BႡ_109CႣႥႣ()
	{
	}

	private void Ⴇ_109A_109CႡ႙ႧႥ_109E_109EႥ႙()
	{
	}
}
