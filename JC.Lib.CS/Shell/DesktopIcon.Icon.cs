using System;
using System.Collections.Generic;
using System.Drawing;
using JC.Lib.CS.Common;
using Microsoft.Win32;
/************************************************/
namespace JC.Lib.CS.Shell
{
  partial class DesktopIcon
  {
    public Icon Icon
    {
      get
      {
        Icon retValue = null;
        /************************************************/
        RegistryKey key = Registry.ClassesRoot.OpenSubKey(string.Format(@"CLSID\{0}\DefaultIcon\", this.GUID));
        /************************************************/
        if (key == null) return retValue;
        /************************************************/
        if (retValue == null)
        {
          string resstr = Convert.ToString(key.GetValue(""));
          /************************************************/
          Dictionary<string, object> dict = resstr.ParseResourceString();
          /************************************************/
          retValue = IconHelper.ExtractIconFromDll(Convert.ToString(dict["path"]), Convert.ToInt32(dict["index"]), true);
        }
        /************************************************/
        return retValue;
      }
    }
  }
}