using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chemlist
{
	public partial class Form1
	{
		public List<ChemicalObject> chemicalList = new List<ChemicalObject>();
		public List<ProjectObject> projectList = new List<ProjectObject>();
		public Hazards[] hazardSymbols = new Hazards[]
		{
			new Hazards("AcutelyToxic", "Toxic material which may cause life threatening effects even in small amounts and with short duration."),
			new Hazards("Corrosive", "Corrosive material which may cause skin burns and permanent eye damage. May corrode metals."),
			new Hazards("EnvironmentalHazard", "Causes harm to the environment and aquatic animals."),
			new Hazards("MildIrritant", "May cause irritation (redness, rash) or less serious toxicity. May damage the ozone layer."),
			new Hazards("Explosive", "May explode if exposed to fire, heat, shock or friction."),
			new Hazards("Flamable", "Flammable if exposed to ignition " +
				"sources, sparks, heat. Some substances may give off flammable gases in contact with water."),
			new Hazards("Pressurised", "Contains gas under pressure. Gas container may explode if heated or gas released may be very cold."),
			new Hazards("HealthHazard", "May cause serious and prolonged health effects on short or long term exposure."),
			new Hazards("Oxidiser", "Can burn even without air or can intensify fire in combustible materials.")
		};
		BindingSource compoundSource = new BindingSource();
		BindingSource projectSource = new BindingSource();


	}
}
