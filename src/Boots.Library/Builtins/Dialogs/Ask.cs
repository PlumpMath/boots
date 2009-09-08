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

			using (var ask = new Form())
			{
				var stack_styles = new Dictionary<object, object>();
				stack_styles.Add("background", "mistyrose");
				stack_styles.Add("heigth", "1.0");
				stack_styles.Add("width", "1.0");
				var stack = new Stack(stack_styles);
				var para = new Para();
				para.Text = message;
				stack.AddControl(para);

				var edit_box = new TextBox();
				stack.AddControl(edit_box);

				var flow_styles = new Dictionary<object, object>();
				flow_styles.Add("background", "gray");
				flow_styles.Add("width", "0.9");
				var flow = new Flow(flow_styles);
				flow.FlowDirection = FlowDirection.RightToLeft;

				var button_ok = new SteelToeBoots.Library.Elements.Button();
				button_ok.Text = "OK";
				button_ok.Click += (object o, EventArgs e) => {
					answer = edit_box.Text;
					ask.Close();
				};
				flow.AddControl(button_ok);

				var button_canel = new SteelToeBoots.Library.Elements.Button();
				button_canel.Text = "Cancel";
				button_canel.Click += (object o, EventArgs e) => {
					answer = string.Empty;
					ask.Close();
				};
				flow.AddControl(button_canel);

				stack.AddControl(flow);

				ask.Text = "Boots ask:";
				//ask.AddControl(stack);
				ask.Controls.Add(stack);

				ask.ShowDialog();
			}

			return answer;
		}
	}
}
