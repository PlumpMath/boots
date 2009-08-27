using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Boots.Library.Elements.Helpers
{
	public class FontStyleTagParser
	{
		private const string REGULAR_EXPRESSION = @"<del>|</del>|<em>|</em>|<ins>|</ins>|<strong>|</strong>";
		private const string BEGINNING_DEL_TAG = @"<del>";
		private const string BEGINNING_EM_TAG = @"<em>";
		private const string BEGINNING_INS_TAG = @"<ins>";
		private const string BEGINNING_STRONG_TAG = @"<strong>";
		private const string ENDING_DEL_TAG = @"</del>";
		private const string ENDING_EM_TAG = @"</em>";
		private const string ENDING_INS_TAG = @"</ins>";
		private const string ENDING_STRONG_TAG = @"</strong>";

		private IList<TextFontStylePair> snippets;
		private Stack<FontStyle> styles;

		public FontStyleTagParser()
		{
			this.snippets = new List<TextFontStylePair>();
			this.styles = new Stack<FontStyle>();
			this.styles.Push(FontStyle.Regular);
		}

		public IList<TextFontStylePair> Parse(string text)
		{
			var expression = new Regex(REGULAR_EXPRESSION);
			var matches = expression.Matches(text);
			var captures = createCaptureList(matches);			

			FontStyle currentStyle = FontStyle.Regular;
			//var previousStyle = FontStyle.Regular;
			int startIndex = 0;

			foreach (Capture capture in captures)
			{
				string snippet = text.Substring(startIndex, capture.Index - startIndex);
				startIndex = addSnippetAndReturnNewIndex(snippet, currentStyle, capture, startIndex);
				//previousStyle = currentStyle;
				currentStyle = determineNextStyleFromCapture(capture);
			}

			if (startIndex < text.Length)
			{
				addSnippet(text.Substring(startIndex, text.Length - startIndex), FontStyle.Regular);
			}

			return snippets;
		}

		private IList<Capture> createCaptureList(MatchCollection matches)
		{
			IList<Capture> captures = new List<Capture>();
			foreach (Match match in matches)
			{
				foreach (Capture capture in match.Captures)
				{
					captures.Add(capture);
				}
			}
			return captures;
		}

		private void addSnippet(string text, FontStyle style)
		{
			snippets.Add(new TextFontStylePair(text, style));
		}

		private int addSnippetAndReturnNewIndex(string text, FontStyle style, Capture capture, int currentindex)
		{
			int index = currentindex;
			if (text != string.Empty)
			{
				addSnippet(text, style);
				index = capture.Index + capture.Length;
			}
			else
			{
				index += capture.Length;
			}
			return index;
		}

		private FontStyle determineNextStyleFromCapture(Capture capture)
		{
			FontStyle newStyle = FontStyle.Regular;
			if (this.styles.Count > 0)
			{
				newStyle = this.styles.Peek();
			}
			switch (capture.Value)
			{
				case BEGINNING_DEL_TAG:
					newStyle = newStyle | FontStyle.Strikeout;
					this.styles.Push(newStyle);
					break;
				case BEGINNING_EM_TAG:
					newStyle = newStyle | FontStyle.Italic;
					this.styles.Push(newStyle);
					break;
				case BEGINNING_INS_TAG:
					newStyle = newStyle | FontStyle.Underline;
					this.styles.Push(newStyle);
					break;
				case BEGINNING_STRONG_TAG:
					newStyle = newStyle | FontStyle.Bold;
					this.styles.Push(newStyle);
					break;

				case ENDING_DEL_TAG:
					newStyle = this.styles.Pop() ^ FontStyle.Strikeout;
					break;
				case ENDING_EM_TAG:
					newStyle = this.styles.Pop() ^ FontStyle.Italic;
					break;
				case ENDING_INS_TAG:
					newStyle = this.styles.Pop() ^ FontStyle.Underline;
					break;
				case ENDING_STRONG_TAG:
					newStyle = this.styles.Pop() ^ FontStyle.Bold;
					break;
			}
			return newStyle;
		}
	}
}
