// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-enumchildwindows
/************************************************/
using System;
using System.Runtime.InteropServices;
/************************************************/
using static JC.Lib.WINAPI._CallbackFunction_;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "EnumChildWindows", SetLastError = true)]
  internal static extern Boolean _ENUM_CHILD_WINDOWS_(
    IntPtr _H_WND_PARENT_,
    _ENUM_CHILD_PROC_ _LP_ENUM_FUNC_,
    IntPtr _L_PARAM_
  );
}