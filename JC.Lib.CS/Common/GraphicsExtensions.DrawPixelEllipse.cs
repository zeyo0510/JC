using System;
using System.Collections.Generic;
using System.Drawing;
/************************************************/
namespace JC.Lib.CS.Common
{
  static partial class GraphicsExtensions
  {
    public static void DrawPixelEllipse(this Graphics g, int x, int y, int width, int height, Color color, bool fill)
    {
      if (width  <= 0) return;
      if (height <= 0) return;
      /************************************************/
      double radiusX = (width  - 1) / 2.0;
      double radiusY = (height - 1) / 2.0;
      /************************************************/
      double centerX = x + radiusX;
      double centerY = y + radiusY;
      /************************************************/
      double rx2 = radiusX * radiusX;
      double ry2 = radiusY * radiusY;
      /************************************************/
      double px = 0;
      double py = radiusY;
      /************************************************/
      double dx = 2 * ry2 * px;
      double dy = 2 * rx2 * py;
      /************************************************/
      Dictionary<int, List<int>> lines = new Dictionary<int, List<int>>();
      /************************************************/
      // region 1: slope > -1
      double p1 = ry2 - (rx2 * radiusY) + (0.25 * rx2);
      /************************************************/
      while (dx < dy)
      {
        GraphicsExtensions.CollectEllipsePoints(centerX, centerY, px, py, lines);
        /************************************************/
        if (p1 < 0)
        {
          px += 1;
          dx += 2 * ry2;
          p1 += dx + ry2;
        }
        else
        {
          px += 1;
          py -= 1;
          dx += 2 * ry2;
          dy -= 2 * rx2;
          p1 += dx - dy + ry2;
        }
      }
      /************************************************/
      // region 2: slope <= -1
      double p2 = ry2 * (px + 0.5) * (px + 0.5) + rx2 * (py - 1) * (py - 1) - rx2 * ry2;
      /************************************************/
      while (py >= 0)
      {
        GraphicsExtensions.CollectEllipsePoints(centerX, centerY, px, py, lines);
        /************************************************/
        if (p2 > 0)
        {
          py -= 1;
          dy -= 2 * rx2;
          p2 += rx2 - dy;
        }
        else
        {
          py -= 1;
          px += 1;
          dx += 2 * ry2;
          dy -= 2 * rx2;
          p2 += dx - dy + rx2;
        }
      }
      /************************************************/
      foreach (KeyValuePair<int, List<int>> line in lines)
      {
        int yPos = line.Key;
        /************************************************/
        List<int> xPosList = line.Value;
        /************************************************/
        xPosList.Sort();
        /************************************************/
        int minX = xPosList[0];
        int maxX = xPosList[xPosList.Count - 1];
        /************************************************/
        if (fill)
        {
          for (int xPos = minX; xPos <= maxX; xPos++)
          {
            g.DrawPixel(xPos, yPos, color);
          }
        }
        /************************************************/
        if (!fill)
        {
          foreach (int xPos in xPosList)
          {
            g.DrawPixel(xPos, yPos, color);
          }
        }
      }
    }
    /************************************************/
    private static void CollectEllipsePoints(double centerX, double centerY, double x, double y, Dictionary<int, List<int>> lines)
    {
      int l = (int)Math.Floor(centerX - x);
      int t = (int)Math.Floor(centerY - y);
      int r = (int)Math.Ceiling(centerX + x);
      int b = (int)Math.Ceiling(centerY + y);
      /************************************************/
      List<Point> fourPoints = new List<Point>();
      {
        fourPoints.Add(new Point(r ,t)); // 第一象限(右上)
        fourPoints.Add(new Point(l, t)); // 第二象限(左上)
        fourPoints.Add(new Point(l, b)); // 第三象限(左下)
        fourPoints.Add(new Point(r, b)); // 第四象限(右下)
      }
      /************************************************/
      foreach (Point point in fourPoints)
      {
        if (!lines.ContainsKey(point.Y))
        {
          lines[point.Y] = new List<int>();
        }
        /************************************************/
        lines[point.Y].Add(point.X);
      }
    }
  }
}