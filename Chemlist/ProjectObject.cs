using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemlist
{
	public class ProjectObject
	{
		public String name;
		public String chemFormula;

		public List<ChemicalObject> requiredCompounds = new List<ChemicalObject>();

	}
}
