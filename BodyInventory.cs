using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	class BodyInventory
	{
		/// <summary>
		/// Essential organs.
		/// </summary>
		public Organ Skin;
		public Organ Brain;
		public Organ Heart;
		public Organ Liver;
		public Organ Stomach;
		public Organ Lungs;

		/// <summary>
		/// Non-essential organs.
		/// </summary>
		public Organ Appendix;
		public Organ Spleen;
		public Organ Teeth;
		public Organ Hair;
		public Organ Eyes;
		public Organ Legs;

		/// <summary>
		/// All the organs.
		/// </summary>
		BodyInventory()
		{
			Skin = new Organ("skin", true, false, 1500m, -30);
			Brain = new Organ("brain", true, false, 5000m, -30);
			Heart = new Organ("heart", true, false, 5000m, -30);
			Liver = new Organ("liver", true, false, 2500m, -30);
			Stomach = new Organ("stomach", true, false, 2500m, -30);
			Lungs = new Organ("lungs", true, false, 3000m, -30);

			Appendix = new Organ("appendix", false, false, 100m, 0);
			Spleen = new Organ("spleen", false, false, 100m, -10);
			Teeth = new Organ("teeth", false, false, 250m, -10);
			Hair = new Organ("teeth", false, false, 300m, -5);
			Eyes = new Organ("eyes", false, false, 500m, -10);
			Legs = new Organ("legs", false, false, 1000m, -20);
		}
	}
}
