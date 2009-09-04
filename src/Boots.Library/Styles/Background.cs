using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StealToeBoots.Library.Styles
{
	static class Background
	{
		public const string Key = "background";

		public static void Set(string color, Control control)
		{
			var backcolor = Color.FromName(color);
			if (backcolor.IsKnownColor)
			{
				control.BackColor = backcolor;
			}
		}
	}
}
