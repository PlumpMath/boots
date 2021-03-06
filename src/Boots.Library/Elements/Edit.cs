﻿using SteelToeBoots.Library.Helpers;
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
	[SteelToeBoots.Library.Styles.Attributes.DefaultStyle("width", 0.9)]
	public partial class Edit : TextBox, IBootsElement 
	{
		public IDictionary<object, object> Styles { get; set; }
		public IBootsControl BootsControl { get; set; }

		public Edit()
		{
			InitializeComponent();
		}

		public Edit(IDictionary<object, object> styles)
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
