using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP1
{
    class Program
    { 
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            House build1 = new House("Vasia");

            build1.width = 4;
            build1.length = 12;
            build1.area = true;
            int Sq;
            try
            {
                Sq = build1.Propertysquare;               
                Console.WriteLine("Площадь участка build1 равна {0}, влвделец {1}", Sq, build1.owner);
                throw new Exception("Здесь сообщение об ошибке");
                
            }
            catch(Exception ex)
            {
                logger.Debug("Обнаружена ошибка {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Это выполняется все равно");
            }


            House build2 = new House("Peter");
            build2.width = 4;
            build2.length = 12;
            build2.area = false;
            Console.WriteLine("Площадь участка build2 равна {0}", build2.Propertysquare);
           


            Skyscraper build3 = new Skyscraper("Boris");
            build3.length = 2;
            build3.width = 4;
            build3.hight = 100;
            build3.YearofBuild = 1805;
            if (build3.PodSnos())
            {
                Console.WriteLine("Cтроениt build3 придется снести, площать под снос {0} ", build3.Propertysquare);
            }
            else
            {
                Console.WriteLine("Площадь строения build3 равна {0}", build3.Propertysquare);
            }

            List<Building> buildings = new List<Building>();
            buildings.Add(build1);
            buildings.Add(build2);
            buildings.Add(build3);
            buildings.Count();
            Console.WriteLine("Количество элементов в коллекции {0}",buildings.Count());

            var sortedBuildings = from b in buildings
                              orderby b.owner
                              select b;

            foreach (Building b in sortedBuildings)
            {
                Console.WriteLine(b.GetBuildingOwner());
            }
          

            buildings.Add(build3);
            buildings.Add(new House("newownername"));

            var sortedBuildings2 = buildings.OrderByDescending((b) => b.owner);

            foreach (Building b in sortedBuildings2)
                Console.WriteLine(b.GetBuildingOwner()+ " Descending");

            Console.Read();

        }
    }
}
