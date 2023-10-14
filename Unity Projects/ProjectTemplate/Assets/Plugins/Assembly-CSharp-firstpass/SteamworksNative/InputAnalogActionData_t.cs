using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 1, Size = 13)]
	public struct InputAnalogActionData_t
	{
		public EInputSourceMode eMode;

		public float x;

		public float y;

		public byte bActive;
	}
}
