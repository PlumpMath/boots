using SteelToeBoots.Library.Helpers;
using SteelToeBoots.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Elements
{
	public partial class Button : System.Windows.Forms.Button, IBootsElement
	{
		public IDictionary<object, object> Styles { get; set; }
		public IBootsControl BootsControl { get; set; }

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
	}
}
