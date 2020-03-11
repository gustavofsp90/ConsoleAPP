using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public static class Search
	{
		public static List<Robot> GetBy(SearchRequest searchRequest, List<ExistingRobot> existingRobots, List<NewRobot> newRobots)
		{
			List<Robot> listRobots = new List<Robot>();
			foreach (ExistingRobot robot in existingRobots)
			{
				if (searchRequest.Model != "" && robot.Model == searchRequest.Model)
					listRobots.Add(robot);
				if (searchRequest.SerialNumber != 0 && robot.SerialNumber == searchRequest.SerialNumber)
					listRobots.Add(robot);
				if (searchRequest.Brain != "" && robot.Brain.Name == searchRequest.Brain)
					listRobots.Add(robot);
				if (searchRequest.Mobility != "" && robot.Mobility.Name == searchRequest.Mobility)
					listRobots.Add(robot);
				if (searchRequest.Vision != "" && robot.Vision.Name == searchRequest.Vision)
					listRobots.Add(robot);
				if (searchRequest.Arms != "" && robot.Arms.Name == searchRequest.Arms)
					listRobots.Add(robot);
				if (searchRequest.MediaCenter != "" && robot.MediaCenter.Name == searchRequest.MediaCenter)
					listRobots.Add(robot);
				if (searchRequest.PowerPlant != "" && robot.PowerPlant.Name == searchRequest.PowerPlant)
					listRobots.Add(robot);
			}

			foreach (NewRobot robot in newRobots)
			{
				if (searchRequest.Model != "" && robot.Model == searchRequest.Model)
					listRobots.Add(robot);
				if (searchRequest.SerialNumber != 0 && robot.SerialNumber == searchRequest.SerialNumber)
					listRobots.Add(robot);
				if (searchRequest.Brain != "" && robot.Brain.Name == searchRequest.Brain)
					listRobots.Add(robot);
				if (searchRequest.Mobility != "" && robot.Mobility.Name == searchRequest.Mobility)
					listRobots.Add(robot);
				if (searchRequest.Vision != "" && robot.Vision.Name == searchRequest.Vision)
					listRobots.Add(robot);
				if (searchRequest.Arms != "" && robot.Arms.Name == searchRequest.Arms)
					listRobots.Add(robot);
				if (searchRequest.MediaCenter != "" && robot.MediaCenter.Name == searchRequest.MediaCenter)
					listRobots.Add(robot);
				if (searchRequest.PowerPlant != "" && robot.PowerPlant.Name == searchRequest.PowerPlant)
					listRobots.Add(robot);
			}

			return listRobots;
		}

		public static List<Robot> GetRobotsDonatedPart(SearchRequest searchRequest, List<ExistingRobot> existingRobots, List<NewRobot> newRobots)
		{
			List<Robot> listExistingRobots = new List<Robot>();

			foreach (NewRobot robot in newRobots)
			{
				//if (searchRequest.Model != "" && robot.Model == searchRequest.Model)
				//	listExistingRobots.Add(robot);
				//if (searchRequest.SerialNumber != 0 && robot.SerialNumber == searchRequest.SerialNumber)
				//	listExistingRobots.Add(robot);
				if (searchRequest.Brain != "" && robot.Brain.RobotPart.Brain.Name == searchRequest.Brain)
					listExistingRobots.Add(robot);
				if (searchRequest.Mobility != "" && robot.Mobility.RobotPart.Mobility.Name == searchRequest.Mobility)
					listExistingRobots.Add(robot);
				if (searchRequest.Vision != "" && robot.Vision.RobotPart.Vision.Name == searchRequest.Vision)
					listExistingRobots.Add(robot);
				if (searchRequest.Arms != "" && robot.Arms.RobotPart.Arms.Name == searchRequest.Arms)
					listExistingRobots.Add(robot);
				if (searchRequest.MediaCenter != "" && robot.MediaCenter.RobotPart.MediaCenter.Name == searchRequest.MediaCenter)
					listExistingRobots.Add(robot);
				if (searchRequest.PowerPlant != "" && robot.PowerPlant.RobotPart.PowerPlant.Name == searchRequest.PowerPlant)
					listExistingRobots.Add(robot);
			}

				return listExistingRobots;
		}
	}
}
