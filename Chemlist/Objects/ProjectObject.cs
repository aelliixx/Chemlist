using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemlist
{
	public class ProjectObject
	{
		public bool available;

		public String name { get; set; }
		public String chemFormula;
		public String description;

		public List<Guid> requiredCompounds = new List<Guid>();

		public Guid projectID { get; set; }

		public ProjectObject()
		{
			projectID = Guid.NewGuid();
		}

		// Methods
		public List<int> subscripts()
		{
			List<int> digits = new List<int>();
			for (int i = 0; i < chemFormula.Length; i++)
			{
				if (chemFormula[i] == '*')
				{
					for (int o = i + 2; o < chemFormula.Length; o++)
					{
						i++;
						if (!Char.IsDigit(chemFormula[o]))
							break;
					}
				}
				else if (Char.IsDigit(chemFormula[i]))
				{
					digits.Add(i);
				}
			}
			return digits;
		}
	}
}
