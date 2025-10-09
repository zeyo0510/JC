using System;
/************************************************/
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Common;
/************************************************/
partial class DesktopHelper
{
  public static bool RefreshIcon()
  {
    bool retValue = false;
    /************************************************/
    if (DesktopHelper.IconListView != null)
    {
      _Function_._SEND_MESSAGE_(DesktopHelper.IconListView.Parent.Handle, _Message_._WM_COMMAND_, _Message_._CMD_REFRESH_ICON_, nint.Zero);
      /************************************************/
      retValue = true;
    }
    /************************************************/
    return retValue;
  }
}