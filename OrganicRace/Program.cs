using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	class Program
	{
		public static Person Player;

		public static Input Input;

		public static Dictionary<string, Organ> AllOrgans;
		public static Dictionary<string, Prosthetic> AllProsthetics;

		static void Main(string[] args)
		{
			//Instantiating player with 10 days left to live and 500 monies.
			Player = new Person(10, 500m);

			//Instantiating empty player input.
			Input = new Input(null, null, null);

			//Intro.
			Console.WriteLine("Welcome to the Organic Race.");
			Console.WriteLine(@"In this game, you have to sell your organs to make as much money as you can before you die.
You can sell your organs to gain money, but your life expectancy will diminish.
You can replace essential organs with temporary prosthetics to increase life expectancy.");
			Console.WriteLine(@"Type MONEY to check your bank account,
BODY to check the state of your organs,
TIME to see how many days you have left.
SHOP for prosthetics, and
BUY and ADD them to your body.");

			/*
			TO DO: 
			Check for when all organs have been sold && all prosthetics have been added. 
			When true, pat on the back, maybe some sort of financial conclusion (sth about bein a rich filthy motherfucker)
			*/
			
			var organInventory = new OrganInventory();
			AllOrgans = new Dictionary<string, Organ>
			{
				//Essential organs.
				{"skin", organInventory.Skin},
				{"brain", organInventory.Brain},
				{"heart", organInventory.Heart},
				{"liver", organInventory.Liver},
				{"stomach", organInventory.Stomach},
				{"lungs", organInventory.Lungs},

				//Non-essential organs.
				{"appendix", organInventory.Appendix},
				{"spleen", organInventory.Spleen},
				{"teeth", organInventory.Teeth},
				{"hair", organInventory.Hair},
				{"eyes", organInventory.Eyes},
				{"legs", organInventory.Legs},
				{"arms", organInventory.Arms}
			};

			var prostheticInventory = new ProstheticInventory();
			AllProsthetics = new Dictionary<string, Prosthetic>
			{
				{"skin", prostheticInventory.ProstSkin},
				{"brain", prostheticInventory.ProstBrain},
				{"heart", prostheticInventory.ProstHeart},
				{"liver", prostheticInventory.ProstLiver},
				{"stomach", prostheticInventory.ProstStomach},
				{"lungs", prostheticInventory.ProstLungs},
			};

			//Checks for player selling all their organs and adding all prostheses.
			bool allOrgansSold = false;
			bool allProstheticsAdded = false;

			//Game loop.
			while (!(allOrgansSold && allProstheticsAdded) && (Player.TimeLeft >= 0))
			{
				Console.WriteLine("Next move?");
				Input.UserPrompt();
				Input.ProcessInput();

				allOrgansSold = AllOrgans.All(entry => entry.Value.IsSold);
				allProstheticsAdded = AllProsthetics.All(entry => entry.Value.IsAdded);
			}

			//Retirement ending.
			if (allOrgansSold && allProstheticsAdded)
			{
				Console.WriteLine($@"
You live out your remaining {Player.TimeLeft} days in peace,
having acquired a generous donor reputation in the black organ market.
Even though you are mostly made of plastic and metal and can't really take care of yourself, 
your mother would have been proud of you.");
			}

			//Death ending.
			if (Player.TimeLeft <= 0)
			{
				Console.WriteLine($@"
You have died!
You've ended the game with ${Player.Money}.");
				if (Player.Money < 1000m)
					Console.WriteLine("You can barely afford cremation. Jeez.");
				if (Player.Money >= 1000m || Player.Money < 5000m)
					Console.WriteLine("You've landed yourself a hauntingly middle-class graveyard spot.");
				if (Player.Money >= 5000m)
					Console.WriteLine("Your offspring will be grateful for the fortune you have left behind.");
			}

			Console.WriteLine(@"
Thank you for playing the Organic Race!");
			Console.ReadKey();
		}
	}
}
