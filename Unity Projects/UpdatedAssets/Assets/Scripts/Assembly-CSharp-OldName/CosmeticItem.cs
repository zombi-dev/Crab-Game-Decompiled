using UnityEngine;

[CreateAssetMenu]
public class CosmeticItem : ScriptableObject
{
	public enum Ⴃ_109C_109AႤႠႦႡႧ_109B_109FႣ
	{
		None = 0,
		Hair = 1,
		Hat = 2,
		Face = 3,
		Shoes = 4,
		Other = 5,
		Box = 6,
		Top = 7,
		Backpack = 8,
		Rags = 9
	}

	public enum _109C_109FႡႥ႙Ⴇ_109AႢ_109FႧႤ
	{
		Common = 0,
		Uncommon = 1,
		Rare = 2,
		Extraordinary = 3,
		Legendary = 4,
		Original = 5,
		Unique = 6
	}

	public int itemdefid;

	public new string name;

	[TextArea]
	public string description;

	public Ⴃ_109C_109AႤႠႦႡႧ_109B_109FႣ type;

	public _109C_109FႡႥ႙Ⴇ_109AႢ_109FႧႤ rarity;

	public Texture icon;

	public Mesh mesh;

	public Material[] materials;

	public int materialToChangeColorOn;

	public int exchangeItemDefId;

	public Vector3 hatOffset;

	public Vector3 hatThresholdBeforeOffset;

	public bool ignoreOffset;
}
