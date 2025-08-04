using System;
using System.Linq;
using System.Windows.Forms;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main
{
  partial class MainForm
  {
    public void SelectAllItem()
    {
      this.listview1.Items
    . Cast<ListViewItem>()
    . ToList()
    . ForEach((_) => {
        _.Selected = true;
      });
    }
  }
}