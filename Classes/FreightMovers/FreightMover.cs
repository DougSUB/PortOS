using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS
{
	public abstract class FreightMover
	{
		public FreightMover(int id, int maxToxicExplosiveContianers, int maxRefrigeratedContainers, int maxHeavyContainers, int maxTotalContainers, string destination, int maxStack, int containersWide, int containersLong)
		{
			ID = id;
			MaxToxicExplosiveContainers = maxToxicExplosiveContianers;
			MaxRefrigeratedContainers = maxRefrigeratedContainers;
			MaxHeavyContainers = maxHeavyContainers;
			MaxTotalContainers = maxTotalContainers;
			Destination = destination;
			MaxStack = maxStack;
			ContainersWide = containersWide;
			ContainersLong = containersLong;
		}

		public int ID { get; set; }
		public int MaxToxicExplosiveContainers { get; set; }
		public int MaxRefrigeratedContainers { get; set; }
		public int MaxHeavyContainers { get; set; }
		public int MaxTotalContainers { get; set; }
		public string Destination { get; set; }
		public int MaxStack { get; set; }
		public int ContainersWide { get; set; }
		public int ContainersLong { get; set; }
	}
}
