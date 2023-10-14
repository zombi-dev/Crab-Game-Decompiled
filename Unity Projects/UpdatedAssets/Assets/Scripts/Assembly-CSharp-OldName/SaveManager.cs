using System.Runtime.CompilerServices;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
	public PlayerSave state;

	public static SaveManager Instance
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

	public void Save()
	{
	}

	public void Load()
	{
	}

	public void NewSave()
	{
	}

	public string Serialize<T>(T toSerialize)
	{
		return null;
	}

	public T Deserialize<T>(string toDeserialize)
	{
		return default(T);
	}
}
