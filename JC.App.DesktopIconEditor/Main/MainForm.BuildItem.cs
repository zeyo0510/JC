using System;
using System.Linq;
using System.Windows.Forms;
using JC.Lib.CS.Shell;
/************************************************/
namespace JC.App.DesktopIconEditor.Main
{
  partial class MainForm
  {
    private bool _Building = false;
    /************************************************/
    public void BuildItem()
    {
      if (this._Building) return;
      /************************************************/
      this._Building = true;
      /************************************************/
      this.listview1.Items.Clear();
      /************************************************/
      DesktopIcon.Items
    . ToList()
    . ForEach((_) => {
        if (_.Name == "") return;
        /************************************************/
        if (_.Icon == null) return;
        /************************************************/
        if (!this.imagelist1.Images.ContainsKey(_.GUID))
        {
          this.imagelist1.Images.Add(_.GUID, _.Icon.ToBitmap());
        }
        /************************************************/
        string a = _.Name;
        /************************************************/
        ListViewItem item = new ListViewItem(new string[] { a });
        {
          item.ImageKey = _.GUID;
          item.Tag      = _;
          item.Checked = _.Visible;
        }
        /************************************************/
        this.listview1.Items.Add(item);
      });
      /************************************************/
      this.listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
      /************************************************/
      this.listview1.Sort();
      /************************************************/
      this._Building = false;
    }
  }
}