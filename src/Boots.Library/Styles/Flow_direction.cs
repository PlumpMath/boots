using SteelToeBoots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Styles
{
	public class Flow_direction : IStyle
	{
		public void Set(string style, Control control)
		{
			var flow_control = Convert.ChangeType(control, control.GetType());
		    
		}
	}
}
