using System;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  public partial class VTrackBar : Control
  {
    public VTrackBar()
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