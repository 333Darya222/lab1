using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            string tmp;
            string pause;
            Console.WriteLine(" число:");
            tmp = Console.ReadLine();
            year = Convert.ToInt32(tmp);
            Console.WriteLine($"Введеный год: {year}");

            if (!(year % 100 == 0 && year % 400 != 0) && (year % 4 == 0))
                {
                Console.WriteLine("Год високосный");
            }
            else
            {

                Console.WriteLine("Год не високосный");
            }
            pause = Console.ReadLine();
        }
    }
}