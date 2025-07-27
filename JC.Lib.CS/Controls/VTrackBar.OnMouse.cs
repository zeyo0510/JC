using System;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VTrackBar
  {
    private bool _dragging = false;
    /************************************************/
    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);
      /************************************************/
      if (e.Button == MouseButtons.Left)
      {
        this._dragging = true;
        /************************************************/
        this.SetValueFromPoint(e.X, e.Y);
      }
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);
      /************************************************/
      if (this._dragging)
      {
        this.SetValueFromPoint(e.X, e.Y);
      }
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);
      /************************************************/
      this._dragging = false;
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);
      /************************************************/
      this.Value += e.Delta / 24;
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void SetValueFromPoint(int x, int y)
    {
      float percentage = 0f;
      /************************************************/
      if (this.Direction == VDirection.TopToBottom) percentage = Convert.ToSingle(              y) / base.Height;
      if (this.Direction == VDirection.BottomToTop) percentage = Convert.ToSingle(base.Height - y) / base.Height;
      /************************************************/
      if (percentage < 0f) percentage = 0f;
      if (percentage > 1f) percentage = 1f;
      /************************************************/
      float range = this.MaxValue - this.MinValue;
      /************************************************/
      float offset = percentage * range;
      /************************************************/
      this.Value = Convert.ToInt32(this.MinValue + offset);
    }
  }
}