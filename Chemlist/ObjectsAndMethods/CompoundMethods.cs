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
			serialiseJsonChem(compoundJSON);
			invalidateCompoundNamesList();
		}
		// Remove chemical
		void removeChemical(int index)
		{
			if (index >= 0)
			{
				chemicalList.RemoveAt(index);
				serialiseJsonChem(compoundJSON);
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
					serialiseJsonChem(compoundJSON);
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

				if (current.inStorage) { txt_Availability.Text = "Available in Storage;    "; }
					else { txt_Availability.Text = "Unavailable in Storage;   "; }
				if (current.availableThroughProject) { txt_Availability.Text += "Available Through Projects"; }
					else { txt_Availability.Text += "Unavailable Through Projects"; }

				rtb_Properties.Text = "";
				if (current.bMolarMass) { rtb_Properties.Text += "Molar mass:\t\t" + current.molarMass.ToString() + "g/mol\n"; }
				else { rtb_Properties.Text += "Molar mass:\t\t-\n"; }
				if (current.bDensity) { rtb_Properties.Text += "Density:\t\t\t" + current.density.ToString() + " g/ccm\n"; }
				else { rtb_Properties.Text += "Density:\t\t\t-\n"; }
				if (current.bMeltingPoint) { rtb_Properties.Text += "Melting point:\t\t" + current.mPoint.ToString() + " °C\n"; }
				else { rtb_Properties.Text += "Melting point:\t\t-\n"; }
				if (current.bBoilingPoint) { rtb_Properties.Text += "Boiling point:\t\t" + current.bPoint.ToString() + " °C\n"; }
				else { rtb_Properties.Text += "Boiling point:\t\t-\n"; }
				if (current.bSInWater && !current.miscible) { rtb_Properties.Text += "Solubility in water:\t\t" +
						current.solubilityInWater.ToString() + " g/l\n"; }
				else { rtb_Properties.Text += "Solubility in water:\t\t-\n"; }
				if (current.miscible) { rtb_Properties.Text += "Solubility in water:\t\tMiscible\n"; }
				if (current.insoluble) { rtb_Properties.Text += "Solubility in water:\t\tInsoluble\n"; }
				if (current.bVapourPressure) { rtb_Properties.Text += "Vapour pressure:\t\t" + current.vapourPressure.ToString() + "mmHg\n";}
				else { rtb_Properties.Text += "Vapour pressure:\t\t-\n"; }
				if (current.bAcidity) { rtb_Properties.Text += "Acidity (pKa):\t\t" + current.pKa.ToString() + "\n"; }
				else { rtb_Properties.Text += "Acidity: (pKa):\t\t-\n"; }
				if (current.bFlashPoint) { rtb_Properties.Text += "Flash point:\t\t" + current.flashPoint.ToString() + " °C\n"; }
				else { rtb_Properties.Text += "Flash point:\t\t-\n"; }
				if (current.bLD50) { rtb_Properties.Text += "LD50:\t\t\t" + current.lethalDose50.ToString() + " mg/kg\n"; }
				else { rtb_Properties.Text += "LD50:\t\t\t-\n"; }
				if (current.bLC50) { rtb_Properties.Text += "LC50:\t\t\t" +  current.lethalConcentration50.ToString() + " ppm\n"; }
				else { rtb_Properties.Text += "LC50:\t\t\t-\n"; }

				if (current.bAllNames) { rtb_Properties.Text += "Other names:\t\t" + current.allNames + "\n"; }
				else { rtb_Properties.Text += "Other names:\t\tNone\n"; }
				if (current.bAppearance) { rtb_Properties.Text += "Appearance:\t\t" + current.appearance + "\n"; }
				else { rtb_Properties.Text += "Appearance:\t\t-\n"; }
				if (current.bSolubility) { rtb_Properties.Text += "Solubility:\t\t\t" +  current.solubility; }
				else { rtb_Properties.Text += "Solubility:\t\t\t-\n"; }

				if (current.bWikiLink) { tlink_Wiki.Enabled = true; tlink_Wiki.Text = current.wikiName; }
				else { tlink_Wiki.Enabled = false; tlink_Wiki.Text = "-"; }
				if (current.bPurchaseLink) { tlink_Purchase.Enabled = true; tlink_Purchase.Text = current.purchaseName; }
				else { tlink_Purchase.Enabled = false; tlink_Purchase.Text = "-"; }
				if (current.bMSDS) { tlink_MSDS.Enabled = true; tlink_MSDS.Text = current.msdsName; }
				else { tlink_MSDS.Enabled = false; tlink_MSDS.Text = "-"; }





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

				rtb_Properties.Text = "";

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
