using System;
/************************************************/
namespace JC.Lib.Mathematic;
/************************************************/
partial class Extremum
{
  public static int Maximum(int n1, int n2)
  {
    int retValue = n1;
    /************************************************/
    if (n1 < n2)
    {
      retValue = n2;
    }
    /************************************************/
    return retValue;
  }
  /************************************************/
  public static int Maximum(int n1, int n2, params int[] n3)
  {
    int retValue = Extremum.Maximum(n1, n2);
    /************************************************/
    foreach (int n in n3)
    {
      retValue = Extremum.Maximum(retValue, n);
    }
    /************************************************/
    return retValue;
  }
}