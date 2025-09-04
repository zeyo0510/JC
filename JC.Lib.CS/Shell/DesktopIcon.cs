using System;
/************************************************/
namespace JC.Lib.CS.Shell
{
  public partial class DesktopIcon
  {
    public static readonly DesktopIcon ControlPanel = new DesktopIcon("{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}");
    public static readonly DesktopIcon Network      = new DesktopIcon("{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}");
    public static readonly DesktopIcon RecycleBin   = new DesktopIcon("{645FF040-5081-101B-9F08-00AA002F954E}");
    public static readonly DesktopIcon ThisPC       = new DesktopIcon("{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
    public static readonly DesktopIcon Libraries    = new DesktopIcon("{031E4825-7B94-4dc3-B131-E946B44C8DD5}");
    public static readonly DesktopIcon UsersFiles   = new DesktopIcon("{59031A47-3F72-44A7-89C5-5595FE6B30EE}");
    /************************************************/
    private DesktopIcon(string guid)
    {
      this.GUID = guid;
    }
  }
}