using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace JC.App.DesktopIconEditor.Main
{
  partial class MainForm
  {
    private IContainer components = null;
    /************************************************/
    private Timer guiTimer = null;
    /************************************************/
    private ImageList imagelist1 = null;
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
      this.imagelist1 = new ImageList(this.components);
      /************************************************/
      this.mainToolStripContainer      = new ToolStripContainer();
      this.listview1                   = new ListView();
      this.topMenuStrip                = new MenuStrip();
      this.fileToolStripMenuItem       = new ToolStripMenuItem();
      this.exitToolStripMenuItem       = new ToolStripMenuItem();
      this.viewToolStripMenuItem       = new ToolStripMenuItem();
      this.refreshToolStripMenuItem    = new ToolStripMenuItem();
      this.statusbarToolStripMenuItem  = new ToolStripMenuItem();
      this.bottomStatusStrip           = new StatusStrip();
      this.messageToolStripStatusLabel = new ToolStripStatusLabel();
      /************************************************/
      // guiTimer
      {
        this.guiTimer.Enabled  = true;
        this.guiTimer.Interval = 100;
        /************************************************/
        this.guiTimer.Tick += this.guiTimer_Tick;
      }
      // imagelist1
      {
        this.imagelist1.ImageSize = new Size(32, 32);
      }
      // mainToolStripContainer
      {
        this.mainToolStripContainer.Name = "mainToolStripContainer";
        this.mainToolStripContainer.Dock = DockStyle.Fill;
        /************************************************/
        this.mainToolStripContainer.ContentPanel.Font       = new Font(FontFamily.GenericMonospace, 10f);
        this.mainToolStripContainer.ContentPanel.RenderMode = ToolStripRenderMode.System;
        /************************************************/
        this.mainToolStripContainer.ContentPanel.Controls.Add(this.listview1);
      }
      // listview1
      {
        this.listview1.Name           = "listview1";
        this.listview1.CheckBoxes     = true;
        this.listview1.Dock           = DockStyle.Fill;
        this.listview1.LargeImageList = this.imagelist1;
        this.listview1.MultiSelect    = true;
        this.listview1.Sorting        = SortOrder.Ascending;
        this.listview1.View           = View.LargeIcon;
        /************************************************/
        this.listview1.ItemChecked += this.listview1_ItemChecked;
      }
      // topMenuStrip
      {
        this.topMenuStrip.Name       = "topMenuStrip";
        this.topMenuStrip.Dock       = DockStyle.Top;
        this.topMenuStrip.Font       = new Font(FontFamily.GenericMonospace, 10f);
        this.topMenuStrip.RenderMode = ToolStripRenderMode.System;
        /************************************************/
        this.topMenuStrip.Items.Add(this.fileToolStripMenuItem);
        this.topMenuStrip.Items.Add(this.viewToolStripMenuItem);
      }
      // fileToolStripMenuItem
      {
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Text = "File";
        /************************************************/
        this.fileToolStripMenuItem.DropDownItems.Add(this.exitToolStripMenuItem);
        /************************************************/
        this.fileToolStripMenuItem.DropDownOpening += this.fileToolStripMenuItem_DropDownOpening;
      }
      // exitToolStripMenuItem
      {
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Text = "Exit";
        /************************************************/
        this.exitToolStripMenuItem.Click += this.exitToolStripMenuItem_Click;
      }
      // viewToolStripMenuItem
      {
        this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        this.viewToolStripMenuItem.Text = "View";
        /************************************************/
        this.viewToolStripMenuItem.DropDownItems.Add(this.refreshToolStripMenuItem);
        this.viewToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
        this.viewToolStripMenuItem.DropDownItems.Add(this.statusbarToolStripMenuItem);
        /************************************************/
        this.viewToolStripMenuItem.DropDownOpening += this.viewToolStripMenuItem_DropDownOpening;
      }
      // refreshToolStripMenuItem
      {
        this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
        this.refreshToolStripMenuItem.Text = "Refresh";
        /************************************************/
        this.refreshToolStripMenuItem.Click += this.refreshToolStripMenuItem_Click;
      }
      // statusbarToolStripMenuItem
      {
        this.statusbarToolStripMenuItem.Name = "statusbarToolStripMenuItem";
        this.statusbarToolStripMenuItem.Text = "Status Bar";
        /************************************************/
        this.statusbarToolStripMenuItem.Click += this.statusbarToolStripMenuItem_Click;
      }
      // bottomStatusStrip
      {
        this.bottomStatusStrip.Name       = "bottomStatusStrip";
        this.bottomStatusStrip.Dock       = DockStyle.Bottom;
        this.bottomStatusStrip.Font       = new Font(FontFamily.GenericMonospace, 10f);
        this.bottomStatusStrip.RenderMode = ToolStripRenderMode.System;
        this.bottomStatusStrip.SizingGrip = true;
        /************************************************/
        this.bottomStatusStrip.Items.Add(this.messageToolStripStatusLabel);
      }
      // messageToolStripStatusLabel
      {
        this.messageToolStripStatusLabel.Name = "messageToolStripStatusLabel";
        this.messageToolStripStatusLabel.Text = "Ready";
        /************************************************/
        this.messageToolStripStatusLabel.TextChanged += this.messageToolStripStatusLabel_TextChanged;
      }
      // MainForm
      {
        base.Name          = "MainForm";
        base.AutoScaleMode = AutoScaleMode.None;
        base.Font          = new Font(FontFamily.GenericMonospace, 10f);
        base.Text          = "JC.App.DesktopIconEditor";
        /************************************************/
        base.Controls.Add(this.mainToolStripContainer);
        base.Controls.Add(this.topMenuStrip);
        base.Controls.Add(this.bottomStatusStrip);
      }
    }
    /************************************************/
    private ToolStripContainer   mainToolStripContainer      = null;
    private ListView             listview1                   = null;
    private MenuStrip            topMenuStrip                = null;
    private ToolStripMenuItem    fileToolStripMenuItem       = null;
    private ToolStripMenuItem    exitToolStripMenuItem       = null;
    private ToolStripMenuItem    viewToolStripMenuItem       = null;
    private ToolStripMenuItem    refreshToolStripMenuItem    = null;
    private ToolStripMenuItem    statusbarToolStripMenuItem  = null;
    private StatusStrip          bottomStatusStrip           = null;
    private ToolStripStatusLabel messageToolStripStatusLabel = null;
  }
}