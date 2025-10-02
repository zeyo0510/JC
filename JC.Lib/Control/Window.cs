using System;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Control;
/************************************************/
public partial class Window
{
  internal Window(nint handle)
  {
    if (!_Function_._IS_WINDOW_(handle)) throw new Exception($"Invalid window handle.");
    /************************************************/
    this.Handle = handle;
  }
}