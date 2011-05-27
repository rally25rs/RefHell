using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RefHell
{
  /// <summary>
  /// This class is used to analyze an assembly and determine what assemblies it references.
  /// It also attempts to locate the referenced assembly in the startup directory or GAC.
  /// If a referenced assembly can not be found, then a 'file open' dialog box is displayed
  /// and the user can manually specify the assembly location.
  /// </summary>
  class AssemblyAnalyzer
  {
    private Dictionary<string, RefData> assemblies;
    private string basePath;

    public Dictionary<string, RefData> AnalyzeAssembly(string assemblyPath)
    {
      this.basePath = assemblyPath.Substring(0, assemblyPath.LastIndexOf('\\'));
      var refDomainSetup = AppDomain.CurrentDomain.SetupInformation;
      refDomainSetup.ApplicationBase = this.basePath;
      refDomainSetup.PrivateBinPath = this.basePath;
      var refDomain = AppDomain.CreateDomain("ReferencesAssemblies", AppDomain.CurrentDomain.Evidence, refDomainSetup);

      this.assemblies = new Dictionary<string, RefData>();
      var name = Assembly.LoadFrom(assemblyPath).GetName();
      this.AnalyzeAssembly(name, "=== File: " + assemblyPath + " ===");

      return this.assemblies;
    }

    public Dictionary<string, RefData> AnalyzeAssembliesInPath(string basePath)
    {
      this.basePath = basePath;
      var refDomainSetup = AppDomain.CurrentDomain.SetupInformation;
      refDomainSetup.ApplicationBase = this.basePath;
      refDomainSetup.PrivateBinPath = this.basePath;
      var refDomain = AppDomain.CreateDomain("ReferencesAssemblies", AppDomain.CurrentDomain.Evidence, refDomainSetup);

      this.assemblies = new Dictionary<string, RefData>();
      var dir = new DirectoryInfo(basePath);
      foreach (FileInfo file in dir.GetFiles("*.exe"))
      {
        var name = Assembly.LoadFrom(file.FullName).GetName();
        this.AnalyzeAssembly(name, name.FullName);
      }
      foreach (FileInfo file in dir.GetFiles("*.dll"))
      {
        var name = Assembly.LoadFrom(file.FullName).GetName();
        this.AnalyzeAssembly(name, "=== File: " + file.FullName + " ===");
      }

      return this.assemblies;
    }

    public Dictionary<string, RefData> AnalyzeAssembliesByFullName(List<string> assemblyFullNames, string basePath)
    {
      this.basePath = basePath;
      var refDomainSetup = AppDomain.CurrentDomain.SetupInformation;
      refDomainSetup.ApplicationBase = this.basePath;
      refDomainSetup.PrivateBinPath = this.basePath;
      var refDomain = AppDomain.CreateDomain("ReferencesAssemblies", AppDomain.CurrentDomain.Evidence, refDomainSetup);

      this.assemblies = new Dictionary<string, RefData>();
      foreach (string fullName in assemblyFullNames)
      {
        var name = new AssemblyName(fullName);
        this.AnalyzeAssembly(name, "=== File: Web Config ===");
      }

      return this.assemblies;
    }

    private void AnalyzeAssembly(AssemblyName asmName, string referencedBy)
    {
      if (!this.assemblies.ContainsKey(asmName.FullName))
      {
        var refData = new RefData(asmName);
        refData.ReferencedBy.Add(referencedBy);
        this.assemblies.Add(asmName.FullName, refData);
        Assembly asm = null;
        try
        {
          asm = AppDomain.CurrentDomain.Load(asmName);
        }
        catch (FileNotFoundException)
        {
          var fi = new FileInfo(this.basePath + "\\" + asmName.Name + ".dll");
          if (fi.Exists)
          {
            try
            {
              asm = Assembly.LoadFrom(fi.FullName);
              if (asm.GetName().FullName != asmName.FullName)
                asm = null;
            }
            catch
            {
              asm = null;
            }
          }

          if (asm == null)
          {
            var ofd = new OpenFileDialog();
            ofd.Title = "Locate " + asmName.Name + " " + asmName.Version.ToString();
            ofd.Filter = "Assemblies (exe, dll)|*.exe;*.dll";
            bool found = false;
            while (!found)
            {
              var ofdResult = ofd.ShowDialog();
              if (ofdResult == DialogResult.Cancel || ofd.FileName == "")
              {
                asm = null;
                found = true;
              }
              else
              {
                asm = Assembly.LoadFrom(ofd.FileName);
                if (asm.GetName().FullName != asmName.FullName)
                {
                  MessageBox.Show("I was looking for " + asmName.FullName + ", but you selected " + asm.GetName().FullName);
                }
                else
                {
                  found = true;
                }
              }
            }
          }
        }
        if (asm != null)
        {
          refData.LoadedFrom = asm.Location;
          var refs = asm.GetReferencedAssemblies();
          foreach (AssemblyName refName in refs)
          {
            refData.References.Add(refName.FullName);
            AnalyzeAssembly(refName, asmName.FullName);
          }
        }
      }
      else
      {
        var refData = this.assemblies[asmName.FullName];
        refData.ReferencedBy.Add(referencedBy);
      }
    }
  }
}
