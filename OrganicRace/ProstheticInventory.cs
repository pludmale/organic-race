using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public class ProstheticInventory
	{
		public Prosthetic ProstSkin;
		public Prosthetic ProstBrain;
		public Prosthetic ProstHeart;
		public Prosthetic ProstLiver;
		public Prosthetic ProstStomach;
		public Prosthetic ProstLungs;

		public ProstheticInventory()
		{
			ProstSkin = new Prosthetic("silicone skin", false, false, -1000m, 15);
			ProstBrain = new Prosthetic("microchip brain", false, false, -5000m, 20);
			ProstHeart = new Prosthetic("artificial heart", false, false, -5000m, 20);
			ProstLiver = new Prosthetic("artificial liver", false, false, -3000m, 15);
			ProstStomach = new Prosthetic("polypropylene stomach", false, false, -2500m, 12);
			ProstLungs = new Prosthetic("silicone lungs", false, false, -2000m, 15);
		}
	}
}
