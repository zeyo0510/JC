using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/************************************************/
namespace JC.Lib.CS.Common
{
  partial class StringExtensions
  {
    public static Dictionary<string, object> ParseResourceString(this string s)
    {
       Dictionary<string, object> retValue = null;
       /************************************************/
       if (string.IsNullOrWhiteSpace(s)) return retValue;
       /************************************************/
       Match match = Regex.Match(s, @"(.+)\,(\-{0,1}\d+)$");
       /************************************************/
       if (!match.Success) return retValue;
       /************************************************/
       retValue = new Dictionary<string, object>();
       /************************************************/
       retValue.Add("path" , Convert.ToString(match.Groups[1].Value));
       retValue.Add("index", Convert.ToInt32(match.Groups[2].Value));
       /************************************************/
       return retValue;
    }
  }
}