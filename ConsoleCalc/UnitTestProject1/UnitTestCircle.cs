using System;
using GeometricFigures;

using NUnit.Framework;

namespace UnitTestProject1
{

    [TestFixture]
    public class UnitTestCircle
    {

        static object[] CircleCases =
        {
         new object[] { 1 },
         new object[] { 2 },
         new object[] { 3 },
         new object[] { 4 },
         new object[] { 5 },
         new object[] { 6 },
         new object[] { 7 },
         new object[] { 8 },
         new object[] { 9 },
         new object[] { 10 },
         new object[] { 11 },
         new object[] { 12 },
         new object[] { 13 },
         new object[] { 14 },
         new object[] { 15 },
         new object[] { 16 },
         new object[] { 17 },
         new object[] { 18 },
         new object[] { 19 },
         new object[] { 20 }
         };
        [TestCaseSource("CircleCases")]
        public void TestMethodCircleArea(int i)
        {
            double pi = Math.PI;


           
                Circle circle1 = new Circle(i);
                Assert.AreEqual(circle1.getAreaCircle(), pi * i * i, "Ошибка в вычислении площади круга");
                //Console.WriteLine(circle1.getAreaCircle() + "*" + pi * i * i);
            
        }

        [TestCaseSource("CircleCases")]
        public void TestMethodCircleLength(int i)
        {
            double pi = Math.PI;
           
                Circle circle1 = new Circle(i);
                Assert.AreEqual(circle1.getLengthCircle(), 2 * pi * i, "Ошибка в вычислении длинны окружности");
                //Console.WriteLine(circle1.getLengthCircle() + "*" + pi * i * i);
            
        }

    }
}
