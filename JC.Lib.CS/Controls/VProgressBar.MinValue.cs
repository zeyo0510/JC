using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VProgressBar
  {
    private int _MinValue = 0;
    /************************************************/
    public int MinValue
    {
      get
      {
        int retValue = this._MinValue;
        /************************************************/
        return retValue;
      }
      set
      {
        if (value >= this.MaxValue) value = this.MaxValue - 1;
        /************************************************/
        if (value == this._MinValue) return;
        /************************************************/
        this._MinValue = value;
        /************************************************/
        if (this.Value < this._MinValue) this.Value = this._MinValue;
        /************************************************/
        base.Invalidate();
      }
    }
  }
}