using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boots.Library.Styles
{
	static class Width
	{
		public const string Key = "width";

		public static int SetWidth(string value, int containerWidth)
		{
			float width;
			if (float.TryParse(value, out width))
			{
				if (width < 1.0)
				{
					return (int)Math.Floor(containerWidth * width);
				}
				return (int)Math.Floor(width);
			}
			return 100;
		}
	}
}
