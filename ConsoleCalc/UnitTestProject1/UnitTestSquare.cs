using System;
using GeometricFigures;

using NUnit.Framework;

namespace UnitTestProject1
{

    [TestFixture]
    public class UnitTestSquare
    {
        static object[] SquareCases =
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
        [TestCaseSource("SquareCases")]
        public void TestMethodSquareArea(int i)
        {

            
                Square square1 = new Square(i);
                Assert.AreEqual(square1.getAreaSquare(), i * i, "Ошибка в вычислении площади квадрата");
                //Console.WriteLine(square1.getAreaSquare() + "*" + i * i);
            
        }
        [TestCaseSource("SquareCases")]
        public void TestMethodSquareLength(int i)
        {
            
                Square square1 = new Square(i);
                Assert.AreEqual(square1.getLengthSquare(), 4 * i, "Ошибка в вычислении периметра квадрата");
                //Console.WriteLine(square1.getLengthSquare() + "*" + 4 * i);
          

        }


    }
}
