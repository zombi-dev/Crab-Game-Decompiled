using UnityEngine;

public abstract class GameMode : MonoBehaviour
{
	public enum Ⴄ_109AႤ_109E_109EႣႤ_109AႤႦႤ
	{
		Freeze = 0,
		Playing = 1,
		Ended = 2,
		GameOver = 3
	}

	protected _109C_109F႙႙ႦႡႥႤ_109BႢ_109A freezeTimer;

	public Ⴄ_109AႤ_109E_109EႣႤ_109AႤႦႤ modeState;

	protected float modeTime;

	private int lastTick;

	private int forcedPlayersLeft;

	private float totalRoundTime;

	public virtual void Init()
	{
	}

	private void ႣႥႥႠႡႧႡႢ_109B_109CႤ()
	{
	}

	private void Update()
	{
	}

	public void HandleStateChange(Ⴄ_109AႤ_109E_109EႣႤ_109AႤႦႤ _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E)
	{
	}

	private void ႠႠ႙႙_109D_109FႡ_109FႤ_109F_109A()
	{
	}

	public virtual void OnFreezeOverAlert()
	{
	}

	public virtual void OnPlayerGameModeLoaded(ulong _109DႤႧ_109CႠ_109FႢႧႡႤ_109D)
	{
	}

	public virtual (int, int) GetGoodBadPlayers()
	{
		return default((int, int));
	}

	public virtual void GameModeAlert(int _႙Ⴁ_109CႨႤ႙ႧႥ_109C_109F_109D)
	{
	}

	public virtual void EndRound()
	{
	}

	private void _႙Ⴄ႙ႢႢႦႤ_109DႢႥႧ()
	{
	}

	private void ႨႡႢႣႦႦႣႧႨႥႣ()
	{
	}

	protected void ႨႣႠႣႢႠႧ႙Ⴃ_109A_109C()
	{
	}

	public abstract void InitMode();

	public abstract void OnFreezeOver();

	public abstract void OnRoundOver();

	public abstract void OnPlayerSpawnOrDespawn(ulong ႧႤ_109B_109F_109BႢ_109E_109CႢ_109C_109E);

	public abstract void ModeUpdate();

	public abstract void StopGame();

	public abstract void PlayerDied(ulong _109BႨ_109BႣႥႣႢႥႦႤ_109F, ulong ႡႢႢႠႢႥႦႡ_109CႦႨ);

	public float GetFreezeTime()
	{
		return 0f;
	}

	public string GetFreezeTimeSeconds()
	{
		return null;
	}

	public void SetGameModeTimer(float ႨႠ_109DႢ_109AႢႤႧႡ_109FႡ, int _109DႢႡႢ_109D_109DႨ_109AႤ_109A_109E)
	{
	}

	public void GameOver()
	{
	}
}
