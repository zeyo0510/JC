// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getdesktopwindow
/************************************************/
using System;
using System.Runtime.InteropServices;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "GetDesktopWindow", SetLastError = true)]
  internal static extern IntPtr _GET_DESKTOP_WINDOW_();
}