// https://learn.microsoft.com/en-us/previous-versions/windows/desktop/legacy/ms633493(v=vs.85)
/************************************************/
using System;
/************************************************/
namespace JC.Lib.WINAPI;
/************************************************/
partial class _CallbackFunction_
{
  internal delegate Boolean _ENUM_CHILD_PROC_(
    IntPtr _H_WND_,
    IntPtr _L_PARAM_
  );
}