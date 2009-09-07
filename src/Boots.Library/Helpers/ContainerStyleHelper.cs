using System;
using System.Collections.Generic;
using System.Linq;
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

			var background = from style
								 in this.Styles
							 where style.Key.ToString() == SteelToeBoots.Library.Styles.Background.Key
							 select style;

			if (background != null)
			{
				
			}
		}
	}
}
