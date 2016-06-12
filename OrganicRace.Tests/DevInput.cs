using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace.Tests
{
	public class DevInput : IUserInput
	{
		public string UserInput = "catch an error by the toe";

		public string GetUserInput()
		{
			return this.UserInput;
		}
	}
}
