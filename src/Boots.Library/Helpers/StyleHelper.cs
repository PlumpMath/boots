using SteelToeBoots.Library.Interfaces;
using SteelToeBoots.Library.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
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
			this.Styles = new Dictionary<string, object>(styles.Count);
			foreach (var style in styles)
			{
				this.Styles.Add(style.Key.ToString(), style.Value);
			}
		}

		public virtual void SetStyles()
		{
			foreach (var pair in Styles)
			{
				if (pair.Key == SteelToeBoots.Library.Styles.Width.Key)
				{
					Width.Set(pair.Value.ToString(), Control);
				}

				if (pair.Key == SteelToeBoots.Library.Styles.Height.Key)
				{
					Height.Set(pair.Value.ToString(), Control);
				}

				if (pair.Key == SteelToeBoots.Library.Styles.Background.Key)
				{
					Background.Set(pair.Value.ToString(), Control);
				}
			}
		}
	}
}
