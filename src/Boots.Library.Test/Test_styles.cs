using NUnit.Framework;
using SteelToeBoots.Library.Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Test
{
	[TestFixture]
	public class Test_styles
	{
		[Test]
		public void Test_background_is_red()
		{
			var control = new Control();
			//Background.Set("red", control);
			Assert.AreEqual(Color.Red, control.BackColor);
			Assert.IsTrue(control.BackColor.IsKnownColor);
		}

		[Test]
		public void Test_background_is_empty()
		{
			var control = new Control();
			//Background.Set("hello", control);
			var backcolor = Color.FromName("hello");
			Assert.AreEqual(0, control.BackColor.A);
			Assert.AreEqual(0, control.BackColor.R);
			Assert.AreEqual(0, control.BackColor.G);
			Assert.AreEqual(0, control.BackColor.B);
			Assert.AreEqual(0, control.BackColor.ToArgb());
			Assert.IsFalse(backcolor.IsKnownColor);
		}

		[Test]
		public void Test_background_is_mistyrose()
		{
			var control = new Control();
			//Background.Set("mistyrose", control);
			Assert.AreEqual(Color.MistyRose, control.BackColor);
			Assert.IsTrue(control.BackColor.IsKnownColor);
		}
	}
}
