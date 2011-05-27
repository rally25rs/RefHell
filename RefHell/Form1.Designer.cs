namespace RefHell
{
	partial class Form1
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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.txtFile = new System.Windows.Forms.TextBox();
      this.cmdBrowse = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.cmdAnalyze = new System.Windows.Forms.Button();
      this.lstResults = new System.Windows.Forms.ListBox();
      this.cmdMerge = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.Filter = "Assemblies (exe, dll)|*.exe;*.dll|Web Config|*.config";
      // 
      // txtFile
      // 
      this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFile.Location = new System.Drawing.Point(73, 12);
      this.txtFile.Name = "txtFile";
      this.txtFile.Size = new System.Drawing.Size(240, 20);
      this.txtFile.TabIndex = 0;
      this.txtFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFile_KeyUp);
      // 
      // cmdBrowse
      // 
      this.cmdBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowse.Location = new System.Drawing.Point(319, 11);
      this.cmdBrowse.Name = "cmdBrowse";
      this.cmdBrowse.Size = new System.Drawing.Size(66, 23);
      this.cmdBrowse.TabIndex = 1;
      this.cmdBrowse.Text = "Browse...";
      this.cmdBrowse.UseVisualStyleBackColor = true;
      this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "File to load:";
      // 
      // cmdAnalyze
      // 
      this.cmdAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdAnalyze.Location = new System.Drawing.Point(12, 44);
      this.cmdAnalyze.Name = "cmdAnalyze";
      this.cmdAnalyze.Size = new System.Drawing.Size(373, 23);
      this.cmdAnalyze.TabIndex = 3;
      this.cmdAnalyze.Text = "Analyze";
      this.cmdAnalyze.UseVisualStyleBackColor = true;
      this.cmdAnalyze.Click += new System.EventHandler(this.cmdAnalyze_Click);
      // 
      // lstResults
      // 
      this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstResults.BackColor = System.Drawing.SystemColors.Window;
      this.lstResults.Location = new System.Drawing.Point(12, 113);
      this.lstResults.Name = "lstResults";
      this.lstResults.Size = new System.Drawing.Size(373, 290);
      this.lstResults.TabIndex = 4;
      this.lstResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstResults_MouseDoubleClick);
      // 
      // cmdMerge
      // 
      this.cmdMerge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdMerge.Enabled = false;
      this.cmdMerge.Location = new System.Drawing.Point(13, 74);
      this.cmdMerge.Name = "cmdMerge";
      this.cmdMerge.Size = new System.Drawing.Size(372, 23);
      this.cmdMerge.TabIndex = 5;
      this.cmdMerge.Text = "Merge IL to Single Assembly";
      this.cmdMerge.UseVisualStyleBackColor = true;
      this.cmdMerge.Click += new System.EventHandler(this.cmdMerge_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 420);
      this.Controls.Add(this.cmdMerge);
      this.Controls.Add(this.lstResults);
      this.Controls.Add(this.cmdAnalyze);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmdBrowse);
      this.Controls.Add(this.txtFile);
      this.Name = "Form1";
      this.Text = "Welcome to Reference Hell";
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Button cmdBrowse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdAnalyze;
		private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button cmdMerge;
	}
}

