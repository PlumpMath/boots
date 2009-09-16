using SteelToeBoots.Library.Interfaces;
using SteelToeBoots.Library.Styles;
using SteelToeBoots.Library.Styles.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Helpers
{
	public class StyleHelper
	{
		public Control Control { get; set; }
		public IDictionary<string, object> Styles { get; set; }

		public StyleHelper(Control control, IDictionary<object, object> styles)
		{
			this.Control = control;
			this.Control.ParentChanged += new EventHandler(Control_ParentChanged);
			this.Styles = new Dictionary<string, object>(styles.Count);
			foreach (var style in styles)
			{
				this.Styles.Add(style.Key.ToString(), style.Value);
			}
		}

		protected virtual void Control_ParentChanged(object sender, EventArgs e)
		{
			this.GetDefaultStyles();
			this.SetStyles();
		}

		public void GetDefaultStyles()
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
			}
		}

		public virtual void SetStyles()
		{
			foreach (var pair in Styles)
			{
				var class_name = pair.Key.Capitalize();
				var type = Type.GetType("SteelToeBoots.Library.Styles." + class_name);
				var style = (IStyle)Activator.CreateInstance(type);
				style.Set(pair.Value.ToString(), Control);
			}
		}
	}
}
