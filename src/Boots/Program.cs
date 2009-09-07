using IronRuby;
using IronRuby.Hosting;
using IronRuby.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting.Hosting.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteelToeBoots
{
	static class BootsConsoleHost
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			var engine = IronRuby.Ruby.CreateEngine((setup) =>
			{
				setup.Options["Compatibility"] = RubyCompatibility.Ruby19;
			});
			if (args.Length == 1)
			{
				engine.RequireRubyFile("C:\\Dev\\Projects\\Boots\\src\\scripts\\Boots.rb");
				engine.RequireRubyFile(args[0]);
			}
		}
	}
}
