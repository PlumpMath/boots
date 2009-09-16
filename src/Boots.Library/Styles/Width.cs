using SteelToeBoots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Styles
{
	public class Width : IStyle
	{
		public const string Key = "width";

		public void Set(string value, Control control)
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
