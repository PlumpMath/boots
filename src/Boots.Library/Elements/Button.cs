using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library.Elements
{
	public partial class Button : System.Windows.Forms.Button
	{
		public Button()
		{
			InitializeComponent();
		}

		public Button(IDictionary<string, string> styles)
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
