using System;
using System.Windows.Forms;
using JC.Lib.CS.Shell;
/************************************************/
namespace JC.App.DesktopIconEditor.Main
{
  partial class MainForm
  {
    public void ToggleIcon(ListViewItem item)
    {
      if (this._Building) return;
      /************************************************/
      DesktopIcon _ = (DesktopIcon)item.Tag;
      /************************************************/
      _.Visible = item.Checked;
    }
  }
}