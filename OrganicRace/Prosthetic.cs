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
		/// Has the player inserted the prosthetic on his body?
		/// </summary>
		public bool IsAdded;

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
		/// <param name="added">See <see cref="IsAdded"/></param>
		/// <param name="price">See <see cref="Price"/>.</param>
		/// <param name="t">See <see cref="Time"/>.</param>
		public Prosthetic(string name, bool bought, bool added, decimal price, int t)
		{
			this.ProstheticName = name;
			this.IsBought = bought;
			this.IsAdded = added;
			this.Price = price;
			this.Time = t;
		}

		/// <summary>
		/// Buys a temporary prosthetic organ.
		/// </summary>
		/// <param name="Player"></param>
		public void Buy(Person Player)
		{
			if (Player.Money > (this.Price * -1))
			{
				this.IsBought = true;
				Player.Money = Player.Money + (this.Price);
				Console.WriteLine($@"You have bought {this.ProstheticName}.
You can now ADD {this.ProstheticName.ToUpper()} to undergo the surgery required.
You have ${Player.Money}.");
			} else
			{
				Console.WriteLine("Ha! You can't afford a prosthetic yet. Try selling some of those non-essential organs!");
			}
		}

		/// <summary>
		/// Performs operation to add prosthetic to player's body.
		/// </summary>
		/// <param name="Player"></param>
		public void Add(Person Player)
		{
			if (this.IsBought)
			{
				Player.TimeLeft = Player.TimeLeft + (this.Time) - 1;
				this.IsAdded = true;

				if (Player.TimeLeft <= 0)
				{
					Console.WriteLine("Oh no!");
					return;
				}

				Console.WriteLine($@"You've undergone the surgery to add {this.ProstheticName} to your body.
One day has passed for the operation.
You now have {Player.TimeLeft} days left to live.");
			} else
			{
				Console.WriteLine("You need to buy this prosthetic first!");
			}
		}

		/// <summary>
		/// Gives player the stats for prosthetic organs.
		/// </summary>
		public void Check()
		{
			if(!this.IsBought)
				Console.WriteLine($"You can buy {this.ProstheticName} for ${this.Price}.");
			else
				Console.WriteLine($"You've already bought the {this.ProstheticName} to your body!");
			if (!this.IsAdded)
				Console.WriteLine($@"You can add this temporary prosthetic to your body.
The operation would take 1 day and the prosthesis would increase your life expectancy by {this.Time} days.");
			else
				Console.WriteLine($"You've already added the {this.ProstheticName} to your body!");
		}
	}
}
