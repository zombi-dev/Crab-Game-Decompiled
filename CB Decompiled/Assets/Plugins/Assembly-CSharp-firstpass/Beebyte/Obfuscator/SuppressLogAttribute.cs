using System;

namespace Beebyte.Obfuscator
{
	public class SuppressLogAttribute : Attribute
	{
		private readonly MessageCode _messageCode;

		private SuppressLogAttribute()
		{
		}

		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
