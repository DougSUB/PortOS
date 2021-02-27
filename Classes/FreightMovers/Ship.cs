using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public class Ship : FreightMover
	{
		public Ship(int id, int maxToxicExplosiveContianers, int maxRefrigeratedContainers, int maxHeavyContainers, int maxTotalContainers, string destination, int maxStack, int containersWide, int containersLong) 
			: base(id, maxToxicExplosiveContianers, maxRefrigeratedContainers, maxHeavyContainers, maxTotalContainers, destination, maxStack, containersWide, containersLong) { }

		public bool Load(Container id)
		{

			return true;
		}
	}

}
