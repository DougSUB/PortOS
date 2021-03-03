using System;
using System.Collections.Generic;
using System.Text;
using PortOS.Classes;

namespace PortOS.Classes
{
	public class Ship : FreightMover
	{
		public Ship(int id, int maxToxicExplosiveContianers, int maxRefrigeratedContainers, int maxHeavyContainers, int maxTotalContainers, string destination, int maxStack, int containersWide, int containersLong)
			: base(id, maxToxicExplosiveContianers, maxRefrigeratedContainers, maxHeavyContainers, maxTotalContainers, destination, maxStack, containersWide, containersLong) { }

		public Dictionary<int, Stack> DeckStackIndex { get; set; }
		public Dictionary<int, Container> DeckUnstackableIndex { get; set; }

		public int TotalContainerCount
		{
			get
			{
				int count = 0;
				foreach(KeyValuePair<int, Stack> kvp in DeckStackIndex)
				{
					count += kvp.Value.Height;
				}
				count += DeckUnstackableIndex.Count;
				return count;
			}
		}
		public int HeavyContainerCount
		{
			get
			{
				int count = 0;
				foreach (KeyValuePair<int, Stack> kvp in DeckStackIndex)
				{
					count += kvp.Value.HeavyContainerCount;
				}
				return count;
			}
		}
		public int RefrigeratedContainerCount
		{
			get
			{
				int count = 0;
				foreach(KeyValuePair<int,Container> kvp in DeckUnstackableIndex)
				{
					if(kvp.Value is RefrigeratedContainer)
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
				foreach (KeyValuePair<int, Stack> kvp in DeckStackIndex)
				{
					count += kvp.Value.ToxicExplosiveContainerCount;
				}
				foreach (KeyValuePair<int, Container> kvp in DeckUnstackableIndex)
				{
					if (kvp.Value.ContainsExplosives || kvp.Value.ContainsToxics)
					{
						count++;
					}
				}
				return count;
			}
		}

		private bool CanLoad(Container container)
		{
			if (TotalContainerCount >= MaxTotalContainers)
			{
				return false;
			}
			if(container is StandardContainer)
			{
				if(ToxicExplosiveContainerCount >= MaxToxicExplosiveContainers)
				{
					return false;
				}
				return true;
			}
			else if(container is HeavyContainer)
			{
				if (HeavyContainerCount >= MaxHeavyContainers)
				{
					return false;
				}
				else if(container is RefrigeratedContainer)
				{
					if (RefrigeratedContainerCount >= MaxRefrigeratedContainers)
					{
						if (ToxicExplosiveContainerCount >= MaxToxicExplosiveContainers)
						{
							return false;
						}
						return false;
					}
				}
				else if (ToxicExplosiveContainerCount >= MaxToxicExplosiveContainers)
				{
					return false;
				}
			}
			return true;
		}


		public bool Load(Container container)
		{
			if (!CanLoad(container))
			{
				return false;
			}

			return true;
		}
	}

}
