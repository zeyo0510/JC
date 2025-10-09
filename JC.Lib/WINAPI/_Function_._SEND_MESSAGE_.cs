// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessage
/************************************************/
using System;
using System.Runtime.InteropServices;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _Function_
{
  [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
  internal static extern IntPtr _SEND_MESSAGE_(
    IntPtr _H_WND_,
    Int32 _MSG_,
    Int32 _W_PARAM_,
    IntPtr _L_PARAM_
  );
}