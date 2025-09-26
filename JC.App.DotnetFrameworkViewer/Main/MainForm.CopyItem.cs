using System;
using System.Text;
/************************************************/
namespace JC.App.DotnetFrameworkViewer.Main;
/************************************************/
partial class MainForm
{
  public void CopyItem()
  {
    StringBuilder buffer = new();
    /************************************************/
    this.listview1.SelectedItems
  . Cast<ListViewItem>()
  . ToList()
  . ForEach((_) => {
      string a = _.SubItems[0].Text;
      string b = _.SubItems[1].Text;
      string c = _.SubItems[2].Text;
      string d = _.SubItems[3].Text;
      /************************************************/
      buffer.AppendLine($"{a}\t{b}\t{c}\t{d}");
    });
    /************************************************/
    Clipboard.SetText(buffer.ToString());
  }
}