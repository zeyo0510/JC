using System;
using System.Collections.Generic;
using System.Drawing;
/************************************************/
namespace JC.Lib.CS.Common
{
  static partial class GraphicsExtensions
  {
    public static void DrawPixelCircle(this Graphics g, int centerX, int centerY, int radius, Color color, bool fill = false)
    {
      Dictionary<int, List<int>> lnies = new Dictionary<int, List<int>>(); // y, x[]
      /************************************************/
      int x = 0;
      int y = radius;
      /************************************************/
      int d = 3 - 2 * radius;
      /************************************************/
      GraphicsExtensions.CollectCirclePoints(centerX, centerY, x, y, lnies);
      /************************************************/
      while (x <= y)
      {
        if (d < 0)
        {
          d = d + 4 * x + 6;
        } else {
          d = d + 4 * (x - y) + 10;
          /************************************************/
          y--;
        }
        /************************************************/
        x++;
        /************************************************/
        GraphicsExtensions.CollectCirclePoints(centerX, centerY, x, y, lnies);
      }
      /************************************************/
      foreach (KeyValuePair<int, List<int>> line in lnies)
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
    private static void CollectCirclePoints(int centerX, int centerY, int x, int y, Dictionary<int, List<int>> lines)
    {
      int l = 0;
      int t = 0;
      int r = 0;
      int b = 0;
      /************************************************/
      List<Point> eightPoints = new List<Point>();
      {
        l = centerX - x;
        t = centerY - y;
        r = centerX + x;
        b = centerY + y;
        /************************************************/
        eightPoints.Add(new Point(r, t)); // 第一象限(右上)
        eightPoints.Add(new Point(l, t)); // 第二象限(左上)
        eightPoints.Add(new Point(l, b)); // 第三象限(左下)
        eightPoints.Add(new Point(r, b)); // 第四象限(右下)
        /************************************************/
        t = centerY - x;
        l = centerX - y;
        b = centerY + x;
        r = centerX + y;
        /************************************************/
        eightPoints.Add(new Point(r, t)); // 第一象限(對稱、右上)
        eightPoints.Add(new Point(l, t)); // 第二象限(對稱、左上)
        eightPoints.Add(new Point(l, b)); // 第三象限(對稱、左下)
        eightPoints.Add(new Point(r, b)); // 第四象限(對稱、右下)
      }
      /************************************************/
      foreach (Point point in eightPoints)
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