using System;
using System.ComponentModel;
/************************************************/
using Timer = System.Windows.Forms.Timer;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main;
/************************************************/
partial class MainForm
{
  private IContainer components = null;
  /************************************************/
  private Timer guiTimer = null;
  /************************************************/
  protected override void Dispose(bool disposing)
  {
    if (disposing && (this.components != null))
    {
      this.components.Dispose();
    }
    base.Dispose(disposing);
  }
  /************************************************/
  private void InitializeComponent()
  {
    this.components = new Container();
    /************************************************/
    this.guiTimer = new(this.components);
    /************************************************/
    this.mainToolStripContainer           = new();
    this.listview1                        = new();
    this.nameColumnHeader                 = new();
    this.versionColumnHeader              = new();
    this.servicepackColumnHeader          = new();
    this.installColumnHeader              = new();
    this.topMenuStrip                     = new();
    this.fileToolStripMenuItem            = new();
    this.exitToolStripMenuItem            = new();
    this.editToolStripMenuItem            = new();
    this.copyToolStripMenuItem            = new();
    this.selectallToolStripMenuItem       = new();
    this.selectnoneToolStripMenuItem      = new();
    this.invertselectionToolStripMenuItem = new();
    this.viewToolStripMenuItem            = new();
    this.refreshToolStripMenuItem         = new();
    this.statusbarToolStripMenuItem       = new();
    this.bottomStatusStrip                = new();
    this.messageToolStripStatusLabel      = new();
    /************************************************/
    // guiTimer
    {
      this.guiTimer.Enabled = true;
      this.guiTimer.Interval = 100;
      /************************************************/
      this.guiTimer.Tick += this.guiTimer_Tick;
    }
    // mainToolStripContainer
    {
      this.mainToolStripContainer.Name = "mainToolStripContainer";
      this.mainToolStripContainer.Dock = DockStyle.Fill;
      /************************************************/
      this.mainToolStripContainer.ContentPanel.RenderMode = ToolStripRenderMode.System;
      /************************************************/
      this.mainToolStripContainer.ContentPanel.Controls.Add(this.listview1);
    }
    // listview1
    {
      this.listview1.Name          = "listview1";
      this.listview1.Dock          = DockStyle.Fill;
      this.listview1.FullRowSelect = true;
      this.listview1.GridLines     = true;
      this.listview1.HeaderStyle   = ColumnHeaderStyle.Nonclickable;
      this.listview1.MultiSelect   = true;
      this.listview1.Sorting       = SortOrder.Ascending;
      this.listview1.View          = View.Details;
      /************************************************/
      this.listview1.Columns.Add(this.nameColumnHeader);
      this.listview1.Columns.Add(this.versionColumnHeader);
      this.listview1.Columns.Add(this.servicepackColumnHeader);
      this.listview1.Columns.Add(this.installColumnHeader);
    }
    // nameColumnHeader
    {
      this.nameColumnHeader.Name = "nameColumnHeader";
      this.nameColumnHeader.Text = "Name";
    }
    // versionColumnHeader
    {
      this.versionColumnHeader.Name = "versionColumnHeader";
      this.versionColumnHeader.Text = "Version";
    }
    // servicepackColumnHeader
    {
      this.servicepackColumnHeader.Name = "servicepackColumnHeader";
      this.servicepackColumnHeader.Text = "Service Pack";
    }
    // installColumnHeader
    {
      this.installColumnHeader.Name = "installColumnHeader";
      this.installColumnHeader.Text = "Install";
    }
    // topMenuStrip
    {
      this.topMenuStrip.Name       = "topMenuStrip";
      this.topMenuStrip.Dock       = DockStyle.Top;
      this.topMenuStrip.RenderMode = ToolStripRenderMode.System;
      /************************************************/
      this.topMenuStrip.Items.Add(this.fileToolStripMenuItem);
      this.topMenuStrip.Items.Add(this.editToolStripMenuItem);
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
    // editToolStripMenuItem
    {
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Text = "Edit";
      /************************************************/
      this.editToolStripMenuItem.DropDownItems.Add(this.copyToolStripMenuItem);
      this.editToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
      this.editToolStripMenuItem.DropDownItems.Add(this.selectallToolStripMenuItem);
      this.editToolStripMenuItem.DropDownItems.Add(this.selectnoneToolStripMenuItem);
      this.editToolStripMenuItem.DropDownItems.Add(this.invertselectionToolStripMenuItem);
      /************************************************/
      this.editToolStripMenuItem.DropDownOpening += this.editToolStripMenuItem_DropDownOpening;
    }
    // copyToolStripMenuItem
    {
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Text = "Copy";
      /************************************************/
      this.copyToolStripMenuItem.Click += this.copyToolStripMenuItem_Click;
    }
    // selectallToolStripMenuItem
    {
      this.selectallToolStripMenuItem.Name = "selectallToolStripMenuItem";
      this.selectallToolStripMenuItem.Text = "Select All";
      /************************************************/
      this.selectallToolStripMenuItem.Click += this.selectallToolStripMenuItem_Click;
    }
    // selectnoneToolStripMenuItem
    {
      this.selectnoneToolStripMenuItem.Name = "selectnoneToolStripMenuItem";
      this.selectnoneToolStripMenuItem.Text = "Select None";
      /************************************************/
      this.selectnoneToolStripMenuItem.Click += this.selectnoneToolStripMenuItem_Click;
    }
    // invertselectionToolStripMenuItem
    {
      this.invertselectionToolStripMenuItem.Name = "invertselectionToolStripMenuItem";
      this.invertselectionToolStripMenuItem.Text = "Invert Selection";
      /************************************************/
      this.invertselectionToolStripMenuItem.Click += this.invertselectionToolStripMenuItem_Click;
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
      base.AutoScaleMode = AutoScaleMode.Font;
      base.StartPosition = FormStartPosition.Manual;
      base.Text          = "JC.App.DotnetFrameworkViewer";
      /************************************************/
      base.Controls.Add(this.mainToolStripContainer);
      base.Controls.Add(this.topMenuStrip);
      base.Controls.Add(this.bottomStatusStrip);
    }
  }
  /************************************************/
  private ToolStripContainer   mainToolStripContainer           = null;
  private ListView             listview1                        = null;
  private ColumnHeader         nameColumnHeader                 = null;
  private ColumnHeader         versionColumnHeader              = null;
  private ColumnHeader         servicepackColumnHeader          = null;
  private ColumnHeader         installColumnHeader              = null;
  private MenuStrip            topMenuStrip                     = null;
  private ToolStripMenuItem    fileToolStripMenuItem            = null;
  private ToolStripMenuItem    exitToolStripMenuItem            = null;
  private ToolStripMenuItem    editToolStripMenuItem            = null;
  private ToolStripMenuItem    copyToolStripMenuItem            = null;
  private ToolStripMenuItem    selectallToolStripMenuItem       = null;
  private ToolStripMenuItem    selectnoneToolStripMenuItem      = null;
  private ToolStripMenuItem    invertselectionToolStripMenuItem = null;
  private ToolStripMenuItem    viewToolStripMenuItem            = null;
  private ToolStripMenuItem    refreshToolStripMenuItem         = null;
  private ToolStripMenuItem    statusbarToolStripMenuItem       = null;
  private StatusStrip          bottomStatusStrip                = null;
  private ToolStripStatusLabel messageToolStripStatusLabel      = null;
}