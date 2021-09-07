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
		private Guid currentGuid;

		public EditProject(ProjectObject current, List<ChemicalObject> chemicals)
		{
			InitializeComponent();
			chemicalList = chemicals;

			lbox_MakesChemicalList.DisplayMember = "name";
			cbox_CompoundList.DisplayMember = "name";
			cbox_ParentProject.DisplayMember = "name";

			tbox_ProjectName.Text = current.name;
			rtb_ProjectFormula.Text = current.chemFormula;
			tbox_Description.Text = current.description;
			cbox_ParentProject.Text = current.parentProject.name;
			rtb_Methods.Text = current.methods;

			requiredChemicals = current.requiredChemicals;
			currentGuid = current.projectID;


			invalidateRequiredCompounds();
			populateMakesList();
			

			foreach (ChemicalObject chemical in chemicalList)
			{
				foreach (ChemicalObject chemicalObject in current.makesChemicals)
				{
					if (chemical.name == chemicalObject.name)
					{
						lbox_MakesChemicalList.SetSelected(lbox_MakesChemicalList.FindString(chemical.name), true);
					}
				}
			}


			foreach (Hazards hazards in current.hazards)
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
				cbox_ParentProject.Items.Add(project);
		}

		private void cbox_CompoundList_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbox_CompoundList.Items.Clear();
			foreach (ChemicalObject chemicalObject in parentForm.chemicalList)
				cbox_CompoundList.Items.Add(chemicalObject);

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
	}
}
