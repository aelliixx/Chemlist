using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemlist
{
	public class ChemicalObject
	{
		public String name { get; set; }
		public String allNames { get; set; }
		public String chemFormula { get; set; }
		public String descripion { get; set; }
		public String appearance { get; set; }
		public float molarMass { get; set; }
		public float pKa { get; set; }
		public float mPoint { get; set; }
		public float bPoint { get; set; }
		public float density { get; set; }
		public float solubilityInWater { get; set; }
		public bool miscible { get; set; }
		public float vapourPressure { get; set; }
		public float lethalDose50 { get; set; }
		public float lethalConcentration50 { get; set; }
		public float flashPoint { get; set; }
		public String solubility { get; set; }

		public bool bAllNames = false;
		public bool bAppearance = false;
		public bool bMolarMass = false;
		public bool bDensity = false;
		public bool bMeltingPoint = false;
		public bool bBoilingPoint = false;
		public bool bSInWater = false;
		public bool bVapourPressure = false;
		public bool bAcidity = false;
		public bool bFlashPoint = false;
		public bool bLD50 = false;
		public bool bLC50 = false;
		public bool bSolubility = false;
		public bool bWikiLink = false;
		public bool bPurchaseLink = false;
		public bool bMSDS = false;

		// Links
		public String wikiLink { get; set; }
		public String purchaseLink { get; set; }
		public String msds { get; set; }

		public Guid chemID { get; set; }

		public ChemicalObject()
		{
			name = "Compund"; chemFormula = "H2O"; chemID = Guid.NewGuid();
		}


		// Methods
		public List<int> subscripts()
		{
			List<int> digits = new List<int>();
			for (int i = 0; i < chemFormula.Length; i++)
			{
				if (Char.IsDigit(chemFormula[i]))
				{
					digits.Add(i);
				}
			}
			return digits;
		}
	}
}
