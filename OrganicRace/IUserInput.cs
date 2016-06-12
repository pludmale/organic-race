using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public interface IUserInput
	{
		void GetUserInput(string action, string @object, string subject);
	}
}
