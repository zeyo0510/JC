using System;
/************************************************/
namespace JC.Lib.Geometry;
/************************************************/
public partial class Line
{
  public Line(Point start, Point end) : base()
  {
    this.Start = start;
    this.End   = end;
  }
  /************************************************/
  public Line(int x1, int y1, int x2, int y2) : this(new Point(x1, y1), new Point(x2, y2))
  {
    // do nothing...
  }
  /************************************************/
  public Line() : this(0, 0, 0, 0)
  {
    // do nothing...
  }
}