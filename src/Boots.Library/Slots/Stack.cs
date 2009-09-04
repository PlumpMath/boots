using StealToeBoots.Library.Helpers;
using StealToeBoots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StealToeBoots.Library.Slots
{
	public partial class Stack : FlowLayoutPanel, IStack
	{
		protected IDictionary<object, object> Styles { get; private set; }

		public Stack()
		{
			this.FlowDirection = FlowDirection.TopDown;
			InitializeComponent();
		}

		public Stack(IDictionary<object, object> styles)
		{
			this.FlowDirection = FlowDirection.TopDown;
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
