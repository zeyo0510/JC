using System;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VTrackBar
  {
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      /************************************************/
      Graphics g = e.Graphics;
      /************************************************/
      Rectangle rect = base.ClientRectangle;
      /************************************************/
      if (this.Direction == VDirection.BottomToTop)
      {
        g.ScaleTransform(1, 1 * -1);
        /************************************************/
        g.TranslateTransform(0, rect.Height * - 1);
      }
      /************************************************/
      this.DrawTrack(g, rect);
      /************************************************/
      this.DrawThumb(g, rect);
    }
    /************************************************/
    private void DrawTrack(Graphics g, Rectangle rect)
    {
      float trackWidth  = 4f;
      float trackHeight = rect.Height;
      /************************************************/
      float x = (rect.Width - trackWidth) / 2;
      float y = rect.Y;
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
        h = this.PercentageValue * rect.Height;
        /************************************************/
        g.FillRectangle(brush, x, y, w, h);
      }
    }
    /************************************************/
    private void DrawThumb(Graphics g, Rectangle rect)
    {
      float thumbWidth  = 20f;
      float thumbHeight = 10f;
      /************************************************/
      float x = rect.Left;
      float y = this.PercentageValue * (rect.Height - thumbHeight);
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