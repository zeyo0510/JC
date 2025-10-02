// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-iswindow
/************************************************/
using System;
using System.Runtime.InteropServices;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "IsWindow", SetLastError = true)]
  internal static extern Boolean _IS_WINDOW_(
    IntPtr _H_WND_
  );
}