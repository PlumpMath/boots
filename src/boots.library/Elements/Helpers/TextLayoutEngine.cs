using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library.Elements.Helpers
{
	public class TextLayoutEngine
	{
		private IList<TextFontStylePair> textFontStylePairs;
		private Graphics graphics;
		private Font font;
		private Brush brush;
		private IList<DrawStringInfo> text_to_paint;
		private int margin;
		private int width;

		public TextLayoutEngine()//IList<TextFontStylePair> textFontStylePairs, Graphics graphics, Font font)
		{
			//this.textFontStylePairs = textFontStylePairs;
			//this.graphics = graphics;
			//this.font = font;
			this.text_to_paint = new List<DrawStringInfo>();
		}

		public TextLayoutEngine(IList<TextFontStylePair> textFontStylePairs, Graphics graphics, Font font, Brush brush, int width, int margin)
		{
			this.textFontStylePairs = textFontStylePairs;
			this.graphics = graphics;
			this.font = font;
			this.brush = brush;
			this.width = width;
			this.margin = margin;
			this.text_to_paint = new List<DrawStringInfo>();
		}

		public void Layout()
		{
			var containers = new List<TokenContainer>();

			foreach (TextFontStylePair pair in textFontStylePairs)
			{
				containers.Add(Create_TokenContainer_For_TextFontStylePair(pair));
			}

			Prepare_To_Paint_TokenContainer(containers);

			foreach (DrawStringInfo info in text_to_paint)
			{
				using (Font the_font = new Font(font, info.Style))
				{
					if (info.StartingPoint.X > 0)
					{
						string space = " ";
						SizeF space_size = graphics.MeasureString(space, the_font);
						//info.StartingPoint = new PointF(info.StartingPoint.X - space_size.Width, info.StartingPoint.Y);
					}
					graphics.DrawString(info.Text, the_font, brush, info.StartingPoint);
				}
			}
		}

		private TokenContainer Create_TokenContainer_For_TextFontStylePair(TextFontStylePair pair)
		{
			var container = new TokenContainer(pair.Style);

			foreach (string line in Split_text_with_new_lines(pair))
			{
				container.AddTokenList(Create_Token_List_From_String_Array(line, pair.Style));
			}

			return container;

		}

		private void Prepare_To_Paint_TokenContainer(List<TokenContainer> containers)
		{
			PointF point = new PointF(0, 0);
			PointF last_point = new PointF(0, 0);
			foreach (TokenContainer container in containers)
			{
				int line_number = 0;
				foreach (IList<Token> tokens in container.Tokens)
				{
					if (line_number > 0)
					{
						last_point.X = margin + 0;
						last_point.Y = last_point.Y + font.Height;
					}
					last_point = Prepare_Line_For_Painting(tokens, container.Style, last_point);
					line_number++;
				}
			}
		}

		private string[] Split_text_with_new_lines(TextFontStylePair pair)
		{
			string[] split_text = pair.Text.Split(new string[] { "\\n" }, StringSplitOptions.None);
			return split_text;
		}

		private IList<Token> Create_Token_List_From_String_Array(string line, FontStyle style)
		{
			using (Font font_with_style = new Font(font, style))
			{
				var tokenList = new List<Token>();
				string[] tokens = line.Split(new char[] { ' ' });
				for (int i = 0; i < tokens.Length; i++)
				{
					string text_to_add = tokens[i];
					if (i != tokens.Length - 1)
					{
						text_to_add += " ";
					}
					tokenList.Add(new Token(text_to_add, graphics.MeasureString(text_to_add, font_with_style)));
				}
				return tokenList;
			}
		}

		private PointF Prepare_Line_For_Painting(IList<Token> tokens, FontStyle style, PointF point)
		{
			StringBuilder sb = new StringBuilder();
			int client_width = (width - margin * 2);
			float current_width = point.X;
			PointF current_point = point;
			for (int i = 0; i < tokens.Count; )
			{
				current_width += tokens[i].Size.Width;
				if (current_width < width)
				{
					sb.Append(tokens[i].Text);
					i++;
				}
				else
				{
					text_to_paint.Add(new DrawStringInfo(sb.ToString(), style, current_point));

					current_point = new PointF(margin + 0, current_point.Y + font.Height);
					current_width = 0;
					sb = new StringBuilder();
				}
			}
			if (sb.ToString().Length > 0)
			{
				text_to_paint.Add(new DrawStringInfo(sb.ToString(), style, current_point));
			}

			return new PointF(current_width, current_point.Y);
		}
	}

	public class TokenContainer
	{
		private FontStyle style;
		private List<IList<Token>> tokensList;

		public TokenContainer(FontStyle style)
		{
			this.style = style;
			this.tokensList = new List<IList<Token>>();
		}

		public FontStyle Style
		{
			get { return style; }
		}

		public IList<IList<Token>> Tokens
		{
			get { return tokensList; }
		}

		public void AddTokenList(IList<Token> tokens)
		{
			tokensList.Add(tokens);
		}
	}

	public class Token
	{
		private SizeF size;
		private string text;

		public Token(string text, SizeF size)
		{
			this.text = text;
			this.size = size;
		}

		public SizeF Size
		{
			get { return size; }
		}

		public string Text
		{
			get { return text; }
		}
	}

	public class DrawStringInfo
	{
		private PointF startingPoint;
		private FontStyle style;
		private string text;

		public DrawStringInfo(string text, FontStyle style, PointF point)
		{
			this.text = text;
			this.style = style;
			this.startingPoint = point;
		}

		public PointF StartingPoint
		{
			get { return startingPoint; }
			set { startingPoint = value; }
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
