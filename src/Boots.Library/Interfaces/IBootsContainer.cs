using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library.Interfaces
{
	public interface IBootsContainer
	{
		Control.ControlCollection Controls{ get; }

		void AddControl(Control control);
	}
}
