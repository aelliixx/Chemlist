using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemlist
{
	public partial class Options : Form
	{
		public Form1 parentForm { get; set; }

		public Options()
		{
			InitializeComponent();
		}

		private void check_GUID_CheckedChanged(object sender, EventArgs e)
		{
			parentForm.settings.showGUID = check_GUID.Checked;
			parentForm.redrawCompoundInfoPanel();
		}
	}
}
