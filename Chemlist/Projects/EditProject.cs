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
	public partial class EditProject : Form
	{
		public Form1 parentForm { get; set; }
		private List<Guid> compoundID = new List<Guid>();
		private List<ChemicalObject> chemicalList = new List<ChemicalObject>();
		private bool allowAdding = true;
		private List<ProjectObject.RequiredChemicals> requiredChemicals = new List<ProjectObject.RequiredChemicals>();
		private List<ChemicalObject> makesChemicals = new List<ChemicalObject>();
		private ProjectObject parentProject = new ProjectObject();
		private ProjectObject currentEditable;
		private Guid currentGuid;

		public EditProject(ProjectObject editable, List<ChemicalObject> chemicals)
		{
			currentEditable = editable;
			InitializeComponent();
			chemicalList = chemicals;

			lbox_MakesChemicalList.DisplayMember = "name";
			cbox_CompoundList.DisplayMember = "name";
			cbox_ParentProject.DisplayMember = "name";

			tbox_ProjectName.Text = currentEditable.name;
			rtb_ProjectFormula.Text = currentEditable.chemFormula;
			tbox_Description.Text = currentEditable.description;
			cbox_ParentProject.Text = currentEditable.parentProject != null ? currentEditable.parentProject.name : "";
			rtb_Methods.Text = currentEditable.methods;

			parentProject = currentEditable.parentProject;
			requiredChemicals = currentEditable.requiredChemicals;
			makesChemicals = currentEditable.makesChemicals;
			currentGuid = currentEditable.projectID;


			invalidateRequiredCompounds();
			populateMakesList();
			

			foreach (ChemicalObject chemical in chemicalList)
			{
				foreach (ChemicalObject chemicalObject in makesChemicals)
				{
					if (chemical.name == chemicalObject.name)
					{
						lbox_MakesChemicalList.SetSelected(lbox_MakesChemicalList.FindString(chemical.name), true);
					}
				}
			}


			foreach (Hazards hazards in currentEditable.hazards)
			{
				switch (hazards.symbols)
				{
					case "AcutelyToxic":
						check_AccutelyToxic.Checked = true;
						break;
					case "Corrosive":
						check_Corrosive.Checked = true;
						break;
					case "EnvironmentalHazard":
						check_EnvHazard.Checked = true;
						break;
					case "MildIrritant":
						check_HarmfulIrritant.Checked = true;
						break;
					case "Explosive":
						check_Explosive.Checked = true;
						break;
					case "Flamable":
						check_Flamable.Checked = true;
						break;
					case "Pressurised":
						check_CompressedGas.Checked = true;
						break;
					case "HealthHazard":
						check_HealthHazard.Checked = true;
						break;
					case "Oxidiser":
						check_Oxidising.Checked = true;
						break;
					default:
						break;
				}
			}
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
		
		private void invalidateRequiredCompounds()
		{
			dg_CompoundList.Rows.Clear();
			compoundID.Clear();
			foreach (ProjectObject.RequiredChemicals selected in requiredChemicals)
			{
				dg_CompoundList.Rows.Add(selected.compound.name, selected.quantity + selected.unit);
				foreach (ChemicalObject chemical in chemicalList)
				{
					if (chemical.chemID == selected.compound.chemID)
					{
						compoundID.Add(chemical.chemID);
					}
				}
			}

		}

		private void cbox_ParentProject_DropDown(object sender, EventArgs e)
		{
			cbox_ParentProject.Items.Clear();
			cbox_ParentProject.Items.Add(new ProjectObject());
			foreach (ProjectObject project in parentForm.projectList)
				 if (project != currentEditable)
					cbox_ParentProject.Items.Add(project);
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			validateConfirmation();
			if (allowAdding)
			{
				ProjectObject editedProject = new ProjectObject()
				{
					projectID = currentGuid,
					name = tbox_ProjectName.Text,
					description = tbox_Description.Text,
					chemFormula = rtb_ProjectFormula.Text,
					requiredChemicals = requiredChemicals,
					makesChemicals = makesChemicals,
					parentProject = parentProject,
					methods = rtb_Methods.Text
				};
				editedProject.hazards.Clear();
				if (check_AccutelyToxic.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[0]);
				if (check_Corrosive.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[1]);
				if (check_EnvHazard.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[2]);
				if (check_HarmfulIrritant.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[3]);
				if (check_Explosive.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[4]);
				if (check_Flamable.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[5]);
				if (check_CompressedGas.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[6]);
				if (check_HealthHazard.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[7]);
				if (check_Oxidising.Checked)
					editedProject.hazards.Add(parentForm.hazardSymbols[8]);

				parentForm.editProject(editedProject);
				this.Close();
			}
		}

		private void validateConfirmation()
		{
			if (validateTextbox(tbox_ProjectName) && validateTextbox(tbox_Description))
			{
				allowAdding = true;
				return;
			}
			allowAdding = false;
			return;
		}

		private bool validateTextbox(TextBox textBox)
		{
			errorProvider.SetError(textBox, "");
			if (textBox.Text == "")
			{
				errorProvider.SetError(textBox, "Please enter a value");
				return false;
			}
			return true;
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

		private void cbox_CompoundList_DropDown(object sender, EventArgs e)
		{
			cbox_CompoundList.Items.Clear();
			foreach (ChemicalObject chemicalObject in parentForm.chemicalList)
				cbox_CompoundList.Items.Add(chemicalObject);
		}

		private void btn_AddRequirement_Click(object sender, EventArgs e)
		{
			if (cbox_CompoundList.SelectedItem != null)
			{
				errorProvider.SetError(cbox_CompoundList, "");
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
				errorProvider.SetError(cbox_CompoundList, "Please add a valid compound.");
		}

		private void lbox_MakesChemicalList_Click(object sender, EventArgs e)
		{
			rtb_ProjectFormula.Clear();
			makesChemicals.Clear();
			foreach (ChemicalObject chemical in lbox_MakesChemicalList.SelectedItems)
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
