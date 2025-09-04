using System;
using JC.Lib.CS.Common;
using Microsoft.Win32;
/************************************************/
namespace JC.Lib.CS.Shell
{
  partial class DesktopIcon
  {
    public string Name
    {
      get
      {
        string retValue = "";
        /************************************************/
        if (this.GUID == "{59031A47-3F72-44A7-89C5-5595FE6B30EE}")
        {
          retValue = StringHelper.GetUserDisplayName();
        }
        /************************************************/
        RegistryKey key = Registry.ClassesRoot.OpenSubKey(string.Format(@"CLSID\{0}\", this.GUID));
        /************************************************/
        if (key == null) return retValue;
        /************************************************/
        if (retValue == "")
        {
          string resstr = Convert.ToString(key.GetValue("LocalizedString"));
          /************************************************/
          retValue = resstr.IndirectResourceString();
        }
        /************************************************/
        if (retValue == "")
        {
          retValue = Convert.ToString(key.GetValue(""));
        }
        /************************************************/
        return retValue;
      }
    }
  }
}