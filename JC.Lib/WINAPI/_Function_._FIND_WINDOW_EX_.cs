// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-findwindowexa
// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-findwindowexw
/************************************************/
using System;
using System.Runtime.InteropServices;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
  internal static extern IntPtr _FIND_WINDOW_EX_(
    IntPtr _H_WND_PARENT_,
    IntPtr _H_WND_CHILD_AFTER,
    string _LPSZ_CLASS_,
    string _LPSZ_WINDOW_
  );
}