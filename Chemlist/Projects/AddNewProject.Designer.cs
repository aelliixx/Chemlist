namespace Chemlist
{
	partial class AddNewProject
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProject));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbox_ParentProject = new System.Windows.Forms.ComboBox();
			this.tbox_Description = new System.Windows.Forms.TextBox();
			this.tbox_ProjectName = new System.Windows.Forms.TextBox();
			this.rtb_ProjectFormula = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dg_CompoundList = new System.Windows.Forms.DataGridView();
			this.Compounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_RemoveRequirement = new System.Windows.Forms.Button();
			this.btn_AddRequirement = new System.Windows.Forms.Button();
			this.check_MiliPrefix = new System.Windows.Forms.CheckBox();
			this.rb_Grams = new System.Windows.Forms.RadioButton();
			this.rb_Litres = new System.Windows.Forms.RadioButton();
			this.num_Concentration = new System.Windows.Forms.NumericUpDown();
			this.num_Quantity = new System.Windows.Forms.NumericUpDown();
			this.cbox_CompoundList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tbox_CompoundSearch = new System.Windows.Forms.TextBox();
			this.lbox_MakesChemicalList = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rtb_Methods = new System.Windows.Forms.RichTextBox();
			this.check_Flamable = new System.Windows.Forms.CheckBox();
			this.check_Explosive = new System.Windows.Forms.CheckBox();
			this.check_HealthHazard = new System.Windows.Forms.CheckBox();
			this.check_Corrosive = new System.Windows.Forms.CheckBox();
			this.check_CompressedGas = new System.Windows.Forms.CheckBox();
			this.check_Oxidising = new System.Windows.Forms.CheckBox();
			this.check_HarmfulIrritant = new System.Windows.Forms.CheckBox();
			this.check_AccutelyToxic = new System.Windows.Forms.CheckBox();
			this.check_EnvHazard = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_CompoundList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Concentration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.check_Flamable);
			this.groupBox1.Controls.Add(this.check_Explosive);
			this.groupBox1.Controls.Add(this.check_HealthHazard);
			this.groupBox1.Controls.Add(this.check_Corrosive);
			this.groupBox1.Controls.Add(this.check_CompressedGas);
			this.groupBox1.Controls.Add(this.check_Oxidising);
			this.groupBox1.Controls.Add(this.check_HarmfulIrritant);
			this.groupBox1.Controls.Add(this.check_AccutelyToxic);
			this.groupBox1.Controls.Add(this.check_EnvHazard);
			this.groupBox1.Controls.Add(this.cbox_ParentProject);
			this.groupBox1.Controls.Add(this.tbox_Description);
			this.groupBox1.Controls.Add(this.tbox_ProjectName);
			this.groupBox1.Controls.Add(this.rtb_ProjectFormula);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(668, 194);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Details";
			// 
			// cbox_ParentProject
			// 
			this.cbox_ParentProject.FormattingEnabled = true;
			this.cbox_ParentProject.Location = new System.Drawing.Point(433, 134);
			this.cbox_ParentProject.Name = "cbox_ParentProject";
			this.cbox_ParentProject.Size = new System.Drawing.Size(225, 21);
			this.cbox_ParentProject.TabIndex = 23;
			this.cbox_ParentProject.DropDown += new System.EventHandler(this.cbox_ParentProject_DropDown);
			this.cbox_ParentProject.SelectedIndexChanged += new System.EventHandler(this.cbox_ParentProject_SelectedIndexChanged);
			// 
			// tbox_Description
			// 
			this.tbox_Description.Location = new System.Drawing.Point(83, 70);
			this.tbox_Description.Multiline = true;
			this.tbox_Description.Name = "tbox_Description";
			this.tbox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbox_Description.Size = new System.Drawing.Size(289, 118);
			this.tbox_Description.TabIndex = 22;
			// 
			// tbox_ProjectName
			// 
			this.tbox_ProjectName.Location = new System.Drawing.Point(83, 18);
			this.tbox_ProjectName.Name = "tbox_ProjectName";
			this.tbox_ProjectName.Size = new System.Drawing.Size(289, 20);
			this.tbox_ProjectName.TabIndex = 21;
			// 
			// rtb_ProjectFormula
			// 
			this.rtb_ProjectFormula.BackColor = System.Drawing.SystemColors.Control;
			this.rtb_ProjectFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_ProjectFormula.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.rtb_ProjectFormula.Location = new System.Drawing.Point(83, 45);
			this.rtb_ProjectFormula.Name = "rtb_ProjectFormula";
			this.rtb_ProjectFormula.ReadOnly = true;
			this.rtb_ProjectFormula.Size = new System.Drawing.Size(289, 20);
			this.rtb_ProjectFormula.TabIndex = 17;
			this.rtb_ProjectFormula.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(378, 137);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Parent:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(378, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Hazards:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Description:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Formula:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Name:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.splitContainer1);
			this.groupBox3.Location = new System.Drawing.Point(3, 203);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(668, 159);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Required Compounds";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 16);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dg_CompoundList);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label7);
			this.splitContainer1.Panel2.Controls.Add(this.label6);
			this.splitContainer1.Panel2.Controls.Add(this.btn_RemoveRequirement);
			this.splitContainer1.Panel2.Controls.Add(this.btn_AddRequirement);
			this.splitContainer1.Panel2.Controls.Add(this.check_MiliPrefix);
			this.splitContainer1.Panel2.Controls.Add(this.rb_Grams);
			this.splitContainer1.Panel2.Controls.Add(this.rb_Litres);
			this.splitContainer1.Panel2.Controls.Add(this.num_Concentration);
			this.splitContainer1.Panel2.Controls.Add(this.num_Quantity);
			this.splitContainer1.Panel2.Controls.Add(this.cbox_CompoundList);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(662, 140);
			this.splitContainer1.SplitterDistance = 341;
			this.splitContainer1.TabIndex = 0;
			// 
			// dg_CompoundList
			// 
			this.dg_CompoundList.AllowUserToAddRows = false;
			this.dg_CompoundList.AllowUserToDeleteRows = false;
			this.dg_CompoundList.AllowUserToResizeColumns = false;
			this.dg_CompoundList.AllowUserToResizeRows = false;
			this.dg_CompoundList.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dg_CompoundList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg_CompoundList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dg_CompoundList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg_CompoundList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dg_CompoundList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_CompoundList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Compounds,
            this.Quantity});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg_CompoundList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dg_CompoundList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dg_CompoundList.GridColor = System.Drawing.SystemColors.Control;
			this.dg_CompoundList.Location = new System.Drawing.Point(0, 0);
			this.dg_CompoundList.MultiSelect = false;
			this.dg_CompoundList.Name = "dg_CompoundList";
			this.dg_CompoundList.ReadOnly = true;
			this.dg_CompoundList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg_CompoundList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dg_CompoundList.RowHeadersVisible = false;
			this.dg_CompoundList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dg_CompoundList.Size = new System.Drawing.Size(341, 140);
			this.dg_CompoundList.TabIndex = 0;
			// 
			// Compounds
			// 
			this.Compounds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Compounds.HeaderText = "Compounds";
			this.Compounds.Name = "Compounds";
			this.Compounds.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(160, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "Concentration (%):";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "Quantity:";
			// 
			// btn_RemoveRequirement
			// 
			this.btn_RemoveRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveRequirement.BackColor = System.Drawing.Color.White;
			this.btn_RemoveRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_RemoveRequirement.Location = new System.Drawing.Point(163, 112);
			this.btn_RemoveRequirement.Name = "btn_RemoveRequirement";
			this.btn_RemoveRequirement.Size = new System.Drawing.Size(147, 25);
			this.btn_RemoveRequirement.TabIndex = 23;
			this.btn_RemoveRequirement.Text = "Remove";
			this.btn_RemoveRequirement.UseVisualStyleBackColor = false;
			this.btn_RemoveRequirement.Click += new System.EventHandler(this.btn_RemoveRequirement_Click);
			// 
			// btn_AddRequirement
			// 
			this.btn_AddRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddRequirement.BackColor = System.Drawing.Color.White;
			this.btn_AddRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_AddRequirement.Location = new System.Drawing.Point(9, 112);
			this.btn_AddRequirement.Name = "btn_AddRequirement";
			this.btn_AddRequirement.Size = new System.Drawing.Size(147, 25);
			this.btn_AddRequirement.TabIndex = 23;
			this.btn_AddRequirement.Text = "Add";
			this.btn_AddRequirement.UseVisualStyleBackColor = false;
			this.btn_AddRequirement.Click += new System.EventHandler(this.btn_AddRequirement_Click);
			// 
			// check_MiliPrefix
			// 
			this.check_MiliPrefix.AutoSize = true;
			this.check_MiliPrefix.Location = new System.Drawing.Point(80, 88);
			this.check_MiliPrefix.Name = "check_MiliPrefix";
			this.check_MiliPrefix.Size = new System.Drawing.Size(43, 17);
			this.check_MiliPrefix.TabIndex = 4;
			this.check_MiliPrefix.Text = "mili-";
			this.check_MiliPrefix.UseVisualStyleBackColor = true;
			// 
			// rb_Grams
			// 
			this.rb_Grams.AutoSize = true;
			this.rb_Grams.Checked = true;
			this.rb_Grams.Location = new System.Drawing.Point(6, 87);
			this.rb_Grams.Name = "rb_Grams";
			this.rb_Grams.Size = new System.Drawing.Size(31, 17);
			this.rb_Grams.TabIndex = 3;
			this.rb_Grams.TabStop = true;
			this.rb_Grams.Text = "g";
			this.rb_Grams.UseVisualStyleBackColor = true;
			// 
			// rb_Litres
			// 
			this.rb_Litres.AutoSize = true;
			this.rb_Litres.Location = new System.Drawing.Point(43, 87);
			this.rb_Litres.Name = "rb_Litres";
			this.rb_Litres.Size = new System.Drawing.Size(31, 17);
			this.rb_Litres.TabIndex = 3;
			this.rb_Litres.Text = "L";
			this.rb_Litres.UseVisualStyleBackColor = true;
			// 
			// num_Concentration
			// 
			this.num_Concentration.DecimalPlaces = 1;
			this.num_Concentration.Location = new System.Drawing.Point(163, 61);
			this.num_Concentration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_Concentration.Name = "num_Concentration";
			this.num_Concentration.Size = new System.Drawing.Size(147, 20);
			this.num_Concentration.TabIndex = 2;
			this.num_Concentration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// num_Quantity
			// 
			this.num_Quantity.DecimalPlaces = 2;
			this.num_Quantity.Location = new System.Drawing.Point(6, 61);
			this.num_Quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_Quantity.Name = "num_Quantity";
			this.num_Quantity.Size = new System.Drawing.Size(147, 20);
			this.num_Quantity.TabIndex = 2;
			// 
			// cbox_CompoundList
			// 
			this.cbox_CompoundList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbox_CompoundList.FormattingEnabled = true;
			this.cbox_CompoundList.Location = new System.Drawing.Point(6, 21);
			this.cbox_CompoundList.Name = "cbox_CompoundList";
			this.cbox_CompoundList.Size = new System.Drawing.Size(304, 21);
			this.cbox_CompoundList.TabIndex = 1;
			this.cbox_CompoundList.DropDown += new System.EventHandler(this.cbox_CompoundList_DropDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add Required Compounds";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.BackColor = System.Drawing.Color.White;
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Cancel.Location = new System.Drawing.Point(780, 401);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(93, 25);
			this.btn_Cancel.TabIndex = 22;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = false;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Confirm.BackColor = System.Drawing.Color.White;
			this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Confirm.Location = new System.Drawing.Point(681, 401);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(93, 25);
			this.btn_Confirm.TabIndex = 21;
			this.btn_Confirm.Text = "Confirm";
			this.btn_Confirm.UseVisualStyleBackColor = false;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(885, 394);
			this.tabControl1.TabIndex = 23;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(877, 368);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Details";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tbox_CompoundSearch);
			this.groupBox4.Controls.Add(this.lbox_MakesChemicalList);
			this.groupBox4.Location = new System.Drawing.Point(677, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(192, 359);
			this.groupBox4.TabIndex = 23;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Makes";
			// 
			// tbox_CompoundSearch
			// 
			this.tbox_CompoundSearch.Location = new System.Drawing.Point(6, 333);
			this.tbox_CompoundSearch.Name = "tbox_CompoundSearch";
			this.tbox_CompoundSearch.Size = new System.Drawing.Size(180, 20);
			this.tbox_CompoundSearch.TabIndex = 10;
			this.tbox_CompoundSearch.TextChanged += new System.EventHandler(this.tbox_CompoundSearch_TextChanged);
			this.tbox_CompoundSearch.Enter += new System.EventHandler(this.tbox_CompoundSearch_Enter);
			this.tbox_CompoundSearch.Leave += new System.EventHandler(this.tbox_CompoundSearch_Leave);
			// 
			// lbox_MakesChemicalList
			// 
			this.lbox_MakesChemicalList.BackColor = System.Drawing.SystemColors.Control;
			this.lbox_MakesChemicalList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbox_MakesChemicalList.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbox_MakesChemicalList.FormattingEnabled = true;
			this.lbox_MakesChemicalList.Location = new System.Drawing.Point(3, 16);
			this.lbox_MakesChemicalList.Name = "lbox_MakesChemicalList";
			this.lbox_MakesChemicalList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lbox_MakesChemicalList.Size = new System.Drawing.Size(186, 312);
			this.lbox_MakesChemicalList.TabIndex = 0;
			this.lbox_MakesChemicalList.SelectedIndexChanged += new System.EventHandler(this.lbox_MakesChemicalList_SelectedIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(877, 368);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Methods";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.rtb_Methods);
			this.groupBox2.Location = new System.Drawing.Point(7, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(861, 386);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Methods";
			// 
			// rtb_Methods
			// 
			this.rtb_Methods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtb_Methods.Location = new System.Drawing.Point(6, 19);
			this.rtb_Methods.Name = "rtb_Methods";
			this.rtb_Methods.Size = new System.Drawing.Size(530, 337);
			this.rtb_Methods.TabIndex = 0;
			this.rtb_Methods.Text = "";
			// 
			// check_Flamable
			// 
			this.check_Flamable.AutoSize = true;
			this.check_Flamable.Location = new System.Drawing.Point(433, 20);
			this.check_Flamable.Name = "check_Flamable";
			this.check_Flamable.Size = new System.Drawing.Size(68, 17);
			this.check_Flamable.TabIndex = 24;
			this.check_Flamable.Text = "Flamable";
			this.check_Flamable.UseVisualStyleBackColor = true;
			// 
			// check_Explosive
			// 
			this.check_Explosive.AutoSize = true;
			this.check_Explosive.Location = new System.Drawing.Point(433, 43);
			this.check_Explosive.Name = "check_Explosive";
			this.check_Explosive.Size = new System.Drawing.Size(71, 17);
			this.check_Explosive.TabIndex = 25;
			this.check_Explosive.Text = "Explosive";
			this.check_Explosive.UseVisualStyleBackColor = true;
			// 
			// check_HealthHazard
			// 
			this.check_HealthHazard.AutoSize = true;
			this.check_HealthHazard.Location = new System.Drawing.Point(433, 66);
			this.check_HealthHazard.Name = "check_HealthHazard";
			this.check_HealthHazard.Size = new System.Drawing.Size(94, 17);
			this.check_HealthHazard.TabIndex = 26;
			this.check_HealthHazard.Text = "Health Hazard";
			this.check_HealthHazard.UseVisualStyleBackColor = true;
			// 
			// check_Corrosive
			// 
			this.check_Corrosive.AutoSize = true;
			this.check_Corrosive.Location = new System.Drawing.Point(433, 89);
			this.check_Corrosive.Name = "check_Corrosive";
			this.check_Corrosive.Size = new System.Drawing.Size(70, 17);
			this.check_Corrosive.TabIndex = 27;
			this.check_Corrosive.Text = "Corrosive";
			this.check_Corrosive.UseVisualStyleBackColor = true;
			// 
			// check_CompressedGas
			// 
			this.check_CompressedGas.AutoSize = true;
			this.check_CompressedGas.Location = new System.Drawing.Point(545, 89);
			this.check_CompressedGas.Name = "check_CompressedGas";
			this.check_CompressedGas.Size = new System.Drawing.Size(106, 17);
			this.check_CompressedGas.TabIndex = 28;
			this.check_CompressedGas.Text = "Compressed Gas";
			this.check_CompressedGas.UseVisualStyleBackColor = true;
			// 
			// check_Oxidising
			// 
			this.check_Oxidising.AutoSize = true;
			this.check_Oxidising.Location = new System.Drawing.Point(545, 20);
			this.check_Oxidising.Name = "check_Oxidising";
			this.check_Oxidising.Size = new System.Drawing.Size(68, 17);
			this.check_Oxidising.TabIndex = 29;
			this.check_Oxidising.Text = "Oxidising";
			this.check_Oxidising.UseVisualStyleBackColor = true;
			// 
			// check_HarmfulIrritant
			// 
			this.check_HarmfulIrritant.AutoSize = true;
			this.check_HarmfulIrritant.Location = new System.Drawing.Point(545, 43);
			this.check_HarmfulIrritant.Name = "check_HarmfulIrritant";
			this.check_HarmfulIrritant.Size = new System.Drawing.Size(94, 17);
			this.check_HarmfulIrritant.TabIndex = 30;
			this.check_HarmfulIrritant.Text = "Harmful Irritant";
			this.check_HarmfulIrritant.UseVisualStyleBackColor = true;
			// 
			// check_AccutelyToxic
			// 
			this.check_AccutelyToxic.AutoSize = true;
			this.check_AccutelyToxic.Location = new System.Drawing.Point(545, 66);
			this.check_AccutelyToxic.Name = "check_AccutelyToxic";
			this.check_AccutelyToxic.Size = new System.Drawing.Size(90, 17);
			this.check_AccutelyToxic.TabIndex = 31;
			this.check_AccutelyToxic.Text = "Acutely Toxic";
			this.check_AccutelyToxic.UseVisualStyleBackColor = true;
			// 
			// check_EnvHazard
			// 
			this.check_EnvHazard.AutoSize = true;
			this.check_EnvHazard.Location = new System.Drawing.Point(433, 112);
			this.check_EnvHazard.Name = "check_EnvHazard";
			this.check_EnvHazard.Size = new System.Drawing.Size(130, 17);
			this.check_EnvHazard.TabIndex = 32;
			this.check_EnvHazard.Text = "Environmental Hazard";
			this.check_EnvHazard.UseVisualStyleBackColor = true;
			// 
			// AddNewProject
			// 
			this.AcceptButton = this.btn_Confirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(885, 438);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Confirm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(901, 477);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(901, 477);
			this.Name = "AddNewProject";
			this.Text = "Add New Project";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg_CompoundList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Concentration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dg_CompoundList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Compounds;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.RadioButton rb_Grams;
		private System.Windows.Forms.RadioButton rb_Litres;
		private System.Windows.Forms.NumericUpDown num_Quantity;
		private System.Windows.Forms.ComboBox cbox_CompoundList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.CheckBox check_MiliPrefix;
		private System.Windows.Forms.Button btn_RemoveRequirement;
		private System.Windows.Forms.Button btn_AddRequirement;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtb_ProjectFormula;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown num_Concentration;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox rtb_Methods;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox lbox_MakesChemicalList;
		private System.Windows.Forms.TextBox tbox_Description;
		private System.Windows.Forms.TextBox tbox_ProjectName;
		private System.Windows.Forms.TextBox tbox_CompoundSearch;
		private System.Windows.Forms.ComboBox cbox_ParentProject;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox check_Flamable;
		private System.Windows.Forms.CheckBox check_Explosive;
		private System.Windows.Forms.CheckBox check_HealthHazard;
		private System.Windows.Forms.CheckBox check_Corrosive;
		private System.Windows.Forms.CheckBox check_CompressedGas;
		private System.Windows.Forms.CheckBox check_Oxidising;
		private System.Windows.Forms.CheckBox check_HarmfulIrritant;
		private System.Windows.Forms.CheckBox check_AccutelyToxic;
		private System.Windows.Forms.CheckBox check_EnvHazard;
	}
}