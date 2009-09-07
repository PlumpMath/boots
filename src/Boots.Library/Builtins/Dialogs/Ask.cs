using SteelToeBoots.Library.Elements;
using SteelToeBoots.Library.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteelToeBoots.Library.Builtins.Dialogs
{
	public class Ask
	{
		public static string Show(string message)
		{
			string answer = string.Empty;

			using (Form ask = new Form())
			{
				var stack = new Stack();
				var para = new Para();
				para.Text = message;
				stack.AddControl(para);

				var edit_box = new TextBox();
				stack.AddControl(edit_box);

				var button_ok = new SteelToeBoots.Library.Elements.Button();
				button_ok.Text = "OK";
				button_ok.Click += (object o, EventArgs e) => {
					answer = edit_box.Text;
					ask.Close();
				};
				stack.AddControl(button_ok);

				ask.Text = "Boots ask:";
				ask.Controls.Add(stack);

				ask.ShowDialog();
			}

			return answer;
		}
	}
}
