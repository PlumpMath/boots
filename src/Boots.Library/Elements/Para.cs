using Boots.Library.Elements.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boots.Library.Elements
{
	public partial class Para : Label
	{
		public Para()
		{
			InitializeComponent();
		}

		public override bool AutoSize
		{
			get
			{
				return base.AutoSize;
			}
			set
			{
				base.AutoSize = false;
			}
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			if (!DesignMode)
			{
				IList<TextFontStylePair> pairs = new FontStyleTagParser().Parse(this.Text);
				TextLayoutEngine layout = new TextLayoutEngine(pairs, pe.Graphics, Font, new SolidBrush(ForeColor), this.Width, 0);
				layout.Layout();
				UpdateSize(layout.NumberOfLines);
			}
			else
			{
				base.OnPaint(pe);
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			UpdateSize();
			base.OnTextChanged(e);
		}

		private void UpdateSize()
		{
			using (Graphics g = this.CreateGraphics())
			{
				SizeF size = g.MeasureString(this.Text, this.Font, this.Width);
				this.Height = (int)Math.Ceiling(size.Height);
			}
		}

		private void UpdateSize(int rows)
		{
			//using (Graphics g = this.CreateGraphics())
			//{
				//SizeF size = g.MeasureString(this.Text, this.Font, this.Width);
				this.Height = rows * this.Font.Height;
			//}
		}
	}
}
