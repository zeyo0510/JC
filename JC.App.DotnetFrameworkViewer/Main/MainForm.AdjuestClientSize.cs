using System;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main
{
  partial class MainForm
  {
    public void AdjuestClientSize()
    {
      float w = Screen.PrimaryScreen.WorkingArea.Width  * 0.75f;
      float h = Screen.PrimaryScreen.WorkingArea.Height * 0.75f;
      /************************************************/
      Size size = Size.Round(new SizeF(w, h));
      /************************************************/
      base.ClientSize = size;
      /************************************************/
      base.CenterToScreen();
    }
  }
}