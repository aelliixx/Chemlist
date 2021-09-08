using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chemlist;
using Xunit;

namespace Chemlist.Tests
{
	public class ChemlistTests
	{
		[Theory]
		[InlineData("FeO → Fe + O2", "2FeO → 2Fe + O2")]
		[InlineData("Fe + O2 + H →  Fe(OH)2", "Fe + O2 + 2H → Fe(OH)2")]
		[InlineData("SbCl3 + Cl2 → SbCl5", "SbCl3 + Cl2 → SbCl5")]
		[InlineData("CH3CH2OH → CH2CH2 + H2O", "CH3CH2OH → CH2CH2 + H2O")]
		public void balancer(String f, String exp)
		{
			var returned = ChemicalObject.balance(f);
			Assert.Equal(exp, returned);
		}
	}
}
