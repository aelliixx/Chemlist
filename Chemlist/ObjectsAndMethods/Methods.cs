using System;
using System.Collections.Generic;

namespace Chemlist
{
	public partial class Form1
	{
		ChemicalObject matchChemicalObject(ChemicalObject match)
		{
			foreach (ChemicalObject chemical in chemicalList)
			{
				if (chemical.chemID == match.chemID)
					return chemical;
			}
			return new ChemicalObject() { name = "Invalid Compound" };
		}


		public List<int> subscripts(String formula)
		{
			List<int> digits = new List<int>();
			for (int i = 0; i < formula.Length; i++)
			{
				if (formula[i] == '*')
				{
					for (int o = i + 2; o < formula.Length; o++)
					{
						i++;
						if (!Char.IsDigit(formula[o]))
							break;
					}
				}
				else if (Char.IsDigit(formula[i]))
				{
					digits.Add(i);
				}
			}
			return digits;
		}

		private void serialiseAll(String compoundFile, String projectFile)
		{
			serialiseJsonChem(compoundFile);
			serialiseJsonProjects(projectFile);
		}

		private void invalidateAllLists()
		{
			invalidateCompoundNamesList();
			invalidateProjectList();
		}

		private void redrawAllDetails()
		{
			redrawCompoundInfoPanel();
			redrawProjectInfoPanel();
		}

		private void checkAllAvailabilities()
		{
			foreach (ProjectObject project in projectList)
				checkProjectAvailability(project);
			foreach (ChemicalObject chemical in chemicalList)
				checkCompoundAvailabilityThroughProjects(chemical);
			foreach (ProjectObject project in projectList)
				checkProjectAvailabilityThroughOtherProjects(project);
		}

		private void deserialiseAll()
		{
			deserialiseJsonChem();
			deserialiseJsonProjets();
		}

		private void setNewReadFiles(String compoundFile, String projectFile)
		{
			compoundJSON = compoundFile;
			projectJSON = projectFile;
			Properties.Settings.Default.compoundJsonPath = compoundJSON;
			Properties.Settings.Default.projectJsonPath = projectJSON;
			Properties.Settings.Default.Save();
		}

		private void initJson(String compoundFile, String projectFile, bool saveSettings)
		{
			chemicalList.Clear();
			projectList.Clear();

			if (saveSettings)
				setNewReadFiles(compoundFile, projectFile);
			
			validateFile(compoundFile, ref jsonChemicals);
			validateFile(projectFile, ref jsonProjects);
			
			deserialiseAll();
			serialiseAll(compoundFile, projectFile);
			invalidateAllLists();
			redrawAllDetails();
		}
	}
}
