using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StealToeBoots.Library.Styles
{
	static class Width
	{
		public const string Key = "width";

		public static void Set(string value, Control control)
		{
			float width;
			if (float.TryParse(value, out width))
			{
				if (width <= 1.0)
				{
					control.Width = (int)Math.Floor(control.Parent.Width * width);
				}
				else
				{
					control.Width = (int)Math.Floor(width);
				}
			}
		}
	}
}
