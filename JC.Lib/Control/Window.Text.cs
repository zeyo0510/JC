using System;
using System.Text;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Control;
/************************************************/
partial class Window
{
  public string Text
  {
    get
    {
      string retValue = "";
      /************************************************/
      StringBuilder sb = new(_Function_._GET_WINDOW_TEXT_LENGTH_(this.Handle) + 1);
      /************************************************/
      if (_Function_._GET_WINDOW_TEXT_(this.Handle, sb, sb.Capacity) > 0)
      {
        retValue = sb.ToString();
      }
      /************************************************/
      return retValue;
    }
  }
}