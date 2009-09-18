using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Interfaces
{
	public interface IBootsControl
	{
		Control Control { get; set; }
		IDictionary<object, object> Styles { get; set; }
	}
}
