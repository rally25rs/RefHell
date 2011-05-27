using System.Collections.Generic;
using System.Reflection;

namespace RefHell
{
	/// <summary>
	/// Data structure to hold all assembly reference info
	/// </summary>
	public class RefData
	{
		public RefData(AssemblyName assemblyName)
		{
			this.AssemblyName = assemblyName;
			this.ReferencedBy = new List<string>();
			this.References = new List<string>();
		}

		public AssemblyName AssemblyName { get; private set; }
		public List<string> ReferencedBy { get; private set; }
		public List<string> References { get; private set; }
		public string LoadedFrom { get; set; }
	}
}
