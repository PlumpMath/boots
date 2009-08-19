using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Boots.Library
{
	public class Boots
	{
		public static void Setup()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		}

		public static void Run(Canvas canvas)
		{
			Application.Run(canvas);
		}
	}
}
