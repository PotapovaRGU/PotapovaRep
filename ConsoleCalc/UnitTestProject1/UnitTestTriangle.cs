using System;
using GeometricFigures;

using NUnit.Framework;

namespace UnitTestProject1
{

    [TestFixture]
    public class UnitTestTriangle
    {
        static object[] TriangleCases =
     {
         new object[] { 1 , 3 , 5 },
         new object[] { 2 , 2 , 2 },
         new object[] { 3 , 6 , 4 },
         new object[] { 3 , 4 , 2 },
         new object[] { 3 , 6 , 9 }
         };

        static object[] TriangleCasesNeg =
     {
         new object[] { 1 , 3 , 0 },
         new object[] { 9 , 2 , 1 },
         new object[] { 3 , 6 , 1 },
         new object[] { 3 , -4 , 6 },
         new object[] { 3 , 1 , 9 }
         };
        [TestCaseSource("TriangleCases")]
        public void TestMethodTriangleLength(int i,int j, int z)
        {                        
           Triangle triangle1 = new Triangle(i, j, z);
           Assert.AreEqual(triangle1.getLengthTriangle(), i + j + z, "Ошибка в вычислении периметра треугольника");
           // Console.WriteLine(triangle1.getLengthTriangle() + "*" + i + j + z);
               
        }
        [TestCaseSource("TriangleCases")]
        public void TestMethodTriangleArea(int i, int j, int z)
        {
           Triangle triangle1 = new Triangle(i, j, z);
           int pp = (i + j + z) / 2;
           Assert.AreEqual(triangle1.getAreaTriangle(), Math.Sqrt(pp * (pp - i) * (pp - j) * (pp - z)), "Ошибка в вычислении площади треугольника");

        }

        [TestCaseSource("TriangleCasesNeg")]
        public void TestMethodTriangleLengthNeg(int i, int j, int z)
        {
            try
            {
                Triangle triangle1 = new Triangle(2, 3, -5);
                triangle1.getLengthTriangle();
                triangle1.getAreaTriangle();
                Assert.AreEqual(2, 1, "Не поймано исключение на несуществующем треугольнике");

            }
            catch (Exception)
            {

            }

        }



    }
}

