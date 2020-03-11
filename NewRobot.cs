using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
	public class NewRobot : Robot
	{
		public List<ExistingRobot> ExistingRobot { get; }
		public ExistingRobot RobotPart { get; set; }
		List<ExistingRobot> UsedRobots = new List<ExistingRobot>();

		public NewRobot()
		{
		}
		public NewRobot(List<ExistingRobot> existingRobot)
		{
			ExistingRobot = existingRobot;
		}
		public List<NewRobot> GenerateNewRobots()
		{
			List<NewRobot> listRobots = new List<NewRobot>();

			for (int i = 0; i < 400; i++)
			{
				UsedRobots = new List<ExistingRobot>();

				ExistingRobot existingRobot;
				Random rnd = new Random();
				NewRobot robot = new NewRobot();

				robot.Model = GetRandomModel().ToString();
				robot.SerialNumber = rnd.Next(100000, 900000);

				existingRobot = GetRandomRobot();
				robot.Brain = existingRobot.Brain;
				robot.Brain.RobotPart = existingRobot;

				existingRobot = GetRandomRobot();
				robot.Mobility = existingRobot.Mobility;
				robot.Mobility.RobotPart = existingRobot;

				existingRobot = GetRandomRobot();
				robot.Vision = existingRobot.Vision;
				robot.Vision.RobotPart = existingRobot;

				existingRobot = GetRandomRobot();
				robot.Arms = existingRobot.Arms;
				robot.Arms.RobotPart = existingRobot;

				existingRobot = GetRandomRobot();
				robot.MediaCenter = existingRobot.MediaCenter;
				robot.MediaCenter.RobotPart = existingRobot;

				existingRobot = GetRandomRobot();
				robot.PowerPlant = existingRobot.PowerPlant;
				robot.PowerPlant.RobotPart = existingRobot;

				listRobots.Add(robot);
				ClearAddedParts();
			}
			
			return listRobots;
		}

		private ExistingRobot GetRandomRobot()
		{
			Random rnd = new Random();
			ExistingRobot existingRobot = new ExistingRobot();
			bool robotAbleToDonatePart = false;

			while (!robotAbleToDonatePart)
			{
				existingRobot = ExistingRobot[rnd.Next(ExistingRobot.Count)];
				robotAbleToDonatePart = true;
				foreach (ExistingRobot robot in UsedRobots)
				{
					if (robot.Equals(existingRobot) && robot.PartUsed >= 2)
					{
						robotAbleToDonatePart = false;
						break;
					}
				}
			}
			existingRobot.PartUsed += 1;
			if (!UsedRobots.Contains(existingRobot))
				UsedRobots.Add(existingRobot);
			return existingRobot;
		}

		private void ClearAddedParts()
		{
			foreach (ExistingRobot robot in ExistingRobot)
			{
				robot.PartUsed = 0;
			}
		}

		private static string GetRandomModel()
		{
			List<string> listModels = new List<string>();
			listModels.Add("Andy the Android");
			listModels.Add("Betty the Busibot");
			listModels.Add("Bobi the Racedroid");
			listModels.Add("Fred the Friendlybot");
			Random random = new Random();
			return listModels[random.Next(listModels.Count)];
		}
	}
}
