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
	public class BootsControl : IBootsControl
	{
		public Control Control { get; set; }
		public IDictionary<object, object> Styles
		{
			get { return styles; }
			set
			{
				styles = value;
				ConvertDictionary();
				GetDefaultStyles();
			}
		}
		private IDictionary<object, object> styles;
		protected IDictionary<string, object> converted_key_styles { get; set; }

		public BootsControl(Control control)
		{
			this.Control = control;
			this.Control.ParentChanged += new EventHandler(Control_ParentChanged);
			this.converted_key_styles = new Dictionary<string, object>();
		}

		protected virtual void Control_ParentChanged(object sender, EventArgs e)
		{
			SetStyles();
		}

		//public virtual void Control_Resize(object sender, EventArgs e)
		public virtual void Resize()
		{
			if (converted_key_styles.ContainsKey("height"))
			{
				var height = new SteelToeBoots.Library.Styles.Height();
				var height_value = converted_key_styles["height"].ToString();
				height.Set(height_value, Control);
			}

			if (converted_key_styles.ContainsKey("width"))
			{
				var width = new SteelToeBoots.Library.Styles.Width();
				width.Set(converted_key_styles["width"].ToString(), Control);
			}
		}

		protected virtual void GetDefaultStyles()
		{
			var element = (from exported_types in Assembly.GetAssembly(Control.GetType()).GetExportedTypes() select Control.GetType()).First();
			if (element != null)
			{
				var default_styles = element.GetCustomAttributes(typeof(DefaultStyleAttribute), true);
				if (default_styles != null)
				{
					foreach (DefaultStyleAttribute default_style in default_styles)
					{
						if (!this.converted_key_styles.ContainsKey(default_style.Style.Key))
						{
							this.converted_key_styles.Add(default_style.Style);
						}
					}
				}
			}
		}

		protected virtual void ConvertDictionary()
		{
			if (styles != null)
			{
				foreach (var style in styles)
				{
					this.converted_key_styles.Add(style.Key.ToString(), style.Value);
				}
			}
		}

		public virtual void SetStyles()
		{
			foreach (var pair in converted_key_styles)
			{
				var class_name = pair.Key.Capitalize();
				var type = Type.GetType("SteelToeBoots.Library.Styles." + class_name);
				var style = (IStyle)Activator.CreateInstance(type);
				style.Set(pair.Value.ToString(), Control);
			}
		}
	}
}