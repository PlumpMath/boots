using SteelToeBoots.Library.Interfaces;
using SteelToeBoots.Library.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Slots
{
	public partial class Flow : FlowLayoutPanel, IFlow, IBootsContainer
	{
		public Flow()
		{
			this.FlowDirection = FlowDirection.LeftToRight;
			InitializeComponent();
		}

		public Flow(IDictionary<object, object> styles)
		{
			this.FlowDirection = FlowDirection.LeftToRight;
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
