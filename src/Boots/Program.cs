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

namespace StealToeBoots
{
	//class BootsConsoleHost : ConsoleHost
	//{
	//    protected override Type Provider
	//    {
	//        get { return typeof(RubyContext); }
	//    }

	//    protected override CommandLine/*!*/ CreateCommandLine()
	//    {
	//        return new RubyCommandLine();
	//    }

	//    protected override OptionsParser/*!*/ CreateOptionsParser()
	//    {
	//        return new RubyOptionsParser();
	//    }

	//    protected override LanguageSetup CreateLanguageSetup()
	//    {
	//        return Ruby.CreateRubySetup();
	//    }

	//    private static void SetHome()
	//    {
	//        try
	//        {
	//            PlatformAdaptationLayer platform = PlatformAdaptationLayer.Default;
	//            string homeDir = RubyUtils.GetHomeDirectory(platform);
	//            platform.SetEnvironmentVariable("HOME", homeDir);
	//        }
	//        catch (System.Security.SecurityException e)
	//        {
	//            // Ignore EnvironmentPermission exception
	//            if (e.PermissionType != typeof(System.Security.Permissions.EnvironmentPermission))
	//            {
	//                throw;
	//            }
	//        }
	//    }
			
	//    [STAThread]
	//    [RubyStackTraceHidden]
	//    static int Main(string[] args)
	//    {
	//        Ruby.CreateEngine();
	//        SetHome();
	//        return new BootsConsoleHost().Run(args);
	//    }
	//}

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
				engine.RequireRubyFile(args[0]);
			}
		}
	}
}
