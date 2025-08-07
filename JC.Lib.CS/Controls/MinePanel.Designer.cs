using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.Lib.CS.Controls
{
  partial class MinePanel
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
      this.panel1 = new Control();
      this.panel2 = new Control();
      /************************************************/
      // guiTimer
      {
        this.guiTimer.Enabled  = true;
        this.guiTimer.Interval = 100;
        /************************************************/
        this.guiTimer.Tick += this.guiTimer_Tick;
      }
      // panel1
      {
        this.panel1.Name   = "panel1";
        this.panel1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        this.panel1.Left   = 11;
        this.panel1.Top    = 11;
        this.panel1.Width  = 146;
        this.panel1.Height = 33;
      }
      // panel2
      {
        this.panel2.Name   = "panel2";
        this.panel2.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
        this.panel2.Left   = 11;
        this.panel2.Top    = 54;
        this.panel2.Width  = 146;
        this.panel2.Height = 146;
      }
      // MinePanel
      {
        base.Name        = "MinePanel";
        base.ClientSize  = new Size(167, 210);
        base.MinimumSize = new Size(167, 210);
        /************************************************/
        base.Controls.Add(this.panel1);
        base.Controls.Add(this.panel2);
      }
    }
    /************************************************/
    private Control panel1 = null;
    private Control panel2 = null;
  }
}