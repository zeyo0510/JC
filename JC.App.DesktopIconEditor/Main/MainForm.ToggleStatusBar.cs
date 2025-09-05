using System;
/************************************************/
namespace JC.App.DesktopIconEditor.Main
{
  partial class MainForm
  {
    public void ToggleStatusBar()
    {
      this.bottomStatusStrip.Visible = !this.bottomStatusStrip.Visible;
    }
  }
}