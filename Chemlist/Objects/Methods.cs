using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Chemlist
{
	public partial class Form1
	{
		// Populate chemicals
		public List<ChemicalObject> chemicalList = new List<ChemicalObject>();

		void invalidateNamesList()
		{
			chemicalNames.Clear();
			chemicalList.Sort(delegate (ChemicalObject name1, ChemicalObject name2) { return name1.name.CompareTo(name2.name); });
			foreach (ChemicalObject chemical in chemicalList)
				chemicalNames.Add(chemical.name);

			bs.DataSource = chemicalNames;
			bs.ResetBindings(false);
		}



		// Read and populate from json
		String filePath = @".\chemicals.json";
		List<String> jsonChemicals;
		String concatted;
		void validateFile()
		{
			if (File.Exists(filePath))
			{
				jsonChemicals = File.ReadAllLines(filePath).ToList();
				concatted = String.Concat(jsonChemicals);
				return;
			}
			File.Create(filePath);
		}

		void deserialiseJsonChem()
		{
			List<ChemicalObject> NewChemical = JsonConvert.DeserializeObject<List<ChemicalObject>>(concatted);
			foreach (ChemicalObject item in NewChemical)
			{
				chemicalList.Add(item);
			}
			invalidateNamesList();
		}

		void serialiseJsonChem()
		{
			String newJson = JsonConvert.SerializeObject(chemicalList);
			File.WriteAllText(filePath, newJson);
			invalidateNamesList();
		}


		// Add new chemical
		public void addNewChemical(ChemicalObject newChemical)
		{
			chemicalList.Add(newChemical);
			serialiseJsonChem();
			invalidateNamesList();
		}
		// Remove chemical
		void removeChemical(int index)
		{
			chemicalList.RemoveAt(index);
			serialiseJsonChem();
			invalidateNamesList();
			redrawInfoPanel();
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
					redrawInfoPanel();
					return;
				}
				i++;
			}
		}

		public void redrawInfoPanel()
		{
			ChemicalObject current = chemicalList[lbox_ChemicalList.SelectedIndex];
			float FontSize = rtb_Formula.Font.Size;
			Font Small_font = new Font(rtb_Formula.Font.FontFamily, FontSize * .8f);

			// Pupulate
			txt_chemName.Text = current.name;
			rtb_Formula.Text = current.chemFormula;
			foreach (int position in current.subscripts())
			{
				rtb_Formula.Select(position, 1);
				rtb_Formula.SelectionCharOffset = -4;
				rtb_Formula.SelectionFont = Small_font;
				rtb_Formula.Select(0, 0);
			}

			rtb_Description.Text = current.descripion;


			if (current.bAllNames) { txt_Names.Text = current.allNames; } else { txt_Names.Text = "None"; }
			if (current.bMolarMass) { txt_MolarMass.Text = current.molarMass.ToString() + " g/mol"; } else { txt_MolarMass.Text = "Unavailable"; }
			if (current.bAppearance) { txt_Appearance.Text = current.appearance; } else { txt_Appearance.Text = "Unavailable"; }
			if (current.bDensity) { txt_Density.Text = current.density.ToString() + " g/ccm"; } else { txt_Density.Text = "Unavailable"; }
			if (current.bMeltingPoint) { txt_MeltingPoint.Text = current.mPoint.ToString() + " °C"; } else { txt_MeltingPoint.Text = "Unavailable"; }
			if (current.bBoilingPoint) { txt_BoilingPoint.Text = current.bPoint.ToString() + " °C"; } else { txt_BoilingPoint.Text = "Unavailable"; }
			if (current.bSolubility) { txt_Solubility.Text = current.solubility; } else { txt_Solubility.Text = "Unavailable"; }
			if (current.bVapourPressure) { txt_VapourPressure.Text = current.vapourPressure.ToString() + " mmHg"; } else { txt_VapourPressure.Text = "Unavailable"; }
			if (current.bAcidity) { txt_Acidity.Text = current.pKa.ToString(); } else { txt_Acidity.Text = "Unavailable"; }
			if (current.bFlashPoint) { txt_FlashPoint.Text = current.flashPoint.ToString() + " °C"; } else { txt_FlashPoint.Text = "Unavailable"; }
			if (current.bLD50) { txt_LD50.Text = current.lethalDose50.ToString() + " mg/kg"; } else { txt_LD50.Text = "Unavailable"; }
			if (current.bLC50) { txt_LC50.Text = current.lethalConcentration50.ToString() + " ppm"; } else { txt_LC50.Text = "Unavailable"; }
			
			if (current.bSInWater && !current.miscible) { txt_SInWater.Text = current.solubilityInWater.ToString() + " g/100 ml"; } else { txt_SInWater.Text = "Unavailable"; }
			if (current.miscible) { txt_SInWater.Text = "Miscible"; }




			if (settings.showGUID)
			{
				cguid.Text = current.chemID.ToString();
				cguid.Visible = true;
			}
			else
				cguid.Visible = false;
		}
	}



	public class Settings
	{
		public bool showGUID { get; set; }

		public Settings()
		{
			showGUID = false;
		}
	}
}
