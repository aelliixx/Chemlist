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
	public partial class AddNewCompound : Form
	{
		public Form1 parentForm { get; set; }

		public AddNewCompound()
		{
			InitializeComponent();
		}

		private void btn_CancelEdit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			ChemicalObject newChemical = new ChemicalObject
			{
				name = tbox_ChemName.Text,
				chemFormula = tbox_ChemFormula.Text
			};


			parentForm.addNewChemical(newChemical);

			//Close();
		}
	}
}
