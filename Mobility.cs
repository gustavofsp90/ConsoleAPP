using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	public class Mobility : ExistingRobotPart
	{
		public string Name { get; }

		public Mobility(string Name)
		{
			this.Name = Name;
		}

		public static Mobility GetRandomMobility()
		{
			List<Mobility> listMobilities = new List<Mobility>();
			listMobilities.Add(new Mobility("Caterpillar Tracks"));
			listMobilities.Add(new Mobility("Wheels"));
			listMobilities.Add(new Mobility("Legs"));
			Random random = new Random();
			return listMobilities[random.Next(listMobilities.Count)];
		}
	}
}