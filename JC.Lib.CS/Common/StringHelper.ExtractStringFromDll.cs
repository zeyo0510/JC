// https://learn.microsoft.com/en-us/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary
// https://learn.microsoft.com/en-us/windows/win32/api/libloaderapi/nf-libloaderapi-loadlibrarya
// https://learn.microsoft.com/en-us/windows/win32/api/libloaderapi/nf-libloaderapi-loadlibraryw
// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-loadstringa
// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-loadstringw
/************************************************/
using System;
using System.Runtime.InteropServices;
using System.Text;
/************************************************/
namespace JC.Lib.CS.Common
{
  partial class StringHelper
  {
    [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
    private static extern IntPtr _LOAD_LIBRARY_(string _LP_LIB_FILE_NAME_);
    /************************************************/
    [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
    private static extern bool _FREE_LIBRARY_(IntPtr _H_LIB_MODULE_);
    /************************************************/
    [DllImport("user32.dll", EntryPoint = "LoadString")]
    private static extern int _LOAD_STRING_(IntPtr _H_INSTANCE_, int _U_ID_, StringBuilder _LP_BUFFER_, int _CCH_BUFFER_MAX_);
    /************************************************/
    public static string ExtractStringFromDll(string path, int index = 0)
    {
      string retValue = "";
      /************************************************/
      IntPtr instance = StringHelper._LOAD_LIBRARY_(path);
      /************************************************/
      if (instance == IntPtr.Zero) return retValue;
      /************************************************/
      StringBuilder sb = new StringBuilder(1024);
      /************************************************/
      int length = StringHelper._LOAD_STRING_(instance, index, sb, sb.Capacity);
      /************************************************/
      if (length > 0)
      {
        retValue = sb.ToString();
        /************************************************/
        StringHelper._FREE_LIBRARY_(instance);
      }
      /************************************************/
      return retValue;
    }
  }
}