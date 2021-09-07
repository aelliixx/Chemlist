using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

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
				if (cbox_ProjectSort.SelectedIndex == 1 && (!project.available && !project.availableThroughProjects))
					continue;
				else if (cbox_ProjectSort.SelectedIndex == 2 && (project.available || project.availableThroughProjects))
					continue;


				if (project.name.ToLower().Contains(tbox_ProjectSearch.Text.ToLower())
					|| tbox_ProjectSearch.Text == ""
					|| tbox_ProjectSearch.Text == "Search")
				{
					projectsToAdd.Add(project);
				}
			}
			addProjectToTree(projectsToAdd);
		}

		void addProjectToTree(List<ProjectObject> toAdd)
		{
			List<ProjectObject> leftOver = new List<ProjectObject>();
			foreach (ProjectObject project in toAdd)
			{
				
				if (project.parentProject == null || !projectTreeViewToolStripMenuItem.Checked)
					tree_Projects.Nodes.Add(project.name).Tag = project;
				else
				{
					if (selectProjectByTag(project.parentProject))
						tree_Projects.SelectedNode.Nodes.Add(project.name).Tag = project;
					else if (!selectProjectByTag(project.parentProject) && findProjectInList(toAdd, project.parentProject) != null)
						leftOver.Add(project);
					else if (!selectProjectByTag(project.parentProject) && findProjectInList(toAdd, project.parentProject) == null)
						tree_Projects.Nodes.Add(project.name).Tag = project;
				}
			}

			if (leftOver.Count > 0)
				addProjectToTree(leftOver);
			else
			{
				tree_Projects.ExpandAll();
				tree_Projects.SelectedNode = null;
				foreach (ProjectObject project in projectList)
				{
					colourAvailabilities(project);
				}
			}
		}

		ProjectObject findProjectInList(List<ProjectObject> list, ProjectObject project)
		{
			foreach (ProjectObject projectObject in list)
			{
				if (projectObject.projectID == project.projectID)
					return projectObject;
			}
			return null;
		}

		bool selectProjectByTag(ProjectObject tag)
		{
			var selectedNode = findProjectByTag(tag);
			if (selectedNode != null)
			{
				tree_Projects.SelectedNode = selectedNode;
				return true;
			}
			return false;
		}
		TreeNode findProjectByTag(ProjectObject tag)
		{
			return tree_Projects.descendants().Where(x => ((x.Tag as ProjectObject) != null) &&
					(x.Tag as ProjectObject).projectID == tag.projectID).FirstOrDefault();
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
				if (checkProjectAvailability(current)) { txt_ProjectDoable.Text = "Available";	}
				else if (checkProjectAvailabilityThroughOtherProjects(current)) { txt_ProjectDoable.Text = "Available Through Projects"; }
				else { txt_ProjectDoable.Text = "Unavailable"; }


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
				txt_ProjectDoable.Text = "";
				pguid.Text = "";
				lbox_RequiredChem.Items.Clear();
				lbox_ProjectMakes.Items.Clear();
			}


		}

		private bool checkProjectAvailability(ProjectObject project)
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

		bool checkProjectAvailabilityThroughOtherProjects(ProjectObject project)
		{
			foreach (ProjectObject.RequiredChemicals requiredChemical in project.requiredChemicals)
			{
				if (!matchChemicalObject(requiredChemical.compound).availableThroughProject
					&& !matchChemicalObject(requiredChemical.compound).inStorage)
				{
					project.availableThroughProjects = false;
					return false;
				}
			}
			project.availableThroughProjects = true;

			return true;
		}

		public void addNewProject(ProjectObject newProject)
		{
			projectList.Add(newProject);
			serialiseJsonProjects(projectJSON);
			invalidateProjectList();
		}

		public void editProject(ProjectObject editedProject)
		{
			for (int i = 0; i < projectList.Count; i++)
			{
				if (projectList[i].projectID == editedProject.projectID)
				{
					projectList[i] = editedProject;
					serialiseJsonProjects(projectJSON);
					redrawProjectInfoPanel();
					return;
				}
			}
		}

		private void colourAvailabilities(ProjectObject project)
		{
			var node = findProjectByTag(project);
			if (project.available) { node.ForeColor = Color.Green; return;  }
			else if (project.availableThroughProjects) { node.ForeColor = Color.DarkOrange; return; }
			node.ForeColor = Color.Red;
		}

		private void removeSelectedProject(ProjectObject project)
		{
			projectList.Remove(project);
			serialiseJsonProjects(projectJSON);
			invalidateProjectList();
			redrawProjectInfoPanel();
		}
	}
}
