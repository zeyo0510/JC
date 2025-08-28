using System;
/************************************************/
namespace JC.Lib.CS.Mathematics
{
  partial class Extremum
  {
    public static int Minimum(int n1, int n2)
    {
      int retValue = n1;
      /************************************************/
      if (retValue > n2)
      {
        retValue = n2;
      }
      /************************************************/
      return retValue;
    }
    /************************************************/
    public static int Minimum(int n1, int n2, params int[] n)
    {
      int retValue = n1;
      /************************************************/
      retValue = Minimum(retValue, n2);
      /************************************************/
      for (int i = 0; i < n.Length; i++)
      {
        retValue = Minimum(retValue, n[i]);
      }
      /************************************************/
      return retValue;
    }
  }
}