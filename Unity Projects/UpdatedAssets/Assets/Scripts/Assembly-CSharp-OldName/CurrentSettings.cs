using UnityEngine;

public class CurrentSettings : MonoBehaviour
{
	public static bool cameraShake;

	public static bool grass;

	public static bool invertedHor;

	public static bool invertedVer;

	public float sensMultiplier;

	public int fov;

	public bool tutorial;

	public static bool holdCrouch;

	public static float volume;

	public static float music;

	public static float voip;

	public static _109DႨ_109AႣ_109AႨ_109A_109BႧ_109D_109C._109AႨ_109C_109D_109FႢ_109EႤ_109DႣ_109A micSetting;

	public int deaf;

	public string micDevice;

	public static CurrentSettings Instance;

	public static bool lastSentVcOn;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void InitSettings()
	{
	}

	public void UpdateSave()
	{
	}

	public void UpdateCamShake(bool b)
	{
	}

	public void UpdateSens(float i)
	{
	}

	public void UpdateInputDelay(int i)
	{
	}

	public void UpdateFov(float i)
	{
	}

	public void UpdateInverted(bool hor, bool ver)
	{
	}

	public void UpdateGrass(bool b)
	{
	}

	public void UpdateTutorial(bool b)
	{
	}

	public void UpdateChat(bool b)
	{
	}

	public void UpdateStreamerMode(bool b)
	{
	}

	public void UpdateHoldCrouch(bool b)
	{
	}

	public void UpdateShadowQuality(int i)
	{
	}

	public void UpdateShadowResolution(int i)
	{
	}

	public void UpdateShadowCascades(int i)
	{
	}

	public void UpdateShadowDistance(int i)
	{
	}

	public void UpdateTextureQuality(int i)
	{
	}

	public void UpdateAntiAliasing(int i)
	{
	}

	public void UpdateSoftParticles(bool b)
	{
	}

	public void UpdateBloom(int i)
	{
	}

	public void UpdateMotionBlur(bool b)
	{
	}

	public void UpdateAO(bool b)
	{
	}

	public void UpdateResolution(int width, int height, int refreshRate)
	{
	}

	public void UpdateFullscreen(bool i)
	{
	}

	public void UpdateFullscreenMode(int i)
	{
	}

	public void UpdateVSync(int i)
	{
	}

	public void UpdateMaxFps(int i)
	{
	}

	public void UpdateVolume(int i)
	{
	}

	public void UpdateMusic(int i)
	{
	}

	public void UpdateVoip(int i)
	{
	}

	public void UpdateMicSetting(int i)
	{
	}

	public void UpdateDeaf(int i)
	{
	}
}
