using System;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  public partial class HProgressBar : Control
  {
    public HProgressBar()
    {
      this.InitializeComponent();
      /************************************************/
      base.SetStyle(ControlStyles.DoubleBuffer, true);
    }
    /************************************************/
    private void guiTimer_Tick(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
  }
}