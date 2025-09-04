using System;
using System.Collections.Generic;
/************************************************/
namespace JC.Lib.CS.Shell
{
  partial class DesktopIcon
  {
    private static List<DesktopIcon> _Items = null;
    /************************************************/
    public static DesktopIcon[] Items
    {
      get
      {
        if (DesktopIcon._Items == null)
        {
          DesktopIcon._Items = new List<DesktopIcon>();
          /************************************************/
          DesktopIcon._Items.Add(DesktopIcon.ControlPanel);
          DesktopIcon._Items.Add(DesktopIcon.Libraries   );
          DesktopIcon._Items.Add(DesktopIcon.Network     );
          DesktopIcon._Items.Add(DesktopIcon.RecycleBin  );
          DesktopIcon._Items.Add(DesktopIcon.ThisPC      );
          DesktopIcon._Items.Add(DesktopIcon.UsersFiles  );
        }
        /************************************************/
        return DesktopIcon._Items.ToArray();
      }
    }
  }
}