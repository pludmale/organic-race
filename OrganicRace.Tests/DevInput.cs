using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace.Tests
{
	public class DevInput : IUserInput
	{
		public string GetUserInput()
		{
			string prompt = "catch an error by the toe";
			return prompt;
		}
	}
}
