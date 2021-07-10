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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbox_ProjectFormula = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbox_ChemName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dg_CompoundList = new System.Windows.Forms.DataGridView();
			this.Compounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_RemoveRequirement = new System.Windows.Forms.Button();
			this.btn_AddRequirement = new System.Windows.Forms.Button();
			this.check_MiliPrefix = new System.Windows.Forms.CheckBox();
			this.rb_Grams = new System.Windows.Forms.RadioButton();
			this.rb_Litres = new System.Windows.Forms.RadioButton();
			this.num_Quantity = new System.Windows.Forms.NumericUpDown();
			this.cbox_CompundList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.rtbox_Methods = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_CompoundList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbox_ProjectFormula);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbox_ChemName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(652, 122);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Project Details";
			// 
			// tbox_ProjectFormula
			// 
			this.tbox_ProjectFormula.Location = new System.Drawing.Point(83, 39);
			this.tbox_ProjectFormula.Name = "tbox_ProjectFormula";
			this.tbox_ProjectFormula.Size = new System.Drawing.Size(289, 20);
			this.tbox_ProjectFormula.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Formula:";
			// 
			// tbox_ChemName
			// 
			this.tbox_ChemName.Location = new System.Drawing.Point(83, 13);
			this.tbox_ChemName.Name = "tbox_ChemName";
			this.tbox_ChemName.Size = new System.Drawing.Size(289, 20);
			this.tbox_ChemName.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Name:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rtbox_Methods);
			this.groupBox2.Location = new System.Drawing.Point(12, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(652, 372);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Methods";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.splitContainer1);
			this.groupBox3.Location = new System.Drawing.Point(670, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(316, 500);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Required Compounds";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 16);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dg_CompoundList);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btn_RemoveRequirement);
			this.splitContainer1.Panel2.Controls.Add(this.btn_AddRequirement);
			this.splitContainer1.Panel2.Controls.Add(this.check_MiliPrefix);
			this.splitContainer1.Panel2.Controls.Add(this.rb_Grams);
			this.splitContainer1.Panel2.Controls.Add(this.rb_Litres);
			this.splitContainer1.Panel2.Controls.Add(this.num_Quantity);
			this.splitContainer1.Panel2.Controls.Add(this.cbox_CompundList);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(310, 481);
			this.splitContainer1.SplitterDistance = 300;
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
			this.dg_CompoundList.Size = new System.Drawing.Size(310, 300);
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
			// btn_RemoveRequirement
			// 
			this.btn_RemoveRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveRequirement.BackColor = System.Drawing.Color.White;
			this.btn_RemoveRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_RemoveRequirement.Location = new System.Drawing.Point(160, 149);
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
			this.btn_AddRequirement.Location = new System.Drawing.Point(6, 149);
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
			this.check_MiliPrefix.Location = new System.Drawing.Point(206, 49);
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
			this.rb_Grams.Location = new System.Drawing.Point(132, 48);
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
			this.rb_Litres.Location = new System.Drawing.Point(169, 48);
			this.rb_Litres.Name = "rb_Litres";
			this.rb_Litres.Size = new System.Drawing.Size(31, 17);
			this.rb_Litres.TabIndex = 3;
			this.rb_Litres.Text = "L";
			this.rb_Litres.UseVisualStyleBackColor = true;
			// 
			// num_Quantity
			// 
			this.num_Quantity.DecimalPlaces = 2;
			this.num_Quantity.Location = new System.Drawing.Point(6, 48);
			this.num_Quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_Quantity.Name = "num_Quantity";
			this.num_Quantity.Size = new System.Drawing.Size(120, 20);
			this.num_Quantity.TabIndex = 2;
			// 
			// cbox_CompundList
			// 
			this.cbox_CompundList.FormattingEnabled = true;
			this.cbox_CompundList.Location = new System.Drawing.Point(6, 21);
			this.cbox_CompundList.Name = "cbox_CompundList";
			this.cbox_CompundList.Size = new System.Drawing.Size(301, 21);
			this.cbox_CompundList.TabIndex = 1;
			this.cbox_CompundList.DropDown += new System.EventHandler(this.cbox_CompundList_DropDown);
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
			this.btn_Cancel.Location = new System.Drawing.Point(893, 518);
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
			this.btn_Confirm.Location = new System.Drawing.Point(794, 518);
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
			// rtbox_Methods
			// 
			this.rtbox_Methods.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbox_Methods.Location = new System.Drawing.Point(3, 16);
			this.rtbox_Methods.Name = "rtbox_Methods";
			this.rtbox_Methods.Size = new System.Drawing.Size(646, 353);
			this.rtbox_Methods.TabIndex = 0;
			this.rtbox_Methods.Text = "";
			// 
			// AddNewProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 555);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1014, 594);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1014, 594);
			this.Name = "AddNewProject";
			this.Text = "Add New Project";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg_CompoundList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
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
		private System.Windows.Forms.ComboBox cbox_CompundList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.CheckBox check_MiliPrefix;
		private System.Windows.Forms.Button btn_RemoveRequirement;
		private System.Windows.Forms.Button btn_AddRequirement;
		private System.Windows.Forms.TextBox tbox_ChemName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbox_ProjectFormula;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtbox_Methods;
	}
}