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

namespace SteelToeBoots.Library
{
	public partial class Canvas : Form, IBootsContainer
	{
		public IDictionary<object, object> Styles { get; set; }
		public IBootsControl BootsControl { get; set; }

		public Canvas()
		{
			InitializeComponent();
			this.verticalScrollBar.Visible = false;
		}

		public void AddControl(Control control)
		{
			this.canvasFlow.AddControl(control);
		}
	}
}
