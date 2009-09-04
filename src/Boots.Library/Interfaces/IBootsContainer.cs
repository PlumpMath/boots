using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StealToeBoots.Library.Interfaces
{
	public interface IBootsContainer
	{
		Control.ControlCollection Controls{ get; }

		void AddControl(Control control);
	}
}
