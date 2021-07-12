using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemlist
{
	public class ProjectObject
	{
		public class RequiredChemicals
		{
			public ChemicalObject compound { get; set; }
			public float quantity { get; set; }
			public String unit { get; set; }
			public float concentration { get; set; }
		}
		public class ReactionFormula
		{
			public String formula { get; set; }
			public List<ChemicalObject> leftSide { get; set; }
			public List<ChemicalObject> rightSide { get; set; }

			/// <summary>
			///  2 C2H4O2 + Cu + H2O2 = Cu(C2H3O2)2 + 2 H2O
			///  6O + 4C + 10 H + Cu = Cu + 4C + 6O + 10H
			/// </summary>
			
		}

		public bool available;

		public String name { get; set; }
		public String chemFormula { get; set; }
		public String description { get; set; }
		public String methods { get; set; }

		public List<RequiredChemicals> requiredChemicals { get; set; }

		public Guid projectID { get; set; }

		public ProjectObject()
		{
			projectID = Guid.NewGuid();
		}
	}
}
