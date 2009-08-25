using Boots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library.Helpers
{
	static class ContainerLayoutHelper
	{
		public static Point NextPosition(this IBootsContainer container)
		{
			if (container.Controls.Count == 1)
			{
				return new Point(0, 0);
			}
			else
			{
				var lastControl = container.Controls[container.Controls.Count - 1];
				return new Point(lastControl.Location.X, lastControl.Location.Y + lastControl.Height);
			}
			
		}
	}
}
