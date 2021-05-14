using System;
using PickleTemplate;
using System.Collections.Generic;

namespace BroccoliData
{
    public class BroccoliDataHolder
    {
		public readonly List<Pickle> broccolis;
		public BroccoliDataHolder() {
			broccolis = new List<Pickle>()
			{
				new Pickle {Id = 1, Name = "Broccoli", Price = "$1.99"},
				new Pickle {Id = 2, Name = "Italian Broccoli", Price = "$3.99"},
				new Pickle {Id = 3, Name = "Pickle", Price = "$2.99"},
				new Pickle {Id = 4, Name = "BunchO'DillPicles", Price = "$5.99"},
			
			};
		}
    }
}