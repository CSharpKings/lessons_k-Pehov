using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cem_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            // X-(икс)
            int X = int.Parse(Console.ReadLine());

            if (X > 0)
            {
                Console.WriteLine("1");
            }
            else if (X < 0)
            {
                Console.WriteLine("-1");
            }
            else 
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
        }
    }
}
