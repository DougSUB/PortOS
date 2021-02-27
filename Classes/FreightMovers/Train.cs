using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public class Train : FreightMover
	{
		public int ID { get; set; }
		public int NumberOfCars { get; set; }
		public int MaxWeight { get; set; }		
	}
}
