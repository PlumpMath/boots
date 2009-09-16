using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteelToeBoots.Library.Helpers
{
	static class StringHelper
	{
		public static string Capitalize(this string value)
		{
			if (value.Length > 0)
			{
				StringBuilder sb = new StringBuilder(value);
				sb.Replace(value[0].ToString(), value[0].ToString().ToUpper(), 0, 1);
				return sb.ToString();
			}
			else
			{
				return value;
			}
		}
	}
}
