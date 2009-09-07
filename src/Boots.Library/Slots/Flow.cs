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
		protected IDictionary<object, object> Styles { get; private set; }

		public Flow()
		{
			this.FlowDirection = FlowDirection.LeftToRight;
			InitializeComponent();
		}

		public Flow(IDictionary<object, object> styles)
		{
			this.FlowDirection = FlowDirection.LeftToRight;
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
				new ContainerStyleHelper(this, this.Styles).SetStyles();
			}
			base.OnParentChanged(e);
		}

		public void AddControl(Control control)
		{
			this.Controls.Add(control);
		}
	}
}
