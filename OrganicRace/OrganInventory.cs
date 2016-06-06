using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public class OrganInventory
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
		public Organ Arms;

		/// <summary>
		/// All the organ objects.
		/// </summary>
		public OrganInventory()
		{
			Skin = new Organ("skin", true, false, 2000m, -10);
			Brain = new Organ("brain", true, false, 5000m, -10);
			Heart = new Organ("heart", true, false, 5000m, -10);
			Liver = new Organ("liver", true, false, 3000m, -10);
			Stomach = new Organ("stomach", true, false, 3000m, -10);
			Lungs = new Organ("lungs", true, false, 3000m, -10);

			Appendix = new Organ("appendix", false, false, 200m, 0);
			Spleen = new Organ("spleen", false, false, 100m, 0);
			Teeth = new Organ("teeth", false, false, 250m, 0);
			Hair = new Organ("hair", false, false, 300m, 0);
			Eyes = new Organ("eyes", false, false, 750m, 0);
			Legs = new Organ("legs", false, false, 1000m, -1);
			Arms = new Organ("arms", false, false, 1000m, -1);
		}
	}
}
