using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	public class Arms : ExistingRobotPart
	{
		public string Name { get; }

		public Arms(string Name)
		{
			this.Name = Name;
		}

		public static Arms GetRandomArms()
		{
			List<Arms> listArms = new List<Arms>();
			listArms.Add(new Arms("Claws"));
			listArms.Add(new Arms("Grippers"));
			listArms.Add(new Arms("Articulated Fingers"));
			Random random = new Random();
			return listArms[random.Next(listArms.Count)];
		}
	}
}