using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public class Prosthetic
	{
		/// <summary>
		/// Name of the prosthetic.
		/// </summary>
		public string ProstheticName;

		/// <summary>
		/// Has the player bought the prosthetic?
		/// </summary>
		public bool IsBought;

		/// <summary>
		/// How much is the prosthetic worth?
		/// </summary>
		public decimal Price;

		/// <summary>
		/// How does buying the prosthetic affect player's life expectancy?
		/// </summary>
		public int Time;

		/// <summary>
		/// Prosthetic constructor.
		/// </summary>
		/// <param name="name">See <see cref="ProstheticName"/>.</param>
		/// <param name="bought">See <see cref="IsBought"/>.</param>
		/// <param name="price">See <see cref="Price"/>.</param>
		/// <param name="t">See <see cref="Time"/>.</param>
		public Prosthetic(string name, bool bought, decimal price, int t)
		{
			this.ProstheticName = name;
			this.IsBought = bought;
			this.Price = price;
			this.Time = t;
		}
	}
}
