using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class VProgressBar
  {
    private IContainer components = null;
    /************************************************/
    private Timer guiTimer = null;
    /************************************************/
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.components != null)
        {
          this.components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    /************************************************/
    private void InitializeComponent()
    {
      this.components = new Container();
      /************************************************/
      this.guiTimer = new Timer(this.components);
      /************************************************/
      // guiTimer
      {
        this.guiTimer.Enabled  = true;
        this.guiTimer.Interval = 100;
        /************************************************/
        this.guiTimer.Tick += this.guiTimer_Tick;
      }
      // VProgressBar
      {
        base.Name        = "VProgressBar";
        base.ClientSize  = new Size(20, 100);
        base.MinimumSize = new Size(20, 100);
      }
    }
  }
}