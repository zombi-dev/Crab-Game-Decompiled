using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class ႠႧႢႨ_109E_109BႣ_109F_109B႙Ⴀ : Ⴇ_109FႦ_109E_109E_109AႣ_109AႤ_109EႡ, ႨႨ_109C_109A_109AႧ႙Ⴅ_109DႧ_109F
{
	public ItemData itemData;

	protected bool _109F႙Ⴈ_109BႡ_109FႣႠႧႠ႙;

	public GameObject pickupFx;

	public Transform rightHandTarget;

	public Transform leftHandTarget;

	protected Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C ႠႡႧ႙_109AႡ႙ႦႦႢ_109E;

	public bool _109C_109CႢႡ_109CႤႦ_109A_109D_109D_109D
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

	private new void Start()
	{
	}

	protected virtual void _႙Ⴄ_109AႣ_109AႦ_109DႠႦႥႥ()
	{
	}

	private void Reset()
	{
	}

	public abstract void TryUse(Transform _႙ႣႢ_109AႥႨ_109DႠႥ_109CႠ);

	public abstract void LocalUse(Transform _109DႤႢႦႥႨႤႡ_109D_109BႢ);

	public abstract void AllUse(Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ, int _109B_109AႧ_109EႣ_109AႣႥ_109E_109AႢ = -1, bool _109B_109EႢ_109B႙Ⴂ_109AႨႤ_109F_109D = false);

	public abstract void OnlineUse(Vector3 _109EႤႥႠႣႢႠႦ_109D႙Ⴅ, ulong _႙Ⴈ_109DႨႠ_109EႡႡႨႡႧ);

	public abstract void MouseUp();

	public virtual bool TryReload()
	{
		return false;
	}

	public void SetOwner(Ⴅ_109A_109E_109E႙ႨႨ_109A_109D_109F_109C _109EႡ_109EႣႤႨ_109FႥႥႠ_109A)
	{
	}

	public virtual void Equip()
	{
	}

	private void _109D_109A႙Ⴇ_109F႙_109BႨ_109E_109CႧ()
	{
	}

	public void TryInteract()
	{
	}

	public void LocalInteract()
	{
	}

	public void ServerInteract(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	public void AllInteract(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	public bool CanInteract()
	{
		return false;
	}

	private void _109B_109DႨ_109EႡ_109EႡ_109FႢႣ_109D()
	{
	}

	public void InstanceData()
	{
	}
}
