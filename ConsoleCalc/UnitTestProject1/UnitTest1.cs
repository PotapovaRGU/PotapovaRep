using System;
using GeometricFigures;
using NUnit.Framework;

namespace UnitTestProject1
{

    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 2);
        }
        [Test]
        public void TestMethodCircleArea()
        {
            double pi = Math.PI;
           
       
            for (int i = 0; i <= 20; i++)
            {
                Circle circle1 = new Circle(i);
                Assert.AreEqual(circle1.getAreaCircle(),pi*i*i,"Ошибка в вычислении площади круга");
                //Console.WriteLine(circle1.getAreaCircle() + "*" + pi * i * i);
            }
        }
        [Test]
        public void TestMethodCircleLength()
        {
            double pi = Math.PI;
            for (int i = 0; i <= 20; i++)
            {
                Circle circle1 = new Circle(i);
                Assert.AreEqual(circle1.getLengthCircle(), 2 * pi * i, "Ошибка в вычислении длинны окружности");
                //Console.WriteLine(circle1.getLengthCircle() + "*" + pi * i * i);
            }
        }
        [Test]
        public void TestMethodSquareArea()
        {

            for (int i = 0; i <= 20; i++)
            {
                Square square1 = new Square(i);
                Assert.AreEqual(square1.getAreaSquare(), i * i, "Ошибка в вычислении площади квадрата");
                //Console.WriteLine(square1.getAreaSquare() + "*" + i * i);
            }
        }
        [Test]
        public void TestMethodSquareLength()
        {
            for (int i = 0; i <= 20; i++)
            {
                Square square1 = new Square(i);
                Assert.AreEqual(square1.getLengthSquare(),4* i, "Ошибка в вычислении периметра квадрата");
                //Console.WriteLine(square1.getLengthSquare() + "*" + 4 * i);
            }

        }
        [Test]
        public void TestMethodTriangleArea()
        {

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    for (int z = 1; z <= 20; z++)
                    {
                        if ((i + j >= z) && (i + z >= j) && (j + z >= i))
                        {
                            Triangle triangle1 = new Triangle(i, j, z);
                            int pp = (i + j + z) / 2;
                            Assert.AreEqual(triangle1.getAreaTriangle(), Math.Sqrt(pp * (pp - i) * (pp - j) * (pp - z)), "Ошибка в вычислении площади треугольника");                           
                           
                        }

                    }
                }
               
            }
        }
        [Test]
        public void TestMethodTriangleLength()
        {

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    for (int z = 1; z <= 20; z++)
                    {
                        if ((i + j >= z) && (i + z >= j) && (j + z >= i))
                        {
                            Triangle triangle1 = new Triangle(i, j, z);
                            Assert.AreEqual(triangle1.getLengthTriangle(), i + j + z, "Ошибка в вычислении периметра треугольника");
                           // Console.WriteLine(triangle1.getLengthTriangle() + "*" + i + j + z);
                        }
                    }
                }

            }
        }
        [Test]
        public void TestMethodTriangleLengthNeg()
        {
            try
            {
                Triangle triangle1 = new Triangle(2, 3, -5);
                triangle1.getLengthTriangle();
                triangle1.getAreaTriangle();
                Assert.AreEqual(2, 1,"Не поймано исключение на несуществующем треугольнике");

            }
            catch (Exception)
            {
                
            }
            

           
        }
    }
}
