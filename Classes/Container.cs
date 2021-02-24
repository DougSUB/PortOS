using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public class Container
	{

		public string Owner { get; set; }
		public string Origin { get; set; }
		public string Destination { get; set; }
		public int Weight { get; set; }
		public int ID { get; set; }
		public bool ContainsExplosives { get; set; }
		public bool ConstainsToxics { get; set; }

	}
}
