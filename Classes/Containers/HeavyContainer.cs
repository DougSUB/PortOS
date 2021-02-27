using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public class HeavyContainer : Container , IStackable
	{
		public HeavyContainer(int id, string owner, string origin, string destination, int weight, bool containsExplosives, bool containsToxics) : base(id, owner, origin, destination, weight, containsExplosives, containsToxics) { }
		public bool Stackable { get; } = true;
	}
}
