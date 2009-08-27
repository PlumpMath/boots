using Boots.Library.Elements.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Boots.Library.Test
{
	[TestFixture]
	public class Test_font_style_tag_parser
	{
		/// <summary>
		/// del aka FontStyle.Strikeout
		/// </summary>
		[Test]
		public void Parse_del_text()
		{
			string text_to_parse = @"This is not struckout.  <del>This text should be struckout.</del>  But this text should not be.";
			var snippets = new FontStyleTagParser().Parse(text_to_parse);
			
			Assert.AreEqual(3, snippets.Count);
			Assert.AreEqual("This text should be struckout.", snippets[1].Text);
			Assert.AreEqual(FontStyle.Strikeout, snippets[1].Style);
		}

		/// <summary>
		/// em aka FontStyle.Italic
		/// </summary>
		[Test]
		public void Parse_em_text()
		{
			string text_to_parse = @"<em>This text should be emphasized.</em>  But this text should not be.";
			var snippets = new FontStyleTagParser().Parse(text_to_parse);

			Assert.AreEqual(2, snippets.Count);
			Assert.AreEqual("This text should be emphasized.", snippets[0].Text);
			Assert.AreEqual(FontStyle.Italic, snippets[0].Style);
		}

		/// <summary>
		/// ins aka FontStyle.Underline
		/// </summary>
		[Test]
		public void Parse_ins_text()
		{
			string text_to_parse = @"<ins>This text should be underlined.</ins>  But this text should not be.";
			var snippets = new FontStyleTagParser().Parse(text_to_parse);

			Assert.AreEqual(2, snippets.Count);
			Assert.AreEqual("This text should be underlined.", snippets[0].Text);
			Assert.AreEqual(FontStyle.Underline, snippets[0].Style);
		}

		/// <summary>
		/// strong aka FontStyle.Bold
		/// </summary>
		[Test]
		public void Parse_strong_text()
		{
			string text_to_parse = @"<strong>This text should be bold, aka strong.</strong>  But this text should not be.";
			var snippets = new FontStyleTagParser().Parse(text_to_parse);

			Assert.AreEqual(2, snippets.Count);
			Assert.AreEqual("This text should be bold, aka strong.", snippets[0].Text);
			Assert.AreEqual(FontStyle.Bold, snippets[0].Style);
			Assert.AreEqual("  But this text should not be.", snippets[1].Text);
			Assert.AreEqual(FontStyle.Regular, snippets[1].Style);
		}

		/// <summary>
		/// Test for FontStyle.Bold | FontStyle.Strikeout
		/// </summary>
		[Test]
		public void Parse_strong_ins_text()
		{
			string text_to_parse = @"<strong><ins>This text should be bold, and struckout.</ins></strong>  But this text should not be.";
			var snippets = new FontStyleTagParser().Parse(text_to_parse);

			Assert.AreEqual(2, snippets.Count);
			Assert.AreEqual("This text should be bold, and struckout.", snippets[0].Text);
			Assert.AreEqual(FontStyle.Bold | FontStyle.Underline, snippets[0].Style);
			Assert.AreEqual("  But this text should not be.", snippets[1].Text);
			Assert.AreEqual(FontStyle.Regular, snippets[1].Style);
		}

		/// <summary>
		/// Test for FontStyle.Bold | FontStyle.Strikeout
		/// </summary>
		[Test]
		public void Parse_strong_ins_and_em_text()
		{
			string text_to_parse = @"<em><ins>This text should be <strong>bold</strong>, and struckout.</ins></em>  But this text should not be.";
			var snippets = new FontStyleTagParser().Parse(text_to_parse);

			Assert.AreEqual(4, snippets.Count);
			Assert.AreEqual("This text should be ", snippets[0].Text);
			Assert.AreEqual(FontStyle.Italic | FontStyle.Underline, snippets[0].Style);
			Assert.AreEqual("bold", snippets[1].Text);
			Assert.AreEqual(FontStyle.Italic | FontStyle.Underline | FontStyle.Bold, snippets[1].Style);
			Assert.AreEqual(", and struckout.", snippets[2].Text);
			Assert.AreEqual(FontStyle.Italic | FontStyle.Underline, snippets[2].Style);
			Assert.AreEqual("  But this text should not be.", snippets[3].Text);
			Assert.AreEqual(FontStyle.Regular, snippets[3].Style);
		}

		/// <summary>
		/// FontStyle.Regular
		/// </summary>
		[Test]
		public void Parse_regular_text()
		{
			string text_to_parse = @"This is a string of regular text.";
			var snippets = new FontStyleTagParser().Parse(text_to_parse);

			Assert.AreEqual(1, snippets.Count);
			Assert.AreEqual("This is a string of regular text.", snippets[0].Text);
			Assert.AreEqual(FontStyle.Regular, snippets[0].Style);
		}
	}
}
