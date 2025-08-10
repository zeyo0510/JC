using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VProgressBar
  {
    private int _Value = 0;
    /************************************************/
    public int Value
    {
      get
      {
        int retValue = this._Value;
        /************************************************/
        return retValue;
      }
      set
      {
        if (value < this.MinValue) value = this.MinValue;
        if (value > this.MaxValue) value = this.MaxValue;
        /************************************************/
        if (value == this._Value) return;
        /************************************************/
        this._Value = value;
        /************************************************/
        this.OnValueChanged();
        /************************************************/
        base.Invalidate();
      }
    }
  }
}