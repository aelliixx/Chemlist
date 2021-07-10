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
	public partial class AddNewProject : Form
	{
		public Form1 parentForm { get; set; }
		bool allowAdding = true;


		public List<ChemicalObject> compounds = new List<ChemicalObject>();

		public AddNewProject()
		{
			InitializeComponent();


		}

		private void cbox_CompundList_DropDown(object sender, EventArgs e)
		{
			cbox_CompundList.Items.Clear();
			foreach (ChemicalObject chemicalObject in parentForm.chemicalList)
			{
				cbox_CompundList.Items.Add(chemicalObject.name);
			}

		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_AddRequirement_Click(object sender, EventArgs e)
		{
			String unit;
			if (check_MiliPrefix.Checked) unit = " m"; else unit = " ";
			if (rb_Grams.Checked) unit += "g"; else if (rb_Litres.Checked) unit += "L";
			dg_CompoundList.Rows.Add(cbox_CompundList.SelectedItem.ToString(), (float)num_Quantity.Value + unit);

			foreach (ChemicalObject chemical in parentForm.chemicalList)
			{
				if (chemical.name == cbox_CompundList.SelectedItem.ToString())
				{
					compounds.Add(chemical);
				}
			}

		}

		private void btn_RemoveRequirement_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dg_CompoundList.Rows)
			{
				if (row.Selected)
				{
					dg_CompoundList.Rows.Remove(row);
				}
			}
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			ProjectObject newProject = new ProjectObject
			{
				name = "test",
				chemFormula = "H2O",
				requiredCompounds = compounds
			};
			parentForm.addNewProject(newProject);
		}
	}
}
