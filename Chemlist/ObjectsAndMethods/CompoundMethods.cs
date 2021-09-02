using System.Collections.Generic;
using System.Drawing;

namespace Chemlist
{
	public partial class Form1
	{
		// Populate chemicals
		void invalidateCompoundNamesList()
		{
			List<ChemicalObject> chemicalNames = new List<ChemicalObject>();
			chemicalNames.Clear();
			chemicalList.Sort(delegate (ChemicalObject name1, ChemicalObject name2) { return name1.name.CompareTo(name2.name); });
			foreach (ChemicalObject chemical in chemicalList)
			{
				if (cbox_CompoundSort.SelectedIndex == 1 && !chemical.inStorage)
					continue;
				else if (cbox_CompoundSort.SelectedIndex == 2 && chemical.inStorage)
					continue;

				if (chemical.name.ToLower().Contains(tbox_CompoundSearch.Text.ToLower())
				|| tbox_CompoundSearch.Text == ""
				|| tbox_CompoundSearch.Text == "Search"
				|| chemical.chemFormula.ToLower().Contains(tbox_CompoundSearch.Text.ToLower())
				|| chemical.allNames.ToLower().Contains(tbox_CompoundSearch.Text.ToLower()))
				{
					chemicalNames.Add(chemical);
				}
			}
			compoundSource.DataSource = chemicalNames;
			compoundSource.ResetBindings(false);
		}

		// Add new chemical
		public void addNewChemical(ChemicalObject newChemical)
		{
			chemicalList.Add(newChemical);
			serialiseJsonChem();
			invalidateCompoundNamesList();
		}
		// Remove chemical
		void removeChemical(int index)
		{
			if (index >= 0)
			{
				chemicalList.RemoveAt(index);
				serialiseJsonChem();
				invalidateCompoundNamesList();
				redrawCompoundInfoPanel();
			}
		}

		// Edit compound
		public void editCompound(ChemicalObject edited)
		{
			int i = 0;
			foreach (ChemicalObject item in chemicalList)
			{
				if (edited.chemID == item.chemID)
				{
					chemicalList[i] = edited;
					serialiseJsonChem();
					redrawCompoundInfoPanel();
					return;
				}
				i++;
			}
		}

		public void redrawCompoundInfoPanel()
		{
			if (lbox_ChemicalList.Items.Count > 0 && lbox_ChemicalList.SelectedItem != null)
			{
				ChemicalObject current = (ChemicalObject)lbox_ChemicalList.SelectedItem;
				float FontSize = rtb_Formula.Font.Size;
				Font Small_font = new Font(rtb_Formula.Font.FontFamily, FontSize * .8f);

				// Pupulate
				txt_chemName.Text = current.name;
				rtb_Formula.Text = current.chemFormula;
				foreach (int position in subscripts(current.chemFormula))
				{
					rtb_Formula.Select(position, 1);
					rtb_Formula.SelectionCharOffset = -4;
					rtb_Formula.SelectionFont = Small_font;
					rtb_Formula.Select(0, 0);
				}

				// Used in
				lbox_UsedIn.Items.Clear();
				foreach (ProjectObject project in projectList)
				{
					foreach (ProjectObject.RequiredChemicals chemical in project.requiredChemicals)
					{
						if (chemical.compound.chemID == current.chemID)
							lbox_UsedIn.Items.Add(project);
					}
				}

				lview_Warnings.Clear();
				foreach (Hazards hazards in current.hazards)
				{
					lview_Warnings.Items.Add(hazards.symbols, hazards.symbols).ToolTipText = hazards.description;
					//lview_Warnings.Items[0].ToolTipText = hazards.description;
				}

				// Made in
				lbox_ChemMadeIn.Items.Clear();
				foreach (ProjectObject project in projectList)
					foreach (ChemicalObject chemical in project.makesChemicals)
					{
						if (chemical.chemID == current.chemID)
							lbox_ChemMadeIn.Items.Add(project);
					}


				rtb_Description.Text = current.descripion;

				if (current.inStorage) { txt_Availability.Text = "Available in Storage"; }
					else { txt_Availability.Text = "Unavailable in Storage"; }
				if (current.availableThroughProject) { txt_Availability.Text += "\nAvailable Through Projects"; }
					else { txt_Availability.Text += "\nUnavailable Through Projects"; }


				if (current.bAllNames) { txt_Names.Text = current.allNames; }
				else { txt_Names.Text = "None"; }
				if (current.bMolarMass) { txt_MolarMass.Text = current.molarMass.ToString() + " g/mol"; }
				else { txt_MolarMass.Text = "-"; }
				if (current.bAppearance) { txt_Appearance.Text = current.appearance; }
				else { txt_Appearance.Text = "-"; }
				if (current.bDensity) { txt_Density.Text = current.density.ToString() + " g/ccm"; }
				else { txt_Density.Text = "-"; }
				if (current.bMeltingPoint) { txt_MeltingPoint.Text = current.mPoint.ToString() + " °C"; }
				else { txt_MeltingPoint.Text = "-"; }
				if (current.bBoilingPoint) { txt_BoilingPoint.Text = current.bPoint.ToString() + " °C"; }
				else { txt_BoilingPoint.Text = "-"; }
				if (current.bSolubility) { rtb_Solubility.Text = current.solubility; }
				else { rtb_Solubility.Text = "-"; }
				if (current.bVapourPressure) { txt_VapourPressure.Text = current.vapourPressure.ToString() + " mmHg"; }
				else { txt_VapourPressure.Text = "-"; }
				if (current.bAcidity) { txt_Acidity.Text = current.pKa.ToString(); }
				else { txt_Acidity.Text = "-"; }
				if (current.bFlashPoint) { txt_FlashPoint.Text = current.flashPoint.ToString() + " °C"; }
				else { txt_FlashPoint.Text = "-"; }
				if (current.bLD50) { txt_LD50.Text = current.lethalDose50.ToString() + " mg/kg"; }
				else { txt_LD50.Text = "-"; }
				if (current.bLC50) { txt_LC50.Text = current.lethalConcentration50.ToString() + " ppm"; }
				else { txt_LC50.Text = "-"; }
				if (current.bWikiLink) { tlink_Wiki.Enabled = true; tlink_Wiki.Text = current.wikiName; }
				else { tlink_Wiki.Enabled = false; tlink_Wiki.Text = "-"; }
				if (current.bPurchaseLink) { tlink_Purchase.Enabled = true; tlink_Purchase.Text = current.purchaseName; }
				else { tlink_Purchase.Enabled = false; tlink_Purchase.Text = "-"; }
				if (current.bMSDS) { tlink_MSDS.Enabled = true; tlink_MSDS.Text = current.msdsName; }
				else { tlink_MSDS.Enabled = false; tlink_MSDS.Text = "-"; }


				if (current.bSInWater && !current.miscible) { txt_SInWater.Text = current.solubilityInWater.ToString() + " g/l"; }
				else { txt_SInWater.Text = "-"; }
				if (current.miscible) { txt_SInWater.Text = "Miscible"; }

				if (Properties.Settings.Default.showGuid)
				{
					cguid.Text = current.chemID.ToString();
					cguid.Visible = true;
				}
				else
					cguid.Visible = false;
			}
			else
			{
				txt_chemName.Text = "Please select a compound.";
				rtb_Formula.Text = "";
				rtb_Description.Text = "";
				cguid.Text = "";
				lbox_UsedIn.Items.Clear();

				txt_Names.Text = "None";
				txt_MolarMass.Text = "-";
				txt_Appearance.Text = "-";
				txt_Density.Text = "-";
				txt_MeltingPoint.Text = "-";
				txt_BoilingPoint.Text = "-";
				rtb_Solubility.Text = "-";
				txt_VapourPressure.Text = "-";
				txt_Acidity.Text = "-";
				txt_FlashPoint.Text = "-";
				txt_LD50.Text = "-";
				txt_LC50.Text = "-";
				txt_SInWater.Text = "-";

			}
		}

		public bool checkCompoundAvailabilityThroughProjects(ChemicalObject chemicalObject)
		{
			List<ProjectObject> projects = new List<ProjectObject>();
			foreach (ProjectObject project in projectList)
				foreach (ChemicalObject chemical in project.makesChemicals)
					if (chemical.chemID == chemicalObject.chemID)
						projects.Add(project);
			foreach (ProjectObject project in projects)
				if (project.available || project.availableThroughProjects)
				{
					chemicalObject.availableThroughProject = true;
					return true;
				}
			chemicalObject.availableThroughProject = false;
			return false;
		}
	}
}
