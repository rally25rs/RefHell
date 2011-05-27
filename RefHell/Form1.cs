using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace RefHell
{
  public partial class Form1 : Form
  {
    private Dictionary<string, RefData> assemblies = null;

    public Form1()
    {
      InitializeComponent();
    }

    private void cmdBrowse_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.ShowDialog(this);
      this.txtFile.Text = openFileDialog1.FileName;
    }

    private void cmdAnalyze_Click(object sender, EventArgs e)
    {
      try
      {
        cmdAnalyze.Enabled = false;
        var analyzer = new AssemblyAnalyzer();

        if (this.txtFile.Text.EndsWith(".dll") || this.txtFile.Text.EndsWith(".exe"))
          assemblies = analyzer.AnalyzeAssembly(txtFile.Text);
        else if (this.txtFile.Text.EndsWith(".config"))
          assemblies = analyzer.AnalyzeAssembliesByFullName(getAssembliesFromXml(txtFile.Text), txtFile.Text.Substring(0, txtFile.Text.LastIndexOf('\\')));
        else if (this.txtFile.Text.EndsWith("\\"))
          assemblies = analyzer.AnalyzeAssembliesInPath(txtFile.Text);
        else
          throw new ApplicationException("Unknown file extension. Must be .dll, .exe, .config, or a path ending with \"\\\"");

        this.lstResults.Items.Clear();
        this.lstResults.Items.AddRange(generateResults(assemblies));
        this.cmdMerge.Enabled = true;
      }
      catch (Exception ex)
      {
        this.cmdMerge.Enabled = false;
        this.lstResults.Items.Clear();
        this.lstResults.Items.Add(ex.Message + " " + ex.StackTrace);
      }
      finally
      {
        cmdAnalyze.Enabled = true;
      }
    }

    private List<string> getAssembliesFromXml(string xmlFilePath)
    {
      var xmlDoc = new XmlDocument();
      xmlDoc.Load(xmlFilePath);

      var assemblyFullNames = new List<string>();
      var assembliesNode = xmlDoc["configuration"]["system.web"]["compilation"]["assemblies"];
      foreach (XmlNode assemblyNode in assembliesNode.ChildNodes)
      {
        if (assemblyNode.Name == "add")
          assemblyFullNames.Add(assemblyNode.Attributes["assembly"].Value);
      }
      return assemblyFullNames;
    }

    private string[] generateResults(Dictionary<string, RefData> assemblies)
    {
      var results = new List<string>();
      var resultsLoaded = new List<string>();
      var usedAsms = new Dictionary<string, string>();
      var resultsConflicting = new List<string>();

      results.Add("=== Loaded Assemblies ===");
      foreach (var key in assemblies.Keys)
      {
        resultsLoaded.Add(assemblies[key].AssemblyName.FullName);
      }
      resultsLoaded.Sort();
      results.AddRange(resultsLoaded);
      results.Add("");
      results.Add("=== Conflicting Assemblies ===");
      foreach (var key in assemblies.Keys)
      {
        AssemblyName asmName = assemblies[key].AssemblyName;
        if (usedAsms.ContainsKey(asmName.Name))
        {
          resultsConflicting.Add(usedAsms[asmName.Name]);
          resultsConflicting.Add(asmName.FullName);
        }
        else
        {
          usedAsms.Add(asmName.Name, asmName.FullName);
        }
      }
      resultsConflicting.Sort();
      results.AddRange(resultsConflicting);
      return results.ToArray();
    }

    private void lstResults_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (this.lstResults.SelectedIndex >= 0 && this.lstResults.Text.Length > 0 && !this.lstResults.Text.StartsWith("="))
      {
        var viewer = new RefsViewer(this.assemblies);
        viewer.Show();
        viewer.DisplayData(this.lstResults.Text);
      }
    }

    private void txtFile_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
        this.cmdAnalyze_Click(null, null);
    }

    private void cmdMerge_Click(object sender, EventArgs e)
    {
      var mergeView = new MergeView();
      mergeView.Assemblies = this.assemblies;
      mergeView.Show();
    }
  }
}
