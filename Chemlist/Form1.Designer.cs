namespace Chemlist
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
			this.tab_Switcher = new System.Windows.Forms.TabControl();
			this.tab_Chemicals = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.lbox_ChemicalList = new System.Windows.Forms.ListBox();
			this.btn_RemoveChemicalFromList = new System.Windows.Forms.Button();
			this.btn_AddNew = new System.Windows.Forms.Button();
			this.btn_EditCurrentChemical = new System.Windows.Forms.Button();
			this.tab_Projects = new System.Windows.Forms.TabPage();
			this.tab_Equipment = new System.Windows.Forms.TabPage();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel_Info = new System.Windows.Forms.Panel();
			this.rtb_Formula = new System.Windows.Forms.RichTextBox();
			this.cguid = new System.Windows.Forms.Label();
			this.txt_chemName = new System.Windows.Forms.Label();
			this.tab_Switcher.SuspendLayout();
			this.tab_Chemicals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel_Info.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_Switcher
			// 
			this.tab_Switcher.Controls.Add(this.tab_Chemicals);
			this.tab_Switcher.Controls.Add(this.tab_Projects);
			this.tab_Switcher.Controls.Add(this.tab_Equipment);
			this.tab_Switcher.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Switcher.Location = new System.Drawing.Point(0, 24);
			this.tab_Switcher.Name = "tab_Switcher";
			this.tab_Switcher.Padding = new System.Drawing.Point(0, 0);
			this.tab_Switcher.SelectedIndex = 0;
			this.tab_Switcher.Size = new System.Drawing.Size(800, 426);
			this.tab_Switcher.TabIndex = 0;
			// 
			// tab_Chemicals
			// 
			this.tab_Chemicals.Controls.Add(this.splitContainer1);
			this.tab_Chemicals.Location = new System.Drawing.Point(4, 22);
			this.tab_Chemicals.Name = "tab_Chemicals";
			this.tab_Chemicals.Size = new System.Drawing.Size(792, 400);
			this.tab_Chemicals.TabIndex = 1;
			this.tab_Chemicals.Text = "Chemicals";
			this.tab_Chemicals.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel_Info);
			this.splitContainer1.Size = new System.Drawing.Size(792, 400);
			this.splitContainer1.SplitterDistance = 264;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.lbox_ChemicalList);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.btn_RemoveChemicalFromList);
			this.splitContainer2.Panel2.Controls.Add(this.btn_AddNew);
			this.splitContainer2.Panel2.Controls.Add(this.btn_EditCurrentChemical);
			this.splitContainer2.Size = new System.Drawing.Size(264, 400);
			this.splitContainer2.SplitterDistance = 361;
			this.splitContainer2.TabIndex = 0;
			// 
			// lbox_ChemicalList
			// 
			this.lbox_ChemicalList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbox_ChemicalList.FormattingEnabled = true;
			this.lbox_ChemicalList.Items.AddRange(new object[] {
            "Compound List"});
			this.lbox_ChemicalList.Location = new System.Drawing.Point(0, 0);
			this.lbox_ChemicalList.Margin = new System.Windows.Forms.Padding(0);
			this.lbox_ChemicalList.Name = "lbox_ChemicalList";
			this.lbox_ChemicalList.Size = new System.Drawing.Size(264, 361);
			this.lbox_ChemicalList.TabIndex = 0;
			this.lbox_ChemicalList.SelectedIndexChanged += new System.EventHandler(this.lbox_ChemicalList_SelectedIndexChanged);
			// 
			// btn_RemoveChemicalFromList
			// 
			this.btn_RemoveChemicalFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveChemicalFromList.Location = new System.Drawing.Point(183, -1);
			this.btn_RemoveChemicalFromList.Name = "btn_RemoveChemicalFromList";
			this.btn_RemoveChemicalFromList.Size = new System.Drawing.Size(77, 25);
			this.btn_RemoveChemicalFromList.TabIndex = 3;
			this.btn_RemoveChemicalFromList.Text = "Delete";
			this.btn_RemoveChemicalFromList.UseVisualStyleBackColor = true;
			this.btn_RemoveChemicalFromList.Click += new System.EventHandler(this.btn_RemoveChemicalFromList_Click);
			// 
			// btn_AddNew
			// 
			this.btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddNew.Location = new System.Drawing.Point(3, -1);
			this.btn_AddNew.Name = "btn_AddNew";
			this.btn_AddNew.Size = new System.Drawing.Size(77, 25);
			this.btn_AddNew.TabIndex = 5;
			this.btn_AddNew.Text = "Add New";
			this.btn_AddNew.UseVisualStyleBackColor = true;
			this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
			// 
			// btn_EditCurrentChemical
			// 
			this.btn_EditCurrentChemical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditCurrentChemical.Location = new System.Drawing.Point(93, -1);
			this.btn_EditCurrentChemical.Name = "btn_EditCurrentChemical";
			this.btn_EditCurrentChemical.Size = new System.Drawing.Size(77, 25);
			this.btn_EditCurrentChemical.TabIndex = 4;
			this.btn_EditCurrentChemical.Text = "Edit";
			this.btn_EditCurrentChemical.UseVisualStyleBackColor = true;
			this.btn_EditCurrentChemical.Click += new System.EventHandler(this.btn_EditCurrentChemical_Click);
			// 
			// tab_Projects
			// 
			this.tab_Projects.Location = new System.Drawing.Point(4, 22);
			this.tab_Projects.Name = "tab_Projects";
			this.tab_Projects.Size = new System.Drawing.Size(792, 400);
			this.tab_Projects.TabIndex = 2;
			this.tab_Projects.Text = "Projects";
			this.tab_Projects.UseVisualStyleBackColor = true;
			// 
			// tab_Equipment
			// 
			this.tab_Equipment.Location = new System.Drawing.Point(4, 22);
			this.tab_Equipment.Name = "tab_Equipment";
			this.tab_Equipment.Size = new System.Drawing.Size(792, 400);
			this.tab_Equipment.TabIndex = 3;
			this.tab_Equipment.Text = "Equipment";
			this.tab_Equipment.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// panel_Info
			// 
			this.panel_Info.Controls.Add(this.txt_chemName);
			this.panel_Info.Controls.Add(this.cguid);
			this.panel_Info.Controls.Add(this.rtb_Formula);
			this.panel_Info.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Info.Location = new System.Drawing.Point(0, 0);
			this.panel_Info.Margin = new System.Windows.Forms.Padding(5);
			this.panel_Info.Name = "panel_Info";
			this.panel_Info.Padding = new System.Windows.Forms.Padding(3);
			this.panel_Info.Size = new System.Drawing.Size(524, 400);
			this.panel_Info.TabIndex = 6;
			// 
			// rtb_Formula
			// 
			this.rtb_Formula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rtb_Formula.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_Formula.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rtb_Formula.Location = new System.Drawing.Point(11, 32);
			this.rtb_Formula.Name = "rtb_Formula";
			this.rtb_Formula.ReadOnly = true;
			this.rtb_Formula.Size = new System.Drawing.Size(199, 21);
			this.rtb_Formula.TabIndex = 2;
			this.rtb_Formula.Text = "Formula";
			// 
			// cguid
			// 
			this.cguid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cguid.AutoSize = true;
			this.cguid.Location = new System.Drawing.Point(8, 370);
			this.cguid.Name = "cguid";
			this.cguid.Size = new System.Drawing.Size(34, 13);
			this.cguid.TabIndex = 5;
			this.cguid.Text = "GUID";
			// 
			// txt_chemName
			// 
			this.txt_chemName.AutoSize = true;
			this.txt_chemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.txt_chemName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_chemName.Location = new System.Drawing.Point(6, 3);
			this.txt_chemName.Name = "txt_chemName";
			this.txt_chemName.Size = new System.Drawing.Size(104, 26);
			this.txt_chemName.TabIndex = 0;
			this.txt_chemName.Text = "Chemical";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tab_Switcher);
			this.Controls.Add(this.menuStrip1);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.Text = "Chemlist";
			this.tab_Switcher.ResumeLayout(false);
			this.tab_Chemicals.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel_Info.ResumeLayout(false);
			this.panel_Info.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tab_Switcher;
		private System.Windows.Forms.TabPage tab_Chemicals;
		private System.Windows.Forms.TabPage tab_Projects;
		private System.Windows.Forms.TabPage tab_Equipment;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox lbox_ChemicalList;
		private System.Windows.Forms.Button btn_RemoveChemicalFromList;
		private System.Windows.Forms.Button btn_EditCurrentChemical;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button btn_AddNew;
		private System.Windows.Forms.Panel panel_Info;
		private System.Windows.Forms.Label txt_chemName;
		private System.Windows.Forms.Label cguid;
		private System.Windows.Forms.RichTextBox rtb_Formula;
	}
}

