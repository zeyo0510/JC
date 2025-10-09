using System;
/************************************************/
using JC.Lib.Control;
using JC.Lib.WINAPI;
/************************************************/
namespace JC.Lib.Common;
/************************************************/
partial class DesktopHelper
{
  private static Window? _IconListView = null;
  /************************************************/
  public static Window? IconListView
  {
    get
    {
      Window? retValue = DesktopHelper._IconListView;
      /************************************************/
      if (retValue != null)
      {
        if (!_Function_._IS_WINDOW_(retValue.Handle))
        {
          retValue = null;
        }
      }
      /************************************************/
      if (retValue == null)
      {
        Window.DesktopWindow.ChildList
      . Cast<Window>()
      . Where((_) =>
        {
          bool retValue = false;
          /************************************************/
          if (!retValue && _.ClassName == "Progman") retValue = true;
          if (!retValue && _.ClassName == "WorkerW") retValue = true;
          /************************************************/
          return retValue;
        })
      . ToList()
      . ForEach((_) =>
        {
          Window? window = _;
          /************************************************/
          if (window != null) window = window.FindChild("SHELLDLL_DefView".Trim(), "          ".Trim());
          if (window != null) window = window.FindChild("SysListView32   ".Trim(), "FolderView".Trim());
          if (window != null)
          {
            retValue = window;
            /************************************************/
            return;
          }
        });
      }
      /************************************************/
      DesktopHelper._IconListView = retValue;
      /************************************************/
      return retValue;
    }
  }
}