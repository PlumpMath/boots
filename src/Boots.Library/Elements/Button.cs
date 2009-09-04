using StealToeBoots.Library.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StealToeBoots.Library.Elements
{
	public partial class Button : System.Windows.Forms.Button
	{
		protected IDictionary<object, object> Styles { get; private set; }

		public Button()
		{
			InitializeComponent();
		}

		public Button(IDictionary<object, object> styles)
		{
			this.Styles = styles;
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		protected override void OnParentChanged(EventArgs e)
		{
			if (this.Styles != null)
			{
				new StyleHelper(this, this.Styles).SetStyles();
			}
			base.OnParentChanged(e);
		}
	}
}
