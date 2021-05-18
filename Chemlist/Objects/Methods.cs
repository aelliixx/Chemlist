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


			txt_chemName.Text = current.name;
			rtb_Formula.Text = current.chemFormula;

			foreach (int position in current.subscripts())
			{
				rtb_Formula.Select(position, 1);
				rtb_Formula.SelectionCharOffset = -4;
				rtb_Formula.SelectionFont = Small_font;
				rtb_Formula.Select(0, 0);
			}

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
