using System;
using System.Drawing;
/************************************************/
namespace JC.Lib.CS.Common
{
  static partial class GraphicsExtensions
  {
    public static void DrawPixel(this Graphics g, int x, int y, Color color)
    {
      using (SolidBrush brush = new SolidBrush(color))
      {
        g.FillRectangle(brush, x, y, 1, 1);
      }
    }
  }
}