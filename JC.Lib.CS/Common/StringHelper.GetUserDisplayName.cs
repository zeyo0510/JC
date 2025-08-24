// https://learn.microsoft.com/en-us/windows/win32/api/secext/ne-secext-extended_name_format
// https://learn.microsoft.com/en-us/windows/win32/api/secext/nf-secext-getusernameexa
// https://learn.microsoft.com/en-us/windows/win32/api/secext/nf-secext-getusernameexw
/************************************************/
using System;
using System.Runtime.InteropServices;
using System.Text;
/************************************************/
namespace JC.Lib.CS.Common
{
  static partial class StringHelper
  {
    private enum _EXTENDED_NAME_FORMAT_
    {
      _NAME_UNKNOWN_            =  0,
      _NAME_FULLY_QUALIFIED_DN_ =  1,
      _NAME_SAM_COMPATIBLE_     =  2,
      _NAME_DISPLAY_            =  3,
      _NAME_UNIQUE_ID_          =  6,
      _NAME_CANONICAL_          =  7,
      _NAME_USER_PRINCIPAL_     =  8,
      _NAME_CANONICAL_EX_       =  9,
      _NAME_SERVICE_PRINCIPAL_  = 10,
      _NAME_DNS_DOMAIN_         = 12,
    }
    /************************************************/
    [DllImport("secur32.dll", EntryPoint = "GetUserNameEx")]
    private static extern bool _GET_USER_NAME_EX_(int _NAME_FORMAT_, StringBuilder _LP_NAME_BUFFER_, ref int _N_SIZE_);
    /************************************************/
    public static string GetUserDisplayName()
    {
      string retValue = "";
      /************************************************/
      int size = 1024;
      /************************************************/
      StringBuilder sb = new StringBuilder(size);
      /************************************************/
      if (StringHelper._GET_USER_NAME_EX_((int)_EXTENDED_NAME_FORMAT_._NAME_DISPLAY_, sb, ref size))
      {
        retValue = sb.ToString();
      }
      /************************************************/
      return retValue;
    }
  }
}