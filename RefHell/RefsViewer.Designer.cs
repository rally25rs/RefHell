namespace RefHell
{
	partial class RefsViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.lblAssemblyFullName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoadedFrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActionsIcon = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyAssemblyNameToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAssemblyPathToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAssemblyFileToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAssemblyFullName
            // 
            this.lblAssemblyFullName.AutoEllipsis = true;
            this.lblAssemblyFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssemblyFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyFullName.Location = new System.Drawing.Point(0, 0);
            this.lblAssemblyFullName.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.lblAssemblyFullName.Name = "lblAssemblyFullName";
            this.lblAssemblyFullName.Size = new System.Drawing.Size(676, 20);
            this.lblAssemblyFullName.TabIndex = 0;
            this.lblAssemblyFullName.Text = "Assembly Full Name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstFrom);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTo);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(676, 269);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 1;
            // 
            // lstFrom
            // 
            this.lstFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.Location = new System.Drawing.Point(0, 13);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(329, 251);
            this.lstFrom.TabIndex = 1;
            this.lstFrom.DoubleClick += new System.EventHandler(this.lstFrom_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referenced By:";
            // 
            // lstTo
            // 
            this.lstTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTo.FormattingEnabled = true;
            this.lstTo.Location = new System.Drawing.Point(0, 13);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(335, 251);
            this.lstTo.TabIndex = 1;
            this.lstTo.DoubleClick += new System.EventHandler(this.lstTo_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Refers To:";
            // 
            // lblLoadedFrom
            // 
            this.lblLoadedFrom.AutoEllipsis = true;
            this.lblLoadedFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoadedFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadedFrom.Location = new System.Drawing.Point(0, 0);
            this.lblLoadedFrom.Name = "lblLoadedFrom";
            this.lblLoadedFrom.Size = new System.Drawing.Size(661, 25);
            this.lblLoadedFrom.TabIndex = 2;
            this.lblLoadedFrom.Text = "Path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoadedFrom);
            this.panel1.Controls.Add(this.lblActionsIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 25);
            this.panel1.TabIndex = 3;
            // 
            // lblActionsIcon
            // 
            this.lblActionsIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblActionsIcon.Image = global::RefHell.Properties.Resources.Expand_large;
            this.lblActionsIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblActionsIcon.Location = new System.Drawing.Point(661, 0);
            this.lblActionsIcon.Name = "lblActionsIcon";
            this.lblActionsIcon.Size = new System.Drawing.Size(15, 25);
            this.lblActionsIcon.TabIndex = 3;
            this.lblActionsIcon.Click += new System.EventHandler(this.lblActionsIcon_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAssemblyNameToClipboardToolStripMenuItem,
            this.copyAssemblyPathToClipboardToolStripMenuItem,
            this.copyAssemblyFileToToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 70);
            // 
            // copyAssemblyNameToClipboardToolStripMenuItem
            // 
            this.copyAssemblyNameToClipboardToolStripMenuItem.Image = global::RefHell.Properties.Resources.PasteHS;
            this.copyAssemblyNameToClipboardToolStripMenuItem.Name = "copyAssemblyNameToClipboardToolStripMenuItem";
            this.copyAssemblyNameToClipboardToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.copyAssemblyNameToClipboardToolStripMenuItem.Text = "Copy Assembly Name to Clipboard";
            this.copyAssemblyNameToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyAssemblyNameToClipboardToolStripMenuItem_Click);
            // 
            // copyAssemblyPathToClipboardToolStripMenuItem
            // 
            this.copyAssemblyPathToClipboardToolStripMenuItem.Image = global::RefHell.Properties.Resources.PasteHS;
            this.copyAssemblyPathToClipboardToolStripMenuItem.Name = "copyAssemblyPathToClipboardToolStripMenuItem";
            this.copyAssemblyPathToClipboardToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.copyAssemblyPathToClipboardToolStripMenuItem.Text = "Copy Assembly Path to Clipboard";
            this.copyAssemblyPathToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyAssemblyPathToClipboardToolStripMenuItem_Click);
            // 
            // copyAssemblyFileToToolStripMenuItem
            // 
            this.copyAssemblyFileToToolStripMenuItem.Image = global::RefHell.Properties.Resources.CopyHS;
            this.copyAssemblyFileToToolStripMenuItem.Name = "copyAssemblyFileToToolStripMenuItem";
            this.copyAssemblyFileToToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.copyAssemblyFileToToolStripMenuItem.Text = "Copy Assembly File to...";
            this.copyAssemblyFileToToolStripMenuItem.Click += new System.EventHandler(this.copyAssemblyFileToToolStripMenuItem_Click);
            // 
            // RefsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 314);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAssemblyFullName);
            this.Name = "RefsViewer";
            this.Text = "Assembly References";
            this.Resize += new System.EventHandler(this.RefsViewer_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblAssemblyFullName;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox lstFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblLoadedFrom;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblActionsIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem copyAssemblyNameToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyAssemblyPathToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyAssemblyFileToToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;

	}
}