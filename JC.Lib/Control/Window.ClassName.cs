using System;
using System.Text;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Control;
/************************************************/
partial class Window
{
  public string ClassName
  {
    get
    {
      string retValue = "";
      /************************************************/
      StringBuilder sb = new(256);
      /************************************************/
      if (_Function_._GET_CLASS_NAME_(this.Handle, sb, sb.Capacity) > 0)
      {
        retValue = sb.ToString();
      }
      /************************************************/
      return retValue;
    }
  }
}