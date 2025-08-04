using System;
using System.Windows.Forms;
using JC.App.DotnetFrameworkViewer.Main;
/************************************************/
namespace JC.App.DotnetFrameworkViewer
{
  internal sealed class Program
  {
    [STAThread]
    private static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}