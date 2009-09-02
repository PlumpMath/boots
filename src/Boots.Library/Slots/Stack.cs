
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
		public Stack()
		{
			InitializeComponent();
		}

		public Stack(IDictionary<object, object> styles)
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		public void AddControl(Control control)
		{
			this.Controls.Add(control);
		}
	}
}
