using System;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main;
/************************************************/
partial class MainForm
{
  public void DeselectAllItem()
  {
    this.listview1.Items
  . Cast<ListViewItem>()
  . ToList()
  . ForEach((_) => {
      _.Selected = false;
    });
  }
}