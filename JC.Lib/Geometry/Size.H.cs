using System;
/************************************************/
namespace JC.Lib.Geometry;
/************************************************/
partial class Size
{
  public int H
  {
    get
    {
      int retValue = this.Height;
      /************************************************/
      return retValue;
    }
    set
    {
      this.Height = value;
    }
  }
}