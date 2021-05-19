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
			this.panel_Info = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txt_MeltingPoint = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_Density = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Appearance = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_MolarMass = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Names = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cguid = new System.Windows.Forms.Label();
			this.rtb_Description = new System.Windows.Forms.RichTextBox();
			this.txt_chemName = new System.Windows.Forms.Label();
			this.rtb_Formula = new System.Windows.Forms.RichTextBox();
			this.tab_Projects = new System.Windows.Forms.TabPage();
			this.tab_Equipment = new System.Windows.Forms.TabPage();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_BoilingPoint = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_SInWater = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txt_Solubility = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txt_VapourPressure = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txt_Acidity = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txt_FlashPoint = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.tlink_Wiki = new System.Windows.Forms.LinkLabel();
			this.tlink_Purchase = new System.Windows.Forms.LinkLabel();
			this.tlink_MSDS = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_LD50 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_LC50 = new System.Windows.Forms.Label();
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
			this.panel_Info.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_Switcher
			// 
			this.tab_Switcher.Controls.Add(this.tab_Chemicals);
			this.tab_Switcher.Controls.Add(this.tab_Projects);
			this.tab_Switcher.Controls.Add(this.tab_Equipment);
			this.tab_Switcher.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tab_Switcher.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Switcher.Location = new System.Drawing.Point(0, 24);
			this.tab_Switcher.Name = "tab_Switcher";
			this.tab_Switcher.Padding = new System.Drawing.Point(0, 0);
			this.tab_Switcher.SelectedIndex = 0;
			this.tab_Switcher.Size = new System.Drawing.Size(998, 531);
			this.tab_Switcher.TabIndex = 0;
			// 
			// tab_Chemicals
			// 
			this.tab_Chemicals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.tab_Chemicals.Controls.Add(this.splitContainer1);
			this.tab_Chemicals.Location = new System.Drawing.Point(4, 22);
			this.tab_Chemicals.Name = "tab_Chemicals";
			this.tab_Chemicals.Size = new System.Drawing.Size(990, 505);
			this.tab_Chemicals.TabIndex = 1;
			this.tab_Chemicals.Text = "Chemicals";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.Window;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
			this.splitContainer1.Panel2.Controls.Add(this.panel_Info);
			this.splitContainer1.Size = new System.Drawing.Size(990, 505);
			this.splitContainer1.SplitterDistance = 330;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BackColor = System.Drawing.SystemColors.Window;
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
			this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Window;
			this.splitContainer2.Panel2.Controls.Add(this.btn_RemoveChemicalFromList);
			this.splitContainer2.Panel2.Controls.Add(this.btn_AddNew);
			this.splitContainer2.Panel2.Controls.Add(this.btn_EditCurrentChemical);
			this.splitContainer2.Size = new System.Drawing.Size(330, 505);
			this.splitContainer2.SplitterDistance = 465;
			this.splitContainer2.TabIndex = 0;
			// 
			// lbox_ChemicalList
			// 
			this.lbox_ChemicalList.BackColor = System.Drawing.SystemColors.Window;
			this.lbox_ChemicalList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbox_ChemicalList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbox_ChemicalList.ForeColor = System.Drawing.Color.Black;
			this.lbox_ChemicalList.FormattingEnabled = true;
			this.lbox_ChemicalList.Items.AddRange(new object[] {
            "Compound List"});
			this.lbox_ChemicalList.Location = new System.Drawing.Point(0, 0);
			this.lbox_ChemicalList.Margin = new System.Windows.Forms.Padding(0);
			this.lbox_ChemicalList.Name = "lbox_ChemicalList";
			this.lbox_ChemicalList.Size = new System.Drawing.Size(330, 465);
			this.lbox_ChemicalList.Sorted = true;
			this.lbox_ChemicalList.TabIndex = 0;
			this.lbox_ChemicalList.SelectedIndexChanged += new System.EventHandler(this.lbox_ChemicalList_SelectedIndexChanged);
			// 
			// btn_RemoveChemicalFromList
			// 
			this.btn_RemoveChemicalFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveChemicalFromList.BackColor = System.Drawing.SystemColors.Window;
			this.btn_RemoveChemicalFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_RemoveChemicalFromList.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn_RemoveChemicalFromList.Location = new System.Drawing.Point(228, 3);
			this.btn_RemoveChemicalFromList.Name = "btn_RemoveChemicalFromList";
			this.btn_RemoveChemicalFromList.Size = new System.Drawing.Size(98, 25);
			this.btn_RemoveChemicalFromList.TabIndex = 3;
			this.btn_RemoveChemicalFromList.Text = "Delete";
			this.btn_RemoveChemicalFromList.UseVisualStyleBackColor = false;
			this.btn_RemoveChemicalFromList.Click += new System.EventHandler(this.btn_RemoveChemicalFromList_Click);
			// 
			// btn_AddNew
			// 
			this.btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_AddNew.Location = new System.Drawing.Point(8, 3);
			this.btn_AddNew.Name = "btn_AddNew";
			this.btn_AddNew.Size = new System.Drawing.Size(98, 25);
			this.btn_AddNew.TabIndex = 5;
			this.btn_AddNew.Text = "Add New";
			this.btn_AddNew.UseVisualStyleBackColor = true;
			this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
			// 
			// btn_EditCurrentChemical
			// 
			this.btn_EditCurrentChemical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditCurrentChemical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_EditCurrentChemical.Location = new System.Drawing.Point(118, 3);
			this.btn_EditCurrentChemical.Name = "btn_EditCurrentChemical";
			this.btn_EditCurrentChemical.Size = new System.Drawing.Size(98, 25);
			this.btn_EditCurrentChemical.TabIndex = 4;
			this.btn_EditCurrentChemical.Text = "Edit";
			this.btn_EditCurrentChemical.UseVisualStyleBackColor = true;
			this.btn_EditCurrentChemical.Click += new System.EventHandler(this.btn_EditCurrentChemical_Click);
			// 
			// panel_Info
			// 
			this.panel_Info.AutoScroll = true;
			this.panel_Info.BackColor = System.Drawing.SystemColors.Window;
			this.panel_Info.Controls.Add(this.groupBox3);
			this.panel_Info.Controls.Add(this.groupBox2);
			this.panel_Info.Controls.Add(this.groupBox1);
			this.panel_Info.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Info.Location = new System.Drawing.Point(0, 0);
			this.panel_Info.Margin = new System.Windows.Forms.Padding(5);
			this.panel_Info.Name = "panel_Info";
			this.panel_Info.Padding = new System.Windows.Forms.Padding(3);
			this.panel_Info.Size = new System.Drawing.Size(656, 505);
			this.panel_Info.TabIndex = 6;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox3.Controls.Add(this.tlink_MSDS);
			this.groupBox3.Controls.Add(this.tlink_Purchase);
			this.groupBox3.Controls.Add(this.tlink_Wiki);
			this.groupBox3.Controls.Add(this.txt_LC50);
			this.groupBox3.Controls.Add(this.txt_LD50);
			this.groupBox3.Controls.Add(this.txt_FlashPoint);
			this.groupBox3.Controls.Add(this.txt_Acidity);
			this.groupBox3.Controls.Add(this.txt_VapourPressure);
			this.groupBox3.Controls.Add(this.label26);
			this.groupBox3.Controls.Add(this.txt_Solubility);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.txt_SInWater);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.txt_BoilingPoint);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.txt_MeltingPoint);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txt_Density);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.txt_Appearance);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txt_MolarMass);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.txt_Names);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.groupBox3.Location = new System.Drawing.Point(6, 135);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(368, 319);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Properties";
			// 
			// txt_MeltingPoint
			// 
			this.txt_MeltingPoint.AutoSize = true;
			this.txt_MeltingPoint.Location = new System.Drawing.Point(93, 84);
			this.txt_MeltingPoint.Name = "txt_MeltingPoint";
			this.txt_MeltingPoint.Size = new System.Drawing.Size(27, 13);
			this.txt_MeltingPoint.TabIndex = 0;
			this.txt_MeltingPoint.Text = "N/A";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 84);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Melting point:";
			// 
			// txt_Density
			// 
			this.txt_Density.AutoSize = true;
			this.txt_Density.Location = new System.Drawing.Point(93, 67);
			this.txt_Density.Name = "txt_Density";
			this.txt_Density.Size = new System.Drawing.Size(27, 13);
			this.txt_Density.TabIndex = 0;
			this.txt_Density.Text = "N/A";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Density:";
			// 
			// txt_Appearance
			// 
			this.txt_Appearance.AutoSize = true;
			this.txt_Appearance.Location = new System.Drawing.Point(93, 50);
			this.txt_Appearance.Name = "txt_Appearance";
			this.txt_Appearance.Size = new System.Drawing.Size(27, 13);
			this.txt_Appearance.TabIndex = 0;
			this.txt_Appearance.Text = "N/A";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Appearance:";
			// 
			// txt_MolarMass
			// 
			this.txt_MolarMass.AutoSize = true;
			this.txt_MolarMass.Location = new System.Drawing.Point(93, 33);
			this.txt_MolarMass.Name = "txt_MolarMass";
			this.txt_MolarMass.Size = new System.Drawing.Size(27, 13);
			this.txt_MolarMass.TabIndex = 0;
			this.txt_MolarMass.Text = "N/A";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Molar mass:";
			// 
			// txt_Names
			// 
			this.txt_Names.AutoSize = true;
			this.txt_Names.Location = new System.Drawing.Point(93, 16);
			this.txt_Names.Name = "txt_Names";
			this.txt_Names.Size = new System.Drawing.Size(27, 13);
			this.txt_Names.TabIndex = 0;
			this.txt_Names.Text = "N/A";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Names:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox2.Controls.Add(this.listBox1);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.groupBox2.Location = new System.Drawing.Point(380, 135);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(253, 229);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Used In";
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.Window;
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.listBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g"});
			this.listBox1.Location = new System.Drawing.Point(3, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(247, 210);
			this.listBox1.TabIndex = 0;
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox1.Controls.Add(this.cguid);
			this.groupBox1.Controls.Add(this.rtb_Description);
			this.groupBox1.Controls.Add(this.txt_chemName);
			this.groupBox1.Controls.Add(this.rtb_Formula);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(627, 123);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Compound";
			// 
			// cguid
			// 
			this.cguid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cguid.AutoSize = true;
			this.cguid.Location = new System.Drawing.Point(11, 101);
			this.cguid.Name = "cguid";
			this.cguid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cguid.Size = new System.Drawing.Size(34, 13);
			this.cguid.TabIndex = 5;
			this.cguid.Text = "GUID";
			// 
			// rtb_Description
			// 
			this.rtb_Description.BackColor = System.Drawing.SystemColors.Window;
			this.rtb_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_Description.ForeColor = System.Drawing.SystemColors.WindowText;
			this.rtb_Description.Location = new System.Drawing.Point(216, 16);
			this.rtb_Description.Name = "rtb_Description";
			this.rtb_Description.ReadOnly = true;
			this.rtb_Description.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rtb_Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtb_Description.Size = new System.Drawing.Size(405, 99);
			this.rtb_Description.TabIndex = 3;
			this.rtb_Description.Text = "Acetic acid (or ethanoic acid) is an organic compound with the chemical formula C" +
    "H3COOH. It is a colorless liquid that when undiluted is called glacial acetic ac" +
    "id.";
			// 
			// txt_chemName
			// 
			this.txt_chemName.AutoSize = true;
			this.txt_chemName.BackColor = System.Drawing.SystemColors.Window;
			this.txt_chemName.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txt_chemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.txt_chemName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_chemName.Location = new System.Drawing.Point(6, 16);
			this.txt_chemName.Name = "txt_chemName";
			this.txt_chemName.Size = new System.Drawing.Size(104, 26);
			this.txt_chemName.TabIndex = 0;
			this.txt_chemName.Text = "Chemical";
			// 
			// rtb_Formula
			// 
			this.rtb_Formula.BackColor = System.Drawing.SystemColors.Window;
			this.rtb_Formula.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_Formula.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.rtb_Formula.ForeColor = System.Drawing.SystemColors.WindowText;
			this.rtb_Formula.Location = new System.Drawing.Point(11, 45);
			this.rtb_Formula.Name = "rtb_Formula";
			this.rtb_Formula.ReadOnly = true;
			this.rtb_Formula.Size = new System.Drawing.Size(122, 21);
			this.rtb_Formula.TabIndex = 2;
			this.rtb_Formula.Text = "Formula";
			// 
			// tab_Projects
			// 
			this.tab_Projects.Location = new System.Drawing.Point(4, 22);
			this.tab_Projects.Name = "tab_Projects";
			this.tab_Projects.Size = new System.Drawing.Size(990, 505);
			this.tab_Projects.TabIndex = 2;
			this.tab_Projects.Text = "Projects";
			this.tab_Projects.UseVisualStyleBackColor = true;
			// 
			// tab_Equipment
			// 
			this.tab_Equipment.Location = new System.Drawing.Point(4, 22);
			this.tab_Equipment.Name = "tab_Equipment";
			this.tab_Equipment.Size = new System.Drawing.Size(990, 505);
			this.tab_Equipment.TabIndex = 3;
			this.tab_Equipment.Text = "Equipment";
			this.tab_Equipment.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(998, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
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
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 101);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Boiling point:";
			// 
			// txt_BoilingPoint
			// 
			this.txt_BoilingPoint.AutoSize = true;
			this.txt_BoilingPoint.Location = new System.Drawing.Point(93, 101);
			this.txt_BoilingPoint.Name = "txt_BoilingPoint";
			this.txt_BoilingPoint.Size = new System.Drawing.Size(27, 13);
			this.txt_BoilingPoint.TabIndex = 0;
			this.txt_BoilingPoint.Text = "N/A";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 118);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(87, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Sulibility in water:";
			// 
			// txt_SInWater
			// 
			this.txt_SInWater.AutoSize = true;
			this.txt_SInWater.Location = new System.Drawing.Point(93, 118);
			this.txt_SInWater.Name = "txt_SInWater";
			this.txt_SInWater.Size = new System.Drawing.Size(27, 13);
			this.txt_SInWater.TabIndex = 0;
			this.txt_SInWater.Text = "N/A";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 135);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(51, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "Solubility:";
			// 
			// txt_Solubility
			// 
			this.txt_Solubility.AutoSize = true;
			this.txt_Solubility.Location = new System.Drawing.Point(93, 135);
			this.txt_Solubility.Name = "txt_Solubility";
			this.txt_Solubility.Size = new System.Drawing.Size(27, 13);
			this.txt_Solubility.TabIndex = 0;
			this.txt_Solubility.Text = "N/A";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 152);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(87, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Vapour pressure:";
			// 
			// txt_VapourPressure
			// 
			this.txt_VapourPressure.AutoSize = true;
			this.txt_VapourPressure.Location = new System.Drawing.Point(93, 152);
			this.txt_VapourPressure.Name = "txt_VapourPressure";
			this.txt_VapourPressure.Size = new System.Drawing.Size(27, 13);
			this.txt_VapourPressure.TabIndex = 0;
			this.txt_VapourPressure.Text = "N/A";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 169);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(69, 13);
			this.label18.TabIndex = 0;
			this.label18.Text = "Acidity (pKa):";
			// 
			// txt_Acidity
			// 
			this.txt_Acidity.AutoSize = true;
			this.txt_Acidity.Location = new System.Drawing.Point(93, 169);
			this.txt_Acidity.Name = "txt_Acidity";
			this.txt_Acidity.Size = new System.Drawing.Size(27, 13);
			this.txt_Acidity.TabIndex = 0;
			this.txt_Acidity.Text = "N/A";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(6, 186);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(61, 13);
			this.label20.TabIndex = 0;
			this.label20.Text = "Flash point:";
			// 
			// txt_FlashPoint
			// 
			this.txt_FlashPoint.AutoSize = true;
			this.txt_FlashPoint.Location = new System.Drawing.Point(93, 186);
			this.txt_FlashPoint.Name = "txt_FlashPoint";
			this.txt_FlashPoint.Size = new System.Drawing.Size(27, 13);
			this.txt_FlashPoint.TabIndex = 0;
			this.txt_FlashPoint.Text = "N/A";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(6, 237);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(31, 13);
			this.label22.TabIndex = 0;
			this.label22.Text = "Wiki:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(6, 254);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(55, 13);
			this.label24.TabIndex = 0;
			this.label24.Text = "Purchase:";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(6, 271);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(41, 13);
			this.label26.TabIndex = 0;
			this.label26.Text = "MSDS:";
			// 
			// tlink_Wiki
			// 
			this.tlink_Wiki.AutoSize = true;
			this.tlink_Wiki.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tlink_Wiki.LinkColor = System.Drawing.Color.Black;
			this.tlink_Wiki.Location = new System.Drawing.Point(93, 237);
			this.tlink_Wiki.Name = "tlink_Wiki";
			this.tlink_Wiki.Size = new System.Drawing.Size(27, 13);
			this.tlink_Wiki.TabIndex = 1;
			this.tlink_Wiki.TabStop = true;
			this.tlink_Wiki.Text = "Link";
			this.tlink_Wiki.VisitedLinkColor = System.Drawing.Color.Black;
			this.tlink_Wiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tlink_Wiki_LinkClicked);
			// 
			// tlink_Purchase
			// 
			this.tlink_Purchase.AutoSize = true;
			this.tlink_Purchase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tlink_Purchase.LinkColor = System.Drawing.Color.Black;
			this.tlink_Purchase.Location = new System.Drawing.Point(93, 254);
			this.tlink_Purchase.Name = "tlink_Purchase";
			this.tlink_Purchase.Size = new System.Drawing.Size(27, 13);
			this.tlink_Purchase.TabIndex = 1;
			this.tlink_Purchase.TabStop = true;
			this.tlink_Purchase.Text = "Link";
			this.tlink_Purchase.VisitedLinkColor = System.Drawing.Color.Black;
			this.tlink_Purchase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tlink_Purchase_LinkClicked);
			// 
			// tlink_MSDS
			// 
			this.tlink_MSDS.AutoSize = true;
			this.tlink_MSDS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tlink_MSDS.LinkColor = System.Drawing.Color.Black;
			this.tlink_MSDS.Location = new System.Drawing.Point(93, 271);
			this.tlink_MSDS.Name = "tlink_MSDS";
			this.tlink_MSDS.Size = new System.Drawing.Size(27, 13);
			this.tlink_MSDS.TabIndex = 1;
			this.tlink_MSDS.TabStop = true;
			this.tlink_MSDS.Text = "Link";
			this.tlink_MSDS.VisitedLinkColor = System.Drawing.Color.Black;
			this.tlink_MSDS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tlink_MSDS_LinkClicked);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "LD50:";
			// 
			// txt_LD50
			// 
			this.txt_LD50.AutoSize = true;
			this.txt_LD50.Location = new System.Drawing.Point(93, 203);
			this.txt_LD50.Name = "txt_LD50";
			this.txt_LD50.Size = new System.Drawing.Size(27, 13);
			this.txt_LD50.TabIndex = 0;
			this.txt_LD50.Text = "N/A";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 220);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "LC50:";
			// 
			// txt_LC50
			// 
			this.txt_LC50.AutoSize = true;
			this.txt_LC50.Location = new System.Drawing.Point(93, 220);
			this.txt_LC50.Name = "txt_LC50";
			this.txt_LC50.Size = new System.Drawing.Size(27, 13);
			this.txt_LC50.TabIndex = 0;
			this.txt_LC50.Text = "N/A";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(998, 555);
			this.Controls.Add(this.tab_Switcher);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1014, 594);
			this.MinimumSize = new System.Drawing.Size(1014, 594);
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
			this.panel_Info.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.RichTextBox rtb_Description;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txt_Names;
		private System.Windows.Forms.Label txt_MolarMass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txt_Density;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label txt_Appearance;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label txt_MeltingPoint;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label txt_Acidity;
		private System.Windows.Forms.Label txt_VapourPressure;
		private System.Windows.Forms.Label txt_Solubility;
		private System.Windows.Forms.Label txt_SInWater;
		private System.Windows.Forms.Label txt_BoilingPoint;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.LinkLabel tlink_MSDS;
		private System.Windows.Forms.LinkLabel tlink_Purchase;
		private System.Windows.Forms.LinkLabel tlink_Wiki;
		private System.Windows.Forms.Label txt_FlashPoint;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label txt_LC50;
		private System.Windows.Forms.Label txt_LD50;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
	}
}

