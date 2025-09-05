using System;
/************************************************/
namespace JC.App.DesktopIconEditor.Main
{
  partial class MainForm
  {
    public void UpdateUI()
    {
      this.           fileToolStripMenuItem.Checked = (false)                                            ;
      this.           exitToolStripMenuItem.Checked = (false)                                            ;
      this.           viewToolStripMenuItem.Checked = (false)                                            ;
      this.        refreshToolStripMenuItem.Checked = (false)                                            ;
      this.      statusbarToolStripMenuItem.Checked = (false) || (this.bottomStatusStrip.Visible == true);
      /************************************************/
      this.           fileToolStripMenuItem.Enabled = (true)                                            ;
      this.           exitToolStripMenuItem.Enabled = (true)                                            ;
      this.           viewToolStripMenuItem.Enabled = (true)                                            ;
      this.        refreshToolStripMenuItem.Enabled = (true)                                            ;
      this.      statusbarToolStripMenuItem.Enabled = (true)                                            ;
      /************************************************/
      this.messageToolStripStatusLabel.Text = "Ready";
      /************************************************/
      if (this.listview1.SelectedItems.Count >= 1)
      {
        this.messageToolStripStatusLabel.Text = string.Format("{0} selected", this.listview1.SelectedItems.Count);
      }
    }
  }
}