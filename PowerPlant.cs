using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	public class PowerPlant : ExistingRobotPart
	{
		public string Name { get; }

		public PowerPlant(string Name)
		{
			this.Name = Name;
		}

		public static PowerPlant GetRandomPowerPlant()
		{
			List<PowerPlant> listPowerPlants = new List<PowerPlant>();
			listPowerPlants.Add(new PowerPlant("Lithium"));
			listPowerPlants.Add(new PowerPlant("Hydrogen"));
			listPowerPlants.Add(new PowerPlant("Plasma"));
			Random random = new Random();
			return listPowerPlants[random.Next(listPowerPlants.Count)];
		}
	}
}