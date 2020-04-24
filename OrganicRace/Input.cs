﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public class Input
	{
		/// <summary>
		/// First word of user prompt, usually a verb.
		/// </summary>
		public string Action;
		/// <summary>
		/// Optional second word of user prompt, usually an organ name, unless "prosthetic".
		/// </summary>
		public string Object;
		/// <summary>
		/// Optional third word of user prompt, if used, a prosthetic organ name.
		/// </summary>
		public string Subject;

		private IUserInput _userInput;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="action">See <see cref="Action"/>.</param>
		/// <param name="object">See <see cref="Object"/>.</param>
		/// <param name="subject">See <see cref="Subject"/>.</param>
		public Input(string action, string @object, string subject, IUserInput userInput)
		{
			this.Action = action;
			this.Object = @object;
			this.Subject = subject;
			this._userInput = userInput;
		}

		/// <summary>
		/// Prompts the user for input, assigns words to Input object fields.
		/// </summary>
		public void UserPrompt()
		{
			var prompt = _userInput.GetUserInput();
			string[] words = prompt.Split(' ');
			words = words.Where(s => s != "the").ToArray();

			if (words.Length > 0)
			{Action = words[0];}
			if (words.Length > 1)
			{Object = words[1];}
			if (words.Length > 2)
			{Subject = words[2];}
			if (words.Length > 3)
			{ Console.WriteLine("You're using too many words!"); }
		}

		
		/// <summary>
		/// Processes Input object fields, calls corresponding methods.
		/// </summary>
		public void ProcessInput()
		{
			var unsoldOrgans = Program.AllOrgans.Where(entry => !entry.Value.IsSold).Select(entry => entry.Value.OrganName);
			var boughtProsthetics = Program.AllProsthetics.Where(entry => entry.Value.IsBought).Select(entry => entry.Value.ProstheticName);
			var addedProsthetics = Program.AllProsthetics.Where(entry => entry.Value.IsBought && !entry.Value.IsAdded).Select(entry => entry.Value.ProstheticName);
			var shopProstheticNames = Program.AllProsthetics.Where(entry => !entry.Value.IsBought).Select(entry => entry.Value.ProstheticName);
			var shopProstheticPrices = Program.AllProsthetics.Where(entry => !entry.Value.IsBought).Select(entry => entry.Value.Price);
			var shopProstheticTimes = Program.AllProsthetics.Where(entry => !entry.Value.IsBought).Select(entry => entry.Value.Time);

			switch (Action)
			{
				case "sell":
					if (Program.AllOrgans.ContainsKey(Object))
						(Program.AllOrgans[Object]).Sell(Program.Player);
					else
						Console.WriteLine("Invalid organ.");
					break;
				case "buy":
					if (Program.AllProsthetics.ContainsKey(Object))
						(Program.AllProsthetics[Object]).Buy(Program.Player);
					else if ((Program.AllProsthetics.ContainsKey(Subject) && Object == "prosthetic"))
						(Program.AllProsthetics[Subject]).Buy(Program.Player);
					else
						Console.WriteLine("Invalid prosthetic.");
					break;
				case "add":
					//if (unsoldOrgans.Any())
					//	Console.WriteLine("You can't replace an organ you haven't removed yet.");
					//else if
					if (Program.AllProsthetics.ContainsKey(Object))
						Program.AllProsthetics[Object].Add(Program.Player);
					else if (Program.AllProsthetics.ContainsKey(Subject))
							Program.AllProsthetics[Subject].Add(Program.Player);
					else
						Console.WriteLine("Invalid prosthetic, m8.");
					break;
				case "time":
					Console.WriteLine($"You currently have {Program.Player.TimeLeft} days left to live.");
					break;
				case "money":
					Console.WriteLine($"You have ${Program.Player.Money} in your bank account.");
					break;
				case "body":
					if (unsoldOrgans.Any())
						Console.WriteLine("You have the following organs left in your body:");
						foreach (var organ in Program.AllOrgans.Where(entry => !entry.Value.IsSold))
							{
						Console.WriteLine($@" - {organ.Value.OrganName} -
sell it for ${organ.Value.Price}, lose {organ.Value.Time} days of precious life.
");
							}
					if (boughtProsthetics.Any())
						Console.WriteLine("You have added the following temporary prosthetics to your body:" + String.Join(", ", boughtProsthetics) + ".");
					if (addedProsthetics.Any())
						Console.WriteLine("You have bought the following temporary prosthetics:" + String.Join(", ", addedProsthetics) + ".");
					break;
				case "shop":
					Console.WriteLine("You can buy the following temporary prosthetics:");
					foreach (var item in Program.AllProsthetics.Where(entry => !entry.Value.IsBought)) {
						Console.WriteLine($@"~~ {item.Value.ProstheticName} ~~
will set you back {item.Value.Price} dollars with life expectancy of +{item.Value.Time} days,
");
					}
					break;
				default:
					Console.WriteLine("Excuse me?");
					break;
			}
		}

		/// <summary>
		/// Prints all of player's unsold organs, and bought and added prosthetics, if any.
		/// </summary>
		public void Shop()
		{

		}
	}
}
