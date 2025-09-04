using System;
using JC.Lib.CS.Common;
using Microsoft.Win32;
/************************************************/
namespace JC.Lib.CS.Shell
{
  partial class DesktopIcon
  {
    public bool Visible
    {
      get
      {
        bool retValue = false;
        /************************************************/
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel\");
        /************************************************/
        retValue = Convert.ToInt32(key.GetValue(this.GUID)) == 0;
        /************************************************/
        return retValue;
      }
      set
      {
        if (this.Visible == value) return;
        /************************************************/
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel\", true);
        /************************************************/
        key.SetValue(this.GUID, Convert.ToInt32(!value), RegistryValueKind.DWord);
        /************************************************/
        DesktopHelper.RefreshDesktop();
      }
    }
  }
}