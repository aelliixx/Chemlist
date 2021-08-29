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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", 8);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_Switcher = new System.Windows.Forms.TabControl();
            this.tab_Chemicals = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbox_ChemicalList = new System.Windows.Forms.ListBox();
            this.tbox_CompoundSearch = new System.Windows.Forms.TextBox();
            this.cbox_CompoundSort = new System.Windows.Forms.ComboBox();
            this.btn_RemoveChemicalFromList = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.btn_EditCurrentChemical = new System.Windows.Forms.Button();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbox_ChemMadeIn = new System.Windows.Forms.ListBox();
            this.lview_Warnings = new System.Windows.Forms.ListView();
            this.hazardImages = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_Solubility = new System.Windows.Forms.RichTextBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Names = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Appearance = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbox_Properties = new System.Windows.Forms.GroupBox();
            this.tlink_MSDS = new System.Windows.Forms.LinkLabel();
            this.tlink_Purchase = new System.Windows.Forms.LinkLabel();
            this.tlink_Wiki = new System.Windows.Forms.LinkLabel();
            this.txt_LC50 = new System.Windows.Forms.Label();
            this.txt_LD50 = new System.Windows.Forms.Label();
            this.txt_FlashPoint = new System.Windows.Forms.Label();
            this.txt_Acidity = new System.Windows.Forms.Label();
            this.txt_VapourPressure = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_SInWater = new System.Windows.Forms.Label();
            this.txt_wiki = new System.Windows.Forms.Label();
            this.txt_BoilingPoint = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_MeltingPoint = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Density = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MolarMass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbox_UsedIn = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Availability = new System.Windows.Forms.Label();
            this.txt_chemName = new System.Windows.Forms.Label();
            this.cguid = new System.Windows.Forms.Label();
            this.rtb_Formula = new System.Windows.Forms.RichTextBox();
            this.tab_Projects = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lbox_ProjectList = new System.Windows.Forms.ListBox();
            this.tbox_ProjectSearch = new System.Windows.Forms.TextBox();
            this.cbox_ProjectSort = new System.Windows.Forms.ComboBox();
            this.btn_DeleteProject = new System.Windows.Forms.Button();
            this.btn_AddNewProject = new System.Windows.Forms.Button();
            this.btn_EditProject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_ProjectInfo = new System.Windows.Forms.TabControl();
            this.tab_Description = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_ProjectDescription = new System.Windows.Forms.RichTextBox();
            this.tab_Methods = new System.Windows.Forms.TabPage();
            this.rtb_Methods = new System.Windows.Forms.RichTextBox();
            this.tab_Yields = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbox_RequiredChem = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pguid = new System.Windows.Forms.Label();
            this.txt_ProjectDoable = new System.Windows.Forms.Label();
            this.txt_Project = new System.Windows.Forms.Label();
            this.rtb_ProjectChemFormula = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.groupBox4.SuspendLayout();
            this.gbox_Properties.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_Projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_ProjectInfo.SuspendLayout();
            this.tab_Description.SuspendLayout();
            this.tab_Methods.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Switcher
            // 
            this.tab_Switcher.Controls.Add(this.tab_Chemicals);
            this.tab_Switcher.Controls.Add(this.tab_Projects);
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
            this.tab_Chemicals.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Chemicals.Controls.Add(this.splitContainer1);
            this.tab_Chemicals.Location = new System.Drawing.Point(4, 22);
            this.tab_Chemicals.Name = "tab_Chemicals";
            this.tab_Chemicals.Size = new System.Drawing.Size(990, 505);
            this.tab_Chemicals.TabIndex = 1;
            this.tab_Chemicals.Text = "Chemicals";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
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
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.tbox_CompoundSearch);
            this.splitContainer2.Panel2.Controls.Add(this.cbox_CompoundSort);
            this.splitContainer2.Panel2.Controls.Add(this.btn_RemoveChemicalFromList);
            this.splitContainer2.Panel2.Controls.Add(this.btn_AddNew);
            this.splitContainer2.Panel2.Controls.Add(this.btn_EditCurrentChemical);
            this.splitContainer2.Size = new System.Drawing.Size(330, 505);
            this.splitContainer2.SplitterDistance = 438;
            this.splitContainer2.TabIndex = 0;
            // 
            // lbox_ChemicalList
            // 
            this.lbox_ChemicalList.BackColor = System.Drawing.SystemColors.Control;
            this.lbox_ChemicalList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_ChemicalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_ChemicalList.ForeColor = System.Drawing.Color.Black;
            this.lbox_ChemicalList.FormattingEnabled = true;
            this.lbox_ChemicalList.Items.AddRange(new object[] {
            "Compound List"});
            this.lbox_ChemicalList.Location = new System.Drawing.Point(0, 0);
            this.lbox_ChemicalList.Margin = new System.Windows.Forms.Padding(0);
            this.lbox_ChemicalList.Name = "lbox_ChemicalList";
            this.lbox_ChemicalList.Size = new System.Drawing.Size(330, 438);
            this.lbox_ChemicalList.Sorted = true;
            this.lbox_ChemicalList.TabIndex = 0;
            this.lbox_ChemicalList.SelectedIndexChanged += new System.EventHandler(this.lbox_ChemicalList_SelectedIndexChanged);
            // 
            // tbox_CompoundSearch
            // 
            this.tbox_CompoundSearch.Location = new System.Drawing.Point(8, 4);
            this.tbox_CompoundSearch.Name = "tbox_CompoundSearch";
            this.tbox_CompoundSearch.Size = new System.Drawing.Size(155, 20);
            this.tbox_CompoundSearch.TabIndex = 9;
            this.tbox_CompoundSearch.TextChanged += new System.EventHandler(this.tbox_CompoundSearch_TextChanged);
            this.tbox_CompoundSearch.Enter += new System.EventHandler(this.tbox_CompoundSearch_Enter);
            this.tbox_CompoundSearch.Leave += new System.EventHandler(this.tbox_CompoundSearch_Leave);
            // 
            // cbox_CompoundSort
            // 
            this.cbox_CompoundSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_CompoundSort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_CompoundSort.BackColor = System.Drawing.SystemColors.Control;
            this.cbox_CompoundSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_CompoundSort.Items.AddRange(new object[] {
            "All",
            "Only Available",
            "Only Unavailable"});
            this.cbox_CompoundSort.Location = new System.Drawing.Point(169, 4);
            this.cbox_CompoundSort.Name = "cbox_CompoundSort";
            this.cbox_CompoundSort.Size = new System.Drawing.Size(157, 21);
            this.cbox_CompoundSort.TabIndex = 8;
            this.cbox_CompoundSort.SelectionChangeCommitted += new System.EventHandler(this.cbox_CompoundSort_SelectedIndexChanged);
            // 
            // btn_RemoveChemicalFromList
            // 
            this.btn_RemoveChemicalFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemoveChemicalFromList.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RemoveChemicalFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveChemicalFromList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_RemoveChemicalFromList.Location = new System.Drawing.Point(228, 30);
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
            this.btn_AddNew.Location = new System.Drawing.Point(8, 30);
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
            this.btn_EditCurrentChemical.Location = new System.Drawing.Point(118, 30);
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
            this.panel_Info.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Info.Controls.Add(this.groupBox3);
            this.panel_Info.Controls.Add(this.gbox_Properties);
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
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lview_Warnings);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rtb_Solubility);
            this.groupBox3.Controls.Add(this.rtb_Description);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_Names);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_Appearance);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(6, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 212);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbox_ChemMadeIn);
            this.groupBox4.Location = new System.Drawing.Point(6, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 62);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Made In";
            // 
            // lbox_ChemMadeIn
            // 
            this.lbox_ChemMadeIn.BackColor = System.Drawing.SystemColors.Control;
            this.lbox_ChemMadeIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_ChemMadeIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_ChemMadeIn.FormattingEnabled = true;
            this.lbox_ChemMadeIn.Location = new System.Drawing.Point(3, 16);
            this.lbox_ChemMadeIn.Name = "lbox_ChemMadeIn";
            this.lbox_ChemMadeIn.Size = new System.Drawing.Size(259, 43);
            this.lbox_ChemMadeIn.TabIndex = 0;
            // 
            // lview_Warnings
            // 
            this.lview_Warnings.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lview_Warnings.BackColor = System.Drawing.SystemColors.Control;
            this.lview_Warnings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lview_Warnings.HideSelection = false;
            this.lview_Warnings.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lview_Warnings.LargeImageList = this.hazardImages;
            this.lview_Warnings.Location = new System.Drawing.Point(377, 144);
            this.lview_Warnings.Margin = new System.Windows.Forms.Padding(0);
            this.lview_Warnings.MultiSelect = false;
            this.lview_Warnings.Name = "lview_Warnings";
            this.lview_Warnings.Size = new System.Drawing.Size(243, 59);
            this.lview_Warnings.TabIndex = 6;
            this.lview_Warnings.TileSize = new System.Drawing.Size(55, 55);
            this.lview_Warnings.UseCompatibleStateImageBehavior = false;
            this.lview_Warnings.View = System.Windows.Forms.View.Tile;
            // 
            // hazardImages
            // 
            this.hazardImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("hazardImages.ImageStream")));
            this.hazardImages.TransparentColor = System.Drawing.Color.Transparent;
            this.hazardImages.Images.SetKeyName(0, "AcutelyToxic");
            this.hazardImages.Images.SetKeyName(1, "Corrosive");
            this.hazardImages.Images.SetKeyName(2, "EnvironmentalHazard");
            this.hazardImages.Images.SetKeyName(3, "MildIrritant");
            this.hazardImages.Images.SetKeyName(4, "Explosive");
            this.hazardImages.Images.SetKeyName(5, "Flamable");
            this.hazardImages.Images.SetKeyName(6, "Pressurised");
            this.hazardImages.Images.SetKeyName(7, "HealthHazard");
            this.hazardImages.Images.SetKeyName(8, "Oxidiser");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hazards:";
            // 
            // rtb_Solubility
            // 
            this.rtb_Solubility.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Solubility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Solubility.Location = new System.Drawing.Point(369, 45);
            this.rtb_Solubility.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rtb_Solubility.Name = "rtb_Solubility";
            this.rtb_Solubility.ReadOnly = true;
            this.rtb_Solubility.Size = new System.Drawing.Size(251, 96);
            this.rtb_Solubility.TabIndex = 4;
            this.rtb_Solubility.Text = "";
            // 
            // rtb_Description
            // 
            this.rtb_Description.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Description.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_Description.Location = new System.Drawing.Point(6, 19);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.ReadOnly = true;
            this.rtb_Description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtb_Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_Description.Size = new System.Drawing.Size(265, 122);
            this.rtb_Description.TabIndex = 3;
            this.rtb_Description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Names:";
            // 
            // txt_Names
            // 
            this.txt_Names.AutoSize = true;
            this.txt_Names.Location = new System.Drawing.Point(367, 19);
            this.txt_Names.Name = "txt_Names";
            this.txt_Names.Size = new System.Drawing.Size(27, 13);
            this.txt_Names.TabIndex = 0;
            this.txt_Names.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Appearance:";
            // 
            // txt_Appearance
            // 
            this.txt_Appearance.AutoSize = true;
            this.txt_Appearance.Location = new System.Drawing.Point(367, 32);
            this.txt_Appearance.Name = "txt_Appearance";
            this.txt_Appearance.Size = new System.Drawing.Size(27, 13);
            this.txt_Appearance.TabIndex = 0;
            this.txt_Appearance.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(280, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Solubility:";
            // 
            // gbox_Properties
            // 
            this.gbox_Properties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Properties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbox_Properties.BackColor = System.Drawing.SystemColors.Control;
            this.gbox_Properties.Controls.Add(this.tlink_MSDS);
            this.gbox_Properties.Controls.Add(this.tlink_Purchase);
            this.gbox_Properties.Controls.Add(this.tlink_Wiki);
            this.gbox_Properties.Controls.Add(this.txt_LC50);
            this.gbox_Properties.Controls.Add(this.txt_LD50);
            this.gbox_Properties.Controls.Add(this.txt_FlashPoint);
            this.gbox_Properties.Controls.Add(this.txt_Acidity);
            this.gbox_Properties.Controls.Add(this.txt_VapourPressure);
            this.gbox_Properties.Controls.Add(this.label24);
            this.gbox_Properties.Controls.Add(this.label26);
            this.gbox_Properties.Controls.Add(this.txt_SInWater);
            this.gbox_Properties.Controls.Add(this.txt_wiki);
            this.gbox_Properties.Controls.Add(this.txt_BoilingPoint);
            this.gbox_Properties.Controls.Add(this.label7);
            this.gbox_Properties.Controls.Add(this.label3);
            this.gbox_Properties.Controls.Add(this.label20);
            this.gbox_Properties.Controls.Add(this.txt_MeltingPoint);
            this.gbox_Properties.Controls.Add(this.label18);
            this.gbox_Properties.Controls.Add(this.label16);
            this.gbox_Properties.Controls.Add(this.label12);
            this.gbox_Properties.Controls.Add(this.label10);
            this.gbox_Properties.Controls.Add(this.label8);
            this.gbox_Properties.Controls.Add(this.txt_Density);
            this.gbox_Properties.Controls.Add(this.label6);
            this.gbox_Properties.Controls.Add(this.txt_MolarMass);
            this.gbox_Properties.Controls.Add(this.label2);
            this.gbox_Properties.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbox_Properties.Location = new System.Drawing.Point(6, 353);
            this.gbox_Properties.Name = "gbox_Properties";
            this.gbox_Properties.Size = new System.Drawing.Size(368, 144);
            this.gbox_Properties.TabIndex = 8;
            this.gbox_Properties.TabStop = false;
            this.gbox_Properties.Text = "Properties";
            // 
            // tlink_MSDS
            // 
            this.tlink_MSDS.AutoSize = true;
            this.tlink_MSDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlink_MSDS.LinkColor = System.Drawing.Color.Black;
            this.tlink_MSDS.Location = new System.Drawing.Point(276, 101);
            this.tlink_MSDS.Name = "tlink_MSDS";
            this.tlink_MSDS.Size = new System.Drawing.Size(27, 13);
            this.tlink_MSDS.TabIndex = 1;
            this.tlink_MSDS.TabStop = true;
            this.tlink_MSDS.Text = "Link";
            this.tlink_MSDS.VisitedLinkColor = System.Drawing.Color.Black;
            this.tlink_MSDS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tlink_MSDS_LinkClicked);
            // 
            // tlink_Purchase
            // 
            this.tlink_Purchase.AutoSize = true;
            this.tlink_Purchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlink_Purchase.LinkColor = System.Drawing.Color.Black;
            this.tlink_Purchase.Location = new System.Drawing.Point(93, 117);
            this.tlink_Purchase.Name = "tlink_Purchase";
            this.tlink_Purchase.Size = new System.Drawing.Size(27, 13);
            this.tlink_Purchase.TabIndex = 1;
            this.tlink_Purchase.TabStop = true;
            this.tlink_Purchase.Text = "Link";
            this.tlink_Purchase.VisitedLinkColor = System.Drawing.Color.Black;
            this.tlink_Purchase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tlink_Purchase_LinkClicked);
            // 
            // tlink_Wiki
            // 
            this.tlink_Wiki.AutoSize = true;
            this.tlink_Wiki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlink_Wiki.LinkColor = System.Drawing.Color.Black;
            this.tlink_Wiki.Location = new System.Drawing.Point(93, 100);
            this.tlink_Wiki.Name = "tlink_Wiki";
            this.tlink_Wiki.Size = new System.Drawing.Size(27, 13);
            this.tlink_Wiki.TabIndex = 1;
            this.tlink_Wiki.TabStop = true;
            this.tlink_Wiki.Text = "Link";
            this.tlink_Wiki.VisitedLinkColor = System.Drawing.Color.Black;
            this.tlink_Wiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tlink_Wiki_LinkClicked);
            // 
            // txt_LC50
            // 
            this.txt_LC50.AutoSize = true;
            this.txt_LC50.Location = new System.Drawing.Point(276, 84);
            this.txt_LC50.Name = "txt_LC50";
            this.txt_LC50.Size = new System.Drawing.Size(27, 13);
            this.txt_LC50.TabIndex = 0;
            this.txt_LC50.Text = "N/A";
            // 
            // txt_LD50
            // 
            this.txt_LD50.AutoSize = true;
            this.txt_LD50.Location = new System.Drawing.Point(276, 67);
            this.txt_LD50.Name = "txt_LD50";
            this.txt_LD50.Size = new System.Drawing.Size(27, 13);
            this.txt_LD50.TabIndex = 0;
            this.txt_LD50.Text = "N/A";
            // 
            // txt_FlashPoint
            // 
            this.txt_FlashPoint.AutoSize = true;
            this.txt_FlashPoint.Location = new System.Drawing.Point(276, 50);
            this.txt_FlashPoint.Name = "txt_FlashPoint";
            this.txt_FlashPoint.Size = new System.Drawing.Size(27, 13);
            this.txt_FlashPoint.TabIndex = 0;
            this.txt_FlashPoint.Text = "N/A";
            // 
            // txt_Acidity
            // 
            this.txt_Acidity.AutoSize = true;
            this.txt_Acidity.Location = new System.Drawing.Point(276, 33);
            this.txt_Acidity.Name = "txt_Acidity";
            this.txt_Acidity.Size = new System.Drawing.Size(27, 13);
            this.txt_Acidity.TabIndex = 0;
            this.txt_Acidity.Text = "N/A";
            // 
            // txt_VapourPressure
            // 
            this.txt_VapourPressure.AutoSize = true;
            this.txt_VapourPressure.Location = new System.Drawing.Point(276, 16);
            this.txt_VapourPressure.Name = "txt_VapourPressure";
            this.txt_VapourPressure.Size = new System.Drawing.Size(27, 13);
            this.txt_VapourPressure.TabIndex = 0;
            this.txt_VapourPressure.Text = "N/A";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Purchase:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(189, 101);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "MSDS:";
            // 
            // txt_SInWater
            // 
            this.txt_SInWater.AutoSize = true;
            this.txt_SInWater.Location = new System.Drawing.Point(93, 84);
            this.txt_SInWater.Name = "txt_SInWater";
            this.txt_SInWater.Size = new System.Drawing.Size(27, 13);
            this.txt_SInWater.TabIndex = 0;
            this.txt_SInWater.Text = "N/A";
            // 
            // txt_wiki
            // 
            this.txt_wiki.AutoSize = true;
            this.txt_wiki.Location = new System.Drawing.Point(6, 100);
            this.txt_wiki.Name = "txt_wiki";
            this.txt_wiki.Size = new System.Drawing.Size(31, 13);
            this.txt_wiki.TabIndex = 0;
            this.txt_wiki.Text = "Wiki:";
            // 
            // txt_BoilingPoint
            // 
            this.txt_BoilingPoint.AutoSize = true;
            this.txt_BoilingPoint.Location = new System.Drawing.Point(93, 67);
            this.txt_BoilingPoint.Name = "txt_BoilingPoint";
            this.txt_BoilingPoint.Size = new System.Drawing.Size(27, 13);
            this.txt_BoilingPoint.TabIndex = 0;
            this.txt_BoilingPoint.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "LC50:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "LD50:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(189, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Flash point:";
            // 
            // txt_MeltingPoint
            // 
            this.txt_MeltingPoint.AutoSize = true;
            this.txt_MeltingPoint.Location = new System.Drawing.Point(93, 50);
            this.txt_MeltingPoint.Name = "txt_MeltingPoint";
            this.txt_MeltingPoint.Size = new System.Drawing.Size(27, 13);
            this.txt_MeltingPoint.TabIndex = 0;
            this.txt_MeltingPoint.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(189, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Acidity (pKa):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(189, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Vapour pressure:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sulibility in water:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Boiling point:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Melting point:";
            // 
            // txt_Density
            // 
            this.txt_Density.AutoSize = true;
            this.txt_Density.Location = new System.Drawing.Point(93, 33);
            this.txt_Density.Name = "txt_Density";
            this.txt_Density.Size = new System.Drawing.Size(27, 13);
            this.txt_Density.TabIndex = 0;
            this.txt_Density.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Density:";
            // 
            // txt_MolarMass
            // 
            this.txt_MolarMass.AutoSize = true;
            this.txt_MolarMass.Location = new System.Drawing.Point(93, 16);
            this.txt_MolarMass.Name = "txt_MolarMass";
            this.txt_MolarMass.Size = new System.Drawing.Size(27, 13);
            this.txt_MolarMass.TabIndex = 0;
            this.txt_MolarMass.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Molar mass:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lbox_UsedIn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(380, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 144);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Used In";
            // 
            // lbox_UsedIn
            // 
            this.lbox_UsedIn.BackColor = System.Drawing.SystemColors.Control;
            this.lbox_UsedIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_UsedIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_UsedIn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbox_UsedIn.Location = new System.Drawing.Point(3, 16);
            this.lbox_UsedIn.Name = "lbox_UsedIn";
            this.lbox_UsedIn.Size = new System.Drawing.Size(247, 125);
            this.lbox_UsedIn.TabIndex = 0;
            this.lbox_UsedIn.DoubleClick += new System.EventHandler(this.lbox_UsedIn_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txt_Availability);
            this.groupBox1.Controls.Add(this.txt_chemName);
            this.groupBox1.Controls.Add(this.cguid);
            this.groupBox1.Controls.Add(this.rtb_Formula);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compound";
            // 
            // txt_Availability
            // 
            this.txt_Availability.AutoSize = true;
            this.txt_Availability.Location = new System.Drawing.Point(8, 69);
            this.txt_Availability.Name = "txt_Availability";
            this.txt_Availability.Size = new System.Drawing.Size(56, 13);
            this.txt_Availability.TabIndex = 6;
            this.txt_Availability.Text = "Availability";
            // 
            // txt_chemName
            // 
            this.txt_chemName.AutoSize = true;
            this.txt_chemName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_chemName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_chemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_chemName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_chemName.Location = new System.Drawing.Point(6, 16);
            this.txt_chemName.Name = "txt_chemName";
            this.txt_chemName.Size = new System.Drawing.Size(104, 26);
            this.txt_chemName.TabIndex = 0;
            this.txt_chemName.Text = "Chemical";
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
            // rtb_Formula
            // 
            this.rtb_Formula.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Formula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Formula.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtb_Formula.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_Formula.Location = new System.Drawing.Point(11, 45);
            this.rtb_Formula.Name = "rtb_Formula";
            this.rtb_Formula.ReadOnly = true;
            this.rtb_Formula.Size = new System.Drawing.Size(147, 21);
            this.rtb_Formula.TabIndex = 2;
            this.rtb_Formula.Text = "Formula";
            // 
            // tab_Projects
            // 
            this.tab_Projects.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Projects.Controls.Add(this.splitContainer3);
            this.tab_Projects.Location = new System.Drawing.Point(4, 22);
            this.tab_Projects.Name = "tab_Projects";
            this.tab_Projects.Size = new System.Drawing.Size(990, 505);
            this.tab_Projects.TabIndex = 2;
            this.tab_Projects.Text = "Projects";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel2.Controls.Add(this.panel1);
            this.splitContainer3.Size = new System.Drawing.Size(990, 505);
            this.splitContainer3.SplitterDistance = 330;
            this.splitContainer3.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lbox_ProjectList);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Panel2.Controls.Add(this.tbox_ProjectSearch);
            this.splitContainer4.Panel2.Controls.Add(this.cbox_ProjectSort);
            this.splitContainer4.Panel2.Controls.Add(this.btn_DeleteProject);
            this.splitContainer4.Panel2.Controls.Add(this.btn_AddNewProject);
            this.splitContainer4.Panel2.Controls.Add(this.btn_EditProject);
            this.splitContainer4.Size = new System.Drawing.Size(330, 505);
            this.splitContainer4.SplitterDistance = 438;
            this.splitContainer4.TabIndex = 0;
            // 
            // lbox_ProjectList
            // 
            this.lbox_ProjectList.BackColor = System.Drawing.SystemColors.Control;
            this.lbox_ProjectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_ProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_ProjectList.ForeColor = System.Drawing.Color.Black;
            this.lbox_ProjectList.FormattingEnabled = true;
            this.lbox_ProjectList.Items.AddRange(new object[] {
            "Project List"});
            this.lbox_ProjectList.Location = new System.Drawing.Point(0, 0);
            this.lbox_ProjectList.Margin = new System.Windows.Forms.Padding(0);
            this.lbox_ProjectList.Name = "lbox_ProjectList";
            this.lbox_ProjectList.Size = new System.Drawing.Size(330, 438);
            this.lbox_ProjectList.Sorted = true;
            this.lbox_ProjectList.TabIndex = 0;
            this.lbox_ProjectList.SelectedIndexChanged += new System.EventHandler(this.lbox_ProjectList_SelectedIndexChanged);
            // 
            // tbox_ProjectSearch
            // 
            this.tbox_ProjectSearch.Location = new System.Drawing.Point(8, 4);
            this.tbox_ProjectSearch.Name = "tbox_ProjectSearch";
            this.tbox_ProjectSearch.Size = new System.Drawing.Size(155, 20);
            this.tbox_ProjectSearch.TabIndex = 7;
            this.tbox_ProjectSearch.TextChanged += new System.EventHandler(this.tbox_ProjectSearch_TextChanged);
            // 
            // cbox_ProjectSort
            // 
            this.cbox_ProjectSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ProjectSort.FormattingEnabled = true;
            this.cbox_ProjectSort.Location = new System.Drawing.Point(169, 4);
            this.cbox_ProjectSort.Name = "cbox_ProjectSort";
            this.cbox_ProjectSort.Size = new System.Drawing.Size(157, 21);
            this.cbox_ProjectSort.TabIndex = 6;
            this.cbox_ProjectSort.SelectedIndexChanged += new System.EventHandler(this.cbox_ProjectSort_SelectedIndexChanged);
            // 
            // btn_DeleteProject
            // 
            this.btn_DeleteProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteProject.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteProject.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_DeleteProject.Location = new System.Drawing.Point(228, 30);
            this.btn_DeleteProject.Name = "btn_DeleteProject";
            this.btn_DeleteProject.Size = new System.Drawing.Size(98, 25);
            this.btn_DeleteProject.TabIndex = 3;
            this.btn_DeleteProject.Text = "Delete";
            this.btn_DeleteProject.UseVisualStyleBackColor = false;
            this.btn_DeleteProject.Click += new System.EventHandler(this.btn_DeleteProject_Click);
            // 
            // btn_AddNewProject
            // 
            this.btn_AddNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNewProject.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewProject.Location = new System.Drawing.Point(8, 30);
            this.btn_AddNewProject.Name = "btn_AddNewProject";
            this.btn_AddNewProject.Size = new System.Drawing.Size(98, 25);
            this.btn_AddNewProject.TabIndex = 5;
            this.btn_AddNewProject.Text = "Add New";
            this.btn_AddNewProject.UseVisualStyleBackColor = false;
            this.btn_AddNewProject.Click += new System.EventHandler(this.btn_AddNewProject_Click);
            // 
            // btn_EditProject
            // 
            this.btn_EditProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditProject.BackColor = System.Drawing.SystemColors.Control;
            this.btn_EditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditProject.Location = new System.Drawing.Point(118, 30);
            this.btn_EditProject.Name = "btn_EditProject";
            this.btn_EditProject.Size = new System.Drawing.Size(98, 25);
            this.btn_EditProject.TabIndex = 4;
            this.btn_EditProject.Text = "Edit";
            this.btn_EditProject.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tab_ProjectInfo);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(656, 505);
            this.panel1.TabIndex = 6;
            // 
            // tab_ProjectInfo
            // 
            this.tab_ProjectInfo.Controls.Add(this.tab_Description);
            this.tab_ProjectInfo.Controls.Add(this.tab_Methods);
            this.tab_ProjectInfo.Controls.Add(this.tab_Yields);
            this.tab_ProjectInfo.Location = new System.Drawing.Point(6, 135);
            this.tab_ProjectInfo.Name = "tab_ProjectInfo";
            this.tab_ProjectInfo.SelectedIndex = 0;
            this.tab_ProjectInfo.Size = new System.Drawing.Size(435, 362);
            this.tab_ProjectInfo.TabIndex = 9;
            // 
            // tab_Description
            // 
            this.tab_Description.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Description.Controls.Add(this.linkLabel1);
            this.tab_Description.Controls.Add(this.label9);
            this.tab_Description.Controls.Add(this.rtb_ProjectDescription);
            this.tab_Description.Location = new System.Drawing.Point(4, 22);
            this.tab_Description.Name = "tab_Description";
            this.tab_Description.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Description.Size = new System.Drawing.Size(427, 336);
            this.tab_Description.TabIndex = 0;
            this.tab_Description.Text = "Description";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.WindowText;
            this.linkLabel1.Location = new System.Drawing.Point(72, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Unavailable";
            this.linkLabel1.VisitedLinkColor = System.Drawing.SystemColors.WindowText;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Video Link:";
            // 
            // rtb_ProjectDescription
            // 
            this.rtb_ProjectDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_ProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ProjectDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_ProjectDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_ProjectDescription.Location = new System.Drawing.Point(3, 23);
            this.rtb_ProjectDescription.Name = "rtb_ProjectDescription";
            this.rtb_ProjectDescription.ReadOnly = true;
            this.rtb_ProjectDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtb_ProjectDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_ProjectDescription.Size = new System.Drawing.Size(421, 310);
            this.rtb_ProjectDescription.TabIndex = 3;
            this.rtb_ProjectDescription.Text = "";
            // 
            // tab_Methods
            // 
            this.tab_Methods.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Methods.Controls.Add(this.rtb_Methods);
            this.tab_Methods.Location = new System.Drawing.Point(4, 22);
            this.tab_Methods.Name = "tab_Methods";
            this.tab_Methods.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Methods.Size = new System.Drawing.Size(427, 336);
            this.tab_Methods.TabIndex = 1;
            this.tab_Methods.Text = "Methods";
            // 
            // rtb_Methods
            // 
            this.rtb_Methods.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Methods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Methods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Methods.Location = new System.Drawing.Point(3, 3);
            this.rtb_Methods.Name = "rtb_Methods";
            this.rtb_Methods.ReadOnly = true;
            this.rtb_Methods.Size = new System.Drawing.Size(421, 330);
            this.rtb_Methods.TabIndex = 0;
            this.rtb_Methods.Text = "";
            // 
            // tab_Yields
            // 
            this.tab_Yields.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Yields.Location = new System.Drawing.Point(4, 22);
            this.tab_Yields.Name = "tab_Yields";
            this.tab_Yields.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Yields.Size = new System.Drawing.Size(427, 336);
            this.tab_Yields.TabIndex = 2;
            this.tab_Yields.Text = "Yields";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.lbox_RequiredChem);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox5.Location = new System.Drawing.Point(447, 149);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 348);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Requires";
            // 
            // lbox_RequiredChem
            // 
            this.lbox_RequiredChem.BackColor = System.Drawing.SystemColors.Control;
            this.lbox_RequiredChem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_RequiredChem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_RequiredChem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbox_RequiredChem.Location = new System.Drawing.Point(3, 16);
            this.lbox_RequiredChem.Name = "lbox_RequiredChem";
            this.lbox_RequiredChem.Size = new System.Drawing.Size(180, 329);
            this.lbox_RequiredChem.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.richTextBox1);
            this.groupBox6.Controls.Add(this.pguid);
            this.groupBox6.Controls.Add(this.txt_ProjectDoable);
            this.groupBox6.Controls.Add(this.txt_Project);
            this.groupBox6.Controls.Add(this.rtb_ProjectChemFormula);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(627, 123);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Project";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(11, 72);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(610, 21);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Reaction";
            this.richTextBox1.Visible = false;
            // 
            // pguid
            // 
            this.pguid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pguid.AutoSize = true;
            this.pguid.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pguid.Location = new System.Drawing.Point(79, 96);
            this.pguid.Name = "pguid";
            this.pguid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pguid.Size = new System.Drawing.Size(34, 13);
            this.pguid.TabIndex = 5;
            this.pguid.Text = "GUID";
            this.pguid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pguid.Visible = false;
            // 
            // txt_ProjectDoable
            // 
            this.txt_ProjectDoable.AutoSize = true;
            this.txt_ProjectDoable.Location = new System.Drawing.Point(8, 96);
            this.txt_ProjectDoable.Name = "txt_ProjectDoable";
            this.txt_ProjectDoable.Size = new System.Drawing.Size(56, 13);
            this.txt_ProjectDoable.TabIndex = 7;
            this.txt_ProjectDoable.Text = "Availability";
            // 
            // txt_Project
            // 
            this.txt_Project.AutoSize = true;
            this.txt_Project.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Project.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_Project.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Project.Location = new System.Drawing.Point(6, 16);
            this.txt_Project.Name = "txt_Project";
            this.txt_Project.Size = new System.Drawing.Size(104, 26);
            this.txt_Project.TabIndex = 0;
            this.txt_Project.Text = "Chemical";
            // 
            // rtb_ProjectChemFormula
            // 
            this.rtb_ProjectChemFormula.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_ProjectChemFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ProjectChemFormula.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtb_ProjectChemFormula.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_ProjectChemFormula.Location = new System.Drawing.Point(11, 45);
            this.rtb_ProjectChemFormula.Multiline = false;
            this.rtb_ProjectChemFormula.Name = "rtb_ProjectChemFormula";
            this.rtb_ProjectChemFormula.ReadOnly = true;
            this.rtb_ProjectChemFormula.Size = new System.Drawing.Size(610, 21);
            this.rtb_ProjectChemFormula.TabIndex = 2;
            this.rtb_ProjectChemFormula.Text = "Formula";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
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
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(998, 555);
            this.Controls.Add(this.tab_Switcher);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel_Info.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gbox_Properties.ResumeLayout(false);
            this.gbox_Properties.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_Projects.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tab_ProjectInfo.ResumeLayout(false);
            this.tab_Description.ResumeLayout(false);
            this.tab_Description.PerformLayout();
            this.tab_Methods.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tab_Switcher;
		private System.Windows.Forms.TabPage tab_Chemicals;
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
		private System.Windows.Forms.ListBox lbox_UsedIn;
		private System.Windows.Forms.RichTextBox rtb_Description;
		private System.Windows.Forms.GroupBox gbox_Properties;
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
		private System.Windows.Forms.Label txt_wiki;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label txt_LC50;
		private System.Windows.Forms.Label txt_LD50;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tab_Projects;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.ListBox lbox_ProjectList;
		private System.Windows.Forms.Button btn_DeleteProject;
		private System.Windows.Forms.Button btn_AddNewProject;
		private System.Windows.Forms.Button btn_EditProject;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ListBox lbox_RequiredChem;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label pguid;
		private System.Windows.Forms.RichTextBox rtb_ProjectDescription;
		private System.Windows.Forms.Label txt_Project;
		private System.Windows.Forms.RichTextBox rtb_ProjectChemFormula;
		private System.Windows.Forms.TextBox tbox_ProjectSearch;
		private System.Windows.Forms.ComboBox cbox_ProjectSort;
		private System.Windows.Forms.TextBox tbox_CompoundSearch;
		private System.Windows.Forms.ComboBox cbox_CompoundSort;
		private System.Windows.Forms.Label txt_Availability;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label txt_ProjectDoable;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RichTextBox rtb_Solubility;
		private System.Windows.Forms.ListView lview_Warnings;
		private System.Windows.Forms.ImageList hazardImages;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox lbox_ChemMadeIn;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TabControl tab_ProjectInfo;
		private System.Windows.Forms.TabPage tab_Description;
		private System.Windows.Forms.TabPage tab_Methods;
		private System.Windows.Forms.RichTextBox rtb_Methods;
		private System.Windows.Forms.TabPage tab_Yields;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label9;
	}
}

