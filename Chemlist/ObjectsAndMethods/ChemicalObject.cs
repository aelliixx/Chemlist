using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemlist
{
	public class Hazards
	{
		public String symbols { get; set; }
		public String description { get; set; }

		public Hazards(String imageName, String symbolDescription)
		{
			symbols = imageName;
			description = symbolDescription;
		}
	}

	public class ChemicalObject
	{
		// Constructor
		public ChemicalObject()
		{
			chemID = Guid.NewGuid();
			instances++;
			//molecules = parseMolecule(chemFormula);
		}
		~ChemicalObject()
		{
			instances--;
		}


		public class Molecule
		{
			public String element { get; set; }
			public int count { get; set; }

			public Molecule(String _element, int _count)
			{
				element = _element;
				count = _count;
			}
		}



		public String name { get; set; }
		public String allNames { get; set; }
		public String chemFormula { get; set; }
		public String descripion { get; set; }
		public String appearance { get; set; }
		public bool inStorage { get; set; }
		public bool availableThroughProject { get; set; }
		public float molarMass { get; set; }
		public float pKa { get; set; }
		public float mPoint { get; set; }
		public float bPoint { get; set; }
		public float density { get; set; }
		public float solubilityInWater { get; set; } // TODO: Complex solubility graphs and solubilities in other substances.
		public bool miscible { get; set; }
		public bool insoluble { get; set; }
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

		public List<Hazards> hazards = new List<Hazards>();
		public List<Molecule> molecules = new List<Molecule>();


		public Guid chemID { get; set; } // FIXME: Const readonly?

		public static int instances;


		public static List<Molecule> parseMolecule(String formula)
		{
			List<Molecule> m = new List<Molecule>();
			String elementRegex = "([A-Z][a-z]*|\\(.*?\\))([0-9]*)";
			String validateRegex = "^(" + elementRegex + ")+$";

			if (!Regex.IsMatch(formula, validateRegex))
				return null;
				//throw new FormatException("Invalid input");

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
