using System;
using System.Collections;
using System.Collections.Generic;

public class _109CႤ_109E႙Ⴇ_109F_109F_109DႤ_109FႣ : GameMode
{
	public enum _109BႧ_109FႨႣႤ_109DႣႡႣ_109A
	{
		RevealGreen = 0,
		RevealRed = 1,
		ShowTimer = 2,
		ResetButtons = 3
	}

	private int _109FႡ_109CႣႣႢ_109FႣ_109DႧႡ;

	private float ႦႦ_109DႡႠႠ_109CႥ_109C_109D_109A;

	private float ႣႢႨႡ_109AႡ_109C႙_109D_109B႙;

	private float _109E_109D_109BႡႧႤ_109BႨ_109CႦႨ;

	private float ႧႨ_109AႠ_109DႢႡႦႦ_109F_109B;

	private int _109BႠႨ_109B_109AႧ_109FႣႦႡ_109A;

	public ulong currentButtonPresser;

	public ulong nextButtonPresser;

	private bool _႙Ⴇ_109B_109CႤႤ_109BႥႢ_109E_109F;

	public List<ulong> playerOrder;

	public int playerIndex;

	public _109C_109F႙႙ႦႡႥႤ_109BႢ_109A killTimer;

	public _109C_109F႙႙ႦႡႥႤ_109BႢ_109A maxModeTimer;

	private int Ⴇ႙Ⴃ_109B႙_109BႢႧႡႦ_109D;

	private Random ႦႨ_109C_109EႤ_109B_109BႤ_109BႧႤ;

	private float _109B_109F_109BႥႢႡႨႨ_109CႨႢ;

	public void PressButton(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	private IEnumerator ႤႥ_109AႣႨႠ_109F႙ႥႤႠ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
		return null;
	}

	public void _109AႥႥႥ_109FႥႨႦႥႤႢ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	public void ResetButtons()
	{
	}

	public virtual void _႙ႠႨႥႠ_109AႤႠႣ_109BႤ(ulong _109BႨ_109BႣႥႣႢႥႦႤ_109F, ulong ႡႢႢႠႢႥႦႡ_109CႦႨ)
	{
	}

	private void ႢႦႠႡႢႠႧႢ_109E႙Ⴈ()
	{
	}

	private void Ⴅ_109CႧႣႨ_109F_109AႦႨ_109F_109C(bool ႤႠ_109AႥႠႨႧႣႤႠႢ = true)
	{
	}

	private void Ⴀ_109FႦႦႤႦႡႥႧႠႥ()
	{
	}

	public void SetNextPlayer(ulong ႡႢ႙Ⴁ_109B႙Ⴂ_109EႠ႙_109D, ulong _109A_109F႙ႧႢ_109AႥ_109C_109B_109E_109A)
	{
	}

	private void ႥႨ႙႙ႦႥ႙_109D_109BႣႠ()
	{
	}

	private void ႢႧႦ႙Ⴆ_109CႠႤႢ႙_109A()
	{
	}

	public virtual void ႧႤ_109CႧ_109DႠႨႢ_109CႠ_109D()
	{
	}

	public virtual void _႙Ⴀ_109DႦႧ႙_109A_109FႢ_109B_109B()
	{
	}

	private List<ulong> _109C_109EႦ_109FႥႧ_109AႡ_109FႧႠ()
	{
		return null;
	}

	private void ႥႨႧ_109F႙_109B_109EႦႢႦ_109D()
	{
	}

	public void ReceiveButtonStateChange(_109BႧ_109FႨႣႤ_109DႣႡႣ_109A _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E)
	{
	}

	private void Ⴃ_109C႙ႥႧႦႥ_109CႦႤႧ()
	{
	}

	private IEnumerator _႙_109BႥႨ_109B_109A႙Ⴂ_109A႙_109F(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
		return null;
	}

	public void _႙_109AႠ_109EႦ_109CႡႠ_109A_109FႧ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	public override void OnRoundOver()
	{
	}

	public void _109CႣႡ_109A_109FႠ_109DႥ_109E_109AႦ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	public virtual void Ⴀ_109CႤႦႨႥႢႢ_109EႤႦ()
	{
	}

	public virtual void _႙_109E_109DႡႦႣႨႣ_109B_109D_109D()
	{
	}

	public virtual void Ⴄ႙_109C_109C_109C_109F_109C_109CႡႨႧ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	private void _109BႥ႙ႡႠႧႣႣ_109CႢႥ()
	{
	}

	private void _109AႡႤ_109E႙_109B_109CႣ_109EႡ႙()
	{
	}

	public virtual void ႣႤ_109AႢႣႣႠႥႥ_109F_109B()
	{
	}

	private void _109F_109FႦ_109F_109E_109DႨ_109CႨ႙Ⴇ()
	{
	}

	private void ႥႢႥ_109B_109BႧ႙ႠႡ႙Ⴁ()
	{
	}

	public virtual void Ⴃ_109FႡႤႠႣႡႧ_109CႠႧ(ulong _109BႨ_109BႣႥႣႢႥႦႤ_109F, ulong ႡႢႢႠႢႥႦႡ_109CႦႨ)
	{
	}

	private void Ⴀ_109EႧ_109DႨႧႡႡ_109E_109C_109F()
	{
	}

	private IEnumerator ႢႤႡႥ_109F_109C႙ႠႠ_109BႥ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
		return null;
	}

	public virtual void ႨႧႧႥ_109A႙ႠႢ_109F_109AႨ()
	{
	}

	public override void InitMode()
	{
	}

	private void _109BႣႡ_109C_109CႡ_109CႨ_109C_109CႡ()
	{
	}

	public virtual void _109AႢ_109EႨႥ_109FႤႢႥ႙Ⴇ()
	{
	}

	public virtual void Ⴅ_109E_109D_109CႢ_109BႨႠ_109EႧ_109E()
	{
	}

	private void _109BႨႧႤႨႢႨႤ_109E_109E_109F()
	{
	}

	public virtual void Ⴅ_109A_109CႠ_109AႨႨႧ႙_109DႤ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	private void Ⴀ_109D_109DႠႦႢႢႥႣ_109AႦ()
	{
	}

	private void Ⴃ_109EႨႥႣ_109BႢႤႤႧႠ()
	{
	}

	public override void OnPlayerSpawnOrDespawn(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	public virtual void ႡႦႠ_109F_109E_109CႦႧ_109FႢႠ()
	{
	}

	public virtual void Ⴇ_109BႠ_109DႢႨႦ_109CႦ_109F_109E()
	{
	}

	public virtual void _109E_109F_109AႦႢႠႥႡႡ_109A႙()
	{
	}

	private void ႢႤႣႣ_109BႡ႙_109D_109AႢႣ()
	{
	}

	private void Ⴇ_109DႡႠႣ_109CႦ_109AႦႠႥ()
	{
	}

	public void _109EႡ႙ႡႨ႙ႢႡ_109DႤႦ()
	{
	}

	public virtual void Ⴂ_109BႥႢ_109FႨ_109A_109F_109DႥ_109E()
	{
	}

	private void _109CႡႢႧ_109E႙ႦႠႦႧ_109F()
	{
	}

	private void ႣႤႢႦ_109AႥ_109BႣႡ_109D႙()
	{
	}

	public virtual void ႤႠႦႠႥႦႢႠႡႢႧ()
	{
	}

	private void ႠႡ_109A_109E_109E_109EႨႥ႙Ⴁ_109E()
	{
	}

	public void _109CႥ_109F_109DႨႠႢႥ႙ႡႧ(ulong ႡႢ႙Ⴁ_109B႙Ⴂ_109EႠ႙_109D, ulong _109A_109F႙ႧႢ_109AႥ_109C_109B_109E_109A)
	{
	}

	public virtual void _႙Ⴄ_109DႢႥႥ_109B_109E_109FႣႦ()
	{
	}

	private IEnumerator _109CႡ_109CႨႤ႙Ⴃ_109F_109F_109B_109C(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
		return null;
	}

	public virtual void ႣႦႡႧႢႣ႙Ⴂ_109FႢႣ()
	{
	}

	private void _109FႧႨႦႧ_109CႦႣ႙Ⴄ_109F(bool ႤႠ_109AႥႠႨႧႣႤႠႢ = true)
	{
	}

	public void Ⴃ_109D_109AႠႥ_109DႡ႙ႥႤ႙(_109BႧ_109FႨႣႤ_109DႣႡႣ_109A _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E)
	{
	}

	public virtual void _႙ႠႡႠႠႣႠ_109BႧႨ႙(ulong _109BႨ_109BႣႥႣႢႥႦႤ_109F, ulong ႡႢႢႠႢႥႦႡ_109CႦႨ)
	{
	}

	public virtual void _109C_109BႦ_109BႢ_109CႧ_109AႦ_109A_109F()
	{
	}

	private IEnumerator _109DႡႥ_109C_109E_109A_109BႦ_109F_109DႡ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
		return null;
	}

	public virtual void _109BႢ_109AႠႣႦ႙_109BႢႤႦ(ulong _109BႨ_109BႣႥႣႢႥႦႤ_109F, ulong ႡႢႢႠႢႥႦႡ_109CႦႨ)
	{
	}

	public virtual void Ⴅ_109E႙_109EႧ႙_109A_109DႧ_109A_109A(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	public virtual void _109DႡႥႣ_109BႠ႙_109E_109B႙႙(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	public override void ModeUpdate()
	{
	}

	public override void StopGame()
	{
	}

	private void ႨႧႢႦႨႠႡႢႦႨ႙()
	{
	}

	private void _109BႣ_109F႙ႥႦႧႦ႙Ⴅ_109B()
	{
	}

	public void Ⴅ႙_109D_109A_109A_109C_109C_109E႙႙_109E()
	{
	}

	public void ႤႥႣ_109BႨ_109FႧ_109EႠ႙_109D(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	public override void OnFreezeOver()
	{
	}

	private void _109CႥႧ_109CႧ_109DႢ_109EႥႡ_109B()
	{
	}

	public void ႤႨႨႨႨႦႧ႙Ⴇ_109B_109F(ulong ႡႢ႙Ⴁ_109B႙Ⴂ_109EႠ႙_109D, ulong _109A_109F႙ႧႢ_109AႥ_109C_109B_109E_109A)
	{
	}

	public void Ⴈ_109F_109F႙ႢႥ_109CႥႡ_109EႦ(_109BႧ_109FႨႣႤ_109DႣႡႣ_109A _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E)
	{
	}

	public void ႧႤ_109EႧ_109BႤႠႦႣ_109EႢ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	public void Ⴁ_109B႙ႠႡႢ_109D_109A_109BႤ_109C(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	public virtual void _109EႨႣ_109DႠႠ_109CႦ႙_109A_109E()
	{
	}

	private void ႦႦႨႠႧႥ_109F_109C_109AႧႧ()
	{
	}

	public virtual void ႧႡႣ_109C_109EႨ႙_109BႦ_109FႨ()
	{
	}

	private void _109BႦႦ_109AႢ_109E_109DႡ_109BႠ_109E()
	{
	}

	public void ႢႧ႙ႨႤႤႥ_109AႨႤႦ(ulong ႡႢ႙Ⴁ_109B႙Ⴂ_109EႠ႙_109D, ulong _109A_109F႙ႧႢ_109AႥ_109C_109B_109E_109A)
	{
	}

	private void _႙Ⴈ႙ႢႨႨ_109CႤ_109DႣႠ()
	{
	}

	private void _109B႙ႣႢႨႨ_109B_109D_109D_109B_109D()
	{
	}

	public virtual void Ⴂ_109B_109C_109B_109DႠႥႦ_109DႤႧ()
	{
	}

	public void ႨႣႧႣႦ_109C_109AႠႨႧႡ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	public void ႦႡႥ႙ႤႨႡႥႠႨႢ(ulong ႡႢ႙Ⴁ_109B႙Ⴂ_109EႠ႙_109D, ulong _109A_109F႙ႧႢ_109AႥ_109C_109B_109E_109A)
	{
	}

	public virtual void ႨႨ_109F_109BႨ_109EႢႣႠႤႧ(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E)
	{
	}

	private void ႥႣ_109D_109EႡ_109E_109CႥႦႨႣ()
	{
	}

	private IEnumerator _109EႠႢႧႧႤႥ႙ႣႧ_109F(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
		return null;
	}

	public virtual void ႨႧ_109AႥႧႣႧ_109CႠႢႠ(ulong _109BႨ_109BႣႥႣႢႥႦႤ_109F, ulong ႡႢႢႠႢႥႦႡ_109CႦႨ)
	{
	}

	public virtual void ႤႧႥႧ_109BႡႢႥႢ_109C_109E()
	{
	}

	public void _109D_109AႠ_109FႠႦႦ_109F_109AႡႤ()
	{
	}

	public void _109BႥႥႤ_109FႨႧႨႥႨ_109C()
	{
	}

	private void _109BႡႥ_109FႨႦႠ_109C_109D_109F_109E()
	{
	}

	public void ႣႧ႙_109EႨႠႤႤႣႤႦ(_109BႧ_109FႨႣႤ_109DႣႡႣ_109A _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E)
	{
	}

	public virtual void ႢႨ_109D႙_109A_109E_109DႥႥ_109BႣ()
	{
	}

	public void ServerReceivedButtonPress(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E, int _109EႣႧႡ_109C_109AႠႥႥ_109AႤ)
	{
	}

	private void _109AႠ_109FႣ_109FႨႧႠႢ_109AႢ()
	{
	}

	public override void PlayerDied(ulong _109BႨ_109BႣႥႣႢႥႦႤ_109F, ulong ႡႢႢႠႢႥႦႡ_109CႦႨ)
	{
	}

	public virtual void _109BႤ_109E_109BႠ_109C႙Ⴈ_109F_109B_109C()
	{
	}

	private void ႥႦ_109B_109D_109DႣႠႡ_109EႤႣ(bool ႤႠ_109AႥႠႨႧႣႤႠႢ = true)
	{
	}

	private List<ulong> ႤႣႤႢ႙_109EႦႢ႙_109C_109F()
	{
		return null;
	}
}
