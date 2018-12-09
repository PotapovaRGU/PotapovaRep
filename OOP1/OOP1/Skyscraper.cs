using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    [MyOwn(Architect = "ArchitectorSkyscraper")]
    internal class Skyscraper : Building
    {
        public int hight;
        public int length;
        public int width;
        public int YearofBuild;
        private string City;

        public Skyscraper(string x) : base(x)
        {

        }
        public bool PodSnos()
        {
            if (YearofBuild < 1855)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Propertysquare
        {
            get
            {
                return length * width * hight;
            }
        }
    }
}
