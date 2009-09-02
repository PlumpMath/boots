using Boots.Library.Interfaces;
using Boots.Library.Helpers;
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
	public partial class Flow : FlowLayoutPanel, IFlow, IBootsContainer
	{
		public Flow()
		{
			InitializeComponent();
		}

		public Flow(IDictionary<object, object> styles)
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
