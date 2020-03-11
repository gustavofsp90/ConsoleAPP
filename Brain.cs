using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	public class Brain : ExistingRobotPart
	{
		public string Name { get; }

		public Brain(string name)
		{
			Name = name;
		}
		public static Brain GetRandomBrain()
		{
			List<Brain> listBrains = new List<Brain>();
			listBrains.Add(new Brain("2.5GHZ"));
			listBrains.Add(new Brain("3.5GHZ"));
			listBrains.Add(new Brain("4.5GHZ"));
			Random random = new Random();
			return listBrains[random.Next(listBrains.Count)];
		}
	}
}