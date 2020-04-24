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

		public Person Player;

		/// <summary>
		/// Organ constructor.
		/// </summary>
		/// <param name="name">See <see cref="OrganName"/>.</param>
		/// <param name="sold">See <see cref="IsSold"/>.</param>
		/// <param name="essential">See <see cref="IsEssential"/>.</param>
		/// <param name="price">See <see cref="Price"/>.</param>
		/// <param name="t">See <see cref="Time"/></param>
		public Organ(string name, bool essential, bool sold, decimal price, int t, Person playa)
		{
			this.OrganName = name;
			this.IsEssential = essential;
			this.IsSold = sold;
			this.Price = price;
			this.Time = t;
			this.Player = playa;
		}

		public void Sell()
		{
			this.IsSold = true;
			Player.TimeLeft = Player.TimeLeft + (this.Time) - 1;
			Player.Money = Player.Money + (this.Price);
			Console.WriteLine($@"You have sold {this.OrganName}. One day has passed for the operation.
You now have {Player.TimeLeft} days left to live.
You have ${Player.Money} left.");
		}
	}
}
