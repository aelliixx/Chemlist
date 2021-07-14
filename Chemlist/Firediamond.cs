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
	public partial class Firediamond : Form
	{
		int fire, health, reactivity;
		String special;

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public Firediamond(ref int _fire, ref int _health, ref int _reactivity, ref String _special)
		{
			fire = _fire;
			InitializeComponent();
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			fire = (int)num_Fire.Value;

			this.Close();
		}
	}
}
