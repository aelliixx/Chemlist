namespace Chemlist
{
	partial class Firediamond
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firediamond));
			this.num_Fire = new System.Windows.Forms.NumericUpDown();
			this.num_Health = new System.Windows.Forms.NumericUpDown();
			this.num_Reactivity = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rb_OX = new System.Windows.Forms.RadioButton();
			this.rb_W = new System.Windows.Forms.RadioButton();
			this.rb_SA = new System.Windows.Forms.RadioButton();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num_Fire)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Health)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Reactivity)).BeginInit();
			this.SuspendLayout();
			// 
			// num_Fire
			// 
			this.num_Fire.Location = new System.Drawing.Point(76, 12);
			this.num_Fire.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.num_Fire.Name = "num_Fire";
			this.num_Fire.Size = new System.Drawing.Size(127, 20);
			this.num_Fire.TabIndex = 0;
			// 
			// num_Health
			// 
			this.num_Health.Location = new System.Drawing.Point(76, 38);
			this.num_Health.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.num_Health.Name = "num_Health";
			this.num_Health.Size = new System.Drawing.Size(127, 20);
			this.num_Health.TabIndex = 0;
			// 
			// num_Reactivity
			// 
			this.num_Reactivity.Location = new System.Drawing.Point(76, 64);
			this.num_Reactivity.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.num_Reactivity.Name = "num_Reactivity";
			this.num_Reactivity.Size = new System.Drawing.Size(127, 20);
			this.num_Reactivity.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Flamability:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Health:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Reactivity:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Special:";
			// 
			// rb_OX
			// 
			this.rb_OX.AutoSize = true;
			this.rb_OX.Location = new System.Drawing.Point(76, 90);
			this.rb_OX.Name = "rb_OX";
			this.rb_OX.Size = new System.Drawing.Size(40, 17);
			this.rb_OX.TabIndex = 2;
			this.rb_OX.TabStop = true;
			this.rb_OX.Text = "OX";
			this.rb_OX.UseVisualStyleBackColor = true;
			// 
			// rb_W
			// 
			this.rb_W.AutoSize = true;
			this.rb_W.Location = new System.Drawing.Point(122, 90);
			this.rb_W.Name = "rb_W";
			this.rb_W.Size = new System.Drawing.Size(36, 17);
			this.rb_W.TabIndex = 2;
			this.rb_W.TabStop = true;
			this.rb_W.Text = "W";
			this.rb_W.UseVisualStyleBackColor = true;
			// 
			// rb_SA
			// 
			this.rb_SA.AutoSize = true;
			this.rb_SA.Location = new System.Drawing.Point(164, 90);
			this.rb_SA.Name = "rb_SA";
			this.rb_SA.Size = new System.Drawing.Size(39, 17);
			this.rb_SA.TabIndex = 2;
			this.rb_SA.TabStop = true;
			this.rb_SA.Text = "SA";
			this.rb_SA.UseVisualStyleBackColor = true;
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Confirm.BackColor = System.Drawing.Color.White;
			this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Confirm.Location = new System.Drawing.Point(12, 111);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(93, 25);
			this.btn_Confirm.TabIndex = 20;
			this.btn_Confirm.Text = "Confirm";
			this.btn_Confirm.UseVisualStyleBackColor = false;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(109, 111);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 25);
			this.button1.TabIndex = 21;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Firediamond
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 148);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.rb_SA);
			this.Controls.Add(this.rb_W);
			this.Controls.Add(this.rb_OX);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.num_Reactivity);
			this.Controls.Add(this.num_Health);
			this.Controls.Add(this.num_Fire);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(230, 187);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(230, 187);
			this.Name = "Firediamond";
			this.Text = "Fire Diamond";
			((System.ComponentModel.ISupportInitialize)(this.num_Fire)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Health)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Reactivity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown num_Fire;
		private System.Windows.Forms.NumericUpDown num_Health;
		private System.Windows.Forms.NumericUpDown num_Reactivity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rb_OX;
		private System.Windows.Forms.RadioButton rb_W;
		private System.Windows.Forms.RadioButton rb_SA;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.Button button1;
	}
}