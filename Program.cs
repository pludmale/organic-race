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
		static void Main(string[] args)
		{
			//Instantiating player with 30 days left to live and 500 monies.
			Player = new Person(30, 500m);

			//Intro.
			Console.WriteLine("Welcome to the Organic Race.");
			Console.WriteLine(@"In this game, you have to sell your organs to make as much money as you can before you die.
You can sell your organs to gain money, but your life expectancy will diminish
You can replace essential organs with prosthetics to increase life expectancy.");
			Console.WriteLine(@"Type MONEY to check your bank account,
BODY to check the state of your organs,
TIME to see how much time you have left.");

			while (Player.TimeLeft > 0)
			{

			}
		}
	}
}
