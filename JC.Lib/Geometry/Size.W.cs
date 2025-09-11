using System;
/************************************************/
namespace JC.Lib.Geometry;
/************************************************/
partial class Size
{
  public int W
  {
    get
    {
      int retValue = this.Width;
      /************************************************/
      return retValue;
    }
    set
    {
      this.Width = value;
    }
  }
}