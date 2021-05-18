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
		List<String> chemicalNames = new List<String>();

		public Settings settings = new Settings();
		BindingSource bs = new BindingSource();
		public Form1()
		{

			InitializeComponent();
			invalidateNamesList();

			validateFile();
			deserialiseJsonChem();
			serialiseJsonChem();

			lbox_ChemicalList.DataSource = bs;
			bs.ResetBindings(false);
		}

		private void lbox_ChemicalList_SelectedIndexChanged(object sender, EventArgs e)
		{
			redrawInfoPanel();
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
	}
}
