using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS
{
	public class FreightMover
	{
		public int MaxToxicExplosiveContainers { get; set; }
		public int MaxRefrigeratedContainers { get; set; }
		public int MaxHeavyContainers { get; set; }
		public int MaxTotalConainers { get; set; }
		public string Destination { get; set; }
		public int MaxStack { get; set; }
		public int ContainerWide { get; set; }
		public int ContainerLong { get; set; }
	}
}
