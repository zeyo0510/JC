using System;
/************************************************/
namespace JC.Lib.Geometry;
/************************************************/
public partial class Point
{
  public Point(int x, int y) : base()
  {
    this.X = x;
    this.Y = y;
  }
  /************************************************/
  public Point() : this(0, 0)
  {
    // do nothing...
  }
}