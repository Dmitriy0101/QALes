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
            double price, sum = 0;
            string p;
            double a = 0.05, b = 0.1;

            Console.WriteLine("стоимость товара");
            sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Vip?");
            p = Console.ReadLine();

            switch (p)
            {
                case "vip":
                    price = sum - sum * b;
                    Console.WriteLine(price);
                    break;
                default:
                case "Novip":
                    price = sum - sum * a;
                    Console.WriteLine(price);
                    break;
            }

            Console.ReadKey();
        }
    }
}
