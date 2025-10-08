using System;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Control;
/************************************************/
partial class Window
{
  public Window[] ChildList
  {
    get
    {
      List<Window> retValue = new();
      /************************************************/
      _Function_._ENUM_CHILD_WINDOWS_(this.Handle, (_H_WND_, _L_PARAM_) => {
        Window window = new(_H_WND_);
        /************************************************/
        retValue.Add(window);
        /************************************************/
        return true;
      }, nint.Zero);
      /************************************************/
      return [.. retValue];
    }
  }
}