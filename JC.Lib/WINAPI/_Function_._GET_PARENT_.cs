// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getparent
/************************************************/
using System;
using System.Runtime.InteropServices;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "GetParent", SetLastError = true)]
  internal static extern IntPtr _GET_PARENT_(
    IntPtr _H_WND_
  );
}