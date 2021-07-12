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
		public List<Guid> compoundID = new List<Guid>();
		bool allowAdding = true;



		public AddNewProject()
		{
			InitializeComponent();

			cbox_CompoundList.DisplayMember = "name";
		}

		private void cbox_CompoundList_DropDown(object sender, EventArgs e)
		{
			cbox_CompoundList.Items.Clear();
			foreach (ChemicalObject chemicalObject in parentForm.chemicalList)
			{
				cbox_CompoundList.Items.Add(chemicalObject);
			}

		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_AddRequirement_Click(object sender, EventArgs e)
		{
			if (cbox_CompoundList.SelectedItem != null)
			{
				errorProvider1.SetError(cbox_CompoundList, "");
				String unit;
				if (check_MiliPrefix.Checked) unit = " m"; else unit = " ";
				if (rb_Grams.Checked) unit += "g"; else if (rb_Litres.Checked) unit += "L";

				ChemicalObject selectedChemical = (ChemicalObject)cbox_CompoundList.SelectedItem;
				dg_CompoundList.Rows.Add(selectedChemical.name, (float)num_Quantity.Value + unit);
				foreach (ChemicalObject chemical in parentForm.chemicalList)
				{
					if (chemical.chemID == selectedChemical.chemID)
					{
						compoundID.Add(chemical.chemID);
					}
				}
			}
			else
				errorProvider1.SetError(cbox_CompoundList, "Please add a valid compound.");
		}

		private void btn_RemoveRequirement_Click(object sender, EventArgs e)
		{
			if (dg_CompoundList.SelectedRows.Count > 0)
			{
				//foreach (ChemicalObject chemical in )
				{
					// FIXME: Removing doesn't work anymore.
				}

				dg_CompoundList.Rows.Remove(dg_CompoundList.SelectedRows[0]);

			}
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			ProjectObject newProject = new ProjectObject
			{
				name = tbox_ChemName.Text,
				chemFormula = tbox_ProjectFormula.Text,
				description = rtbox_Methods.Text,
				requiredCompounds = compoundID
			};
			parentForm.addNewProject(newProject);
		}

		public void validateConfirmation()
		{
			// todo
		}
	}
}
