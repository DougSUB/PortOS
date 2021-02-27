using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	class RefrigeratedContainer : HeavyContainer
	{
		public RefrigeratedContainer(int id, string owner, string origin, string destination, int weight, bool containsExplosives, bool containsToxics) : base(id, owner, origin, destination, weight, containsExplosives, containsToxics) { }
		public int Temperature { get; set; }
	}
}
