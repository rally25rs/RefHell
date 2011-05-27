using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RefHell
{
  public partial class MergeView : Form
  {
    public Dictionary<string, RefData> Assemblies { get; set; }

    public MergeView()
    {
      InitializeComponent();
    }

    private void MergeView_Shown(object sender, EventArgs e)
    {
      if (Assemblies == null)
        return;

      foreach (var refName in Assemblies.Keys)
      {
        this.lstAssemblies.Items.Add(refName, !refName.StartsWith("System."));
        var asm = Assemblies[refName];
        if (asm.LoadedFrom.Contains(".exe"))
          cmbStartupAssembly.Items.Add(refName);
      }
    }

    private void cmdMerge_Click(object sender, EventArgs e)
    {
      var merge = new System.Diagnostics.ProcessStartInfo(txtIlMergePath.Text);
      var args = new StringBuilder();
      args.Append("/target:winexe");
      args.Append(" /out:\"").Append(txtOutput.Text).Append("\"");
      args.Append(" \"").Append(Assemblies[cmbStartupAssembly.Text].LoadedFrom).Append("\"");
      foreach (var selected in lstAssemblies.CheckedItems)
      {
        if (selected.ToString() != cmbStartupAssembly.Text)
        {
          args.Append(" \"").Append(Assemblies[selected.ToString()].LoadedFrom).Append("\"");
        }
      }
      merge.Arguments = args.ToString();
      merge.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
      merge.CreateNoWindow = false;
      System.Diagnostics.Process.Start(merge).WaitForExit();
    }
  }
}
