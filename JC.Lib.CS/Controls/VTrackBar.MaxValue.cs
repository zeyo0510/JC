using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VTrackBar
  {
    private int _MaxValue = 100;
    /************************************************/
    public int MaxValue
    {
      get
      {
        int retValue = this._MaxValue;
        /************************************************/
        return retValue;
      }
      set
      {
        if (value <= this.MinValue) value = this.MinValue + 1;
        /************************************************/
        if (value == this._MaxValue) return;
        /************************************************/
        this._MaxValue = value;
        /************************************************/
        if (this.Value > this._MaxValue) this.Value = this._MaxValue;
        /************************************************/
        base.Invalidate();
      }
    }
  }
}