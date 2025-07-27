using System;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class HTrackBar
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
      /************************************************/
      this.DrawThumb(g, rect);
    }
    /************************************************/
    private void DrawTrack(Graphics g, Rectangle rect)
    {
      float trackWidth  = rect.Width;
      float trackHeight = 4f;
      /************************************************/
      float x = rect.X;
      float y = (rect.Height - trackHeight) / 2;
      float w = trackWidth;
      float h = trackHeight;
      /************************************************/
      using (Brush brush = new SolidBrush(Color.LightGray))
      {
        g.FillRectangle(brush, x, y, w, h);
      }
      /************************************************/
      using (Brush brush = new SolidBrush(Color.DodgerBlue))
      {
        w = this.PercentageValue * rect.Width;
        /************************************************/
        g.FillRectangle(brush, x, y, w, h);
      }
    }
    /************************************************/
    private void DrawThumb(Graphics g, Rectangle rect)
    {
      float thumbWidth  = 10f;
      float thumbHeight = 20f;
      /************************************************/
      float x = this.PercentageValue * (rect.Width - thumbWidth);
      float y = rect.Y;
      float w = thumbWidth;
      float h = thumbHeight;
      /************************************************/
      using (Brush brush = new SolidBrush(Color.DarkGray))
      {
        g.FillRectangle(brush, x, y, w, h);
      }
      /************************************************/
      using (Brush brush = new SolidBrush(Color.White))
      {
        x += 1;
        y += 1;
        w -= 2;
        h -= 2;
        /************************************************/
        g.FillRectangle(brush, x, y, w, h);
      }
    }
  }
}