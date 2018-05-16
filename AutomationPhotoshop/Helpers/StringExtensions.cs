

namespace Helpers
{
	
	
	using System;
	using System.Text;
	
	public static class StringExtensions
	{
		public static StringBuilder Append(this string s)
		{
			
			var sb = new StringBuilder();
			sb.Append(s);
			
			return sb;
		}
	}
}
