using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Robot Generator:");

			Console.WriteLine("Generating 300 existing robots:");
			List<ExistingRobot> listExistingRobots = new List<ExistingRobot>();
			listExistingRobots = ExistingRobot.GenerateExistingRobots();
			foreach (ExistingRobot robot in listExistingRobots)
			{
				Console.WriteLine("Model: " + robot.Model);
				Console.WriteLine("Serial Number: " + robot.SerialNumber);
				Console.WriteLine("Brain: " + robot.Brain.Name);
				Console.WriteLine("Mobility: " + robot.Mobility.Name);
				Console.WriteLine("Vision: " + robot.Vision.Name);
				Console.WriteLine("Arms: " + robot.Arms.Name);
				Console.WriteLine("Media Center: " + robot.MediaCenter.Name);
				Console.WriteLine("Power Plant: " + robot.PowerPlant.Name);
				Console.WriteLine("--------------------------------------");
			}

			Console.WriteLine("Generating 400 new robots:");
			List<NewRobot> listNewRobots = new List<NewRobot>();
			NewRobot newRobot = new NewRobot(listExistingRobots);
			listNewRobots = newRobot.GenerateNewRobots();

			foreach (NewRobot robot in listNewRobots)
			{
				Console.WriteLine("Model: " + robot.Model);
				Console.WriteLine("Serial Number: " + robot.SerialNumber);
				Console.WriteLine("Brain: " + robot.Brain.Name + "(" + robot.Brain.RobotPart.Model + ":" + "Serial Number: " + robot.Brain.RobotPart.SerialNumber + ")");
				Console.WriteLine("Mobility: " + robot.Mobility.Name + "(" + robot.Mobility.RobotPart.Model + ":" + "Serial Number: " + robot.Mobility.RobotPart.SerialNumber + ")");
				Console.WriteLine("Vision: " + robot.Vision.Name + "(" + robot.Vision.RobotPart.Model + ":" + "Serial Number: " + robot.Vision.RobotPart.SerialNumber + ")");
				Console.WriteLine("Arms: " + robot.Arms.Name + "(" + robot.Arms.RobotPart.Model + ":" + "Serial Number: " + robot.Arms.RobotPart.SerialNumber + ")");
				Console.WriteLine("Media Center: " + robot.MediaCenter.Name + "(" + robot.MediaCenter.RobotPart.Model + ":" + "Serial Number: " + robot.MediaCenter.RobotPart.SerialNumber + ")");
				Console.WriteLine("Power Plant: " + robot.PowerPlant.Name + "(" + robot.PowerPlant.RobotPart.Model + ":" + "Serial Number: " + robot.PowerPlant.RobotPart.SerialNumber + ")");
				Console.WriteLine("--------------------------------------");
			}

			//SearchRequest searchRequest = new SearchRequest();
			//searchRequest.Model = "Andy the Android";
			//searchRequest.SerialNumber = 0;
			//searchRequest.Brain = "";
			//searchRequest.Mobility = "";
			//searchRequest.Vision = "";
			//searchRequest.Arms = "";
			//searchRequest.MediaCenter = "";
			//searchRequest.PowerPlant = "";
			//List<Robot> listRobotsSearch = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total search: " + listRobotsSearch.Count);

			//List<Robot> listRobots = new List<Robot>();
			//SearchRequest searchRequest = new SearchRequest();
			//searchRequest.Model = "MK1";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "MK2";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "MK3";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "MK4";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "MK5";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "Andy the Android";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "Betty the Busibot";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "Bobi the Racedroid";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//searchRequest.Model = "Fred the Friendlybot";
			//listRobots = Search.GetBy(searchRequest, listExistingRobots, listNewRobots);
			//Console.WriteLine("Total " + searchRequest.Model + ": " + listRobots.Count);

			//SearchRequest searchRequest = new SearchRequest();
			//searchRequest.MediaCenter = "Sony";
			//List<Robot> listRobotsSearch = Search.GetRobotsDonatedPart(searchRequest, listExistingRobots, listNewRobots);

			//foreach (NewRobot robot in listRobotsSearch)
			//{
			//	Console.WriteLine("The models that donated media center " + searchRequest.MediaCenter + " were: ");
			//	Console.WriteLine(robot.MediaCenter.RobotPart.Model + robot.MediaCenter.RobotPart.SerialNumber);
			//	Console.WriteLine("to: " + robot.SerialNumber + "(" + robot.Model + ")");
			//}
			//Console.WriteLine("total: " + listRobotsSearch.Count);

			//searchRequest = new SearchRequest();
			//searchRequest.MediaCenter = "JVC";
			//listRobotsSearch = Search.GetRobotsDonatedPart(searchRequest, listExistingRobots, listNewRobots);

			//foreach (NewRobot robot in listRobotsSearch)
			//{
			//	Console.WriteLine("The models that donated media center " + searchRequest.MediaCenter + " were: ");
			//	Console.WriteLine(robot.MediaCenter.RobotPart.Model + robot.MediaCenter.RobotPart.SerialNumber);
			//	Console.WriteLine("to: " + robot.SerialNumber + "(" + robot.Model + ")");
			//}
			//Console.WriteLine("total: " + listRobotsSearch.Count);

			//searchRequest = new SearchRequest();
			//searchRequest.MediaCenter = "Meridian";
			//listRobotsSearch = Search.GetRobotsDonatedPart(searchRequest, listExistingRobots, listNewRobots);

			//foreach (NewRobot robot in listRobotsSearch)
			//{
			//	Console.WriteLine("The models that donated media center " + searchRequest.MediaCenter + " were: ");
			//	Console.WriteLine(robot.MediaCenter.RobotPart.Model + robot.MediaCenter.RobotPart.SerialNumber);
			//	Console.WriteLine("to: " + robot.SerialNumber + "(" + robot.Model + ")");
			//}
			//Console.WriteLine("total: " + listRobotsSearch.Count);
			Console.ReadKey();
		}


	}
}
