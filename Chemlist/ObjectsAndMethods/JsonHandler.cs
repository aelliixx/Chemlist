using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Chemlist
{
	public partial class Form1
	{
		// Read and populate from json
		private String compoundJSON;
		private String projectJSON;
		private const String backupCompoundJson = @".\chemicals_backup.json";
		private const String backupProjectJson = @".\projects_backup.json";
		private List<String> jsonChemicals;
		private List<String> jsonProjects;
		void validateFile(String fileName, ref List<String> json)
		{
			if (File.Exists(fileName))
			{
				json = File.ReadAllLines(fileName).ToList();
				if (json.Count == 0)
				{
					File.WriteAllText(fileName, "[]");
					validateFile(fileName, ref json);
				}
				return;
			}
			else
			{
				File.WriteAllText(fileName, "[]");
				validateFile(fileName, ref json);
			}
		}

		// fixme empty file same crash
		void deserialiseJsonProjets()
		{
			List<ProjectObject> NewProject = JsonConvert.DeserializeObject<List<ProjectObject>>(String.Concat(jsonProjects));
			foreach (ProjectObject item in NewProject)
			{
				projectList.Add(item);
			}
			invalidateProjectList();
		}

		void deserialiseJsonChem()
		{
			List<ChemicalObject> NewChemical = JsonConvert.DeserializeObject<List<ChemicalObject>>(String.Concat(jsonChemicals));
			foreach (ChemicalObject item in NewChemical)
			{
				chemicalList.Add(item);
			}
			invalidateCompoundNamesList();
		}

		void serialiseJsonProjects(String file)
		{
			String newJson = JsonConvert.SerializeObject(projectList);
			File.WriteAllText(file, newJson);
			invalidateProjectList();
		}

		void serialiseJsonChem(String file)
		{
			String newJson = JsonConvert.SerializeObject(chemicalList);
			File.WriteAllText(file, newJson);
			invalidateCompoundNamesList();
		}
	}
}
