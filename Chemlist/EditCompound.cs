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
	public partial class EditCompound : Form
	{
		public Form1 parentForm { get; set; }
		Guid currentID;
		bool allowAdding = true;

		public EditCompound(ChemicalObject current)
		{
			InitializeComponent();

			tbox_ChemName.Text = current.name;
			tbox_ChemFormula.Text = current.chemFormula;
			tbox_Description.Text = current.descripion;
			tbox_OtherNames.Text = current.allNames;
			tbox_Solubility.Text = current.solubility;
			tbox_Wiki.Text = current.wikiLink;
			tbox_Purchase.Text = current.purchaseLink;
			tbox_MSDS.Text = current.msds;
			tbox_Appearance.Text = current.appearance;
			tbox_MolarMass.Text = current.molarMass.ToString();
			tbox_Density.Text = current.density.ToString();
			tbox_MeltingPoint.Text = current.mPoint.ToString();
			tbox_BoilingPoint.Text = current.bPoint.ToString();
			tbox_SInWater.Text = current.solubilityInWater.ToString();
			tbox_VapourPressure.Text = current.vapourPressure.ToString();
			tbox_Acidity.Text = current.pKa.ToString();
			tbox_FlashPoint.Text = current.flashPoint.ToString();
			tbox_LD50.Text = current.lethalDose50.ToString();
			tbox_LC50.Text = current.lethalConcentration50.ToString();

			check_OtherNames.Checked = current.bAllNames;
			check_Solubility.Checked = current.bSolubility;
			check_Wiki.Checked = current.bWikiLink;
			check_Purchase.Checked = current.bPurchaseLink;
			check_MSDS.Checked = current.bMSDS;
			check_Appearance.Checked = current.bAppearance;
			check_MolarMass.Checked = current.bMolarMass;
			check_Density.Checked = current.bDensity;
			check_mPoint.Checked = current.bMeltingPoint;
			check_bPoint.Checked = current.bBoilingPoint;
			check_SInWater.Checked = current.bSInWater;
			check_Miscible.Checked = current.miscible;
			check_VapourPoint.Checked = current.bVapourPressure;
			check_Acidity.Checked = current.bAcidity;
			check_FlashPoint.Checked = current.bFlashPoint;
			check_LD50.Checked = current.bLD50;
			check_LC50.Checked = current.bLC50;

			tbox_OtherNames.Enabled = check_OtherNames.Checked;
			tbox_Solubility.Enabled = check_Solubility.Checked;
			tbox_WikiName.Enabled = check_Wiki.Checked;
			tbox_Wiki.Enabled = check_Wiki.Checked;
			tbox_Purchase.Enabled = check_Purchase.Checked;
			tbox_PurchaseName.Enabled = check_Purchase.Checked;
			tbox_MSDS.Enabled = check_MSDS.Checked;
			tbox_MSDSName.Enabled = check_MSDS.Checked;
			tbox_Appearance.Enabled = check_Appearance.Checked;
			tbox_MolarMass.Enabled = check_MolarMass.Checked;
			tbox_Density.Enabled = check_Density.Checked;
			tbox_MeltingPoint.Enabled = check_mPoint.Checked;
			tbox_BoilingPoint.Enabled = check_bPoint.Checked;
			tbox_SInWater.Enabled = check_SInWater.Checked;
			tbox_VapourPressure.Enabled = check_VapourPoint.Checked;
			tbox_Acidity.Enabled = check_Acidity.Checked;
			tbox_FlashPoint.Enabled = check_FlashPoint.Checked;
			tbox_LD50.Enabled = check_LD50.Checked;
			tbox_LC50.Enabled = check_LC50.Checked;



			currentID = current.chemID;
		}

		private void btn_CancelEdit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			validateConfirmation();
			if ((!String.IsNullOrEmpty(tbox_ChemName.Text) && !String.IsNullOrEmpty(tbox_ChemFormula.Text)
			&& !String.IsNullOrEmpty(tbox_Description.Text)) && allowAdding)
			{
				ChemicalObject currentEditable = new ChemicalObject
				{
					name = tbox_ChemName.Text,
					chemFormula = tbox_ChemFormula.Text,
					descripion = tbox_Description.Text,
					allNames = tbox_OtherNames.Text,
					solubility = tbox_Solubility.Text,
					wikiLink = tbox_Wiki.Text,
					purchaseLink = tbox_Purchase.Text,
					msds = tbox_MSDS.Text,
					appearance = tbox_Appearance.Text,
					molarMass = float.Parse(tbox_MolarMass.Text),
					density = float.Parse(tbox_Density.Text),
					mPoint = float.Parse(tbox_MeltingPoint.Text),
					bPoint = float.Parse(tbox_BoilingPoint.Text),
					solubilityInWater = float.Parse(tbox_SInWater.Text),
					miscible = check_Miscible.Checked,
					vapourPressure = float.Parse(tbox_VapourPressure.Text),
					pKa = float.Parse(tbox_Acidity.Text),
					flashPoint = float.Parse(tbox_FlashPoint.Text),
					lethalDose50 = float.Parse(tbox_LD50.Text),
					lethalConcentration50 = float.Parse(tbox_LC50.Text),
					chemID = currentID,

					bAllNames = check_OtherNames.Checked,
					bAppearance = check_Appearance.Checked,
					bMolarMass = check_MolarMass.Checked,
					bDensity = check_Density.Checked,
					bMeltingPoint = check_mPoint.Checked,
					bBoilingPoint = check_bPoint.Checked,
					bSInWater = check_SInWater.Checked,
					bVapourPressure = check_VapourPoint.Checked,
					bAcidity = check_Acidity.Checked,
					bFlashPoint = check_FlashPoint.Checked,
					bLD50 = check_LD50.Checked,
					bLC50 = check_LC50.Checked,
					bSolubility = check_Solubility.Checked,
					bWikiLink = check_Wiki.Checked,
					bPurchaseLink = check_Purchase.Checked,
					bMSDS = check_MSDS.Checked,
				};
				parentForm.editCompound(currentEditable);

				Close();
			}
		}

		public void validateConfirmation()
		{
			if (
			validateCompoundValues(typeof(float), tbox_MolarMass) &&
			validateCompoundValues(typeof(String), tbox_Solubility) &&
			validateCompoundValues(typeof(String), tbox_WikiName) &&
			validateCompoundValues(typeof(String), tbox_Wiki) &&
			validateCompoundValues(typeof(String), tbox_PurchaseName) &&
			validateCompoundValues(typeof(String), tbox_Purchase) &&
			validateCompoundValues(typeof(String), tbox_MSDSName) &&
			validateCompoundValues(typeof(String), tbox_MSDS) &&
			validateCompoundValues(typeof(float), tbox_Density) &&
			validateCompoundValues(typeof(float), tbox_MeltingPoint) &&
			validateCompoundValues(typeof(float), tbox_BoilingPoint) &&
			validateCompoundValues(typeof(float), tbox_SInWater) &&
			validateCompoundValues(typeof(float), tbox_VapourPressure) &&
			validateCompoundValues(typeof(float), tbox_Acidity) &&
			validateCompoundValues(typeof(float), tbox_FlashPoint) &&
			validateCompoundValues(typeof(float), tbox_LD50) &&
			validateCompoundValues(typeof(float), tbox_LC50) &&
			validateCompoundValues(typeof(String), tbox_OtherNames) &&
			validateCompoundValues(typeof(String), tbox_Appearance))
			{
				allowAdding = true;
				return;
			}
			allowAdding = false;
			return;
		}

		public bool validateCompoundValues(Type type, TextBox textBox)
		{
			errorProvider1.SetError(textBox, "");
			if (textBox.Text == "")
			{
				errorProvider1.SetError(textBox, "Please enter a value.");
				return false;
			}
			if (type == typeof(float))
			{
				try
				{
					float temp = float.Parse(textBox.Text);
				}
				catch
				{
					errorProvider1.SetError(textBox, "Please enter a float.");
					return false;
				}
			}
			return true;
		}

		private void check_MolarMass_CheckedChanged(object sender, EventArgs e)
		{
			tbox_MolarMass.Enabled = check_MolarMass.Checked;
			if (!check_MolarMass.Checked) { tbox_MolarMass.Text = "0"; }
		}

		private void check_Density_CheckedChanged(object sender, EventArgs e)
		{
			tbox_Density.Enabled = check_Density.Checked;
			if (!check_Density.Checked) { tbox_Density.Text = "0"; }
		}

		private void check_mPoint_CheckedChanged(object sender, EventArgs e)
		{
			tbox_MeltingPoint.Enabled = check_mPoint.Checked;
			if (!check_mPoint.Checked) { tbox_MeltingPoint.Text = "0"; }
		}

		private void check_bPoint_CheckedChanged(object sender, EventArgs e)
		{
			tbox_BoilingPoint.Enabled = check_bPoint.Checked;
			if (!check_bPoint.Checked) { tbox_BoilingPoint.Text = "0"; }
		}

		private void check_SInWater_CheckedChanged(object sender, EventArgs e)
		{
			tbox_SInWater.Enabled = check_SInWater.Checked;
			check_Miscible.Enabled = check_SInWater.Checked;
			if (!check_SInWater.Checked) { tbox_SInWater.Text = "0"; }
		}

		private void check_VapourPoint_CheckedChanged(object sender, EventArgs e)
		{
			tbox_VapourPressure.Enabled = check_VapourPoint.Checked;
			if (!check_VapourPoint.Checked) { tbox_VapourPressure.Text = "0"; }
		}

		private void check_Acidity_CheckedChanged(object sender, EventArgs e)
		{
			tbox_Acidity.Enabled = check_Acidity.Checked;
			if (!check_Acidity.Checked) { tbox_Acidity.Text = "0"; }
		}

		private void check_FlashPoint_CheckedChanged(object sender, EventArgs e)
		{
			tbox_FlashPoint.Enabled = check_FlashPoint.Checked;
			if (!check_FlashPoint.Checked) { tbox_FlashPoint.Text = "0"; }
		}

		private void check_LD50_CheckedChanged(object sender, EventArgs e)
		{
			tbox_LD50.Enabled = check_LD50.Checked;
			if (!check_LD50.Checked) { tbox_LD50.Text = "0"; }
		}

		private void check_LC50_CheckedChanged(object sender, EventArgs e)
		{
			tbox_LC50.Enabled = check_LC50.Checked;
			if (!check_LC50.Checked) { tbox_LC50.Text = "0"; }
		}

		private void check_Solubility_CheckedChanged(object sender, EventArgs e)
		{
			tbox_Solubility.Enabled = check_Solubility.Checked;
			if (!check_Solubility.Checked) { tbox_Solubility.Text = "N/A"; }
		}

		private void check_Wiki_CheckedChanged(object sender, EventArgs e)
		{
			tbox_Wiki.Enabled = check_Wiki.Checked;
			tbox_WikiName.Enabled = check_Wiki.Checked;
			if (!check_Wiki.Checked) { tbox_Wiki.Text = "N/A"; tbox_WikiName.Text = "N/A"; }
		}

		private void check_Purchase_CheckedChanged(object sender, EventArgs e)
		{
			tbox_Purchase.Enabled = check_Purchase.Checked;
			tbox_PurchaseName.Enabled = check_Purchase.Checked;
			if (!check_Purchase.Checked) { tbox_Purchase.Text = "N/A"; tbox_PurchaseName.Text = "N/A"; }
		}

		private void check_MSDS_CheckedChanged(object sender, EventArgs e)
		{
			tbox_MSDS.Enabled = check_MSDS.Checked;
			tbox_MSDSName.Enabled = check_MSDS.Checked;
			if (!check_MSDS.Checked) { tbox_MSDS.Text = "N/A"; tbox_MSDSName.Text = "N/A"; }
		}

		private void check_Appearance_CheckedChanged(object sender, EventArgs e)
		{
			tbox_Appearance.Enabled = check_Appearance.Checked;
			if (!check_Appearance.Checked) { tbox_Appearance.Text = "N/A"; }
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			tbox_OtherNames.Enabled = check_OtherNames.Checked;
			if (!check_OtherNames.Checked) { tbox_OtherNames.Text = "N/A"; }
		}
	}
}
