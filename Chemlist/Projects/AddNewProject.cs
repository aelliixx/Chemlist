using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chemlist
{
	public partial class AddNewProject : Form
	{
		public Form1 parentForm { get; set; }
		private List<Guid> compoundID = new List<Guid>();
		private List<ChemicalObject> chemicalList = new List<ChemicalObject>();
		private bool allowAdding = true;
		private List<ProjectObject.RequiredChemicals> requiredChemicals = new List<ProjectObject.RequiredChemicals>();
        private List<ChemicalObject> makesChemicals = new List<ChemicalObject>();
		private ProjectObject parentProject = new ProjectObject();
		

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			validateConfirmation();
			if (allowAdding)
			{
				ProjectObject newProject = new ProjectObject
				{
					name = tbox_ProjectName.Text,
					chemFormula = rtb_ProjectFormula.Text,
					description = tbox_Description.Text,
					methods = rtb_Methods.Text,
					requiredChemicals = requiredChemicals,
                    makesChemicals = makesChemicals,
					parentProject = parentProject
				};

				if (check_AccutelyToxic.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[0]);
				if (check_Corrosive.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[1]);
				if (check_EnvHazard.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[2]);
				if (check_HarmfulIrritant.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[3]);
				if (check_Explosive.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[4]);
				if (check_Flamable.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[5]);
				if (check_CompressedGas.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[6]);
				if (check_HealthHazard.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[7]);
				if (check_Oxidising.Checked)
					newProject.hazards.Add(parentForm.hazardSymbols[8]);

				parentForm.addNewProject(newProject);
				this.Close();
			}
		}

		public AddNewProject(List<ChemicalObject> chemicals)
		{
			InitializeComponent();


			chemicalList = chemicals;
			populateMakesList();
			
			lbox_MakesChemicalList.DisplayMember = "name";
			cbox_CompoundList.DisplayMember = "name";
			cbox_ParentProject.DisplayMember = "name";
		}

		private void populateMakesList()
		{
			lbox_MakesChemicalList.Items.Clear();
			foreach (ChemicalObject chemical in chemicalList)
			{
				if (chemical.name.ToLower().Contains(tbox_CompoundSearch.Text.ToLower())
					|| tbox_CompoundSearch.Text == ""
					|| tbox_CompoundSearch.Text == "Search"
					|| chemical.chemFormula.ToLower().Contains(tbox_CompoundSearch.Text.ToLower())
					|| chemical.allNames.ToLower().Contains(tbox_CompoundSearch.Text.ToLower()))
					lbox_MakesChemicalList.Items.Add(chemical);
			}
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
		
		private void invalidateRequiredCompounds()
		{
			dg_CompoundList.Rows.Clear();
			compoundID.Clear();
			foreach (ProjectObject.RequiredChemicals selected in requiredChemicals)
			{
				dg_CompoundList.Rows.Add(selected.compound.name, selected.quantity + selected.unit );
				foreach (ChemicalObject chemical in parentForm.chemicalList)
				{
					if (chemical.chemID == selected.compound.chemID)
					{
						compoundID.Add(chemical.chemID);
					}
				}

			}

		}

		private void btn_AddRequirement_Click(object sender, EventArgs e)
		{
			if (cbox_CompoundList.SelectedItem != null)
			{
				errorProvider1.SetError(cbox_CompoundList, "");
				ChemicalObject selectedChemical = (ChemicalObject)cbox_CompoundList.SelectedItem;
				ProjectObject.RequiredChemicals chemical = new ProjectObject.RequiredChemicals()
				{
					compound = selectedChemical,
					unit = (check_MiliPrefix.Checked ? " m" : " ") + (rb_Grams.Checked ? "g" : "L"),
					quantity = (float)num_Quantity.Value,
					concentration = (float)num_Concentration.Value
				};
				requiredChemicals.Add(chemical);
				invalidateRequiredCompounds();

			}
			else
				errorProvider1.SetError(cbox_CompoundList, "Please add a valid compound.");
		}

		private void btn_RemoveRequirement_Click(object sender, EventArgs e)
		{
			if (dg_CompoundList.SelectedRows.Count > 0)
			{
				foreach (ProjectObject.RequiredChemicals chemical in requiredChemicals)
				{
					if (dg_CompoundList.SelectedRows[0].Cells[0].Value.ToString() == chemical.compound.name)
					{
						requiredChemicals.Remove(chemical);
						invalidateRequiredCompounds();
						break;
					}
				}
				
			}
		}

		private void validateConfirmation()
		{
			if (
			validateTextbox(tbox_ProjectName) &&
			validateTextbox(tbox_Description))
			{
				allowAdding = true;
				return;
			}
			allowAdding = false;
			return;
		}

		private bool validateTextbox(TextBox textBox)
		{
			errorProvider1.SetError(textBox, "");
			if (textBox.Text == "")
			{
				errorProvider1.SetError(textBox, "Please enter a value");
				return false;
			}
			return true;
		}

		private void lbox_MakesChemicalList_SelectedIndexChanged(object sender, EventArgs e)
		{
			rtb_ProjectFormula.Clear();
            makesChemicals.Clear();
			foreach(ChemicalObject chemical in lbox_MakesChemicalList.SelectedItems)
			{
				rtb_ProjectFormula.Text += chemical.chemFormula + (lbox_MakesChemicalList.SelectedItems.Count > 1 ? "; " : "");
                makesChemicals.Add(chemical);
			}

			float FontSize = rtb_ProjectFormula.Font.Size;
			Font Small_font = new Font(rtb_ProjectFormula.Font.FontFamily, FontSize * .8f);
			foreach (int position in parentForm.subscripts(rtb_ProjectFormula.Text))
			{
				rtb_ProjectFormula.Select(position, 1);
				rtb_ProjectFormula.SelectionCharOffset = -4;
				rtb_ProjectFormula.SelectionFont = Small_font;
				rtb_ProjectFormula.Select(0, 0);
			}


		}

		private void tbox_CompoundSearch_Enter(object sender, EventArgs e)
		{
			if (tbox_CompoundSearch.Text == "Search")
				tbox_CompoundSearch.Text = "";
		}

		private void tbox_CompoundSearch_Leave(object sender, EventArgs e)
		{
			if (tbox_CompoundSearch.Text == "")
				tbox_CompoundSearch.Text = "Search";
		}

		private void tbox_CompoundSearch_TextChanged(object sender, EventArgs e)
		{
			populateMakesList();
		}

		private void cbox_ParentProject_DropDown(object sender, EventArgs e)
		{
			cbox_ParentProject.Items.Clear();
			cbox_ParentProject.Items.Add(new ProjectObject());
			foreach (ProjectObject project in parentForm.projectList)
				cbox_ParentProject.Items.Add(project);
		}

		private void cbox_ParentProject_SelectedIndexChanged(object sender, EventArgs e)
		{
			ProjectObject selected = (ProjectObject)cbox_ParentProject.SelectedItem;
			if (selected.name == string.Empty || selected.name == null)
				parentProject = null;
			else
				parentProject = (ProjectObject)cbox_ParentProject.SelectedItem;
		}
	}
}
