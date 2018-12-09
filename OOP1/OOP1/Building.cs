using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    [MyOwn(Architect= "Architector1")]
    abstract class Building
    {
        
        public int square;
        public string material;
        public readonly string owner;
        public Building(string x)
        {
            owner = x;
        }

        public string GetBuildingOwner()
        {
            var type = this.GetType();
            var attributeValue = Attribute.GetCustomAttribute(type, typeof(MyOwnAttribute)) as MyOwnAttribute; 
            return owner + " - "+ attributeValue.Architect;
        }


    }
}
