using System.Collections.Generic;
using UnityEngine;

namespace MilkShake
{
	public class Shaker : MonoBehaviour
	{
		public static List<Shaker> GlobalShakers;

		[SerializeField]
		private bool addToGlobalShakers;

		private List<ShakeInstance> activeShakes;

		public static ShakeInstance ShakeAll(IShakeParameters shakeData, int? seed = null)
		{
			return null;
		}

		public static void ShakeAllSeparate(IShakeParameters shakeData, List<ShakeInstance> shakeInstances = null, int? seed = null)
		{
		}

		public static void ShakeAllFromPoint(Vector3 point, float maxDistance, IShakeParameters shakeData, List<ShakeInstance> shakeInstances = null, int? seed = null)
		{
		}

		public static void AddShakeAll(ShakeInstance shakeInstance)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public ShakeInstance Shake(IShakeParameters shakeData, int? seed = null)
		{
			return null;
		}

		public ShakeInstance ShakeFromPoint(Vector3 point, float maxDistance, IShakeParameters shakeData, int? seed = null)
		{
			return null;
		}

		public void AddShake(ShakeInstance shakeInstance)
		{
		}
	}
}
