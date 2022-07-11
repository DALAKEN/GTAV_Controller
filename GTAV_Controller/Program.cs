global using MProcess;
global using System.Diagnostics;
global using System.Runtime.InteropServices;
global using System.Net.NetworkInformation;

namespace GTAV_Tool;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
		ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
	}    
}