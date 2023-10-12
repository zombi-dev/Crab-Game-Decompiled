using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

namespace SteamworksNative
{
	public class InteropHelp
	{
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			public UTF8StringHandle(string str)
				: base(ownsHandle: false)
			{
			}

			protected override bool ReleaseHandle()
			{
				return false;
			}
		}

		public class SteamParamStringArray
		{
			private IntPtr[] m_Strings;

			private IntPtr m_ptrStrings;

			private IntPtr m_pSteamParamStringArray;

			public SteamParamStringArray(IList<string> strings)
			{
			}

			~SteamParamStringArray()
			{
			}

			public static implicit operator IntPtr(SteamParamStringArray that)
			{
				return (IntPtr)0;
			}
		}

		public static void TestIfPlatformSupported()
		{
		}

		public static void TestIfAvailableClient()
		{
		}

		public static void TestIfAvailableGameServer()
		{
		}

		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}

		public static string ByteArrayToStringUTF8(byte[] buffer)
		{
			return null;
		}

		public static void StringToByteArrayUTF8(string str, byte[] outArrayBuffer, int outArrayBufferSize)
		{
		}
	}
}
