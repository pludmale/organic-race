using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public class Person
	{
		/// <summary>
		/// How much days the player has left to live?
		/// </summary>
		public int TimeLeft;
		/// <summary>
		/// How much money does the player have?
		/// </summary>
		public decimal Money;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="days">See <see cref="TimeLeft"/>.</param>
		/// <param name="money">See <see cref="Money"/></param>
		public Person(int days, decimal money)
		{
			this.TimeLeft = days;
			this.Money = money;
		}

	}
}
