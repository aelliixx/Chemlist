using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// TODO: Add automatic calculations between ppm and cubic metres, pressure units of measurement,
/// insoluble check, advanced solubility, and solubilities in other compounds.
/// </summary>

namespace Chemlist
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			projectTreeViewToolStripMenuItem.Checked = Properties.Settings.Default.showTree;
			showGUIDToolStripMenuItem.Checked = Properties.Settings.Default.showGuid;
			compoundJSON = Properties.Settings.Default.compoundJsonPath;
			projectJSON = Properties.Settings.Default.projectJsonPath;

			initJson(compoundJSON, projectJSON, true);

			lbox_ChemicalList.DisplayMember = "name";
			lbox_ChemicalList.DataSource = compoundSource;
			compoundSource.ResetBindings(false);

			projectSource.ResetBindings(false);


			tbox_CompoundSearch.Text = "Search";
			cbox_CompoundSort.SelectedIndex = 0;
			tbox_ProjectSearch.Text = "Search";
			cbox_ProjectSort.SelectedIndex = 0;
			lbox_RequiredChem.DisplayMember = "name";
			lbox_UsedIn.DisplayMember = "name";
			lbox_ChemMadeIn.DisplayMember = "name";
			lbox_ProjectMakes.DisplayMember = "name";

#if DEBUG
			debugToolStripMenuItem.Visible = true;
			debugStatusStrip.Visible = true;
			debugStatusStrip.Dock = DockStyle.Bottom;
			tab_Switcher.Dock = DockStyle.Top;
			tab_Switcher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
#else
			debugToolStripMenuItem.Visible = false;
			debugStatusStrip.Visible = false;
			tab_Switcher.Dock = DockStyle.Fill;
#endif
		}

		

		private void lbox_ChemicalList_SelectedIndexChanged(object sender, EventArgs e)
		{
			redrawCompoundInfoPanel();
		}

		private void btn_RemoveChemicalFromList_Click(object sender, EventArgs e)
		{
			removeChemical(lbox_ChemicalList.SelectedIndex);
		}

		private void tlink_Wiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(chemicalList[lbox_ChemicalList.SelectedIndex].wikiLink);
		}

		private void tlink_Purchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(chemicalList[lbox_ChemicalList.SelectedIndex].purchaseLink);
		}

		private void tlink_MSDS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(chemicalList[lbox_ChemicalList.SelectedIndex].msds);
		}

		private void lbox_ProjectList_SelectedIndexChanged(object sender, EventArgs e)
		{
			redrawProjectInfoPanel();
		}

		private void tree_Projects_AfterSelect(object sender, TreeViewEventArgs e)
		{
			redrawProjectInfoPanel();
		}

		private void btn_DeleteProject_Click(object sender, EventArgs e)
		{
			if (tree_Projects.SelectedNode == null)
				return;
			ProjectObject selected = (ProjectObject)tree_Projects.SelectedNode.Tag;
			var selectedNode = tree_Projects.descendants().Where(x => ((x.Tag as ProjectObject) != null) &&
				(x.Tag as ProjectObject).projectID == selected.projectID).FirstOrDefault();
			if (selectedNode.descendants().Count == 0)
				removeSelectedProject(selected);
			else
			{
				var confirmDeletion = MessageBox.Show("This project has child projects. Are you sure you wish to delete it? Any child projects" +
					" will become root projects.", "Confirm Project Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (confirmDeletion == DialogResult.Yes)
				{
					ProjectObject childProject = (ProjectObject)selectedNode.Nodes[0].Tag;
					childProject.parentProject.name = null;
					removeSelectedProject(selected);
				}
			}

		}

		// Searching and sorting.
		private void tbox_ProjectSearch_TextChanged(object sender, EventArgs e)
		{
			if (tbox_ProjectSearch.Text != "Search")
				invalidateProjectList();
		}

		private void cbox_ProjectSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			invalidateProjectList();
		}

		private void tbox_ProjectSearch_Enter(object sender, EventArgs e)
		{
			if (tbox_ProjectSearch.Text == "Search")
				tbox_ProjectSearch.Text = "";
		}

		private void tbox_ProjectSearch_Leave(object sender, EventArgs e)
		{
			if (tbox_ProjectSearch.Text == "")
				tbox_ProjectSearch.Text = "Search";
		}

		private void cbox_CompoundSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			invalidateCompoundNamesList();
		}

		private void tbox_CompoundSearch_TextChanged(object sender, EventArgs e)
		{
			invalidateCompoundNamesList();
		}

		private void tbox_CompoundSearch_Enter(object sender, EventArgs e)
		{
			if (tbox_CompoundSearch.Text == "Search")
				tbox_CompoundSearch.Text = "";
		}

		private void tbox_CompoundSearch_Leave(object sender, EventArgs e)
		{
			if (tbox_CompoundSearch.Text == "")
				tbox_CompoundSearch.Text = "Search";
		}


		private void btn_EditCurrentChemical_Click(object sender, EventArgs e)
		{
			ChemicalObject temp = (ChemicalObject)lbox_ChemicalList.SelectedItem;
			EditCompound compoundEditor = new EditCompound(temp) { parentForm = this };
			compoundEditor.Show();
		}

		private void btn_AddNew_Click(object sender, EventArgs e)
		{
			AddNewCompound addNewCompound = new AddNewCompound { parentForm = this };
			addNewCompound.Show();
		}

		private void btn_AddNewProject_Click(object sender, EventArgs e)
		{
			AddNewProject addNewProject = new AddNewProject(chemicalList) { parentForm = this };
			addNewProject.Show();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About aboutPage = new About();
			aboutPage.Show();
		}

		private void lbox_UsedIn_DoubleClick(object sender, EventArgs e)
		{
			if (lbox_UsedIn.SelectedItem != null)
			{
				tab_Switcher.SelectTab(1);
				ProjectObject selected = (ProjectObject)lbox_UsedIn.SelectedItem;
				var selectedNode = tree_Projects.descendants().Where(x => ((x.Tag as ProjectObject) != null) &&
					(x.Tag as ProjectObject).projectID == selected.projectID).FirstOrDefault();
				if (selectedNode != null)
					tree_Projects.SelectedNode = selectedNode;
			}
		}

		private void lbox_ChemMadeIn_DoubleClick(object sender, EventArgs e)
		{
			if (lbox_ChemMadeIn.SelectedItem != null)
			{
				tab_Switcher.SelectTab(1);
				ProjectObject selected = (ProjectObject)lbox_ChemMadeIn.SelectedItem;
				var selectedNode = tree_Projects.descendants().Where(x => ((x.Tag as ProjectObject) != null) &&
					(x.Tag as ProjectObject).projectID == selected.projectID).FirstOrDefault();
				if (selectedNode != null)
					tree_Projects.SelectedNode = selectedNode;
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_EditProject_Click(object sender, EventArgs e)
		{
			EditProject editProject =
				new EditProject(tree_Projects.SelectedNode.Tag as ProjectObject, chemicalList) { parentForm = this };
			editProject.Show();
		}

		private void projectTreeViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			projectTreeViewToolStripMenuItem.Checked = !projectTreeViewToolStripMenuItem.Checked;
			Properties.Settings.Default.showTree = projectTreeViewToolStripMenuItem.Checked;
			Properties.Settings.Default.Save();
			invalidateProjectList();
			redrawProjectInfoPanel();
		}

		private void showGUIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			showGUIDToolStripMenuItem.Checked = !showGUIDToolStripMenuItem.Checked;
			Properties.Settings.Default.showGuid = showGUIDToolStripMenuItem.Checked;
			Properties.Settings.Default.Save();
			redrawCompoundInfoPanel();
			redrawProjectInfoPanel();
		}

        private void lbox_RequiredChem_DoubleClick(object sender, EventArgs e)
        {
            if (lbox_RequiredChem.SelectedItem != null)
            {
				tab_Switcher.SelectTab(0);
				lbox_ChemicalList.SelectedItem = lbox_RequiredChem.SelectedItem;
            }
        }

		private void lbox_ProjectMakes_DoubleClick(object sender, EventArgs e)
		{
			if (lbox_ProjectMakes.SelectedItem != null)
			{
				tab_Switcher.SelectTab(0);
				lbox_ChemicalList.SelectedItem = lbox_ProjectMakes.SelectedItem;
			}

		}

		private void backupListsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			initJson(backupCompoundJson, backupProjectJson, false);
		}

		private void loadCompoundsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog.Title = "Load Compounds";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				initJson(openFileDialog.FileName, projectJSON, true);
			}
			
		}

		private void loadProjectsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog.Title = "Load Projects";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				initJson(compoundJSON, openFileDialog.FileName, true);
			}
		}

		private void instanceCounter_Click(object sender, EventArgs e)
		{
			instanceCounter.Text = "Saves: " + Properties.Settings.Default.compoundJsonPath + " " + Properties.Settings.Default.projectJsonPath;
		}

		private void saveCompoundsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFile.Title = "Save Compounds As...";
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				serialiseJsonChem(saveFile.FileName);
				setNewReadFiles(saveFile.FileName, projectJSON);
			}
		}

		private void saveProjectsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFile.Title = "Save Projects As...";
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				serialiseJsonProjects(saveFile.FileName);
				setNewReadFiles(compoundJSON, saveFile.FileName);
			}
		}
	}
}
