using Boots.Library.Styles;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Boots.Library.Test
{
	[TestFixture]
	public class Test_styles
	{
		[Test]
		public void Test_background_is_red()
		{
			var backcolor = Color.FromName("red");
			Assert.AreEqual(Color.Red, backcolor);
			Assert.IsTrue(backcolor.IsKnownColor);
		}

		[Test]
		public void Test_background_is_empty()
		{
			var backcolor = Color.FromName("hello");
			Assert.AreEqual(0, backcolor.A);
			Assert.AreEqual(0, backcolor.R);
			Assert.AreEqual(0, backcolor.G);
			Assert.AreEqual(0, backcolor.B);
			Assert.AreEqual(0, backcolor.ToArgb());
			Assert.IsFalse(backcolor.IsKnownColor);
		}

		[Test]
		public void Test_background_is_mistyrose()
		{
			var backcolor = Color.FromName("mistyrose");
			Assert.AreEqual(Color.MistyRose, backcolor);
			Assert.IsTrue(backcolor.IsKnownColor);
		}
	}
}
