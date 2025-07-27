using System;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class HTrackBar
  {
    public float PercentageValue
    {
      get
      {
        float retValue = 0f;
        /************************************************/
        float part  = this.Value    - this.MinValue;
        float whole = this.MaxValue - this.MinValue;
        /************************************************/
        retValue = part / whole;
        /************************************************/
        return retValue;
      }
    }
  }
}