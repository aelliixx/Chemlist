using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Chemlist
{
	public partial class Form1
	{
		// Populate projects
		void invalidateProjectList()
		{
			tree_Projects.Nodes.Clear();
			projectList.Sort(delegate (ProjectObject name1, ProjectObject name2) { return name1.name.CompareTo(name2.name); });
			List<ProjectObject> projectsToAdd = new List<ProjectObject>();
			foreach (ProjectObject project in projectList)
			{
				if (cbox_ProjectSort.SelectedIndex == 1 && !project.available)
					continue;
				else if (cbox_ProjectSort.SelectedIndex == 2 && project.available)
					continue;

				if (project.name.ToLower().Contains(tbox_ProjectSearch.Text.ToLower())
					|| tbox_ProjectSearch.Text == ""
					|| tbox_ProjectSearch.Text == "Search")
				{
					projectsToAdd.Add(project);
				}
			}
			addProjectToTree(projectsToAdd,
				(tbox_ProjectSearch.Text != "Search" && tbox_ProjectSearch.Text != "") || cbox_ProjectSort.SelectedIndex != 0);
		}

		void addProjectToTree(List<ProjectObject> toAdd, bool searching = false)
		{
			List<ProjectObject> leftOver = new List<ProjectObject>();
			foreach (ProjectObject project in toAdd)
			{
				
				if (project.parentProject.name == null || !projectTreeViewToolStripMenuItem.Checked)
					tree_Projects.Nodes.Add(project.name).Tag = project;
				else
				{
					if (findAndSelectProjectByTag(project))
						tree_Projects.SelectedNode.Nodes.Add(project.name).Tag = project;
					else if (!findAndSelectProjectByTag(project) && !searching)
						leftOver.Add(project);
					else if (!findAndSelectProjectByTag(project) && searching)
						tree_Projects.Nodes.Add(project.name).Tag = project;
				}


			}

			if (leftOver.Count > 0)
				addProjectToTree(leftOver);
		}

		bool findAndSelectProjectByTag(ProjectObject tag)
		{
			var selectedNode = tree_Projects.descendants().Where(x => ((x.Tag as ProjectObject) != null) &&
					(x.Tag as ProjectObject).projectID == tag.parentProject.projectID).FirstOrDefault();
			if (selectedNode != null)
			{
				tree_Projects.SelectedNode = selectedNode;
				return true;
			}
			return false;
		}

		public void redrawProjectInfoPanel()
		{
			if (tree_Projects.Nodes.Count > 0 && tree_Projects.SelectedNode != null)
			{
				ProjectObject current = (ProjectObject)tree_Projects.SelectedNode.Tag;
				float FontSize = rtb_ProjectChemFormula.Font.Size;
				Font Small_font = new Font(rtb_ProjectChemFormula.Font.FontFamily, FontSize * .8f);

				txt_Project.Text = current.name;
				rtb_Methods.Text = current.methods;
				rtb_ProjectDescription.Text = current.description;


				rtb_ProjectChemFormula.Text = current.chemFormula;
				foreach (int position in subscripts(current.chemFormula))
				{
					rtb_ProjectChemFormula.Select(position, 1);
					rtb_ProjectChemFormula.SelectionCharOffset = -4;
					rtb_ProjectChemFormula.SelectionFont = Small_font;
					rtb_ProjectChemFormula.Select(0, 0);
				}


				pguid.Text = current.projectID.ToString();

				// Availability
				if (checkProjectAvailability(current))
				{
					txt_ProjectDoable.Text = "Available";
				}
				else
				{
					txt_ProjectDoable.Text = "Unavailable";
				}

				// Makes and requires lists
				lbox_RequiredChem.Items.Clear();
				foreach (ProjectObject.RequiredChemicals chemical in current.requiredChemicals)
				{
					lbox_RequiredChem.Items.Add(matchChemicalObject(chemical.compound));
				}
				lbox_ProjectMakes.Items.Clear();
				foreach (ChemicalObject chemical in current.makesChemicals)
				{
					lbox_ProjectMakes.Items.Add(matchChemicalObject(chemical));
				}

				// GUID
				if (Properties.Settings.Default.showGuid)
				{
					pguid.Text = current.projectID.ToString();
					pguid.Visible = true;
				}
				else
					pguid.Visible = false;
			}
			else
			{
				txt_Project.Text = "Please select or add a new project.";
				rtb_ProjectChemFormula.Text = "";
				rtb_ProjectDescription.Text = "";
				pguid.Text = "";
				lbox_RequiredChem.Items.Clear();
				lbox_ProjectMakes.Items.Clear();
			}


		}

		bool checkProjectAvailability(ProjectObject project)
		{
			foreach (ProjectObject.RequiredChemicals requiredChemical in project.requiredChemicals)
			{
				if (!matchChemicalObject(requiredChemical.compound).inStorage)
				{
					project.available = false;
					return false;
				}

			}
			project.available = true;
			return true;
		}

		public void addNewProject(ProjectObject newProject)
		{
			projectList.Add(newProject);
			serialiseJsonProjects();
			invalidateProjectList();
		}

		void removeSelectedProject(int index)
		{
			projectList.RemoveAt(index);
			serialiseJsonProjects();
			invalidateProjectList();
			redrawProjectInfoPanel();
		}

		void removeSelectedProject(ProjectObject project)
		{
			projectList.Remove(project);
			serialiseJsonProjects();
			invalidateProjectList();
			redrawProjectInfoPanel();
		}
	}
}
