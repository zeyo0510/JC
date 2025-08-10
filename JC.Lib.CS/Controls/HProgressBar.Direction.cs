using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class HProgressBar
  {
    private HDirection _Direction = HDirection.LeftToRight;
    /************************************************/
    public HDirection Direction
    {
      get
      {
        HDirection retValue = this._Direction;
        /************************************************/
        return retValue;
      }
      set
      {
        if (value == this._Direction) return;
        /************************************************/
        this._Direction = value;
        /************************************************/
        base.Invalidate();
      }
    }
  }
}