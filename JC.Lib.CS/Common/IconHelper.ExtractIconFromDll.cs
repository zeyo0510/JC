// https://learn.microsoft.com/en-us/windows/win32/api/shellapi/nf-shellapi-extracticonexa
// https://learn.microsoft.com/en-us/windows/win32/api/shellapi/nf-shellapi-extracticonexw
// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-destroyicon
/************************************************/
using System;
using System.Drawing;
using System.Runtime.InteropServices;
/************************************************/
namespace JC.Lib.CS.Common
{
  partial class IconHelper
  {
    [DllImport("shell32.dll", EntryPoint = "ExtractIconEx")]
    private static extern int _EXTRACT_ICON_EX_(string _LPSZ_FILE_, int _N_ICON_INDEX_, IntPtr[] _PH_ICON_LARGE_, IntPtr[] _PH_ICON_SMALL_, int _N_ICONS_);
    /************************************************/
    [DllImport("user32.dll", EntryPoint = "DestroyIcon")]
    private static extern bool _DESTROY_ICON_(IntPtr _H_ICON_);
    /************************************************/
    public static Icon ExtractIconFromDll(string path, int index = 0, bool largeIcon = false)
    {
      Icon retValue = null;
      /************************************************/
      IntPtr[] largeIcons = new IntPtr[1];
      IntPtr[] smallIcons = new IntPtr[1];
      /************************************************/
      int count = IconHelper._EXTRACT_ICON_EX_(path, index, largeIcons, smallIcons, 1);
      /************************************************/
      if (count < 0) return retValue;
      /************************************************/
      IntPtr handle = smallIcons[0];
      /************************************************/
      if (largeIcon) handle = largeIcons[0];
      /************************************************/
      if (handle != IntPtr.Zero)
      {
        retValue = (Icon)Icon.FromHandle(handle).Clone();
        /************************************************/
        IconHelper._DESTROY_ICON_(handle);
      }
      /************************************************/
      return retValue;
    }
  }
}