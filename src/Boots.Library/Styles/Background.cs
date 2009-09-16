using SteelToeBoots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Styles
{
	public class Background : IStyle
	{
		public const string Key = "background";

		public void Set(string color, Control control)
		{
			var backcolor = Color.FromName(color);
			if (backcolor.IsKnownColor)
			{
				control.BackColor = backcolor;
			}
		}
	}
}
