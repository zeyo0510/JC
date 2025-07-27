using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class HTrackBar
  {
    public event EventHandler ValueChanged = null;
    /************************************************/
    protected virtual void OnValueChanged()
    {
      if (this.ValueChanged == null) return;
      /************************************************/
      this.ValueChanged.Invoke(this, EventArgs.Empty);
    }
  }
}