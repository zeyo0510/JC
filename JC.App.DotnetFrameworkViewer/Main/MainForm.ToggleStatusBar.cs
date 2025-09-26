using System;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main;
/************************************************/
partial class MainForm
{
  public void ToggleStatusBar()
  {
    this.bottomStatusStrip.Visible = !this.bottomStatusStrip.Visible;
  }
}