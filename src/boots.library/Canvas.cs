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

namespace Boots.Library
{
	public partial class Canvas : Form, IBootsContainer
	{
		public Canvas()
		{
			InitializeComponent();
		}

		public void AddControl(Control control)
		{
			control.Location = this.NextPosition();
			System.Diagnostics.Debug.WriteLine(string.Format("Top {0}, Left {1}", control.Location.Y, control.Location.X));
			this.Controls.Add(control);
		}
	}
}
