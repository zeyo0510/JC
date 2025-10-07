using System;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Control;
/************************************************/
partial class Window
{
  public static Window DesktopWindow
  {
    get
    {
      Window retValue = new(_Function_._GET_DESKTOP_WINDOW_());
      /************************************************/
      return retValue;
    }
  }
}