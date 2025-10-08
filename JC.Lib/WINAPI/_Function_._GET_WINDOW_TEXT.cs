// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowtexta
// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowtextw
/************************************************/
using System;
using System.Runtime.InteropServices;
using System.Text;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "GetWindowText", SetLastError = true)]
  internal static extern Int32 _GET_WINDOW_TEXT_(
    IntPtr _H_WND_,
    StringBuilder _LP_STRING_,
    Int32 _N_MAX_COUNT_
  );
}