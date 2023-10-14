using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 40)]
	public struct InputMotionData_t
	{
		public float rotQuatX;

		public float rotQuatY;

		public float rotQuatZ;

		public float rotQuatW;

		public float posAccelX;

		public float posAccelY;

		public float posAccelZ;

		public float rotVelX;

		public float rotVelY;

		public float rotVelZ;
	}
}
