using System;
using System.Collections.Generic;

namespace Chemlist
{
	public partial class Form1
	{
		ChemicalObject matchChemicalObject(ChemicalObject match)
		{
			foreach (ChemicalObject chemical in chemicalList)
			{
				if (chemical.chemID == match.chemID)
					return chemical;
			}
			return new ChemicalObject() { name = "Invalid Compound" };
		}


		public List<int> subscripts(String formula)
		{
			List<int> digits = new List<int>();
			for (int i = 0; i < formula.Length; i++)
			{
				if (formula[i] == '*')
				{
					for (int o = i + 2; o < formula.Length; o++)
					{
						i++;
						if (!Char.IsDigit(formula[o]))
							break;
					}
				}
				else if (Char.IsDigit(formula[i]))
				{
					digits.Add(i);
				}
			}
			return digits;
		}


	}
}
