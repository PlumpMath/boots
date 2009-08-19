using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Boots.Library.Elements.Helpers
{
	public class TextFontStylePair
	{
		private FontStyle style;
		private string text;

		public TextFontStylePair(string text, FontStyle style)
		{
			this.text = text;
			this.style = style;
		}

		public FontStyle Style
		{
			get { return style; }
			set { style = value; }
		}

		public string Text
		{
			get { return text; }
			set { text = value; }
		}
	}
}
