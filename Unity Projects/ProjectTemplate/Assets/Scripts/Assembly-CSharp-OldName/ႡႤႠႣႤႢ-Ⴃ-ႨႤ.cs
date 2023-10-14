using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ႡႤႠႣႤႢ_109BႣ_109DႨႤ : MonoBehaviour
{
	private Mesh _109C_109B_109A_109FႥႤႥ႙Ⴅ_109D_109D;

	private MeshFilter ႢႨ_109FႥ_109B_109AႨႧႦႡ_109C;

	public Color AdjustedColor;

	public int grassLimit;

	private Vector3 ႣႢႥႤႧႦ႙Ⴂ_109F_109D_109D;

	public int toolbarInt;

	[SerializeField]
	private List<Vector3> positions;

	[SerializeField]
	private List<Color> colors;

	[SerializeField]
	private List<int> indicies;

	[SerializeField]
	private List<Vector3> normals;

	[SerializeField]
	private List<Vector2> length;

	public bool painting;

	public bool removing;

	public bool editing;

	public int i;

	public float sizeWidth;

	public float sizeLength;

	public float density;

	public float normalLimit;

	public float rangeR;

	public float rangeG;

	public float rangeB;

	public LayerMask hitMask;

	public LayerMask paintMask;

	public float brushSize;

	private Vector3 _႙ႠႣ_109AႧႣႡႡ႙_109DႥ;

	[HideInInspector]
	public Vector3 hitPosGizmo;

	private Vector3 Ⴈ_109FႦ_109C_109C_109EႨ_109DႥ_109AႢ;

	[HideInInspector]
	public Vector3 hitNormal;

	private int[] _109BႤ_109FႢႥ_109EႢႠ_109DႧ_109D;
}
