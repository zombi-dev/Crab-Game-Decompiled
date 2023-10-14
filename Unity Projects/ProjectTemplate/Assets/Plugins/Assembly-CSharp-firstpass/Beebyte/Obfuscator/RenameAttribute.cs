using System;

namespace Beebyte.Obfuscator
{
	public class RenameAttribute : Attribute
	{
		private readonly string target;

		private RenameAttribute()
		{
		}

		public RenameAttribute(string target)
		{
		}

		public string GetTarget()
		{
			return null;
		}
	}
}
