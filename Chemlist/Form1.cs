using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

			invalidateCompoundNamesList();
			invalidateProjectList();

			validateFile(compoundJSON, ref jsonChemicals);
			validateFile(projectJSON, ref jsonProjects);

			deserialiseJsonChem();
			serialiseJsonChem();
			deserialiseJsonProjets();
			serialiseJsonProjects();

			lbox_ChemicalList.DisplayMember = "name";
			lbox_ChemicalList.DataSource = compoundSource;
			compoundSource.ResetBindings(false);

			lbox_ProjectList.DisplayMember = "name";
			lbox_ProjectList.DataSource = projectSource;
			projectSource.ResetBindings(false);

			tbox_CompoundSearch.Text = "Search";
			cbox_CompoundSort.SelectedIndex = 0;
			lbox_RequiredChem.DisplayMember = "name";
			lbox_UsedIn.DisplayMember = "name";
            lbox_ChemMadeIn.DisplayMember = "name";


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

		private void btn_DeleteProject_Click(object sender, EventArgs e)
		{
			removeSelectedProject(lbox_ProjectList.SelectedIndex);
		}

		// Searching and sorting.
		private void tbox_ProjectSearch_TextChanged(object sender, EventArgs e)
		{

		}

		private void cbox_ProjectSort_SelectedIndexChanged(object sender, EventArgs e)
		{

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

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Options optionsWindow = new Options { parentForm = this };
			optionsWindow.Show();
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

                lbox_ProjectList.SelectedItem = lbox_UsedIn.SelectedItem;
			}
		}

        private void lbox_ChemMadeIn_DoubleClick(object sender, EventArgs e)
        {
            if (lbox_ChemMadeIn.SelectedItem != null)
            {
                tab_Switcher.SelectTab(1);
                lbox_ProjectList.SelectedItem = lbox_ChemMadeIn.SelectedItem;
            }
        }

        private void lbox_RequiredChem_DoubleClick(object sender, EventArgs e)
        {
            if (lbox_RequiredChem.SelectedItem != null)
            {
                tab_Switcher.SelectTab(0);
                lbox_ChemicalList.SelectedItem = lbox_RequiredChem.SelectedItem;
            }
        }

        private void btn_HighlightRequiredChemicals_Click(object sender, EventArgs e)
        {
            tab_Switcher.SelectTab(0);

        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
