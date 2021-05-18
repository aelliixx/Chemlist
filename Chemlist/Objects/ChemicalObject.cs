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
		public String chemFormula { get; set; }

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
