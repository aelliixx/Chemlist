namespace Chemlist
{
	partial class EditCompound
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
			this.btn_CancelEdit = new System.Windows.Forms.Button();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.check_MSDS = new System.Windows.Forms.CheckBox();
			this.check_Purchase = new System.Windows.Forms.CheckBox();
			this.check_Wiki = new System.Windows.Forms.CheckBox();
			this.check_Solubility = new System.Windows.Forms.CheckBox();
			this.tbox_Solubility = new System.Windows.Forms.TextBox();
			this.tbox_MSDS = new System.Windows.Forms.TextBox();
			this.tbox_MSDSName = new System.Windows.Forms.TextBox();
			this.tbox_Wiki = new System.Windows.Forms.TextBox();
			this.tbox_Purchase = new System.Windows.Forms.TextBox();
			this.tbox_WikiName = new System.Windows.Forms.TextBox();
			this.tbox_PurchaseName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.check_LC50 = new System.Windows.Forms.CheckBox();
			this.check_LD50 = new System.Windows.Forms.CheckBox();
			this.check_FlashPoint = new System.Windows.Forms.CheckBox();
			this.check_Acidity = new System.Windows.Forms.CheckBox();
			this.check_VapourPoint = new System.Windows.Forms.CheckBox();
			this.check_SInWater = new System.Windows.Forms.CheckBox();
			this.check_bPoint = new System.Windows.Forms.CheckBox();
			this.check_mPoint = new System.Windows.Forms.CheckBox();
			this.check_Density = new System.Windows.Forms.CheckBox();
			this.check_Appearance = new System.Windows.Forms.CheckBox();
			this.check_MolarMass = new System.Windows.Forms.CheckBox();
			this.tbox_MolarMass = new System.Windows.Forms.TextBox();
			this.tbox_LC50 = new System.Windows.Forms.TextBox();
			this.check_Miscible = new System.Windows.Forms.CheckBox();
			this.tbox_Appearance = new System.Windows.Forms.TextBox();
			this.tbox_Density = new System.Windows.Forms.TextBox();
			this.tbox_LD50 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbox_MeltingPoint = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbox_FlashPoint = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbox_BoilingPoint = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tbox_SInWater = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tbox_Acidity = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tbox_VapourPressure = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.check_OtherNames = new System.Windows.Forms.CheckBox();
			this.tbox_ChemName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbox_OtherNames = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbox_ChemFormula = new System.Windows.Forms.TextBox();
			this.tbox_Description = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_CancelEdit
			// 
			this.btn_CancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CancelEdit.BackColor = System.Drawing.Color.White;
			this.btn_CancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_CancelEdit.Location = new System.Drawing.Point(570, 345);
			this.btn_CancelEdit.Name = "btn_CancelEdit";
			this.btn_CancelEdit.Size = new System.Drawing.Size(93, 25);
			this.btn_CancelEdit.TabIndex = 10;
			this.btn_CancelEdit.Text = "Cancel";
			this.btn_CancelEdit.UseVisualStyleBackColor = false;
			this.btn_CancelEdit.Click += new System.EventHandler(this.btn_CancelEdit_Click);
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Confirm.BackColor = System.Drawing.Color.White;
			this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Confirm.Location = new System.Drawing.Point(471, 345);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(93, 25);
			this.btn_Confirm.TabIndex = 11;
			this.btn_Confirm.Text = "Confirm";
			this.btn_Confirm.UseVisualStyleBackColor = false;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.btn_Confirm);
			this.panel1.Controls.Add(this.btn_CancelEdit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(675, 382);
			this.panel1.TabIndex = 12;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.check_MSDS);
			this.groupBox3.Controls.Add(this.check_Purchase);
			this.groupBox3.Controls.Add(this.check_Wiki);
			this.groupBox3.Controls.Add(this.check_Solubility);
			this.groupBox3.Controls.Add(this.tbox_Solubility);
			this.groupBox3.Controls.Add(this.tbox_MSDS);
			this.groupBox3.Controls.Add(this.tbox_MSDSName);
			this.groupBox3.Controls.Add(this.tbox_Wiki);
			this.groupBox3.Controls.Add(this.tbox_Purchase);
			this.groupBox3.Controls.Add(this.tbox_WikiName);
			this.groupBox3.Controls.Add(this.tbox_PurchaseName);
			this.groupBox3.Location = new System.Drawing.Point(13, 217);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(377, 120);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Misc";
			// 
			// check_MSDS
			// 
			this.check_MSDS.AutoSize = true;
			this.check_MSDS.Location = new System.Drawing.Point(6, 97);
			this.check_MSDS.Name = "check_MSDS";
			this.check_MSDS.Size = new System.Drawing.Size(60, 17);
			this.check_MSDS.TabIndex = 20;
			this.check_MSDS.Text = "MSDS:";
			this.check_MSDS.UseVisualStyleBackColor = true;
			this.check_MSDS.CheckedChanged += new System.EventHandler(this.check_MSDS_CheckedChanged);
			// 
			// check_Purchase
			// 
			this.check_Purchase.AutoSize = true;
			this.check_Purchase.Location = new System.Drawing.Point(6, 71);
			this.check_Purchase.Name = "check_Purchase";
			this.check_Purchase.Size = new System.Drawing.Size(74, 17);
			this.check_Purchase.TabIndex = 20;
			this.check_Purchase.Text = "Purchase:";
			this.check_Purchase.UseVisualStyleBackColor = true;
			this.check_Purchase.CheckedChanged += new System.EventHandler(this.check_Purchase_CheckedChanged);
			// 
			// check_Wiki
			// 
			this.check_Wiki.AutoSize = true;
			this.check_Wiki.Location = new System.Drawing.Point(6, 45);
			this.check_Wiki.Name = "check_Wiki";
			this.check_Wiki.Size = new System.Drawing.Size(47, 17);
			this.check_Wiki.TabIndex = 20;
			this.check_Wiki.Text = "Wiki";
			this.check_Wiki.UseVisualStyleBackColor = true;
			this.check_Wiki.CheckedChanged += new System.EventHandler(this.check_Wiki_CheckedChanged);
			// 
			// check_Solubility
			// 
			this.check_Solubility.AutoSize = true;
			this.check_Solubility.Location = new System.Drawing.Point(6, 19);
			this.check_Solubility.Name = "check_Solubility";
			this.check_Solubility.Size = new System.Drawing.Size(70, 17);
			this.check_Solubility.TabIndex = 19;
			this.check_Solubility.Text = "Solubility:";
			this.check_Solubility.UseVisualStyleBackColor = true;
			this.check_Solubility.CheckedChanged += new System.EventHandler(this.check_Solubility_CheckedChanged);
			// 
			// tbox_Solubility
			// 
			this.tbox_Solubility.Location = new System.Drawing.Point(82, 17);
			this.tbox_Solubility.Name = "tbox_Solubility";
			this.tbox_Solubility.Size = new System.Drawing.Size(124, 20);
			this.tbox_Solubility.TabIndex = 8;
			this.tbox_Solubility.Text = "N/A";
			// 
			// tbox_MSDS
			// 
			this.tbox_MSDS.Location = new System.Drawing.Point(212, 95);
			this.tbox_MSDS.Name = "tbox_MSDS";
			this.tbox_MSDS.Size = new System.Drawing.Size(159, 20);
			this.tbox_MSDS.TabIndex = 18;
			this.tbox_MSDS.Text = "N/A";
			// 
			// tbox_MSDSName
			// 
			this.tbox_MSDSName.Location = new System.Drawing.Point(82, 95);
			this.tbox_MSDSName.Name = "tbox_MSDSName";
			this.tbox_MSDSName.Size = new System.Drawing.Size(124, 20);
			this.tbox_MSDSName.TabIndex = 18;
			this.tbox_MSDSName.Text = "N/A";
			// 
			// tbox_Wiki
			// 
			this.tbox_Wiki.Location = new System.Drawing.Point(212, 43);
			this.tbox_Wiki.Name = "tbox_Wiki";
			this.tbox_Wiki.Size = new System.Drawing.Size(159, 20);
			this.tbox_Wiki.TabIndex = 16;
			this.tbox_Wiki.Text = "N/A";
			// 
			// tbox_Purchase
			// 
			this.tbox_Purchase.Location = new System.Drawing.Point(212, 69);
			this.tbox_Purchase.Name = "tbox_Purchase";
			this.tbox_Purchase.Size = new System.Drawing.Size(159, 20);
			this.tbox_Purchase.TabIndex = 17;
			this.tbox_Purchase.Text = "N/A";
			// 
			// tbox_WikiName
			// 
			this.tbox_WikiName.Location = new System.Drawing.Point(82, 43);
			this.tbox_WikiName.Name = "tbox_WikiName";
			this.tbox_WikiName.Size = new System.Drawing.Size(124, 20);
			this.tbox_WikiName.TabIndex = 16;
			this.tbox_WikiName.Text = "N/A";
			// 
			// tbox_PurchaseName
			// 
			this.tbox_PurchaseName.Location = new System.Drawing.Point(82, 69);
			this.tbox_PurchaseName.Name = "tbox_PurchaseName";
			this.tbox_PurchaseName.Size = new System.Drawing.Size(124, 20);
			this.tbox_PurchaseName.TabIndex = 17;
			this.tbox_PurchaseName.Text = "N/A";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.check_LC50);
			this.groupBox2.Controls.Add(this.check_LD50);
			this.groupBox2.Controls.Add(this.check_FlashPoint);
			this.groupBox2.Controls.Add(this.check_Acidity);
			this.groupBox2.Controls.Add(this.check_VapourPoint);
			this.groupBox2.Controls.Add(this.check_SInWater);
			this.groupBox2.Controls.Add(this.check_bPoint);
			this.groupBox2.Controls.Add(this.check_mPoint);
			this.groupBox2.Controls.Add(this.check_Density);
			this.groupBox2.Controls.Add(this.check_Appearance);
			this.groupBox2.Controls.Add(this.check_MolarMass);
			this.groupBox2.Controls.Add(this.tbox_MolarMass);
			this.groupBox2.Controls.Add(this.tbox_LC50);
			this.groupBox2.Controls.Add(this.check_Miscible);
			this.groupBox2.Controls.Add(this.tbox_Appearance);
			this.groupBox2.Controls.Add(this.tbox_Density);
			this.groupBox2.Controls.Add(this.tbox_LD50);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.tbox_MeltingPoint);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.tbox_FlashPoint);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.tbox_BoilingPoint);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.tbox_SInWater);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.tbox_Acidity);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.tbox_VapourPressure);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Location = new System.Drawing.Point(396, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(267, 325);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Properties";
			// 
			// check_LC50
			// 
			this.check_LC50.AutoSize = true;
			this.check_LC50.Location = new System.Drawing.Point(6, 298);
			this.check_LC50.Name = "check_LC50";
			this.check_LC50.Size = new System.Drawing.Size(54, 17);
			this.check_LC50.TabIndex = 17;
			this.check_LC50.Text = "LC50:";
			this.check_LC50.UseVisualStyleBackColor = true;
			this.check_LC50.CheckedChanged += new System.EventHandler(this.check_LC50_CheckedChanged);
			// 
			// check_LD50
			// 
			this.check_LD50.AutoSize = true;
			this.check_LD50.Location = new System.Drawing.Point(6, 272);
			this.check_LD50.Name = "check_LD50";
			this.check_LD50.Size = new System.Drawing.Size(55, 17);
			this.check_LD50.TabIndex = 17;
			this.check_LD50.Text = "LD50:";
			this.check_LD50.UseVisualStyleBackColor = true;
			this.check_LD50.CheckedChanged += new System.EventHandler(this.check_LD50_CheckedChanged);
			// 
			// check_FlashPoint
			// 
			this.check_FlashPoint.AutoSize = true;
			this.check_FlashPoint.Location = new System.Drawing.Point(6, 246);
			this.check_FlashPoint.Name = "check_FlashPoint";
			this.check_FlashPoint.Size = new System.Drawing.Size(80, 17);
			this.check_FlashPoint.TabIndex = 17;
			this.check_FlashPoint.Text = "Flash point:";
			this.check_FlashPoint.UseVisualStyleBackColor = true;
			this.check_FlashPoint.CheckedChanged += new System.EventHandler(this.check_FlashPoint_CheckedChanged);
			// 
			// check_Acidity
			// 
			this.check_Acidity.AutoSize = true;
			this.check_Acidity.Location = new System.Drawing.Point(6, 220);
			this.check_Acidity.Name = "check_Acidity";
			this.check_Acidity.Size = new System.Drawing.Size(60, 17);
			this.check_Acidity.TabIndex = 17;
			this.check_Acidity.Text = "Acidity:";
			this.check_Acidity.UseVisualStyleBackColor = true;
			this.check_Acidity.CheckedChanged += new System.EventHandler(this.check_Acidity_CheckedChanged);
			// 
			// check_VapourPoint
			// 
			this.check_VapourPoint.AutoSize = true;
			this.check_VapourPoint.Location = new System.Drawing.Point(6, 194);
			this.check_VapourPoint.Name = "check_VapourPoint";
			this.check_VapourPoint.Size = new System.Drawing.Size(89, 17);
			this.check_VapourPoint.TabIndex = 17;
			this.check_VapourPoint.Text = "Vapour point:";
			this.check_VapourPoint.UseVisualStyleBackColor = true;
			this.check_VapourPoint.CheckedChanged += new System.EventHandler(this.check_VapourPoint_CheckedChanged);
			// 
			// check_SInWater
			// 
			this.check_SInWater.AutoSize = true;
			this.check_SInWater.Location = new System.Drawing.Point(6, 145);
			this.check_SInWater.Name = "check_SInWater";
			this.check_SInWater.Size = new System.Drawing.Size(101, 17);
			this.check_SInWater.TabIndex = 17;
			this.check_SInWater.Text = "Solubility (H2O):";
			this.check_SInWater.UseVisualStyleBackColor = true;
			this.check_SInWater.CheckedChanged += new System.EventHandler(this.check_SInWater_CheckedChanged);
			// 
			// check_bPoint
			// 
			this.check_bPoint.AutoSize = true;
			this.check_bPoint.Location = new System.Drawing.Point(6, 119);
			this.check_bPoint.Name = "check_bPoint";
			this.check_bPoint.Size = new System.Drawing.Size(86, 17);
			this.check_bPoint.TabIndex = 17;
			this.check_bPoint.Text = "Boiling point:";
			this.check_bPoint.UseVisualStyleBackColor = true;
			this.check_bPoint.CheckedChanged += new System.EventHandler(this.check_bPoint_CheckedChanged);
			// 
			// check_mPoint
			// 
			this.check_mPoint.AutoSize = true;
			this.check_mPoint.Location = new System.Drawing.Point(6, 93);
			this.check_mPoint.Name = "check_mPoint";
			this.check_mPoint.Size = new System.Drawing.Size(89, 17);
			this.check_mPoint.TabIndex = 17;
			this.check_mPoint.Text = "Melting point:";
			this.check_mPoint.UseVisualStyleBackColor = true;
			this.check_mPoint.CheckedChanged += new System.EventHandler(this.check_mPoint_CheckedChanged);
			// 
			// check_Density
			// 
			this.check_Density.AutoSize = true;
			this.check_Density.Location = new System.Drawing.Point(6, 67);
			this.check_Density.Name = "check_Density";
			this.check_Density.Size = new System.Drawing.Size(64, 17);
			this.check_Density.TabIndex = 17;
			this.check_Density.Text = "Density:";
			this.check_Density.UseVisualStyleBackColor = true;
			this.check_Density.CheckedChanged += new System.EventHandler(this.check_Density_CheckedChanged);
			// 
			// check_Appearance
			// 
			this.check_Appearance.AutoSize = true;
			this.check_Appearance.Location = new System.Drawing.Point(6, 15);
			this.check_Appearance.Name = "check_Appearance";
			this.check_Appearance.Size = new System.Drawing.Size(87, 17);
			this.check_Appearance.TabIndex = 17;
			this.check_Appearance.Text = "Appearance:";
			this.check_Appearance.UseVisualStyleBackColor = true;
			this.check_Appearance.CheckedChanged += new System.EventHandler(this.check_Appearance_CheckedChanged);
			// 
			// check_MolarMass
			// 
			this.check_MolarMass.AutoSize = true;
			this.check_MolarMass.Location = new System.Drawing.Point(6, 41);
			this.check_MolarMass.Name = "check_MolarMass";
			this.check_MolarMass.Size = new System.Drawing.Size(83, 17);
			this.check_MolarMass.TabIndex = 17;
			this.check_MolarMass.Text = "Molar Mass:";
			this.check_MolarMass.UseVisualStyleBackColor = true;
			this.check_MolarMass.CheckedChanged += new System.EventHandler(this.check_MolarMass_CheckedChanged);
			// 
			// tbox_MolarMass
			// 
			this.tbox_MolarMass.Location = new System.Drawing.Point(111, 39);
			this.tbox_MolarMass.Name = "tbox_MolarMass";
			this.tbox_MolarMass.Size = new System.Drawing.Size(110, 20);
			this.tbox_MolarMass.TabIndex = 3;
			this.tbox_MolarMass.Text = "0";
			// 
			// tbox_LC50
			// 
			this.tbox_LC50.Location = new System.Drawing.Point(111, 296);
			this.tbox_LC50.Name = "tbox_LC50";
			this.tbox_LC50.Size = new System.Drawing.Size(110, 20);
			this.tbox_LC50.TabIndex = 13;
			this.tbox_LC50.Text = "0";
			// 
			// check_Miscible
			// 
			this.check_Miscible.AutoSize = true;
			this.check_Miscible.Location = new System.Drawing.Point(111, 169);
			this.check_Miscible.Name = "check_Miscible";
			this.check_Miscible.Size = new System.Drawing.Size(70, 17);
			this.check_Miscible.TabIndex = 19;
			this.check_Miscible.Text = "Miscible?";
			this.check_Miscible.UseVisualStyleBackColor = true;
			// 
			// tbox_Appearance
			// 
			this.tbox_Appearance.Location = new System.Drawing.Point(111, 13);
			this.tbox_Appearance.Name = "tbox_Appearance";
			this.tbox_Appearance.Size = new System.Drawing.Size(110, 20);
			this.tbox_Appearance.TabIndex = 4;
			this.tbox_Appearance.Text = "N/A";
			// 
			// tbox_Density
			// 
			this.tbox_Density.Location = new System.Drawing.Point(111, 65);
			this.tbox_Density.Name = "tbox_Density";
			this.tbox_Density.Size = new System.Drawing.Size(110, 20);
			this.tbox_Density.TabIndex = 5;
			this.tbox_Density.Text = "0";
			// 
			// tbox_LD50
			// 
			this.tbox_LD50.Location = new System.Drawing.Point(111, 270);
			this.tbox_LD50.Name = "tbox_LD50";
			this.tbox_LD50.Size = new System.Drawing.Size(110, 20);
			this.tbox_LD50.TabIndex = 12;
			this.tbox_LD50.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(227, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "g/mol";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(227, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "g/ccm";
			// 
			// tbox_MeltingPoint
			// 
			this.tbox_MeltingPoint.Location = new System.Drawing.Point(111, 91);
			this.tbox_MeltingPoint.Name = "tbox_MeltingPoint";
			this.tbox_MeltingPoint.Size = new System.Drawing.Size(110, 20);
			this.tbox_MeltingPoint.TabIndex = 6;
			this.tbox_MeltingPoint.Text = "0";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(227, 299);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(27, 13);
			this.label16.TabIndex = 16;
			this.label16.Text = "ppm";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(227, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(18, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "°C";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(227, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "°C";
			// 
			// tbox_FlashPoint
			// 
			this.tbox_FlashPoint.Location = new System.Drawing.Point(111, 244);
			this.tbox_FlashPoint.Name = "tbox_FlashPoint";
			this.tbox_FlashPoint.Size = new System.Drawing.Size(110, 20);
			this.tbox_FlashPoint.TabIndex = 11;
			this.tbox_FlashPoint.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(227, 146);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(20, 13);
			this.label10.TabIndex = 16;
			this.label10.Text = "g/l";
			// 
			// tbox_BoilingPoint
			// 
			this.tbox_BoilingPoint.Location = new System.Drawing.Point(111, 117);
			this.tbox_BoilingPoint.Name = "tbox_BoilingPoint";
			this.tbox_BoilingPoint.Size = new System.Drawing.Size(110, 20);
			this.tbox_BoilingPoint.TabIndex = 7;
			this.tbox_BoilingPoint.Text = "0";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(227, 273);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(38, 13);
			this.label15.TabIndex = 16;
			this.label15.Text = "mg/kg";
			// 
			// tbox_SInWater
			// 
			this.tbox_SInWater.Location = new System.Drawing.Point(111, 143);
			this.tbox_SInWater.Name = "tbox_SInWater";
			this.tbox_SInWater.Size = new System.Drawing.Size(110, 20);
			this.tbox_SInWater.TabIndex = 8;
			this.tbox_SInWater.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(227, 195);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 13);
			this.label12.TabIndex = 16;
			this.label12.Text = "mmHg";
			// 
			// tbox_Acidity
			// 
			this.tbox_Acidity.Location = new System.Drawing.Point(111, 218);
			this.tbox_Acidity.Name = "tbox_Acidity";
			this.tbox_Acidity.Size = new System.Drawing.Size(110, 20);
			this.tbox_Acidity.TabIndex = 10;
			this.tbox_Acidity.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(227, 222);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(26, 13);
			this.label13.TabIndex = 16;
			this.label13.Text = "pKa";
			// 
			// tbox_VapourPressure
			// 
			this.tbox_VapourPressure.Location = new System.Drawing.Point(111, 192);
			this.tbox_VapourPressure.Name = "tbox_VapourPressure";
			this.tbox_VapourPressure.Size = new System.Drawing.Size(110, 20);
			this.tbox_VapourPressure.TabIndex = 9;
			this.tbox_VapourPressure.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(227, 247);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(18, 13);
			this.label14.TabIndex = 16;
			this.label14.Text = "°C";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.check_OtherNames);
			this.groupBox1.Controls.Add(this.tbox_ChemName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbox_OtherNames);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbox_ChemFormula);
			this.groupBox1.Controls.Add(this.tbox_Description);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(378, 198);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Details";
			// 
			// check_OtherNames
			// 
			this.check_OtherNames.AutoSize = true;
			this.check_OtherNames.Location = new System.Drawing.Point(6, 171);
			this.check_OtherNames.Name = "check_OtherNames";
			this.check_OtherNames.Size = new System.Drawing.Size(62, 17);
			this.check_OtherNames.TabIndex = 17;
			this.check_OtherNames.Text = "Names:";
			this.check_OtherNames.UseVisualStyleBackColor = true;
			this.check_OtherNames.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// tbox_ChemName
			// 
			this.tbox_ChemName.Location = new System.Drawing.Point(83, 13);
			this.tbox_ChemName.Name = "tbox_ChemName";
			this.tbox_ChemName.Size = new System.Drawing.Size(289, 20);
			this.tbox_ChemName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Name:";
			// 
			// tbox_OtherNames
			// 
			this.tbox_OtherNames.Location = new System.Drawing.Point(83, 169);
			this.tbox_OtherNames.Name = "tbox_OtherNames";
			this.tbox_OtherNames.Size = new System.Drawing.Size(289, 20);
			this.tbox_OtherNames.TabIndex = 14;
			this.tbox_OtherNames.Text = "N/A";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Formula:";
			// 
			// tbox_ChemFormula
			// 
			this.tbox_ChemFormula.Location = new System.Drawing.Point(83, 39);
			this.tbox_ChemFormula.Name = "tbox_ChemFormula";
			this.tbox_ChemFormula.Size = new System.Drawing.Size(289, 20);
			this.tbox_ChemFormula.TabIndex = 2;
			// 
			// tbox_Description
			// 
			this.tbox_Description.Location = new System.Drawing.Point(83, 65);
			this.tbox_Description.Multiline = true;
			this.tbox_Description.Name = "tbox_Description";
			this.tbox_Description.Size = new System.Drawing.Size(289, 101);
			this.tbox_Description.TabIndex = 15;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(4, 68);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(63, 13);
			this.label20.TabIndex = 14;
			this.label20.Text = "Description:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// EditCompound
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 382);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(618, 321);
			this.Name = "EditCompound";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Compound";
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_CancelEdit;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox check_MSDS;
		private System.Windows.Forms.CheckBox check_Purchase;
		private System.Windows.Forms.CheckBox check_Wiki;
		private System.Windows.Forms.CheckBox check_Solubility;
		private System.Windows.Forms.TextBox tbox_Solubility;
		private System.Windows.Forms.TextBox tbox_MSDS;
		private System.Windows.Forms.TextBox tbox_MSDSName;
		private System.Windows.Forms.TextBox tbox_Wiki;
		private System.Windows.Forms.TextBox tbox_Purchase;
		private System.Windows.Forms.TextBox tbox_WikiName;
		private System.Windows.Forms.TextBox tbox_PurchaseName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox check_LC50;
		private System.Windows.Forms.CheckBox check_LD50;
		private System.Windows.Forms.CheckBox check_FlashPoint;
		private System.Windows.Forms.CheckBox check_Acidity;
		private System.Windows.Forms.CheckBox check_VapourPoint;
		private System.Windows.Forms.CheckBox check_SInWater;
		private System.Windows.Forms.CheckBox check_bPoint;
		private System.Windows.Forms.CheckBox check_mPoint;
		private System.Windows.Forms.CheckBox check_Density;
		private System.Windows.Forms.CheckBox check_Appearance;
		private System.Windows.Forms.CheckBox check_MolarMass;
		private System.Windows.Forms.TextBox tbox_MolarMass;
		private System.Windows.Forms.TextBox tbox_LC50;
		private System.Windows.Forms.CheckBox check_Miscible;
		private System.Windows.Forms.TextBox tbox_Appearance;
		private System.Windows.Forms.TextBox tbox_Density;
		private System.Windows.Forms.TextBox tbox_LD50;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbox_MeltingPoint;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbox_FlashPoint;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbox_BoilingPoint;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tbox_SInWater;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbox_Acidity;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbox_VapourPressure;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox check_OtherNames;
		private System.Windows.Forms.TextBox tbox_ChemName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbox_OtherNames;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbox_ChemFormula;
		private System.Windows.Forms.TextBox tbox_Description;
		private System.Windows.Forms.Label label20;
	}
}