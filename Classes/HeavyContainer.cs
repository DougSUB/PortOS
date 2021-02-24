using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public class HeavyContainer : Container , IStackable
	{
		public bool Stackable { get; }
	}
}
