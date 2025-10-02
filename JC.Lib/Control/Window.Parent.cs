using System;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Control;
/************************************************/
partial class Window
{
  public Window Parent
  {
    get
    {
      Window retValue = new(_Function_._GET_PARENT_(this.Handle));
      /************************************************/
      return retValue;
    }
  }
}