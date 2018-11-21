using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    abstract class Building
    {
        
        public int square;
        public string material;
        private readonly string owner;
        public Building(string owner )
        {
            this.owner= owner

        }

        public string GetBuildingOwner()
        {
            return owner;
        }


    }
}
