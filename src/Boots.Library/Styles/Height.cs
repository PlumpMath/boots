using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boots.Library.Styles
{
	static class Height
	{
		public const string Key = "height";

		public static int Set(string value, int containerHeight)
		{
			float height;
			if (float.TryParse(value, out height))
			{
				if (height < 1.0)
				{
					return (int)Math.Floor(containerHeight * height);
				}
				return (int)Math.Floor(height);
			}
			return 100;
		}
	}
}
