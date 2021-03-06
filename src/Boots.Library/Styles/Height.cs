﻿using SteelToeBoots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Styles
{
	public class Height : IStyle
	{
		public const string Key = "height";

		public void Set(string value, Control control)
		{
			float height;
			if (float.TryParse(value, out height))
			{
				if (height <= 1.0)
				{
					control.Height = (int)Math.Floor(control.Parent.Height * height);
				}
				else
				{
					control.Height = (int)Math.Floor(height);
				}
			}
		}
	}
}
