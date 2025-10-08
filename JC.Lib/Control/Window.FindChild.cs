using System;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Control;
/************************************************/
partial class Window
{
  public Window? FindChild(string className, string windowName, Window? afterWindow = null)
  {
    Window? retValue = null;
    /************************************************/
    nint childNadle = nint.Zero;
    /************************************************/
    if (afterWindow == null) childNadle = _Function_._FIND_WINDOW_EX_(this.Handle, nint.Zero         , className, windowName);
    if (afterWindow != null) childNadle = _Function_._FIND_WINDOW_EX_(this.Handle, afterWindow.Handle, className, windowName);
    /************************************************/
    if (childNadle != nint.Zero)
    {
      retValue = new(childNadle);
    }
    /************************************************/
    return retValue;
  }
}