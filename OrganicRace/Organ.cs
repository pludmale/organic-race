using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public class Organ
	{
		/// <summary>
		///Name of the organ.
		/// </summary>
		public string OrganName;

		/// <summary>
		/// Has the organ been sold?
		/// </summary>
		public bool IsSold;

		/// <summary>
		/// Is the organ essential?
		/// </summary>
		public bool IsEssential;

		/// <summary>
		/// How much is the organ worth?
		/// </summary>
		public decimal Price;

		/// <summary>
		/// How does selling the organ affect player's life expectancy?
		/// </summary>
		public int Time;

		/// <summary>
		/// Organ constructor.
		/// </summary>
		/// <param name="name">See <see cref="OrganName"/>.</param>
		/// <param name="sold">See <see cref="IsSold"/>.</param>
		/// <param name="essential">See <see cref="IsEssential"/>.</param>
		/// <param name="price">See <see cref="Price"/>.</param>
		/// <param name="t">See <see cref="Time"/></param>
		public Organ(string name, bool essential, bool sold, decimal price, int t)
		{
			this.OrganName = name;
			this.IsEssential = essential;
			this.IsSold = sold;
			this.Price = price;
			this.Time = t;
		}

		/// <summary>
		/// Performs operation and sells player's organ in the black market.
		/// </summary>
		/// <param name="Player"></param>
		public void Sell(Person Player)
		{
			if (!this.IsSold)
			{
				this.IsSold = true;
				Player.TimeLeft = Player.TimeLeft + (this.Time) - 1;
				Player.Money = Player.Money + (this.Price);
				Console.WriteLine($@"You have sold your {this.OrganName} for ${this.Price}.
The operation took 1 day.
You now have {Player.TimeLeft} days left to live.
You have ${Player.Money} now.");
			}
			else
			{
				Console.WriteLine($"You've already sold your {this.OrganName}.");
			}
		}
	}
}
