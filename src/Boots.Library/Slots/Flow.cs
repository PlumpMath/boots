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
	[SteelToeBoots.Library.Styles.Attributes.DefaultStyle("height", 1.0)]
	[SteelToeBoots.Library.Styles.Attributes.DefaultStyle("width", 1.0)]
	public partial class Flow : FlowLayoutPanel, IFlow
	{
		public IDictionary<object, object> Styles { get; set; }
		public IBootsControl BootsControl { get; set; }

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



		public void AddControl(Control control)
		{
			if (control is IBootsElement)
			{
				var boots_control = new BootsControl(control);
				var styles = ((IBootsElement)control).Styles;
				boots_control.Styles = styles;
				((IBootsElement)control).BootsControl = boots_control;
			}
			this.Controls.Add(control);
		}
	}
}
