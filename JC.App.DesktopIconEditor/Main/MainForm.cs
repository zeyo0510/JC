using System;
using System.Windows.Forms;
/************************************************/
namespace JC.App.DesktopIconEditor.Main
{
  internal partial class MainForm : Form
  {
    public MainForm()
    {
      this.InitializeComponent();
    }
    /************************************************/
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      /************************************************/
      this.AdjuestClientSize();
      /************************************************/
      this.BuildItem();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void guiTimer_Tick(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
    /************************************************/
    private void listview1_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
      this.ToggleIcon(e.Item);
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
    /************************************************/
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ExitApp();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
    /************************************************/
    private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.BuildItem();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void statusbarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ToggleStatusBar();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void messageToolStripStatusLabel_TextChanged(object sender, EventArgs e)
    {
      // do nothing...
    }
  }
}