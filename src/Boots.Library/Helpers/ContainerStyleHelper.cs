using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Helpers
{
	public class ContainerStyleHelper : StyleHelper
	{
		public ContainerStyleHelper(Control control, IDictionary<object, object> styles)
			: base(control, styles) { }

		public override void SetStyles()
		{
			base.SetStyles();
		}
	}
}
