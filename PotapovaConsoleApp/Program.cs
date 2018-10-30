using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapovaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ans;
            do {
                Console.WriteLine("выберите операцию + - / *");
                string str = Console.ReadLine();
                Console.WriteLine("введите первый аргумент");
                string arg1 = Console.ReadLine();
                int a1 = int.Parse(arg1);
                Console.WriteLine("введите первый аргумент");
                string arg2 = Console.ReadLine();
                int a2 = int.Parse(arg2);
                int n=0;
                switch (str)
                {
                    case "+": n = a1 + a2; break;
                    case "-": n = a1 - a2; break;
                    case "*": n = a1 * a2; break;
                    case "/": n = a1 / a2; break;
                    default: Console.WriteLine("неизвестная ошибка"); break;


                };
                Console.WriteLine("Результат вычислений  {0}", n);
                Console.WriteLine("Продолжить вычисления ? Y / N");
                Ans = Console.ReadLine();
                
            } while (Ans == "Y");
            Console.ReadKey();
        }
    }
}
