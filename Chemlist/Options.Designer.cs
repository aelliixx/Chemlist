namespace Chemlist
{
	partial class Options
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
			this.check_GUID = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// check_GUID
			// 
			this.check_GUID.AutoSize = true;
			this.check_GUID.Location = new System.Drawing.Point(13, 13);
			this.check_GUID.Name = "check_GUID";
			this.check_GUID.Size = new System.Drawing.Size(156, 17);
			this.check_GUID.TabIndex = 0;
			this.check_GUID.Text = "Show GUID for compounds";
			this.check_GUID.UseVisualStyleBackColor = true;
			this.check_GUID.CheckedChanged += new System.EventHandler(this.check_GUID_CheckedChanged);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 247);
			this.Controls.Add(this.check_GUID);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(323, 286);
			this.MinimumSize = new System.Drawing.Size(323, 286);
			this.Name = "Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox check_GUID;
	}
}