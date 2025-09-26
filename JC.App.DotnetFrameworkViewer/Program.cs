using System;
/************************************************/
using JC.App.DotnetFrameworkViewer.Main;
/************************************************/
namespace JC.App.DotnetFrameworkViewer;
/************************************************/
internal static class Program
{
  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();
    /************************************************/
    Application.Run(new MainForm());
  }
}