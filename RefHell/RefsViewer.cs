using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RefHell
{
	public partial class RefsViewer : Form
	{
		private Dictionary<string, RefData> assemblies = null;

		public RefsViewer()
		{
			InitializeComponent();
		}

		public RefsViewer(Dictionary<string, RefData> assemblies)
			: this()
		{
			this.assemblies = assemblies;
		}

		private void RefsViewer_Resize(object sender, EventArgs e)
		{
			this.splitContainer1.SplitterDistance = this.splitContainer1.Width / 2;
		}

		public void DisplayData(string assemblyFullName)
		{
			RefData refData = this.assemblies[assemblyFullName];
			this.lblAssemblyFullName.Text = refData.AssemblyName.FullName;
			this.lblLoadedFrom.Text = refData.LoadedFrom;
			this.lstFrom.Items.Clear();
			var fromItems = refData.ReferencedBy.ToArray();
			var toItems = refData.References.ToArray();
			Array.Sort(fromItems);
			Array.Sort(toItems);
			this.lstFrom.Items.AddRange(fromItems);
			this.lstTo.Items.AddRange(toItems);
		}

		private void lstFrom_DoubleClick(object sender, EventArgs e)
		{
			if (this.lstFrom.SelectedIndex >= 0 && !this.lstFrom.Text.StartsWith("="))
			{
				this.DisplayData(this.lstFrom.Text);
			}
		}

		private void lstTo_DoubleClick(object sender, EventArgs e)
		{
			if (this.lstTo.SelectedIndex >= 0 && !this.lstFrom.Text.StartsWith("="))
			{
				this.DisplayData(this.lstTo.Text);
			}
		}

		private void copyAssemblyNameToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.lblAssemblyFullName.Text);
		}

		private void copyAssemblyPathToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.lblLoadedFrom.Text);
		}

		private void copyAssemblyFileToToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				FileInfo f = new FileInfo(this.lblLoadedFrom.Text);
				if (f.Exists)
				{
					this.saveFileDialog1.FileName = f.Name;
					DialogResult saveResult = this.saveFileDialog1.ShowDialog(this);
					if (saveResult == DialogResult.OK)
					{
						f.CopyTo(this.saveFileDialog1.FileName);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Error copying file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lblActionsIcon_Click(object sender, EventArgs e)
		{
			this.contextMenuStrip1.Show(this.lblActionsIcon, new Point(0, 0));
		}
	}
}
