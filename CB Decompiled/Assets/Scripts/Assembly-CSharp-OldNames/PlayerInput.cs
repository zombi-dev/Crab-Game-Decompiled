using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	public enum CustomKeyCode
	{
		MWheelDown = -1,
		MWheelUp = -2
	}

	private float xRotation;

	public static float sensMultiplier;

	private float desiredX;

	private float mouseScroll;

	public bool active;

	private Transform playerCam;

	private Transform orientation;

	private Ⴂ_109A႙ႦႣ႙_109D_109F_109EႢ_109B playerMovement;

	private _႙Ⴃ_109D_109F_109AႤ_109B_109BႨႦ_109B detectItems;

	private Ⴈ႙႙႙ႤႤႨ_109D_109AႤႥ playerInventory;

	private ႠႠ_109F႙ႨႨႨႧႡ_109A_109F punchPlayers;

	private float actualWallRotation;

	private float wallRotationVel;

	public Vector3 cameraRot;

	private float wallRunRotation;

	public float mouseOffsetY;

	public static float sensitivity
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

	public float x
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float y
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool jumping
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

	public bool crouching
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

	public bool sprinting
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

	public static PlayerInput Instance
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

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void StopInput()
	{
	}

	public static bool CheckInputDown(int keyCode)
	{
		return false;
	}

	public static bool CheckInputUp(int keyCode)
	{
		return false;
	}

	public static bool CheckInput(int keyCode)
	{
		return false;
	}

	private void NotFrozenInput()
	{
	}

	private void AlwaysInput()
	{
	}

	private void Look()
	{
	}

	public Vector2 GetAxisInput()
	{
		return default(Vector2);
	}

	public float GetMouseX()
	{
		return 0f;
	}

	public void SetMouseOffset(float o)
	{
	}

	public float GetMouseOffset()
	{
		return 0f;
	}
}
