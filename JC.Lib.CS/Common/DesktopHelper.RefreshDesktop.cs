// https://learn.microsoft.com/en-us/windows/win32/api/shlobj_core/nf-shlobj_core-shchangenotify
/************************************************/
using System;
using System.Runtime.InteropServices;
/************************************************/
namespace JC.Lib.CS.Common
{
  partial class DesktopHelper
  {
    [DllImport("shell32.dll", EntryPoint = "SHChangeNotify")]
    private static extern void _SH_CHANGE_NOTIFY_(int _W_EVENT_ID_, int _U_FLAGS_, IntPtr _DW_ITEM_1_, IntPtr _DW_ITEM_2_);
    /************************************************/
    private const int _SHCNE_ASSOCCHANGED_ = 0x8000000;
    private const int _SHCNF_IDLIST_       = 0x0000;
    /************************************************/
    public static void RefreshDesktop()
    {
      DesktopHelper._SH_CHANGE_NOTIFY_(DesktopHelper._SHCNE_ASSOCCHANGED_, DesktopHelper._SHCNF_IDLIST_, IntPtr.Zero, IntPtr.Zero);
    }
  }
}