namespace Chemlist
{
	partial class AddNewCompound
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.tbox_ChemName = new System.Windows.Forms.TextBox();
			this.btn_CancelEdit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbox_ChemFormula = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 26);
			this.label1.TabIndex = 12;
			this.label1.Text = "Add New Compund";
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Confirm.Location = new System.Drawing.Point(398, 245);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(93, 25);
			this.btn_Confirm.TabIndex = 18;
			this.btn_Confirm.Text = "Confirm";
			this.btn_Confirm.UseVisualStyleBackColor = true;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// tbox_ChemName
			// 
			this.tbox_ChemName.Location = new System.Drawing.Point(67, 52);
			this.tbox_ChemName.Name = "tbox_ChemName";
			this.tbox_ChemName.Size = new System.Drawing.Size(176, 20);
			this.tbox_ChemName.TabIndex = 13;
			// 
			// btn_CancelEdit
			// 
			this.btn_CancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CancelEdit.Location = new System.Drawing.Point(497, 245);
			this.btn_CancelEdit.Name = "btn_CancelEdit";
			this.btn_CancelEdit.Size = new System.Drawing.Size(93, 25);
			this.btn_CancelEdit.TabIndex = 17;
			this.btn_CancelEdit.Text = "Cancel";
			this.btn_CancelEdit.UseVisualStyleBackColor = true;
			this.btn_CancelEdit.Click += new System.EventHandler(this.btn_CancelEdit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Formula:";
			// 
			// tbox_ChemFormula
			// 
			this.tbox_ChemFormula.Location = new System.Drawing.Point(67, 78);
			this.tbox_ChemFormula.Name = "tbox_ChemFormula";
			this.tbox_ChemFormula.Size = new System.Drawing.Size(176, 20);
			this.tbox_ChemFormula.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_Confirm);
			this.panel1.Controls.Add(this.tbox_ChemFormula);
			this.panel1.Controls.Add(this.btn_CancelEdit);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tbox_ChemName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(602, 282);
			this.panel1.TabIndex = 19;
			// 
			// AddNewCompound
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 282);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(618, 321);
			this.Name = "AddNewCompound";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add New Compound";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.TextBox tbox_ChemName;
		private System.Windows.Forms.Button btn_CancelEdit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbox_ChemFormula;
		private System.Windows.Forms.Panel panel1;
	}
}