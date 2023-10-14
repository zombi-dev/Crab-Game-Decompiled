using System;
using System.Runtime.CompilerServices;

namespace SteamworksNative
{
	internal class CallbackIdentityAttribute : Attribute
	{
		public int Identity
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CallbackIdentityAttribute(int callbackNum)
		{
		}
	}
}
