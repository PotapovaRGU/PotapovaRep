using System;

namespace PotapovaConsoleApp
{
    class Program
    {
        public struct Kalaulator
        {
            public int Paschet(string str, int a1, int a2)
            {
                int n = 0;
                switch (str)
                {
                    case "+": n = a1 + a2; break;
                    case "-": n = a1 - a2; break;
                    case "*": n = a1 * a2; break;
                    case "/": n = a1 / a2; break;
                    default: Console.WriteLine("неизвестная ошибка"); break;
                };
                return n;
            }
        }
        static void Main(string[] args)
        {
            var kalk = new Kalaulator();
            string Ans;
            do
            {
                Console.WriteLine("выберите операцию + - / *");
                string str = Console.ReadLine();
                if ((str !="+") || (str != "*") || (str != "/")||(str != "-"))
                { Console.WriteLine("Неверно выбрана операция"); break; };
                Console.WriteLine("введите первый аргумент");
                string arg1 = Console.ReadLine();
                int a1 = int.Parse(arg1);
                Console.WriteLine("введите первый аргумент");
                string arg2 = Console.ReadLine();
                int a2 = int.Parse(arg2);
                int n = kalk.Paschet(str, a1, a2);
                Console.WriteLine("Результат вычислений  {0}", n);
                Console.WriteLine("Продолжить вычисления ? Y / N");
                Ans = Console.ReadLine();
            } while (Ans == "Y");

            Console.ReadKey();
        }
    }
}
