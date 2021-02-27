using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public class StandardContainer : Container , IStackable
	{
		public StandardContainer(int id, string owner, string origin, string destination, int weight, bool containsExplosives, bool containsToxics) : base(id, owner, origin, destination, weight, containsExplosives, containsToxics) { }

		public bool Stackable { get; } = true;
	}
}