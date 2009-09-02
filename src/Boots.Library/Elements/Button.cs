using Boots.Library.Helpers;
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

		public Button(IDictionary<object, object> styles)
		{
			this.Styles = styles;
			InitializeComponent();
		}

		protected IDictionary<object, object> Styles { get; private set; }

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
