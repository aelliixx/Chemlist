using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chemlist
{
	public partial class Form1 : Form
	{
		public List<ChemicalObject> chemicalList = new List<ChemicalObject>();
		public List<ProjectObject> projectList = new List<ProjectObject>();
		List<String> chemicalNames = new List<String>();
		List<String> projectNames = new List<string>();

		public Settings settings = new Settings();
		BindingSource compoundSource = new BindingSource();
		BindingSource projectSource = new BindingSource();
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

			lbox_ChemicalList.DataSource = compoundSource;
			compoundSource.ResetBindings(false);

			lbox_ProjectList.DataSource = projectSource;
			projectSource.ResetBindings(false);
		}

		private void lbox_ChemicalList_SelectedIndexChanged(object sender, EventArgs e)
		{
			redrawCompoundInfoPanel();
		}

		private void btn_RemoveChemicalFromList_Click(object sender, EventArgs e)
		{
			removeChemical(lbox_ChemicalList.SelectedIndex);
		}

		private void btn_EditCurrentChemical_Click(object sender, EventArgs e)
		{
			ChemicalObject temp = chemicalList[lbox_ChemicalList.SelectedIndex];
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
			AddNewProject addNewProject = new AddNewProject { parentForm = this };
			addNewProject.Show();
		}

		/// FIXME: Fix opening links

		private void tlink_Wiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//System.Diagnostics.Process.Start(chemicalList[lbox_ChemicalList.SelectedIndex].wikiLink);
		}

		private void tlink_Purchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//System.Diagnostics.Process.Start(chemicalList[lbox_ChemicalList.SelectedIndex].purchaseLink);
		}

		private void tlink_MSDS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//System.Diagnostics.Process.Start(chemicalList[lbox_ChemicalList.SelectedIndex].msds);
		}

		private void lbox_ProjectList_SelectedIndexChanged(object sender, EventArgs e)
		{
			redrawProjectInfoPanel();
		}
	}
}
