using System;
using System.Windows.Forms;
using JC.App.DesktopIconEditor.Main;
/************************************************/
namespace JC.App.DesktopIconEditor
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