using System;
using System.Drawing;
using System.Drawing.Drawing2D;
/************************************************/
namespace JC.Lib.CS.Common
{
  partial class GraphicsExtensions
  {
    public static void FillRoundedRectangle(this Graphics g, Brush brush, float x, float y, float width, float height, int radius)
    {
      int diameter = radius * 2;
      /************************************************/
      using (GraphicsPath path = new GraphicsPath())
      {
        path.StartFigure();
        /************************************************/
        if (radius <= 0)
        {
          float l = x;
          float t = y;
          float r = width;
          float b = height;
          /************************************************/
          path.AddLine(l, t, r, t);
          path.AddLine(r, t, r, b);
          path.AddLine(t, b, l, b);
          path.AddLine(l, b, l, t);
        }
        else
        {
          float l = x;
          float t = y;
          float r = width  - diameter;
          float b = height - diameter;
          /************************************************/
          path.AddArc(l, t, diameter, diameter, 180, 90);
          path.AddArc(r, t, diameter, diameter, 270, 90);
          path.AddArc(r, b, diameter, diameter,   0, 90);
          path.AddArc(l, b, diameter, diameter,  90, 90);
          /************************************************/
        }
        /************************************************/
        path.CloseFigure();
        /************************************************/
        g.FillPath(brush, path);
      }
    }
    /************************************************/
    public static void FillRoundedRectangle(this Graphics g, Brush brush, RectangleF rect, int radius)
    {
      FillRoundedRectangle(g, brush, rect.X, rect.Y, rect.Width, rect.Height, radius);
    }
  }
}