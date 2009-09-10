using SteelToeBoots.Library.Styles.Attributes;
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
			var element = (from types in Assembly.GetAssembly(Control.GetType()).GetExportedTypes() select Control.GetType()).First();
			if (element != null)
			{
				var default_styles = element.GetCustomAttributes(typeof(DefaultStyleAttribute), true);
				if (default_styles != null)
				{
					foreach (DefaultStyleAttribute default_style in default_styles)
					{
						if (!this.Styles.ContainsKey(default_style.Style.Key))
						{
							this.Styles.Add(default_style.Style);
						}
					}
				}
				//this.Styles.Contains(style_attributes.
			}

			base.SetStyles();
		}
	}
}
