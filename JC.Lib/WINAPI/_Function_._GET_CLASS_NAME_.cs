// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getclassname
// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getclassnamea
// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getclassnamew
/************************************************/
using System;
using System.Runtime.InteropServices;
using System.Text;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "GetClassName", SetLastError = true)]
  internal static extern Int32 _GET_CLASS_NAME_(
    IntPtr _H_WND_,
    StringBuilder _LP_CLASS_NAME_,
    Int32 _N_MAX_COUNT_
  );
}