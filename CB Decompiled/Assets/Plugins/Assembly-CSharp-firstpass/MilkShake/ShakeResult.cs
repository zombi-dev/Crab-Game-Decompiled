using UnityEngine;

namespace MilkShake
{
	public struct ShakeResult
	{
		public Vector3 PositionShake;

		public Vector3 RotationShake;

		public static ShakeResult operator +(ShakeResult a, ShakeResult b)
		{
			return default(ShakeResult);
		}
	}
}
