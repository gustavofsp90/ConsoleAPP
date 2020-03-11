using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class ExistingRobot : Robot
	{
		public int PartUsed { get; set; }
		public static List<ExistingRobot> GenerateExistingRobots()
		{

			//method to create robots from random values listeds on the respectives
			List<ExistingRobot> listRobots = new List<ExistingRobot>();
			for (int i = 0; i < 300; i++)
			{
				ExistingRobot robot = new ExistingRobot();
				robot.Model = GetRandomModel().ToString();
				Random rnd = new Random();
				robot.SerialNumber = rnd.Next(100000, 900000);
				robot.Brain = Brain.GetRandomBrain();
				robot.Mobility = Mobility.GetRandomMobility();
				robot.Vision = Vision.GetRandomVision();
				robot.Arms = Arms.GetRandomArms();
				robot.MediaCenter = MediaCenter.GetRandomMediaCenter();
				robot.PowerPlant = PowerPlant.GetRandomPowerPlant();

				listRobots.Add(robot);
			}
			return listRobots;
		}
		private static string GetRandomModel() {
			List<string> listModels = new List<string>();
			listModels.Add("MK1");
			listModels.Add("MK2");
			listModels.Add("MK3");
			listModels.Add("MK4");
			listModels.Add("MK5");
			Random random = new Random();
			return listModels[random.Next(listModels.Count)];
		}
	}
}
