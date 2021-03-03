using System;
using System.Collections.Generic;
using System.Text;

namespace PortOS.Classes
{
	public class Stack
	{
		public int Height
		{
			get
			{
				return ContainerStack.Count;
			}
		}
		public Stack<Container> ContainerStack { get; }

		public int StandardContainerCount
		{
			get
			{
				int count = 0;
				foreach(Container container in ContainerStack)
				{
					if(container is StandardContainer)
					{
						count++;
					}
				}
				return count;
			}
		}

		public int HeavyContainerCount
		{
			get
			{
				int count = 0;
				foreach (Container container in ContainerStack)
				{
					if (container is HeavyContainer)
					{
						count++;
					}
				}
				return count;
			}
		}

		public int ToxicExplosiveContainerCount
		{
			get
			{
				int count = 0;
				foreach (Container container in ContainerStack)
				{
					if (container.ContainsExplosives || container.ContainsToxics)
					{
						count++;
					}
				}
				return count;
			}
		}
	}
}
