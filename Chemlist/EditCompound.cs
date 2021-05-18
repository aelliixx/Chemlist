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
	public partial class EditCompound : Form
	{
		public Form1 parentForm { get; set; }
		Guid currentID;

		public EditCompound(ChemicalObject _currentEditable)
		{
			InitializeComponent();

			tbox_ChemName.Text = _currentEditable.name;
			tbox_ChemFormula.Text = _currentEditable.chemFormula;
			currentID = _currentEditable.chemID;
			
		}

		private void btn_CancelEdit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			ChemicalObject currentEditable = new ChemicalObject
			{
				name = tbox_ChemName.Text,
				chemFormula = tbox_ChemFormula.Text,
				chemID = currentID
			};
			parentForm.editCompound(currentEditable);

			Close();
		}
	}
}
