using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	public class Vision : ExistingRobotPart
	{
		public string Name { get; }

		public Vision(string Name)
		{
			this.Name = Name;
		}

		public static Vision GetRandomVision()
		{
			List<Vision> listVisions = new List<Vision>();
			listVisions.Add(new Vision("Heat Vision"));
			listVisions.Add(new Vision("Full colour"));
			listVisions.Add(new Vision("Night Vision"));
			Random random = new Random();
			return listVisions[random.Next(listVisions.Count)];
		}
	}
}