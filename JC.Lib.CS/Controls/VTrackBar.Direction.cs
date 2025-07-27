using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VTrackBar
  {
    private VDirection _Direction = VDirection.TopToBottom;
    /************************************************/
    public VDirection Direction
    {
      get
      {
        VDirection retValue = this._Direction;
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