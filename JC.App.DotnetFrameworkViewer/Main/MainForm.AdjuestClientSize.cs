using System;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main;
/************************************************/
partial class MainForm
{
  public void AdjuestClientSize()
  {
    if (Screen.PrimaryScreen == null) return;
    /************************************************/
    float w = Screen.PrimaryScreen.WorkingArea.Width  * 0.75f;
    float h = Screen.PrimaryScreen.WorkingArea.Height * 0.75f;
    /************************************************/
    Size size = Size.Round(new(w, h));
    /************************************************/
    base.ClientSize = size;
    /************************************************/
    base.CenterToScreen();
  }
}