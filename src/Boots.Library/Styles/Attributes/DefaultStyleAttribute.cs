using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteelToeBoots.Library.Styles.Attributes
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class DefaultStyleAttribute : Attribute
	{
		public DefaultStyleAttribute(string style, object value)
		{
			this.Style = new KeyValuePair<string, object>(style, value);
		}

		public KeyValuePair<string, object> Style { get; private set; }
	}
}
