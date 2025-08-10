using System;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class HProgressBar
  {
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      /************************************************/
      Graphics g = e.Graphics;
      /************************************************/
      Rectangle rect = base.ClientRectangle;
      /************************************************/
      if (this.Direction == HDirection.RightToLeft)
      {
        g.ScaleTransform(1 * -1, 1);
        /************************************************/
        g.TranslateTransform(rect.Width * -1, 0);
      }
      /************************************************/
      this.DrawTrack(g, rect);
    }
    /************************************************/
    private void DrawTrack(Graphics g, RectangleF rect)
    {
      using (Brush brush = new SolidBrush(Color.Black))
      {
        float x = rect.X      + 0;
        float y = rect.Y      + 0;
        float w = rect.Width  - 0;
        float h = rect.Height - 0;
        /************************************************/
        g.FillRectangle(brush, x, y, w, h);
      }
      /************************************************/
      using (Brush brush = new SolidBrush(Color.LightGray))
      {
        float x = rect.X      + 1;
        float y = rect.Y      + 1;
        float w = rect.Width  - 2;
        float h = rect.Height - 2;
        /************************************************/
        g.FillRectangle(brush, x, y, w, h);
      }
      /************************************************/
      using (Brush brush = new SolidBrush(Color.DodgerBlue))
      {
        float x = rect.X                              + 1;
        float y = rect.Y                              + 1;
        float w = (rect.Width * this.PercentageValue) - 2;
        float h = rect.Height                         - 2;
        /************************************************/
        g.FillRectangle(brush, x, y, w, h);
      }
    }
  }
}