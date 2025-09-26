using System;
/************************************************/
using JC.Lib.Development;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main;
/************************************************/
partial class MainForm
{
  public void BuildItem()
  {
    this.listview1.Items.Clear();
    /************************************************/
    DotnetFramework.Items
  . ToList()
  . ForEach((_) => {
      string a = _.Name;
      string b = _.Version;
      string c = _.ServicePack;
      string d = _.Install;
      /************************************************/
      ListViewItem item = new([a, b, c, d]) {
        Tag = _
      };
      /************************************************/
      this.listview1.Items.Add(item);
    });
    /************************************************/
    this.listview1.Columns
  . Cast<ColumnHeader>()
  . ToList()
  . ForEach((_) => {
      _.Width = -2;
    });
    /************************************************/
    this.listview1.Sort();
  }
}