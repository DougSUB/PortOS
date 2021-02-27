using System;
using System.Collections.Generic;
using System.Text;
using PortOS.Classes;

namespace PortOS.DAO
{
	public class StandardContainerDAO
	{
		private static List<StandardContainer> StandardContainers { get; set; }

		public StandardContainerDAO()
		{
			if(StandardContainers == null)
			{
				StandardContainers = new List<StandardContainer>
				{
					new StandardContainer(1,"Maersk","China","New York",20000,false,true),
					new StandardContainer(2,"Maersk","New Zealand","Houston",20000,false,false),
					new StandardContainer(3,"Maersk","China","New York",20000,true,false),
					new StandardContainer(4,"Maersk","India","New York",20000,false,false),
					new StandardContainer(5,"Maersk","China","Pittsburgh",20000,false,true),
					new StandardContainer(6,"CMA","France","Pittsburgh",20000,false,false),
					new StandardContainer(7,"CMA","China","Houston",20000,true,false),
					new StandardContainer(8,"CMA","Germany","Chicago",20000,false,false),
					new StandardContainer(9,"CMA","China","Chicago",20000,false,false),
					new StandardContainer(10,"CMA","India","Houston",20000,true,false),
					new StandardContainer(11,"Evergreen","China","Chicago",20000,true,true),
					new StandardContainer(12,"Evergreen","China","Pittsburgh",20000,false,false),
					new StandardContainer(13,"Evergreen","Brazil","Houston",20000,false,false),
					new StandardContainer(14,"Evergreen","China","Pittsburgh",20000,true,true),
					new StandardContainer(15,"Evergreen","India","Houston",20000,false,false),
				};
			}
		}

		public List<StandardContainer> List()
		{
			return StandardContainers;
		}

		public StandardContainer Get(int id)
		{
			foreach(var container in StandardContainers)
			{
				if(container.ID == id)
				{
					return container;
				}
			}
			return null;
		}

	}
}
