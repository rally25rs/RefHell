namespace RefHell
{
    partial class MergeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeView));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkIlMergeDownload = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIlMergePath = new System.Windows.Forms.TextBox();
            this.cmdIlMergeBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstAssemblies = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStartupAssembly = new System.Windows.Forms.ComboBox();
            this.cmdMerge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdIlMergeBrowse);
            this.groupBox1.Controls.Add(this.txtIlMergePath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lnkIlMergeDownload);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ILMerge Location";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "This feature requires Microsoft ILMerge. It is against the ILMerge license for it" +
                " to be redistributed, so you need to install it yourself. It can be downloaded d" +
                "irectly from Microsoft here:";
            // 
            // lnkIlMergeDownload
            // 
            this.lnkIlMergeDownload.AutoSize = true;
            this.lnkIlMergeDownload.Location = new System.Drawing.Point(9, 55);
            this.lnkIlMergeDownload.Name = "lnkIlMergeDownload";
            this.lnkIlMergeDownload.Size = new System.Drawing.Size(569, 13);
            this.lnkIlMergeDownload.TabIndex = 1;
            this.lnkIlMergeDownload.TabStop = true;
            this.lnkIlMergeDownload.Text = "http://www.microsoft.com/downloads/details.aspx?FamilyID=22914587-b4ad-4eae-87cf-" +
                "b14ae6a939b0&displaylang=en";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location of installed ILMerge.exe:";
            // 
            // txtIlMergePath
            // 
            this.txtIlMergePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlMergePath.Location = new System.Drawing.Point(12, 104);
            this.txtIlMergePath.Name = "txtIlMergePath";
            this.txtIlMergePath.Size = new System.Drawing.Size(449, 20);
            this.txtIlMergePath.TabIndex = 3;
            this.txtIlMergePath.Text = "C:\\Program Files\\Microsoft\\ILMerge\\ILMerge.exe";
            // 
            // cmdIlMergeBrowse
            // 
            this.cmdIlMergeBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdIlMergeBrowse.Location = new System.Drawing.Point(467, 102);
            this.cmdIlMergeBrowse.Name = "cmdIlMergeBrowse";
            this.cmdIlMergeBrowse.Size = new System.Drawing.Size(75, 23);
            this.cmdIlMergeBrowse.TabIndex = 4;
            this.cmdIlMergeBrowse.Text = "Browse...";
            this.cmdIlMergeBrowse.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Merge Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Save merged assembly to:";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 47);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(449, 20);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "C:\\merged.exe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstAssemblies);
            this.groupBox3.Location = new System.Drawing.Point(13, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 167);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assemblies to Merge";
            // 
            // lstAssemblies
            // 
            this.lstAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAssemblies.FormattingEnabled = true;
            this.lstAssemblies.Location = new System.Drawing.Point(12, 20);
            this.lstAssemblies.Name = "lstAssemblies";
            this.lstAssemblies.Size = new System.Drawing.Size(530, 139);
            this.lstAssemblies.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbStartupAssembly);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(13, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 62);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Startup Assembly";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select the startup assembly that contains the Main() method.";
            // 
            // cmbStartupAssembly
            // 
            this.cmbStartupAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartupAssembly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartupAssembly.FormattingEnabled = true;
            this.cmbStartupAssembly.Location = new System.Drawing.Point(9, 35);
            this.cmbStartupAssembly.Name = "cmbStartupAssembly";
            this.cmbStartupAssembly.Size = new System.Drawing.Size(533, 21);
            this.cmbStartupAssembly.TabIndex = 1;
            // 
            // cmdMerge
            // 
            this.cmdMerge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMerge.Location = new System.Drawing.Point(12, 538);
            this.cmdMerge.Name = "cmdMerge";
            this.cmdMerge.Size = new System.Drawing.Size(549, 23);
            this.cmdMerge.TabIndex = 5;
            this.cmdMerge.Text = "Merge!";
            this.cmdMerge.UseVisualStyleBackColor = true;
            this.cmdMerge.Click += new System.EventHandler(this.cmdMerge_Click);
            // 
            // MergeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 573);
            this.Controls.Add(this.cmdMerge);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MergeView";
            this.Text = "Merge Assemblies";
            this.Shown += new System.EventHandler(this.MergeView_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdIlMergeBrowse;
        private System.Windows.Forms.TextBox txtIlMergePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkIlMergeDownload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox lstAssemblies;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbStartupAssembly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdMerge;
    }
}