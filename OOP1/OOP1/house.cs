using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class House : Building
    {
        public bool area;      
        public int length;
        public int width;


        public int Propertysquare
        {
            get
            {
                if (area)
                {
                    return length * width;
                }
                else return 0;
            }
        }



    }
}
