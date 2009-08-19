using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library
{
	public partial class Canvas : Form
	{
		public Canvas()
		{
			InitializeComponent();
		}

		public void AddControl(Control control)
		{
			this.Controls.Add(control);
		}
	}
}
