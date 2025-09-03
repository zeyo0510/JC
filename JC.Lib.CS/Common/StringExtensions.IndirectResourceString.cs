// https://learn.microsoft.com/en-us/windows/win32/api/shlwapi/nf-shlwapi-shloadindirectstring
/************************************************/
using System;
using System.Runtime.InteropServices;
using System.Text;
/************************************************/
namespace JC.Lib.CS.Common
{
  partial class StringExtensions
  {
    [DllImportAttribute("shlwapi.dll", EntryPoint = "SHLoadIndirectString", CharSet = CharSet.Unicode)]
    private static extern int _SH_LOAD_INDIRECT_STRING_(string _PSZ_SOURCE_, StringBuilder _PSZ_OUT_BUF_, int _CCH_OUT_BUF_, IntPtr _PPV_RESERVED_);
    /************************************************/
    public static string IndirectResourceString(this string s)
    {
      string retValue = s;
      /************************************************/
      if (string.IsNullOrWhiteSpace(s)) return retValue;
      /************************************************/
      StringBuilder sb = new StringBuilder(1024);
      /************************************************/
      int result = StringExtensions._SH_LOAD_INDIRECT_STRING_(retValue, sb, sb.Capacity, IntPtr.Zero);
      /************************************************/
      if (result == 0)
      {
        retValue = sb.ToString();
      }
      /************************************************/
      return retValue;
    }
  }
}