using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Builtins.Dialogs
{
	public class Alert
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public static void Show(string message)
		{
			MessageBox.Show(message, "Boots says:");
		}
	}
}
