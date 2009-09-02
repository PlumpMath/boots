using Boots.Library.Interfaces;
using Boots.Library.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library.Helpers
{
	public class StyleHelper
	{
		public Control Control { get; set; }
		public IDictionary<object, object> Styles { get; set; }

		public StyleHelper(Control control, IDictionary<object, object> styles)
		{
			this.Control = control;
			this.Styles = styles;
		}

		public virtual void SetStyles()
		{
			foreach (var pair in Styles)
			{
				if (pair.Key.ToString() == Boots.Library.Styles.Width.Key)
				{
					Control.Width = Width.Set(pair.Value.ToString(), Control.Parent.Width);
				}

				if (pair.Key.ToString() == Boots.Library.Styles.Height.Key)
				{
					Control.Width = Height.Set(pair.Value.ToString(), Control.Parent.Height);
				}
			}
		}
	}
}
