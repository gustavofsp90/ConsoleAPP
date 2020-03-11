using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class Robot
	{
		public string Model { get; set; }
		public int SerialNumber { get; set; }
		public Brain Brain { get; set; }
		public Mobility Mobility { get; set; }
		public Vision Vision { get; set; }
		public Arms Arms { get; set; }
		public MediaCenter MediaCenter { get; set; }
		public PowerPlant PowerPlant { get; set; }

		public Robot()
		{

		}




	}
}
