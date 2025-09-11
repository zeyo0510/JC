using System;
/************************************************/
namespace JC.Lib.Geometry;
/************************************************/
public partial class Size
{
  public Size(int width, int height) : base()
  {
    this.Width  = width;
    this.Height = height;
  }
  /************************************************/
  public Size() : this(0, 0)
  {
    // do nothing...
  }
}