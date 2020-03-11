using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	public class MediaCenter : ExistingRobotPart
	{
		public string Name { get; }

		public MediaCenter(string Name)
		{
			this.Name = Name;
		}

		public static MediaCenter GetRandomMediaCenter()
		{
			List<MediaCenter> listMedias = new List<MediaCenter>();
			listMedias.Add(new MediaCenter("Sony"));
			listMedias.Add(new MediaCenter("JVC"));
			listMedias.Add(new MediaCenter("Meridian"));
			Random random = new Random();
			return listMedias[random.Next(listMedias.Count)];
		}
	}
}