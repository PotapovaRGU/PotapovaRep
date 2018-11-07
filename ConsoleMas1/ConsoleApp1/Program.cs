using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestArray();

        }

        private static void RequestArray()
        {
            Console.Write("N=");
            string str = Console.ReadLine();
            int n = int.Parse(str);
            int[,] arr;
            arr = new int[n, n];
            Console.WriteLine("Ввод элементов массива");
            Console.WriteLine();
            for (int i = 0; i <= n-1; i++)
            {
                Console.WriteLine("row =" + i);
                for (int j = 0; j <= n-1; j++)
                {
                    arr[i, j] =int.Parse(Console.ReadLine());
                }
                
            }
            Console.Write("M=");
            str = Console.ReadLine();
            int m = int.Parse(str);
            int[,] arr2;
            arr2 = new int[m, m];
            Console.Write("Ввод элементов массива");
            Console.WriteLine();
            for (int i = 0; i <= m-1; i++)
            {
                for (int j = 0; j <= m-1; j++)
                {

                    arr2[i, j] = int.Parse(Console.ReadLine());
                };
                Console.WriteLine("row =" + i);
            }

       
            int[,] arr3;
            int r, rr;           
           
            if ((m >= n))
            {
                r = n;
                rr = m;
                arr3 = arr2;
            }
            else
            {
                r = m;
                rr = n;
                arr3 = arr;
            }
                 
            
            
            for (int ii = 0; ii <= r-1; ii++)
            {
                for (int jj = 0; jj <= r-1; jj++)
                {
                    arr3[ii, jj] = arr[ii, jj] + arr2[ii, jj];
                    

                }; Console.WriteLine();
            };
            
            
            for (int ii = 0; ii <= rr - 1; ii++)
            {
                for (int jj = 0; jj <= rr - 1; jj++)
                {
                 
                    Console.Write("  {0}", arr3[ii, jj]);

                }; Console.WriteLine();
            };
            Console.WriteLine("Конец"); Console.ReadLine();
        }
    }
}
