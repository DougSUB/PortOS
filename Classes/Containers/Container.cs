using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public abstract class Container
	{
		public Container(int id, string owner, string origin, string destination, int weight, bool containsExplosives, bool containsToxics)
		{
			ID = id;
			Owner = owner;
			Origin = origin;
			Destination = destination;
			Weight = weight;
			ContainsExplosives = containsExplosives;
			ContainsToxics = containsToxics;
		}

		public int ID { get; set; }
		public string Owner { get; set; }
		public string Origin { get; set; }
		public string Destination { get; set; }
		public int Weight { get; set; }
		public bool ContainsExplosives { get; set; }
		public bool ContainsToxics { get; set; }

		public bool ToxicExplosive()
		{
			if (ContainsExplosives == true || ContainsExplosives == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
