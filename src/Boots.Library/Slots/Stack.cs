using Boots.Library.Helpers;
using Boots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library.Slots
{
	public partial class Stack : FlowLayoutPanel, IStack
	{
		protected IDictionary<object, object> Styles { get; private set; }

		public Stack()
		{
			InitializeComponent();
		}

		public Stack(IDictionary<object, object> styles)
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

		public void AddControl(Control control)
		{
			this.Controls.Add(control);
		}
	}
}
