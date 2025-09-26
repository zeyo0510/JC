using System;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main;
/************************************************/
partial class MainForm
{
  public void InvertSelectionItem()
  {
    this.listview1.Items
  . Cast<ListViewItem>()
  . ToList()
  . ForEach((_) => {
      _.Selected = !_.Selected;
    });
  }
}