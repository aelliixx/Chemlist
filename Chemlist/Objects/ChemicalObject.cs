using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chemlist
{
	public class ChemicalObject
	{
		public List<Molecule> molecules = new List<Molecule>();
		public class Molecule // TODO: struct?
		{
			public String element { get; set; }
			public int count { get; set; }

			public Molecule (String _element, int _count)
			{
				element = _element;
				count = _count;
			}
		}

		public bool inStorage = false;

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
		public float solubilityInWater { get; set; } // TODO: Complex solubility graphs and solubilities in other substances.
		public bool miscible { get; set; } // TODO: Add insoluble
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
		public String wikiName { get; set; }
		public String purchaseName { get; set; }
		public String msdsName { get; set; }
		public String wikiLink { get; set; }
		public String purchaseLink { get; set; }
		public String msds { get; set; }



		public Guid chemID { get; set; } // FIXME: Const readonly?

		public ChemicalObject()
		{
			chemID = Guid.NewGuid();


			// CuSO4 = Cu1 S1 O4
		}

		public static List<Molecule> parseMolecule(String formula)
		{
			List<Molecule> m = new List<Molecule>();
			String elementRegex = "([A-Z][a-z]*|\\(.*?\\))([0-9]*)";
			String validateRegex = "^(" + elementRegex + ")+$";

			if (!Regex.IsMatch(formula, validateRegex))
				throw new FormatException("Invalid input");

			foreach (Match match in Regex.Matches(formula, elementRegex))
			{
				String name = match.Groups[1].Value;
				int count =
				match.Groups[2].Value != "" ? int.Parse(match.Groups[2].Value) : 1;
				
				m.Add(new Molecule(name, count));
			}
			return m;
		}

	}
}
