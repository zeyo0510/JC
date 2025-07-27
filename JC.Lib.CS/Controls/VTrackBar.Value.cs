using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VTrackBar
  {
    private int _Value = 50;
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
        if (this._Value == value) return;
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